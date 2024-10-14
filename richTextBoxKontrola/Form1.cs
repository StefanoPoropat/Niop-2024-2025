using System;
using System.Windows.Forms;

namespace richTextBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.LoadFile(@"D:\visual studio\richTextBox\Temp.rtf");
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Loading failed.");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.SaveFile(@"D:\visual studio\richTextBox\Temp.rtf");
                MessageBox.Show("Saved succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Saving failed.");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }
    }
}
