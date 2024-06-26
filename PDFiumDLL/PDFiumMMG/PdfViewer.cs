using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using MMG.CustomPresentation.RTF;
using ApplicationInfo;
using System.Collections.Generic;
using System.Linq;
using PDFiumMMG;

namespace PdfiumViewer
{
    /// <summary>
    /// Renders PDF document and provide some navigation and print features for PDF files.
    /// </summary>
    public partial class PdfViewer : UserControl
    {
        private IPdfDocument document;
        PDFPermissions permissions = null;
        Action<string> setDocumentNameCallback;
        private bool isBookmarksVisible;

        private PDFSearchForm pdfSearchForm = null;
        private RTFSearchForm rtfSearchForm = null;
        private BasicRTFViewer basicRTFViewer = new BasicRTFViewer();

        private enum ActiveViewer
        {
            PDF_RENDERER,
            RTF_VIEWER
        }

        ActiveViewer activeViewer = ActiveViewer.PDF_RENDERER;

        public PdfViewer()
        {
            InitializeComponent();
            SetDefaults();
            DisableKeyFeatures();
            InitRTFView();
        }

        private void SetDefaults()
        {
            this.DefaultPrintMode = PdfPrintMode.CutMargin;
            zoomFactorTextBox.Text = FormatZoomString();
        }
        
        /**
         * Initializes the control. If not called, none of the control features will be enabled;
         */
        public void Init(PDFPermissions p, Action<string> setDocumentNameCallback)
        {
            this.setDocumentNameCallback = setDocumentNameCallback;
            this.permissions = p;
            SetEnabledFeatures();
        }

        private IniFile iniFile;
        public IniFile IniFile 
        { 
            get
            {
                return iniFile;
            }

            set
            {
                iniFile = value;
                FillRecentDocumentsList();
            }
        }

        [DefaultValue(null)]
        public IPdfDocument Document
        {
            get 
            { 
                return document; 
            }
            set
            {
                if (document != value)
                {
                    document = value;

                    if (document != null)
                    {
                        UpdateBookmarks();
                        pdfRenderer.Load(document);
                        bookmarksView.ExpandAll();

                        mainSplitContainer.Panel1Collapsed = (bookmarksView.Nodes.Count < 1);
                        toggleBookmarksViewButton.Checked = (bookmarksView.Nodes.Count > 0);
                        view_showBookmarks.Checked = toggleBookmarksViewButton.Checked;
                    }

                    ShowPdfLocation(PdfPoint.Empty);
                    SetEnabledFeatures();
                    ActivatePDFRenderer();
                }
            }
        }

        private void SetEnabledFeatures()
        {
            if(this.permissions == null)
            {
                return;
            }

            alertStrip.Visible = false;
            UndoDisableKeyFeatures();


            // =======================
            // MAIN MENU =============
            mainMenu.Visible = this.permissions.MainMenuVisible;

            file_openDocument.Enabled = this.permissions.OpenEnabled;
            file_printPreview.Enabled = this.document != null && this.permissions.PrintEnabled;
            file_print.Enabled = this.document != null && this.permissions.PrintEnabled;
            file_printManyToOnePage.Enabled = this.document != null && this.permissions.PrintEnabled;
            file_saveDocumentAs.Enabled = this.document != null && this.permissions.SaveEnabled;
            file_documentProperties.Enabled = this.document != null && this.permissions.DocumentPropertiesEnabled;

            viewMenu.Enabled = this.document != null;
            
            editMenu.Enabled = this.document != null && this.permissions.EditEnabled;
            edit_find.Enabled = this.document != null; // only to disable shortcut, cause parent menu is already disabled

            // ===========================
            // MAIN TOOL BAR =============
            mainToolBar.Visible = this.permissions.MainMenuVisible;

            toggleBookmarksViewButton.Enabled = this.document != null;

            openDocumentButton.Visible = this.permissions.OpenEnabled;

            saveButton.Enabled = this.document != null && this.permissions.SaveEnabled;
            saveButton.Visible =  this.permissions.SaveEnabled;

            printButton.Enabled = this.document != null && this.permissions.PrintEnabled;
            printButton.Visible =  this.permissions.PrintEnabled;

            pagePreviousButton.Enabled = this.document != null;
            pageNextButton.Enabled = this.document != null;
            pageNumberTextBox.Enabled = this.document != null;
            zoomInButton.Enabled = this.document != null;
            zoomOutButton.Enabled = this.document != null;
            zoomFactorTextBox.Enabled = this.document != null;
            fitHeigthButton.Enabled = this.document != null;
            fitWidthButton.Enabled = this.document != null;
            rotateLeftButton.Enabled = this.document != null;
            rotateRightButton.Enabled = this.document != null;
            getPdfTextButton.Enabled = this.document != null;
            findButton.Enabled = this.document != null;

            // ===========================
            // MAIN STATUS BAR ===========
            mainStatusBar.Visible = this.permissions.MainStatusBarVisible;
        }

        private void DisableKeyFeatures()
        {
            this.mainMenu.Enabled = false;
            this.mainToolBar.Enabled = false;
            this.mainSplitContainer.Enabled = false;
            this.file_openDocument.Enabled = false;
            this.file_print.Enabled = false;
            this.file_saveDocumentAs.Enabled = false;
            this.edit_find.Enabled = false;
        }

        private void UndoDisableKeyFeatures()
        {
            this.mainMenu.Enabled = true;
            this.mainToolBar.Enabled = true;
            this.mainSplitContainer.Enabled = true;
            this.file_openDocument.Enabled = true;
            this.file_print.Enabled = true;
            this.file_saveDocumentAs.Enabled = true;
            this.edit_find.Enabled = true; 
            
            
            //var v = this.file_recentFiles.DropDownItems[0];
            //v.
        }

        private void InitRTFView()
        {
            mainSplitContainer.Panel2.Controls.Add(this.basicRTFViewer);
            this.basicRTFViewer.Dock = DockStyle.Fill;
            this.basicRTFViewer.TextBox.Click += rtfView_Click;
        }

        public PdfRenderer Renderer
        {
            get { return pdfRenderer; }
        }

        [DefaultValue(null)]
        public string DefaultDocumentName { get; set; }

        [DefaultValue(PdfPrintMode.CutMargin)]
        public PdfPrintMode DefaultPrintMode { get; set; }

        /// <summary>
        /// Gets or sets the way the document should be zoomed initially.
        /// </summary>
        [DefaultValue(PdfViewerZoomMode.FitHeight)]
        public PdfViewerZoomMode ZoomMode
        {
            get { return pdfRenderer.ZoomMode; }
            set { pdfRenderer.ZoomMode = value; }
        }


        /// <summary>
        /// Gets or sets whether the bookmarks panel should be shown.
        /// </summary>
        [DefaultValue(true)]
        public bool BookmarksVisible
        {
            get 
            { 
                return isBookmarksVisible; 
            }
            set
            {
                isBookmarksVisible = value;
                UpdateBookmarks();
            }
        }

        private void UpdateBookmarks()
        {
            if(this.document == null)
            {
                return;
            }
            
            bookmarksView.Nodes.Clear();
            foreach (var bookmark in document.Bookmarks)
            {
                bookmarksView.Nodes.Add(GetBookmarkNode(bookmark));
            }
        }

        [Category("Action")]
        [Description("Occurs when a link in the pdf document is clicked.")]
        public event LinkClickEventHandler LinkClick;
        protected virtual void OnLinkClick(LinkClickEventArgs e)
        {
            var handler = LinkClick;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Find();
        }

        public void Find()
        {
            if (this.activeViewer.Equals(ActiveViewer.PDF_RENDERER))
            {
                if (pdfSearchForm == null)
                {
                    pdfSearchForm = new PDFSearchForm(this.Renderer);
                    pdfSearchForm.Disposed += (s, ea) => pdfSearchForm = null;
                }
                ShowSearchForm(pdfSearchForm);
            }
            else if (this.activeViewer.Equals(ActiveViewer.RTF_VIEWER))
            {
                if (rtfSearchForm == null)
                {
                    rtfSearchForm = new RTFSearchForm(this.basicRTFViewer);
                    rtfSearchForm.Disposed += (s, ea) => rtfSearchForm = null;
                }
                ShowSearchForm(rtfSearchForm);
            }
            
        }

        private void ShowSearchForm(Form f)
        {
            f.Top = this.Parent.Top + this.Top + this.mainToolBar.Top + this.mainToolBar.Height + 40;
            f.Left = this.Parent.Left + this.Parent.Width - f.Width - 40;
            f.Focus();
            f.Show();
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            pdfRenderer.ZoomIn();
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            pdfRenderer.ZoomOut();
        }

        private void renderer_ZoomChanged(object sender, EventArgs e)
        {
            zoomFactorTextBox.Text = FormatZoomString();
        }

        private void zoomTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (float.TryParse(zoomFactorTextBox.Text.Replace("%", ""), out float zoom))
                {
                    this.Renderer.Zoom = zoom / 100.0;
                }
                else
                {
                    MessageBox.Show("Invalid zoom factor number");
                }
            }
        }

        private string FormatZoomString()
        {
            int zoomFactor = (int)(this.Renderer.Zoom * 100.0);
            return zoomFactor.ToString() + "%";
        }

        private void file_saveDocumentAsMenu_Click(object sender, EventArgs e)
        {
            SaveDocumentAs();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveDocumentAs();
        }

        public void SaveDocumentAs()
        {
            using (var form = new SaveFileDialog())
            {
                form.DefaultExt = ".pdf";
                form.Filter = Properties.Resources.SaveAsFilter;
                form.RestoreDirectory = true;
                form.Title = Properties.Resources.SaveAsTitle;
                form.FileName = DefaultDocumentName;

                if (form.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    try
                    {
                        document.Save(form.FileName);
                    }
                    catch
                    {
                        MessageBox.Show(
                            FindForm(),
                            Properties.Resources.SaveAsFailedText,
                            Properties.Resources.SaveAsFailedTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void file_printMenu_Click(object sender, EventArgs e)
        {
            PrintDocument();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDocument();
        }

        public void PrintDocument()
        {
            using (var form = new PrintDialog())
            using (var document = this.document.CreatePrintDocument(DefaultPrintMode))
            {
                form.AllowSomePages = true;
                form.Document = document;
                form.UseEXDialog = true;
                form.Document.PrinterSettings.FromPage = 1;
                form.Document.PrinterSettings.ToPage = this.document.PageCount;

                if (form.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    try
                    {
                        if (form.Document.PrinterSettings.FromPage <= this.document.PageCount)
                            form.Document.Print();
                    }
                    catch
                    {
                        // Ignore exceptions; the printer dialog should take care of this.
                    }
                }
            }
        }

        private TreeNode GetBookmarkNode(PdfBookmark bookmark)
        {
            TreeNode node = new TreeNode(bookmark.Title);
            node.Tag = bookmark;
            if (bookmark.Children != null)
            {
                foreach (var child in bookmark.Children)
                    node.Nodes.Add(GetBookmarkNode(child));
            }
            return node;
        }

        private void bookmarks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pdfRenderer.Page = ((PdfBookmark)e.Node.Tag).PageIndex;
        }

        private void renderer_LinkClick(object sender, LinkClickEventArgs e)
        {
            OnLinkClick(e);
        }

        private void view_showBookmarks_Click(object sender, EventArgs e)
        {
            mainSplitContainer.Panel1Collapsed = !view_showBookmarks.Checked;
            toggleBookmarksViewButton.Checked = view_showBookmarks.Checked;
        }

        private void showBookmarksButton_Click(object sender, EventArgs e)
        {
            mainSplitContainer.Panel1Collapsed = !toggleBookmarksViewButton.Checked;
        }

        private void fitWidthButton_Click(object sender, EventArgs e)
        {
            FitPage(PdfViewerZoomMode.FitWidth);
        }

        private void fitHeigthButton_Click(object sender, EventArgs e)
        {
            FitPage(PdfViewerZoomMode.FitHeight);
        }

        private void FitPage(PdfViewerZoomMode zoomMode)
        {
            int page = this.Renderer.Page;
            this.ZoomMode = zoomMode;
            this.Renderer.Zoom = 1;
            this.Renderer.Page = page;
        }

        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            this.Renderer.RotateLeft();
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            this.Renderer.RotateRight();
        }

        private void pagePreviousButton_Click(object sender, EventArgs e)
        {
            this.Renderer.Page--;
        }

        private void pageNextButton_Click(object sender, EventArgs e)
        {
            this.Renderer.Page++;
        }

        private void pageNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (int.TryParse(pageNumberTextBox.Text, out int page))
                {
                    this.Renderer.Page = page - 1;
                }
                else
                {
                    MessageBox.Show(this, "Invalid page number", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rendererDisplayRectangleChanged(object sender, EventArgs e)
        {
            pageNumberTextBox.Text = (this.Renderer.Page + 1).ToString();
        }

        private void file_openDocumentMenu_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void openDocumentButton_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void file_recentDocumentsItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;

            string filePath = menuItem.Tag.ToString();

            if (File.Exists(filePath))
            {
                OpenDocument(filePath);
            }
            else
            {
                MessageBox.Show("This document could't be open. It will be deleted from de recent documents list.");
                file_recentDocuments.DropDownItems.Remove(menuItem);
            }
        }

        public void OpenDocument()
        {
            using (var form = new OpenFileDialog())
            {
                form.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                form.RestoreDirectory = true;
                form.Title = "Open PDF File";

                if (form.ShowDialog(this) != DialogResult.OK)
                {
                    //Dispose();
                    return;
                }

                OpenDocument(form.FileName);
            }
        }

        public void OpenDocument(string fileName)
        {
            try
            {
                this.Document?.Dispose();
                this.Document = PdfDocument.Load(this, fileName);
                this.setDocumentNameCallback(System.IO.Path.GetFileName(fileName));
                this.IniFile.FilePaths.Add(fileName);
                FillRecentDocumentsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillRecentDocumentsList()
        {
            if (IniFile == null || IniFile.FilePaths == null)
            {
                return;
            }

            file_recentDocuments.DropDownItems.Clear();

            foreach (string item in IniFile.FilePaths)
            {
                ToolStripItem doc = new ToolStripMenuItem(
                    FigurativeFileNames.GenerateTruncatedNames(item, 120)
                    );
                file_recentDocuments.DropDownItems.Add(doc);
                doc.Tag = item;
                doc.Click += file_recentDocumentsItem_Click;

            }
        }

        private void file_printPreviewMenu_Click(object sender, EventArgs e)
        {
            using (var printForm = new PrintPreviewDialog())
            {
                printForm.Document = this.Document.CreatePrintDocument(this.DefaultPrintMode);
                try
                {
                    printForm.ShowDialog(this);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("There is no installed printer");
                }
            }
        }

        private void file_printManyToOnePage_Click(object sender, EventArgs e)
        {
            using (var manyToOneForm = new ManyPagesToOneForm(this))
            {
                manyToOneForm.ShowDialog(this);
            }
        }

        private void file_exitMenu_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void file_documentPropertiesMenu_Click(object sender, EventArgs e)
        {
            PdfInformation info = this.Document.GetInformation();
            StringBuilder sz = new StringBuilder();
            sz.AppendLine($"Author: {info.Author}");
            sz.AppendLine($"Creator: {info.Creator}");
            sz.AppendLine($"Keywords: {info.Keywords}");
            sz.AppendLine($"Producer: {info.Producer}");
            sz.AppendLine($"Subject: {info.Subject}");
            sz.AppendLine($"Title: {info.Title}");
            sz.AppendLine($"Create Date: {info.CreationDate}");
            sz.AppendLine($"Modified Date: {info.ModificationDate}");

            MessageBox.Show(sz.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void edit_RenderToBitmapsMenu_Click(object sender, EventArgs e)
        {
            int dpiX;
            int dpiY;

            using (var form = new ExportBitmapsForm())
            {
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                dpiX = form.DpiX;
                dpiY = form.DpiY;
            }

            string path;

            using (var form = new FolderBrowserDialog())
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                path = form.SelectedPath;
            }

            var document = this.Document;

            for (int i = 0; i < document.PageCount; i++)
            {
                using (var image = document.Render(i, (int)document.PageSizes[i].Width, (int)document.PageSizes[i].Height, dpiX, dpiY, false))
                {
                    image.Save(Path.Combine(path, "Page " + i + ".png"));
                }
            }
        }

        private void renderer_MouseLeave(object sender, EventArgs e)
        {
            ShowPdfLocation(PdfPoint.Empty);
        }

        private void renderer_MouseMove(object sender, MouseEventArgs e)
        {
            ShowPdfLocation(this.Renderer.PointToPdf(e.Location));
        }

        private void ShowPdfLocation(PdfPoint point)
        {
            if (!point.IsValid)
            {
                coordinatesStatusLabel.Text = "";
            }
            else
            {
                coordinatesStatusLabel.Text = point.Location.X + " | " + point.Location.Y;
            }
        }

        private void edit_CutMarginsWhenPrintingMenu_Click(object sender, EventArgs e)
        {
            edit_CutMarginsWhenPrinting.Checked = true;
            edit_shrinkToMarginsWhenPrinting.Checked = false;

            this.DefaultPrintMode = PdfPrintMode.CutMargin;
        }

        private void edit_shrinkToMarginsWhenPrintingMenu_Click(object sender, EventArgs e)
        {
            edit_shrinkToMarginsWhenPrinting.Checked = true;
            edit_CutMarginsWhenPrinting.Checked = false;

            this.DefaultPrintMode = PdfPrintMode.ShrinkToMargin;
        }

        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(PdfRotation.Rotate90);
        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(PdfRotation.Rotate180);
        }

        private void rotate270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(PdfRotation.Rotate270);
        }

        private void Rotate(PdfRotation rotate)
        {
            // PdfRenderer does not support changes to the loaded document,
            // so we fake it by reloading the document into the renderer.

            int page = this.Renderer.Page;
            var document = this.Document;
            this.Document = null;
            document.RotatePage(page, rotate);
            this.Document = document;
            this.Renderer.Page = page;
        }

        private void edit_deleteCurrentPageMenu_Click(object sender, EventArgs e)
        {
            // PdfRenderer does not support changes to the loaded document,
            // so we fake it by reloading the document into the renderer.

            int page = this.Renderer.Page;
            var document = this.Document;
            this.Document = null;
            document.DeletePage(page);
            this.Document = document;
            this.Renderer.Page = page;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            alertStrip.Visible = false;
        }

        private void view_showRangeOfPages_Click(object sender, EventArgs e)
        {
            using (var form = new PageRangeForm(this.Document))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.Document = form.Document;
                }
            }
        }

        private void pdfTextButton_Click(object sender, EventArgs e)
        {
            if (getPdfTextButton.Checked)
            {
                ActivateRTFViewer();
            }
            else
            {
                ActivatePDFRenderer();
            }
        }

        private void pdfRenderer_Click(object sender, EventArgs e)
        {
            if (PdfRenderer.ModifierKeys == Keys.Control && this.document != null)
            {
                ActivateRTFViewer();
            }
        }

        private void rtfView_Click(object sender, EventArgs e)
        {
            if (BasicRTFViewer.ModifierKeys == Keys.Control && this.document != null)
            {
                ActivatePDFRenderer();
            }
        }

        private void bookmarksView_Click(object sender, EventArgs e)
        {
            ActivatePDFRenderer();
        }

        private void ActivateRTFViewer()
        {
            this.basicRTFViewer.BringToFront();
            getPdfTextButton.Checked = true;
            int page = this.Renderer.Page;
            this.basicRTFViewer.Text = this.Document.GetPdfText(page);
            this.activeViewer = ActiveViewer.RTF_VIEWER;
        }

        private void ActivatePDFRenderer()
        {
            this.pdfRenderer.BringToFront();
            getPdfTextButton.Checked = false;
            this.activeViewer = ActiveViewer.PDF_RENDERER;
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}
