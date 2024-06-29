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
    public partial class PDFSearchForm : CleanDarkForm
    {
        private readonly PdfSearchManager searchManager;
        private bool findDirty;

        public PDFSearchForm(PdfRenderer renderer)
        {
            if (renderer == null)
            {
                throw new ArgumentNullException(nameof(renderer));
            }

            InitializeComponent();

            searchManager = new PdfSearchManager(renderer);

            matchCaseCheck.Checked = searchManager.MatchCase;
            matchWholeWordCheck.Checked = searchManager.MatchWholeWord;
            highlightAllMatchesCheck.Checked = searchManager.HighlightAllMatches;
        }

        private void _matchCase_CheckedChanged(object sender, EventArgs e)
        {
            findDirty = true;
            searchManager.MatchCase = matchCaseCheck.Checked;
        }

        private void _matchWholeWord_CheckedChanged(object sender, EventArgs e)
        {
            findDirty = true;
            searchManager.MatchWholeWord = matchWholeWordCheck.Checked;
        }

        private void _highlightAll_CheckedChanged(object sender, EventArgs e)
        {
            searchManager.HighlightAllMatches = highlightAllMatchesCheck.Checked;
        }

        private void _find_TextChanged(object sender, EventArgs e)
        {
            findDirty = true;
        }

        private void _findPrevious_Click(object sender, EventArgs e)
        {
            Find(false);
        }

        private void _findNext_Click(object sender, EventArgs e)
        {
            Find(true);
        }

        private void Find(bool forward)
        {
            if (findDirty)
            {
                findDirty = false;

                if (!searchManager.Search(findTextBox.Text))
                {
                    MsgBox.Show("No matches found.");
                    return;
                }
            }

            if (!searchManager.FindNext(forward))
            {
                MsgBox.Show("Find reached the starting point of the search.");
            }
        }

        private void SearchForm_Shown(object sender, EventArgs e)
        {
            findTextBox.Focus();
        }

        private void findTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                Find(true);
            }
        }

        private void findTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F3))
            {
                Find(true);
            }
        }

        private void PDFSearchForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                Close();
            }
        }
    }
}
