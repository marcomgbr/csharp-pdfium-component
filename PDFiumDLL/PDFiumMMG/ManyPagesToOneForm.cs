using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MMG.FormDecoration;
using MMG.Forms;

namespace PdfiumViewer
{
    public partial class ManyPagesToOneForm : CleanDarkForm
    {
        private readonly PdfViewer pdfViewer;

        public ManyPagesToOneForm(PdfViewer v)
        {
            InitializeComponent();
            this.pdfViewer = v ?? throw new ArgumentNullException(nameof(v));
        }

        private void _acceptButton_Click(object sender, EventArgs e)
        {
            int horizontal;
            int vertical;
            float margin;

            if (!int.TryParse(_horizontal.Text, out horizontal))
            {
                MsgBox.Format(SystemIcons.Error).t("Invalid").salmon.t("Pages per row").white.t("value.").Show();
            }
            else if (!int.TryParse(_vertical.Text, out vertical))
            {
                MsgBox.Format(SystemIcons.Error).t("Invalid").salmon.t("Pages per column").white.t("value.").Show();
            }
            else if (!float.TryParse(_margin.Text, out margin))
            {
                MsgBox.Format(SystemIcons.Error).t("Invalid").salmon.t("Margin").white.t("value.").Show();
            }
            else
            {
                var settings = new PdfPrintSettings(
                    pdfViewer.DefaultPrintMode,
                    new PdfPrintMultiplePages(
                        horizontal,
                        vertical,
                        _horizontalOrientation.Checked ? Orientation.Horizontal : Orientation.Vertical,
                        margin
                    )
                );

                using (var form = new PrintPreviewDialog())
                {
                    form.Document = pdfViewer.Document.CreatePrintDocument(settings);
                    form.ShowDialog(this);
                }

                DialogResult = DialogResult.OK;
            }
        }
    }
}
