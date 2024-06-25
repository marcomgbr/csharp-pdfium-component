namespace PdfiumViewer
{
    partial class PageRangeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this._startPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._endPage = new System.Windows.Forms.TextBox();
            this._acceptButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start page:";
            // 
            // _startPage
            // 
            this._startPage.Location = new System.Drawing.Point(87, 54);
            this._startPage.Name = "_startPage";
            this._startPage.Size = new System.Drawing.Size(155, 20);
            this._startPage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End page:";
            // 
            // _endPage
            // 
            this._endPage.Location = new System.Drawing.Point(87, 80);
            this._endPage.Name = "_endPage";
            this._endPage.Size = new System.Drawing.Size(155, 20);
            this._endPage.TabIndex = 3;
            // 
            // _acceptButton
            // 
            this._acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._acceptButton.Location = new System.Drawing.Point(85, 115);
            this._acceptButton.Name = "_acceptButton";
            this._acceptButton.Size = new System.Drawing.Size(75, 23);
            this._acceptButton.TabIndex = 4;
            this._acceptButton.Text = "OK";
            this._acceptButton.UseVisualStyleBackColor = true;
            this._acceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.Location = new System.Drawing.Point(166, 115);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 5;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // PageRangeForm
            // 
            this.AcceptButton = this._acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(253, 156);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._acceptButton);
            this.Controls.Add(this._endPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._startPage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PageRangeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show Range of Pages";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this._startPage, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this._endPage, 0);
            this.Controls.SetChildIndex(this._acceptButton, 0);
            this.Controls.SetChildIndex(this._cancelButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _startPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _endPage;
        private System.Windows.Forms.Button _acceptButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}