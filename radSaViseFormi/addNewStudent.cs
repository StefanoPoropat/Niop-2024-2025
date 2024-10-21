using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace radSaViseFormi
{
    public partial class addNewStudent : Form
    {
        string study;
        public string name => txtName.Text;
        public string surname => txtSurname.Text;
        public string direction => txtDirection.Text;
        public string index => txtIndex.Text;
        public string dateOfBirth => txtdateOfBirth.Value.ToString("yyyy-MM-dd");
        public string typeOfStudy
        {
            get
            {
                if (btnRegularStudent.Checked)
                {
                    study = "R";
                }
                if (btnIregularStudent.Checked)
                {
                    study = "I";
                }
                return study;
            }
        }
        public addNewStudent()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
