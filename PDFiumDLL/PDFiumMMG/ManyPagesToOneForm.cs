using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MMG.FormDecoration;

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
                MessageBox.Show(this, "Invalid horizontal");
            }
            else if (!int.TryParse(_vertical.Text, out vertical))
            {
                MessageBox.Show(this, "Invalid vertical");
            }
            else if (!float.TryParse(_margin.Text, out margin))
            {
                MessageBox.Show(this, "Invalid margin");
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
