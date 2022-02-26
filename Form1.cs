using System;
using System.Windows.Forms;

namespace Lab7_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Conditia_Click(object sender, EventArgs e)
        {

            Form2 newMDIChild = new Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();

        }

        private void Figura_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();

        }
    }
}
