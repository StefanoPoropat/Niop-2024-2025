using formaStudenti.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formaStudenti
{
    public partial class Form1 : Form
    {
        string name, surname, nuIndex;
        public ListBox listBox1 = new ListBox();
        public Form1()
        {
            InitializeComponent();
        }
        private void newStudent_Click(object sender, EventArgs e)
        {
           formName formName1 = new formName();
            formName1.Show();
            listBox1.Items.Add(formName1.name1);
        }

        private void studentDispaly_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteOneStudnet_Click(object sender, EventArgs e)
        {

        }
        private void deleteAllStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
