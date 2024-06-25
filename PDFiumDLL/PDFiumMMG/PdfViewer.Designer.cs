using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer
{
    partial class PdfViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfViewer));
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.toggleBookmarksViewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openDocumentButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.printButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pagePreviousButton = new System.Windows.Forms.ToolStripButton();
            this.pageNumberTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pageNextButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInButton = new System.Windows.Forms.ToolStripButton();
            this.zoomFactorTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
            this.fitWidthButton = new System.Windows.Forms.ToolStripButton();
            this.fitHeigthButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rotateLeftButton = new System.Windows.Forms.ToolStripButton();
            this.rotateRightButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.findButton = new System.Windows.Forms.ToolStripButton();
            this.getPdfTextButton = new System.Windows.Forms.ToolStripButton();
            this.mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.coordinatesStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.file_openDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.z_01 = new System.Windows.Forms.ToolStripSeparator();
            this.file_printPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.file_print = new System.Windows.Forms.ToolStripMenuItem();
            this.file_printManyToOnePage = new System.Windows.Forms.ToolStripMenuItem();
            this.z_02 = new System.Windows.Forms.ToolStripSeparator();
            this.file_saveDocumentAs = new System.Windows.Forms.ToolStripMenuItem();
            this.z_03 = new System.Windows.Forms.ToolStripSeparator();
            this.file_recentFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.z_04 = new System.Windows.Forms.ToolStripSeparator();
            this.file_documentProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.z_05 = new System.Windows.Forms.ToolStripSeparator();
            this.file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.z_06 = new System.Windows.Forms.ToolStripSeparator();
            this.file_recentDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.view_showRangeOfPages = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_find = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_RenderToBitmap = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_CutMarginsWhenPrinting = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_shrinkToMarginsWhenPrinting = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_rotateCurrentPage = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_rotateCurrentPage_90 = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_rotateCurrentPage_180 = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_rotateCurrentPage_270 = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_deleteCurrentPage = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_menuSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.alertStrip = new System.Windows.Forms.ToolStrip();
            this.alertIconStripButton = new System.Windows.Forms.ToolStripButton();
            this.alertTitleStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.alertTextStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.alertCloseStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.bookmarksView = new PdfiumViewer.NativeTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pdfRenderer = new PdfiumViewer.PdfRenderer();
            this.view_showBookmarks = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBar.SuspendLayout();
            this.mainStatusBar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.alertStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolBar
            // 
            this.mainToolBar.BackColor = System.Drawing.Color.Silver;
            this.mainToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleBookmarksViewButton,
            this.toolStripSeparator2,
            this.openDocumentButton,
            this.saveButton,
            this.printButton,
            this.toolStripSeparator4,
            this.pagePreviousButton,
            this.pageNumberTextBox,
            this.pageNextButton,
            this.toolStripSeparator1,
            this.zoomInButton,
            this.zoomFactorTextBox,
            this.zoomOutButton,
            this.fitWidthButton,
            this.fitHeigthButton,
            this.toolStripSeparator3,
            this.rotateLeftButton,
            this.rotateRightButton,
            this.toolStripSeparator6,
            this.findButton,
            this.getPdfTextButton});
            resources.ApplyResources(this.mainToolBar, "mainToolBar");
            this.mainToolBar.Name = "mainToolBar";
            // 
            // toggleBookmarksViewButton
            // 
            this.toggleBookmarksViewButton.CheckOnClick = true;
            this.toggleBookmarksViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleBookmarksViewButton.Image = global::PdfiumViewer.Properties.Resources.bookmarks;
            resources.ApplyResources(this.toggleBookmarksViewButton, "toggleBookmarksViewButton");
            this.toggleBookmarksViewButton.Name = "toggleBookmarksViewButton";
            this.toggleBookmarksViewButton.Click += new System.EventHandler(this.showBookmarksButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // openDocumentButton
            // 
            this.openDocumentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openDocumentButton.Image = global::PdfiumViewer.Properties.Resources.open;
            resources.ApplyResources(this.openDocumentButton, "openDocumentButton");
            this.openDocumentButton.Name = "openDocumentButton";
            this.openDocumentButton.Click += new System.EventHandler(this.openDocumentButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::PdfiumViewer.Properties.Resources.save;
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // printButton
            // 
            this.printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printButton.Image = global::PdfiumViewer.Properties.Resources.printer;
            resources.ApplyResources(this.printButton, "printButton");
            this.printButton.Name = "printButton";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // pagePreviousButton
            // 
            this.pagePreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagePreviousButton.Image = global::PdfiumViewer.Properties.Resources.page_previous;
            resources.ApplyResources(this.pagePreviousButton, "pagePreviousButton");
            this.pagePreviousButton.Name = "pagePreviousButton";
            this.pagePreviousButton.Click += new System.EventHandler(this.pagePreviousButton_Click);
            // 
            // pageNumberTextBox
            // 
            this.pageNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageNumberTextBox.Name = "pageNumberTextBox";
            resources.ApplyResources(this.pageNumberTextBox, "pageNumberTextBox");
            this.pageNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageNumberTextBox_KeyDown);
            // 
            // pageNextButton
            // 
            this.pageNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageNextButton.Image = global::PdfiumViewer.Properties.Resources.page_next;
            resources.ApplyResources(this.pageNextButton, "pageNextButton");
            this.pageNextButton.Name = "pageNextButton";
            this.pageNextButton.Click += new System.EventHandler(this.pageNextButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // zoomInButton
            // 
            this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInButton.Image = global::PdfiumViewer.Properties.Resources.zoom_in;
            resources.ApplyResources(this.zoomInButton, "zoomInButton");
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomFactorTextBox
            // 
            this.zoomFactorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomFactorTextBox.Name = "zoomFactorTextBox";
            resources.ApplyResources(this.zoomFactorTextBox, "zoomFactorTextBox");
            this.zoomFactorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zoomTextBox_KeyDown);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutButton.Image = global::PdfiumViewer.Properties.Resources.zoom_out;
            resources.ApplyResources(this.zoomOutButton, "zoomOutButton");
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // fitWidthButton
            // 
            this.fitWidthButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fitWidthButton.Image = global::PdfiumViewer.Properties.Resources.fit_w;
            resources.ApplyResources(this.fitWidthButton, "fitWidthButton");
            this.fitWidthButton.Name = "fitWidthButton";
            this.fitWidthButton.Click += new System.EventHandler(this.fitWidthButton_Click);
            // 
            // fitHeigthButton
            // 
            this.fitHeigthButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fitHeigthButton.Image = global::PdfiumViewer.Properties.Resources.fit_h;
            resources.ApplyResources(this.fitHeigthButton, "fitHeigthButton");
            this.fitHeigthButton.Name = "fitHeigthButton";
            this.fitHeigthButton.Click += new System.EventHandler(this.fitHeigthButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateLeftButton.Image = global::PdfiumViewer.Properties.Resources.rotate_l;
            resources.ApplyResources(this.rotateLeftButton, "rotateLeftButton");
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateRightButton.Image = global::PdfiumViewer.Properties.Resources.rotate_r;
            resources.ApplyResources(this.rotateRightButton, "rotateRightButton");
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // findButton
            // 
            this.findButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.findButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findButton.Image = global::PdfiumViewer.Properties.Resources.find;
            resources.ApplyResources(this.findButton, "findButton");
            this.findButton.Name = "findButton";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // getPdfTextButton
            // 
            this.getPdfTextButton.CheckOnClick = true;
            this.getPdfTextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.getPdfTextButton, "getPdfTextButton");
            this.getPdfTextButton.Name = "getPdfTextButton";
            this.getPdfTextButton.Click += new System.EventHandler(this.pdfTextButton_Click);
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.coordinatesStatusLabel});
            resources.ApplyResources(this.mainStatusBar, "mainStatusBar");
            this.mainStatusBar.Name = "mainStatusBar";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // coordinatesStatusLabel
            // 
            this.coordinatesStatusLabel.Name = "coordinatesStatusLabel";
            resources.ApplyResources(this.coordinatesStatusLabel, "coordinatesStatusLabel");
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.editMenu,
            this.aboutMenu});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_openDocument,
            this.z_01,
            this.file_printPreview,
            this.file_print,
            this.file_printManyToOnePage,
            this.z_02,
            this.file_saveDocumentAs,
            this.z_03,
            this.file_recentFiles,
            this.z_04,
            this.file_documentProperties,
            this.z_05,
            this.file_exit,
            this.z_06,
            this.file_recentDocuments});
            this.fileMenu.Name = "fileMenu";
            resources.ApplyResources(this.fileMenu, "fileMenu");
            // 
            // file_openDocument
            // 
            this.file_openDocument.Name = "file_openDocument";
            resources.ApplyResources(this.file_openDocument, "file_openDocument");
            this.file_openDocument.Click += new System.EventHandler(this.file_openDocumentMenu_Click);
            // 
            // z_01
            // 
            this.z_01.Name = "z_01";
            resources.ApplyResources(this.z_01, "z_01");
            // 
            // file_printPreview
            // 
            this.file_printPreview.Name = "file_printPreview";
            resources.ApplyResources(this.file_printPreview, "file_printPreview");
            this.file_printPreview.Click += new System.EventHandler(this.file_printPreviewMenu_Click);
            // 
            // file_print
            // 
            this.file_print.Name = "file_print";
            resources.ApplyResources(this.file_print, "file_print");
            this.file_print.Click += new System.EventHandler(this.file_printMenu_Click);
            // 
            // file_printManyToOnePage
            // 
            this.file_printManyToOnePage.Name = "file_printManyToOnePage";
            resources.ApplyResources(this.file_printManyToOnePage, "file_printManyToOnePage");
            this.file_printManyToOnePage.Click += new System.EventHandler(this.file_printManyToOnePage_Click);
            // 
            // z_02
            // 
            this.z_02.Name = "z_02";
            resources.ApplyResources(this.z_02, "z_02");
            // 
            // file_saveDocumentAs
            // 
            this.file_saveDocumentAs.Name = "file_saveDocumentAs";
            resources.ApplyResources(this.file_saveDocumentAs, "file_saveDocumentAs");
            this.file_saveDocumentAs.Click += new System.EventHandler(this.file_saveDocumentAsMenu_Click);
            // 
            // z_03
            // 
            this.z_03.Name = "z_03";
            resources.ApplyResources(this.z_03, "z_03");
            // 
            // file_recentFiles
            // 
            this.file_recentFiles.Name = "file_recentFiles";
            resources.ApplyResources(this.file_recentFiles, "file_recentFiles");
            // 
            // z_04
            // 
            this.z_04.Name = "z_04";
            resources.ApplyResources(this.z_04, "z_04");
            // 
            // file_documentProperties
            // 
            this.file_documentProperties.Name = "file_documentProperties";
            resources.ApplyResources(this.file_documentProperties, "file_documentProperties");
            this.file_documentProperties.Click += new System.EventHandler(this.file_documentPropertiesMenu_Click);
            // 
            // z_05
            // 
            this.z_05.Name = "z_05";
            resources.ApplyResources(this.z_05, "z_05");
            // 
            // file_exit
            // 
            this.file_exit.Name = "file_exit";
            resources.ApplyResources(this.file_exit, "file_exit");
            this.file_exit.Click += new System.EventHandler(this.file_exitMenu_Click);
            // 
            // z_06
            // 
            this.z_06.Name = "z_06";
            resources.ApplyResources(this.z_06, "z_06");
            // 
            // file_recentDocuments
            // 
            this.file_recentDocuments.Name = "file_recentDocuments";
            resources.ApplyResources(this.file_recentDocuments, "file_recentDocuments");
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_showRangeOfPages,
            this.view_showBookmarks});
            this.viewMenu.Name = "viewMenu";
            resources.ApplyResources(this.viewMenu, "viewMenu");
            // 
            // view_showRangeOfPages
            // 
            this.view_showRangeOfPages.Name = "view_showRangeOfPages";
            resources.ApplyResources(this.view_showRangeOfPages, "view_showRangeOfPages");
            this.view_showRangeOfPages.Click += new System.EventHandler(this.view_showRangeOfPages_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_find,
            this.edit_menuSeparator1,
            this.edit_RenderToBitmap,
            this.edit_menuSeparator2,
            this.edit_CutMarginsWhenPrinting,
            this.edit_shrinkToMarginsWhenPrinting,
            this.edit_menuSeparator3,
            this.edit_rotateCurrentPage,
            this.edit_deleteCurrentPage,
            this.edit_menuSeparator4,
            this.edit_menuSeparator5});
            this.editMenu.Name = "editMenu";
            resources.ApplyResources(this.editMenu, "editMenu");
            // 
            // edit_find
            // 
            this.edit_find.Name = "edit_find";
            resources.ApplyResources(this.edit_find, "edit_find");
            this.edit_find.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // edit_menuSeparator1
            // 
            this.edit_menuSeparator1.Name = "edit_menuSeparator1";
            resources.ApplyResources(this.edit_menuSeparator1, "edit_menuSeparator1");
            // 
            // edit_RenderToBitmap
            // 
            this.edit_RenderToBitmap.Name = "edit_RenderToBitmap";
            resources.ApplyResources(this.edit_RenderToBitmap, "edit_RenderToBitmap");
            this.edit_RenderToBitmap.Click += new System.EventHandler(this.edit_RenderToBitmapsMenu_Click);
            // 
            // edit_menuSeparator2
            // 
            this.edit_menuSeparator2.Name = "edit_menuSeparator2";
            resources.ApplyResources(this.edit_menuSeparator2, "edit_menuSeparator2");
            // 
            // edit_CutMarginsWhenPrinting
            // 
            this.edit_CutMarginsWhenPrinting.Checked = true;
            this.edit_CutMarginsWhenPrinting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.edit_CutMarginsWhenPrinting.Name = "edit_CutMarginsWhenPrinting";
            resources.ApplyResources(this.edit_CutMarginsWhenPrinting, "edit_CutMarginsWhenPrinting");
            this.edit_CutMarginsWhenPrinting.Click += new System.EventHandler(this.edit_CutMarginsWhenPrintingMenu_Click);
            // 
            // edit_shrinkToMarginsWhenPrinting
            // 
            this.edit_shrinkToMarginsWhenPrinting.Name = "edit_shrinkToMarginsWhenPrinting";
            resources.ApplyResources(this.edit_shrinkToMarginsWhenPrinting, "edit_shrinkToMarginsWhenPrinting");
            this.edit_shrinkToMarginsWhenPrinting.Click += new System.EventHandler(this.edit_shrinkToMarginsWhenPrintingMenu_Click);
            // 
            // edit_menuSeparator3
            // 
            this.edit_menuSeparator3.Name = "edit_menuSeparator3";
            resources.ApplyResources(this.edit_menuSeparator3, "edit_menuSeparator3");
            // 
            // edit_rotateCurrentPage
            // 
            this.edit_rotateCurrentPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_rotateCurrentPage_90,
            this.edit_rotateCurrentPage_180,
            this.edit_rotateCurrentPage_270});
            this.edit_rotateCurrentPage.Name = "edit_rotateCurrentPage";
            resources.ApplyResources(this.edit_rotateCurrentPage, "edit_rotateCurrentPage");
            // 
            // edit_rotateCurrentPage_90
            // 
            this.edit_rotateCurrentPage_90.Name = "edit_rotateCurrentPage_90";
            resources.ApplyResources(this.edit_rotateCurrentPage_90, "edit_rotateCurrentPage_90");
            this.edit_rotateCurrentPage_90.Tag = "";
            this.edit_rotateCurrentPage_90.Click += new System.EventHandler(this.rotate90ToolStripMenuItem_Click);
            // 
            // edit_rotateCurrentPage_180
            // 
            this.edit_rotateCurrentPage_180.Name = "edit_rotateCurrentPage_180";
            resources.ApplyResources(this.edit_rotateCurrentPage_180, "edit_rotateCurrentPage_180");
            this.edit_rotateCurrentPage_180.Click += new System.EventHandler(this.rotate180ToolStripMenuItem_Click);
            // 
            // edit_rotateCurrentPage_270
            // 
            this.edit_rotateCurrentPage_270.Name = "edit_rotateCurrentPage_270";
            resources.ApplyResources(this.edit_rotateCurrentPage_270, "edit_rotateCurrentPage_270");
            this.edit_rotateCurrentPage_270.Click += new System.EventHandler(this.rotate270ToolStripMenuItem_Click);
            // 
            // edit_deleteCurrentPage
            // 
            this.edit_deleteCurrentPage.Name = "edit_deleteCurrentPage";
            resources.ApplyResources(this.edit_deleteCurrentPage, "edit_deleteCurrentPage");
            this.edit_deleteCurrentPage.Click += new System.EventHandler(this.edit_deleteCurrentPageMenu_Click);
            // 
            // edit_menuSeparator4
            // 
            this.edit_menuSeparator4.Name = "edit_menuSeparator4";
            resources.ApplyResources(this.edit_menuSeparator4, "edit_menuSeparator4");
            // 
            // edit_menuSeparator5
            // 
            this.edit_menuSeparator5.Name = "edit_menuSeparator5";
            resources.ApplyResources(this.edit_menuSeparator5, "edit_menuSeparator5");
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            resources.ApplyResources(this.aboutMenu, "aboutMenu");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // alertStrip
            // 
            this.alertStrip.BackColor = System.Drawing.Color.Yellow;
            this.alertStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.alertStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertIconStripButton,
            this.alertTitleStripLabel,
            this.alertTextStripLabel,
            this.alertCloseStripButton});
            resources.ApplyResources(this.alertStrip, "alertStrip");
            this.alertStrip.Name = "alertStrip";
            // 
            // alertIconStripButton
            // 
            this.alertIconStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alertIconStripButton.Image = global::PdfiumViewer.Properties.Resources.error;
            resources.ApplyResources(this.alertIconStripButton, "alertIconStripButton");
            this.alertIconStripButton.Name = "alertIconStripButton";
            // 
            // alertTitleStripLabel
            // 
            this.alertTitleStripLabel.Name = "alertTitleStripLabel";
            resources.ApplyResources(this.alertTitleStripLabel, "alertTitleStripLabel");
            // 
            // alertTextStripLabel
            // 
            this.alertTextStripLabel.Name = "alertTextStripLabel";
            resources.ApplyResources(this.alertTextStripLabel, "alertTextStripLabel");
            // 
            // alertCloseStripButton
            // 
            this.alertCloseStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.alertCloseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alertCloseStripButton.Image = global::PdfiumViewer.Properties.Resources.close;
            resources.ApplyResources(this.alertCloseStripButton, "alertCloseStripButton");
            this.alertCloseStripButton.Name = "alertCloseStripButton";
            this.alertCloseStripButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // mainSplitContainer
            // 
            resources.ApplyResources(this.mainSplitContainer, "mainSplitContainer");
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.bookmarksView);
            this.mainSplitContainer.Panel1Collapsed = true;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.pdfRenderer);
            this.mainSplitContainer.TabStop = false;
            // 
            // bookmarksView
            // 
            this.bookmarksView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.bookmarksView, "bookmarksView");
            this.bookmarksView.ForeColor = System.Drawing.Color.White;
            this.bookmarksView.FullRowSelect = true;
            this.bookmarksView.ImageList = this.imageList1;
            this.bookmarksView.LineColor = System.Drawing.Color.White;
            this.bookmarksView.Name = "bookmarksView";
            this.bookmarksView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.bookmarks_AfterSelect);
            this.bookmarksView.Click += new System.EventHandler(this.bookmarksView_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow-placeholder.png");
            this.imageList1.Images.SetKeyName(1, "arrow.png");
            this.imageList1.Images.SetKeyName(2, "eddie-placeholder.png");
            this.imageList1.Images.SetKeyName(3, "eddie.ico");
            // 
            // pdfRenderer
            // 
            this.pdfRenderer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pdfRenderer.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.pdfRenderer, "pdfRenderer");
            this.pdfRenderer.Name = "pdfRenderer";
            this.pdfRenderer.Page = 0;
            this.pdfRenderer.Rotation = PdfiumViewer.PdfRotation.Rotate0;
            this.pdfRenderer.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            this.pdfRenderer.LinkClick += new PdfiumViewer.LinkClickEventHandler(this.renderer_LinkClick);
            this.pdfRenderer.ZoomChanged += new System.EventHandler(this.renderer_ZoomChanged);
            this.pdfRenderer.DisplayRectangleChanged += new System.EventHandler(this.rendererDisplayRectangleChanged);
            this.pdfRenderer.Click += new System.EventHandler(this.pdfRenderer_Click);
            this.pdfRenderer.MouseLeave += new System.EventHandler(this.renderer_MouseLeave);
            this.pdfRenderer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.renderer_MouseMove);
            // 
            // view_showBookmarks
            // 
            this.view_showBookmarks.CheckOnClick = true;
            this.view_showBookmarks.Name = "view_showBookmarks";
            resources.ApplyResources(this.view_showBookmarks, "view_showBookmarks");
            this.view_showBookmarks.Click += new System.EventHandler(this.view_showBookmarks_Click);
            // 
            // PdfViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainToolBar);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.alertStrip);
            this.Name = "PdfViewer";
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.mainStatusBar.ResumeLayout(false);
            this.mainStatusBar.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.alertStrip.ResumeLayout(false);
            this.alertStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolBar;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton printButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton zoomInButton;
        private System.Windows.Forms.ToolStripButton zoomOutButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private NativeTreeView bookmarksView;
        private PdfRenderer pdfRenderer;
        private System.Windows.Forms.ToolStripButton toggleBookmarksViewButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox zoomFactorTextBox;
        private System.Windows.Forms.ToolStripButton fitWidthButton;
        private System.Windows.Forms.ToolStripButton fitHeigthButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton rotateRightButton;
        private System.Windows.Forms.ToolStripButton rotateLeftButton;
        private System.Windows.Forms.ToolStripButton pagePreviousButton;
        private System.Windows.Forms.ToolStripButton pageNextButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox pageNumberTextBox;
        private System.Windows.Forms.ToolStripButton findButton;
        private System.Windows.Forms.StatusStrip mainStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel coordinatesStatusLabel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem file_openDocument;
        private System.Windows.Forms.ToolStripSeparator z_01;
        private System.Windows.Forms.ToolStripMenuItem file_printPreview;
        private System.Windows.Forms.ToolStripSeparator z_02;
        private System.Windows.Forms.ToolStripMenuItem file_exit;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem edit_find;
        private System.Windows.Forms.ToolStripSeparator edit_menuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem edit_RenderToBitmap;
        private System.Windows.Forms.ToolStripSeparator edit_menuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem edit_CutMarginsWhenPrinting;
        private System.Windows.Forms.ToolStripMenuItem edit_shrinkToMarginsWhenPrinting;
        private System.Windows.Forms.ToolStripSeparator edit_menuSeparator3;
        private System.Windows.Forms.ToolStripMenuItem edit_deleteCurrentPage;
        private System.Windows.Forms.ToolStripSeparator edit_menuSeparator4;
        private System.Windows.Forms.ToolStripSeparator edit_menuSeparator5;
        private System.Windows.Forms.ToolStripButton openDocumentButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem file_print;
        private System.Windows.Forms.ToolStripSeparator z_03;
        private System.Windows.Forms.ToolStripMenuItem file_documentProperties;
        private System.Windows.Forms.ToolStripMenuItem file_printManyToOnePage;
        private System.Windows.Forms.ToolStripMenuItem edit_rotateCurrentPage;
        private System.Windows.Forms.ToolStripMenuItem edit_rotateCurrentPage_90;
        private System.Windows.Forms.ToolStripMenuItem edit_rotateCurrentPage_180;
        private System.Windows.Forms.ToolStripMenuItem edit_rotateCurrentPage_270;
        private System.Windows.Forms.ToolStripMenuItem file_saveDocumentAs;
        private System.Windows.Forms.ToolStripSeparator z_04;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStrip alertStrip;
        private System.Windows.Forms.ToolStripLabel alertTextStripLabel;
        private System.Windows.Forms.ToolStripButton alertIconStripButton;
        private System.Windows.Forms.ToolStripLabel alertTitleStripLabel;
        private System.Windows.Forms.ToolStripButton alertCloseStripButton;
        private System.Windows.Forms.ToolStripMenuItem file_recentFiles;
        private System.Windows.Forms.ToolStripSeparator z_05;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem view_showRangeOfPages;
        private System.Windows.Forms.ToolStripSeparator z_06;
        private System.Windows.Forms.ToolStripMenuItem file_recentDocuments;
        private System.Windows.Forms.ToolStripButton getPdfTextButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem view_showBookmarks;
    }
}
