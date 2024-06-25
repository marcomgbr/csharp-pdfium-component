
namespace PdfiumViewer
{
    partial class RTFSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTFSearchForm));
            this.findNextButton = new System.Windows.Forms.Button();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // findNextButton
            // 
            this.findNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.findNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findNextButton.Image = ((System.Drawing.Image)(resources.GetObject("findNextButton.Image")));
            this.findNextButton.Location = new System.Drawing.Point(287, 48);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(32, 32);
            this.findNextButton.TabIndex = 15;
            this.findNextButton.UseVisualStyleBackColor = false;
            this.findNextButton.Click += new System.EventHandler(this.findNextButton_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTextBox.Location = new System.Drawing.Point(16, 53);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(265, 24);
            this.findTextBox.TabIndex = 13;
            this.findTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findTextBox_KeyPress);
            this.findTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.findTextBox_KeyUp);
            // 
            // RTFSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 93);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.findTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RTFSearchForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find";
            this.Shown += new System.EventHandler(this.RTFSearchForm_Shown);
            this.Controls.SetChildIndex(this.findTextBox, 0);
            this.Controls.SetChildIndex(this.findNextButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.TextBox findTextBox;
    }
}