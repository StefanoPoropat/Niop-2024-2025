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
        string name1, surname1, nuIndex1;

        public formName()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            name1 = txtName.Text;
            surname1 = txtSurname.Text;
            nuIndex1 = txtNuId.Text;
        }

        private void formName_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
