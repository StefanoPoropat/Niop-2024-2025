using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formaStudenti.Properties
{
    public partial class formName : Form
    {
        public formName student1;
        internal formName Student1 { get=>student1; set=>student1 = value; }
        public string name1, surname1, nuIndex1, date1, direction1;
        public formName()
        {
            InitializeComponent();
        }

        public formName(string name1, string surname1, string nuIndex1, string date1, string direction1)
        {
            this.name1 = name1;
            this.surname1 = surname1;
            this.nuIndex1 = nuIndex1;
            this.date1 = date1;
            this.direction1 = direction1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            name1 = txtName.Text;
            surname1 = txtSurname.Text;
            nuIndex1 = txtNuId.Text;
            date1 = dateTimePicker1.Text;
            direction1 = comboBox1.Text;
            student1 = new formName(name1, surname1, nuIndex1, date1, direction1) ;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
