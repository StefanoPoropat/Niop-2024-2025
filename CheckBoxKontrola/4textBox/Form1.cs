using System;
using System.Windows.Forms;

namespace _4textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) textBox1.Visible = false;
            else textBox1.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("Odabrali ste: \n\n");
        }

        private void dorucak_CheckedChanged(object sender, EventArgs e)
        {
            if (dorucak.Checked) textBox1.AppendText("\nDoručak\r");
            else textBox1.Text = textBox1.Text.Replace("Doručak", "");
        }

        private void rucak_CheckedChanged(object sender, EventArgs e)
        {
            if (rucak.Checked) textBox1.AppendText("\nRučak\r");
            else textBox1.Text = textBox1.Text.Replace("Ručak", "");
        }

        private void vecera_CheckedChanged(object sender, EventArgs e)
        {
            if (vecera.Checked) textBox1.AppendText("\nVečera\r");
            else textBox1.Text = textBox1.Text.Replace("Večera", "");
        }
    }
}
