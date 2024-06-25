﻿namespace PdfiumViewer
{
    partial class ManyPagesToOneForm
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
            this._horizontal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._vertical = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._margin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._verticalOrientation = new System.Windows.Forms.RadioButton();
            this._horizontalOrientation = new System.Windows.Forms.RadioButton();
            this.printButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pages per row:";
            // 
            // _horizontal
            // 
            this._horizontal.Location = new System.Drawing.Point(155, 50);
            this._horizontal.Name = "_horizontal";
            this._horizontal.Size = new System.Drawing.Size(100, 20);
            this._horizontal.TabIndex = 1;
            this._horizontal.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pages per column:";
            // 
            // _vertical
            // 
            this._vertical.Location = new System.Drawing.Point(155, 76);
            this._vertical.Name = "_vertical";
            this._vertical.Size = new System.Drawing.Size(100, 20);
            this._vertical.TabIndex = 3;
            this._vertical.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Margin:";
            // 
            // _margin
            // 
            this._margin.Location = new System.Drawing.Point(155, 102);
            this._margin.Name = "_margin";
            this._margin.Size = new System.Drawing.Size(101, 20);
            this._margin.TabIndex = 5;
            this._margin.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._verticalOrientation);
            this.groupBox1.Controls.Add(this._horizontalOrientation);
            this.groupBox1.Location = new System.Drawing.Point(17, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // _verticalOrientation
            // 
            this._verticalOrientation.AutoSize = true;
            this._verticalOrientation.Location = new System.Drawing.Point(6, 24);
            this._verticalOrientation.Name = "_verticalOrientation";
            this._verticalOrientation.Size = new System.Drawing.Size(58, 17);
            this._verticalOrientation.TabIndex = 1;
            this._verticalOrientation.Text = "Portrait";
            this._verticalOrientation.UseVisualStyleBackColor = true;
            // 
            // _horizontalOrientation
            // 
            this._horizontalOrientation.AutoSize = true;
            this._horizontalOrientation.Checked = true;
            this._horizontalOrientation.Location = new System.Drawing.Point(6, 47);
            this._horizontalOrientation.Name = "_horizontalOrientation";
            this._horizontalOrientation.Size = new System.Drawing.Size(78, 17);
            this._horizontalOrientation.TabIndex = 0;
            this._horizontalOrientation.TabStop = true;
            this._horizontalOrientation.Text = "Landscape";
            this._horizontalOrientation.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Location = new System.Drawing.Point(77, 220);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(87, 23);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.Location = new System.Drawing.Point(170, 220);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(87, 23);
            this._cancelButton.TabIndex = 8;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // ManyPagesToOneForm
            // 
            this.AcceptButton = this.printButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(270, 261);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._margin);
            this.Controls.Add(this._vertical);
            this.Controls.Add(this._horizontal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManyPagesToOneForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Many Pages to One";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this._horizontal, 0);
            this.Controls.SetChildIndex(this._vertical, 0);
            this.Controls.SetChildIndex(this._margin, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.printButton, 0);
            this.Controls.SetChildIndex(this._cancelButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _horizontal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _vertical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _margin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _verticalOrientation;
        private System.Windows.Forms.RadioButton _horizontalOrientation;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}