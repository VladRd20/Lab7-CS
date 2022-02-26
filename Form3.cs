using System;
using System.Windows.Forms;

namespace Lab7_CS
{
    public partial class Form3 : Form
    {
        double pi = 3.14;
        double aria = 0, suma = 0;
        bool dreptunghic = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Figura_Text.SelectedItem.ToString() == "Dreptunghi")
            {
                textBox3.Visible = false;
            }
            else if (Figura_Text.SelectedItem.ToString() == "Cerc")
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click_Click(object sender, EventArgs e)
        {
            if (Figura_Text.SelectedItem.ToString() == "Triunghi")
            {
                if (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1) + Convert.ToDouble(textBox2) * Convert.ToDouble(textBox2) == Convert.ToDouble(textBox3) * Convert.ToDouble(textBox3))
                    dreptunghic = true;
                else if (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1) + Convert.ToDouble(textBox3) * Convert.ToDouble(textBox3) == Convert.ToDouble(textBox2) * Convert.ToDouble(textBox2))
                    dreptunghic = true;
                else if (Convert.ToDouble(textBox3) * Convert.ToDouble(textBox3) + Convert.ToDouble(textBox2) * Convert.ToDouble(textBox2) == Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1))
                    dreptunghic = true;
                else
                {
                    aria = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text);
                    Text_Rezult.Text = "Aria triunghiului: " + aria.ToString("0.00");
                }
            }
        }

    }
}
