using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMG.CustomPresentation.RTF;
using MMG.FormDecoration;

namespace PdfiumViewer
{
    public partial class RTFSearchForm : CleanDarkForm
    {
        BasicRTFViewer rtfViewer;

        public RTFSearchForm(BasicRTFViewer v)
        {
            InitializeComponent();
            this.rtfViewer = v;
        }

        private void RTFSearchForm_Shown(object sender, EventArgs e)
        {
            this.findTextBox.Focus();
        }

        private void findTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                this.rtfViewer.Find(this.findTextBox.Text);
            }
        }

        private void findTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F3))
            {
                this.rtfViewer.Find(this.findTextBox.Text);
            }
        }

        private void findNextButton_Click(object sender, EventArgs e)
        {
            this.rtfViewer.Find(this.findTextBox.Text);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool handled = false;

            if (keyData.Equals(Keys.Escape))
            {
                Close();
                handled = true;
            }

            return (handled || base.ProcessCmdKey(ref msg, keyData));
        }

        private void RTFSearchForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                Close();
            }
        }
    }
}
