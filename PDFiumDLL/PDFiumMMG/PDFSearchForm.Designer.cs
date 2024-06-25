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
            this.optionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.matchCaseButton = new System.Windows.Forms.ToolStripButton();
            this.matchWholeWordButton = new System.Windows.Forms.ToolStripButton();
            this.highlightAllMatchesButton = new System.Windows.Forms.ToolStripButton();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findPreviousButton1 = new System.Windows.Forms.Button();
            this.findNextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.optionsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsToolStrip
            // 
            this.optionsToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionsToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.optionsToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.optionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchCaseButton,
            this.matchWholeWordButton,
            this.highlightAllMatchesButton});
            this.optionsToolStrip.Location = new System.Drawing.Point(0, 44);
            this.optionsToolStrip.Name = "optionsToolStrip";
            this.optionsToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.optionsToolStrip.Size = new System.Drawing.Size(414, 39);
            this.optionsToolStrip.TabIndex = 8;
            this.optionsToolStrip.Text = "toolStrip2";
            // 
            // matchCaseButton
            // 
            this.matchCaseButton.CheckOnClick = true;
            this.matchCaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.matchCaseButton.Image = ((System.Drawing.Image)(resources.GetObject("matchCaseButton.Image")));
            this.matchCaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matchCaseButton.Name = "matchCaseButton";
            this.matchCaseButton.Size = new System.Drawing.Size(36, 36);
            this.matchCaseButton.Text = "Match Case";
            this.matchCaseButton.CheckedChanged += new System.EventHandler(this._matchCase_CheckedChanged);
            // 
            // matchWholeWordButton
            // 
            this.matchWholeWordButton.CheckOnClick = true;
            this.matchWholeWordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.matchWholeWordButton.Image = ((System.Drawing.Image)(resources.GetObject("matchWholeWordButton.Image")));
            this.matchWholeWordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matchWholeWordButton.Name = "matchWholeWordButton";
            this.matchWholeWordButton.Size = new System.Drawing.Size(36, 36);
            this.matchWholeWordButton.Text = "Match Whole Word";
            this.matchWholeWordButton.CheckedChanged += new System.EventHandler(this._matchWholeWord_CheckedChanged);
            // 
            // highlightAllMatchesButton
            // 
            this.highlightAllMatchesButton.CheckOnClick = true;
            this.highlightAllMatchesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.highlightAllMatchesButton.Image = ((System.Drawing.Image)(resources.GetObject("highlightAllMatchesButton.Image")));
            this.highlightAllMatchesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.highlightAllMatchesButton.Name = "highlightAllMatchesButton";
            this.highlightAllMatchesButton.Size = new System.Drawing.Size(36, 36);
            this.highlightAllMatchesButton.Text = "Highlight All Matches";
            this.highlightAllMatchesButton.CheckedChanged += new System.EventHandler(this._highlightAll_CheckedChanged);
            // 
            // findTextBox
            // 
            this.findTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTextBox.Location = new System.Drawing.Point(48, 10);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(243, 24);
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
            this.findPreviousButton1.Location = new System.Drawing.Point(297, 7);
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
            this.findNextButton.Location = new System.Drawing.Point(335, 7);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(32, 32);
            this.findNextButton.TabIndex = 11;
            this.findNextButton.UseVisualStyleBackColor = false;
            this.findNextButton.Click += new System.EventHandler(this._findNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Find:";
            // 
            // PDFSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 83);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.findPreviousButton1);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.optionsToolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDFSearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Shown += new System.EventHandler(this.SearchForm_Shown);
            this.Controls.SetChildIndex(this.optionsToolStrip, 0);
            this.Controls.SetChildIndex(this.findTextBox, 0);
            this.Controls.SetChildIndex(this.findPreviousButton1, 0);
            this.Controls.SetChildIndex(this.findNextButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.optionsToolStrip.ResumeLayout(false);
            this.optionsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip optionsToolStrip;
        private System.Windows.Forms.ToolStripButton matchCaseButton;
        private System.Windows.Forms.ToolStripButton matchWholeWordButton;
        private System.Windows.Forms.ToolStripButton highlightAllMatchesButton;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findPreviousButton1;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Label label1;
    }
}