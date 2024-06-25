//using RTF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMG.CustomPresentation.RTF
{
    public partial class BasicRTFViewer : UserControl
    {
        double rtfFontSizeFactor = 12.0 / 800.0;
        public BasicRTFViewer()
        {
            InitializeComponent();
        }

        public RichTextBox TextBox
        {
            get
            {
                return this.rtfTextBox;
            }
        }

        public override string Text
        {
            set
            {
                GenerateLines(value);
                GenerateRTF(12);
            }
        }

        private string[] lines = null;
        public string[] Lines
        {
            get
            {
                return this.lines;
            }
        }

        private void GenerateLines(string s)
        {
            // remove all '\n' that is not precedded by '\.' or "\.\r"
            s = Regex.Replace(s, @"(?<!(\.\r|\.))(\r?\n)", " ");
            // remove all whitespace on ths paragraph begin
            s = Regex.Replace(s, @"\n\s+", "\n");

            this.lines = s.Split('\n');
        }

        private void GenerateRTF(int fontSize)
        {
            RTFBuilder b = new RTFBuilder();
            b.header.page.portrait().width_mm(215.9).height_mm(279.4).leftmargin_mm(13)
                .rightmargin_mm(13).topmargin_mm(13).bottommargin_mm(13);
            b.hardbr();

            foreach (string item in this.lines)
            {
                b.p(fontSize)._(item)._p();
            }

            this.rtfTextBox.Rtf = b.GetRTFString();
        }

        private void RTFViewer_SizeChanged(object sender, EventArgs e)
        {
            if (this.lines != null)
            {
                GenerateRTF((int)(this.Width * rtfFontSizeFactor));
            }
        }

        string findText;
        int startIndex = 0;
        string lastSearch = "";
        bool reinitializationAllowed = true;
        public void Find(string findText)
        {
            if (findText == "" || findText == null)
            {
                return;
            }

            this.findText = findText;

            rtfTextBox.Focus();

            if (lastSearch.Equals(findText))
            {
                startIndex++;
            }
            else
            {
                lastSearch = findText;
            }

            int index = rtfTextBox.Text.IndexOf(findText, startIndex, StringComparison.OrdinalIgnoreCase);
            if (index != -1)
            {
                rtfTextBox.Select(index, findText.Length);
                startIndex = index;
            }
            else if (reinitializationAllowed)
            {
                startIndex = 0;
                reinitializationAllowed = false; // avoid infinit loop
                Find(findText);
            }

            reinitializationAllowed = true;
        }

        private void rtfTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F3) || e.KeyCode.Equals(Keys.Enter))
            {
                Find(this.findText);
            }
        }
    }
}
