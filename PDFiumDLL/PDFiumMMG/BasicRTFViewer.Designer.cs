
namespace MMG.CustomPresentation.RTF
{
    partial class BasicRTFViewer
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
            this.rtfTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtfTextBox
            // 
            this.rtfTextBox.BackColor = System.Drawing.Color.White;
            this.rtfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfTextBox.EnableAutoDragDrop = true;
            this.rtfTextBox.Location = new System.Drawing.Point(0, 0);
            this.rtfTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.rtfTextBox.Name = "rtfTextBox";
            this.rtfTextBox.ReadOnly = true;
            this.rtfTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtfTextBox.Size = new System.Drawing.Size(800, 600);
            this.rtfTextBox.TabIndex = 9;
            this.rtfTextBox.Text = "";
            this.rtfTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtfTextBox_KeyUp);
            // 
            // BasicRTFViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.rtfTextBox);
            this.Name = "BasicRTFViewer";
            this.Size = new System.Drawing.Size(800, 600);
            this.SizeChanged += new System.EventHandler(this.RTFViewer_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtfTextBox;
    }
}
