﻿namespace Lab7_CS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conditiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introducetiLaturileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conditiaToolStripMenuItem,
            this.introducetiLaturileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(127, 450);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conditiaToolStripMenuItem
            // 
            this.conditiaToolStripMenuItem.Name = "conditiaToolStripMenuItem";
            this.conditiaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.conditiaToolStripMenuItem.Text = "Conditia";
            this.conditiaToolStripMenuItem.Click += new System.EventHandler(this.Conditia_Click);
            // 
            // introducetiLaturileToolStripMenuItem
            // 
            this.introducetiLaturileToolStripMenuItem.Name = "introducetiLaturileToolStripMenuItem";
            this.introducetiLaturileToolStripMenuItem.Size = new System.Drawing.Size(114, 19);
            this.introducetiLaturileToolStripMenuItem.Text = "Calculati aria figurii";
            this.introducetiLaturileToolStripMenuItem.Click += new System.EventHandler(this.Figura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conditiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introducetiLaturileToolStripMenuItem;
    }
}

