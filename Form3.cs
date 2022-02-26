using System;
using System.Windows.Forms;

namespace Lab7_CS
{
    public partial class Form3 : Form
    {
        double pi = 3.14, suma = 0;

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
            if (Figura_Text.SelectedItem.ToString() == "Triunghi") suma = Convert.ToInt32(textBox1) + Convert.ToInt32(textBox2) + Convert.ToInt32(textBox3);
            
        }

        private void Rezultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
