﻿namespace gridflip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flipButton = new System.Windows.Forms.Button();
            this.lowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpperNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(11, 438);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(211, 23);
            this.flipButton.TabIndex = 1;
            this.flipButton.Text = "Reverse Grid";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // lowerNumericUpDown
            // 
            this.lowerNumericUpDown.Location = new System.Drawing.Point(12, 412);
            this.lowerNumericUpDown.Name = "lowerNumericUpDown";
            this.lowerNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.lowerNumericUpDown.TabIndex = 2;
            this.lowerNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // UpperNumericUpDown
            // 
            this.UpperNumericUpDown.Location = new System.Drawing.Point(122, 412);
            this.UpperNumericUpDown.Name = "UpperNumericUpDown";
            this.UpperNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.UpperNumericUpDown.TabIndex = 3;
            this.UpperNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 473);
            this.Controls.Add(this.UpperNumericUpDown);
            this.Controls.Add(this.lowerNumericUpDown);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GridFlip";
            ((System.ComponentModel.ISupportInitialize)(this.lowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.NumericUpDown lowerNumericUpDown;
        private System.Windows.Forms.NumericUpDown UpperNumericUpDown;
    }
}

