﻿
namespace MegaDesk_Bear
{
    partial class ViewAllQuotes
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
            this.return2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return2
            // 
            this.return2.Location = new System.Drawing.Point(315, 381);
            this.return2.Name = "return2";
            this.return2.Size = new System.Drawing.Size(75, 23);
            this.return2.TabIndex = 0;
            this.return2.Text = "Return";
            this.return2.UseVisualStyleBackColor = true;
            this.return2.Click += new System.EventHandler(this.return2_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return2);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return2;
    }
}