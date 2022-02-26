namespace Lab7_CS
{
    partial class Form3
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
            this.Figura_Text = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.Button_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Figura_Text
            // 
            this.Figura_Text.FormattingEnabled = true;
            this.Figura_Text.Items.AddRange(new object[] {
            "Triunghi",
            "Dreptunghi",
            "Cerc"});
            this.Figura_Text.Location = new System.Drawing.Point(12, 12);
            this.Figura_Text.Name = "Figura_Text";
            this.Figura_Text.Size = new System.Drawing.Size(144, 21);
            this.Figura_Text.TabIndex = 0;
            this.Figura_Text.Text = "Alegeti figura geometrica";
            this.Figura_Text.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(374, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // Rezultat
            // 
            this.Rezultat.Location = new System.Drawing.Point(162, 40);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(312, 20);
            this.Rezultat.TabIndex = 4;
            this.Rezultat.TextChanged += new System.EventHandler(this.Rezultat_TextChanged);
            // 
            // Button_Click
            // 
            this.Button_Click.Location = new System.Drawing.Point(162, 67);
            this.Button_Click.Name = "Button_Click";
            this.Button_Click.Size = new System.Drawing.Size(100, 46);
            this.Button_Click.TabIndex = 5;
            this.Button_Click.Text = "Calculeaza";
            this.Button_Click.UseVisualStyleBackColor = true;
            this.Button_Click.Click += new System.EventHandler(this.Button_Click_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 333);
            this.Controls.Add(this.Button_Click);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Figura_Text);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Figura_Text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Rezultat;
        private System.Windows.Forms.Button Button_Click;
    }
}