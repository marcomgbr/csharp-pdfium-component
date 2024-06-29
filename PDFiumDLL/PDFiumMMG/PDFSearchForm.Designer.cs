namespace PdfiumViewer
{
    partial class PDFSearchForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFSearchForm));
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findPreviousButton1 = new System.Windows.Forms.Button();
            this.findNextButton = new System.Windows.Forms.Button();
            this.matchCaseCheck = new System.Windows.Forms.CheckBox();
            this.matchWholeWordCheck = new System.Windows.Forms.CheckBox();
            this.highlightAllMatchesCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // findTextBox
            // 
            this.findTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTextBox.Location = new System.Drawing.Point(16, 54);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(310, 24);
            this.findTextBox.TabIndex = 9;
            this.findTextBox.TextChanged += new System.EventHandler(this._find_TextChanged);
            this.findTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findTextBox_KeyPress);
            this.findTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.findTextBox_KeyUp);
            // 
            // findPreviousButton1
            // 
            this.findPreviousButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.findPreviousButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findPreviousButton1.Image = ((System.Drawing.Image)(resources.GetObject("findPreviousButton1.Image")));
            this.findPreviousButton1.Location = new System.Drawing.Point(256, 128);
            this.findPreviousButton1.Name = "findPreviousButton1";
            this.findPreviousButton1.Size = new System.Drawing.Size(32, 32);
            this.findPreviousButton1.TabIndex = 10;
            this.findPreviousButton1.UseVisualStyleBackColor = false;
            this.findPreviousButton1.Click += new System.EventHandler(this._findPrevious_Click);
            // 
            // findNextButton
            // 
            this.findNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.findNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findNextButton.Image = ((System.Drawing.Image)(resources.GetObject("findNextButton.Image")));
            this.findNextButton.Location = new System.Drawing.Point(294, 128);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(32, 32);
            this.findNextButton.TabIndex = 11;
            this.findNextButton.UseVisualStyleBackColor = false;
            this.findNextButton.Click += new System.EventHandler(this._findNext_Click);
            // 
            // matchCaseCheck
            // 
            this.matchCaseCheck.AutoSize = true;
            this.matchCaseCheck.Location = new System.Drawing.Point(17, 97);
            this.matchCaseCheck.Name = "matchCaseCheck";
            this.matchCaseCheck.Size = new System.Drawing.Size(83, 17);
            this.matchCaseCheck.TabIndex = 12;
            this.matchCaseCheck.Text = "Match Case";
            this.matchCaseCheck.UseVisualStyleBackColor = true;
            this.matchCaseCheck.CheckedChanged += new System.EventHandler(this._matchCase_CheckedChanged);
            // 
            // matchWholeWordCheck
            // 
            this.matchWholeWordCheck.AutoSize = true;
            this.matchWholeWordCheck.Location = new System.Drawing.Point(17, 120);
            this.matchWholeWordCheck.Name = "matchWholeWordCheck";
            this.matchWholeWordCheck.Size = new System.Drawing.Size(119, 17);
            this.matchWholeWordCheck.TabIndex = 13;
            this.matchWholeWordCheck.Text = "Match Whole Word";
            this.matchWholeWordCheck.UseVisualStyleBackColor = true;
            this.matchWholeWordCheck.CheckedChanged += new System.EventHandler(this._matchWholeWord_CheckedChanged);
            // 
            // highlightAllMatchesCheck
            // 
            this.highlightAllMatchesCheck.AutoSize = true;
            this.highlightAllMatchesCheck.Checked = true;
            this.highlightAllMatchesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.highlightAllMatchesCheck.Location = new System.Drawing.Point(17, 143);
            this.highlightAllMatchesCheck.Name = "highlightAllMatchesCheck";
            this.highlightAllMatchesCheck.Size = new System.Drawing.Size(125, 17);
            this.highlightAllMatchesCheck.TabIndex = 14;
            this.highlightAllMatchesCheck.Text = "Highlight All Matches";
            this.highlightAllMatchesCheck.UseVisualStyleBackColor = true;
            this.highlightAllMatchesCheck.CheckedChanged += new System.EventHandler(this._highlightAll_CheckedChanged);
            // 
            // PDFSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 178);
            this.Controls.Add(this.highlightAllMatchesCheck);
            this.Controls.Add(this.matchWholeWordCheck);
            this.Controls.Add(this.matchCaseCheck);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.findPreviousButton1);
            this.Controls.Add(this.findTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDFSearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find";
            this.Shown += new System.EventHandler(this.SearchForm_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PDFSearchForm_KeyUp);
            this.Controls.SetChildIndex(this.findTextBox, 0);
            this.Controls.SetChildIndex(this.findPreviousButton1, 0);
            this.Controls.SetChildIndex(this.findNextButton, 0);
            this.Controls.SetChildIndex(this.matchCaseCheck, 0);
            this.Controls.SetChildIndex(this.matchWholeWordCheck, 0);
            this.Controls.SetChildIndex(this.highlightAllMatchesCheck, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findPreviousButton1;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.CheckBox matchCaseCheck;
        private System.Windows.Forms.CheckBox matchWholeWordCheck;
        private System.Windows.Forms.CheckBox highlightAllMatchesCheck;
    }
}