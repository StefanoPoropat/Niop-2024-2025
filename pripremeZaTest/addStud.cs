using System;
using System.Windows.Forms;

namespace testRep
{
    public partial class addStud : Form
    {
        public addStud()
        {
            InitializeComponent();
        }

        private DateTime pocetno = DateTime.Now;

        private string study;
        public string name => txbName.Text;
        public string surname => txbSurname.Text;
        public string index => txbIndex.Text;
        public string direction => cbDirection.Text;
        public string date => dtpDateOfBirth.Text;

        public string studyType
        {
            get
            {
                if (rbRegular.Checked)
                {
                    study = "R";
                }
                if (rbIregular.Checked)
                {
                    study = "I";
                }
                return study;
            }
        }

        private void btnCloseWithOutSaving_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSaveData_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel1.Text = "Proteklo: " +
            proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }
    }
}