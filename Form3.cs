using System;
using System.Windows.Forms;


namespace Lab7_CS
{

    public partial class Form3 : Form
    {
        double pi = 3.14;
        double aria = 0, perimetru = 0, suma = 0;

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
              
                perimetru = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text)) / 2;
                aria = Math.Sqrt(perimetru * (perimetru - Convert.ToDouble(textBox1.Text)) * (perimetru - Convert.ToDouble(textBox2.Text) * (perimetru - Convert.ToDouble(textBox3.Text))));
                Text_Rezult.Text = "Aria Triunghiului: " + aria.ToString("0.00");

            }
            if (Figura_Text.SelectedItem.ToString() == "Dreptunghi")
            {

                aria = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                Text_Rezult.Text = "Aria Dreptunghiului: " + aria.ToString("0.00");

            }
            if (Figura_Text.SelectedItem.ToString() == "Cerc")
            {

                aria = pi * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
                Text_Rezult.Text = "Aria Cercului: " + aria.ToString("0.00");

            }
        }

    }
}
