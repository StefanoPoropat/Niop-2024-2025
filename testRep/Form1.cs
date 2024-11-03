using System;
using System.Windows.Forms;

namespace testRep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string name, surname, date, direction, index, study;
        private DateTime pocetno = DateTime.Now;

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel1.Text = "Proteklo: " +
            proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string line;
            System.IO.StreamReader saveFile = new System.IO.StreamReader("D:\\winrar\\file.txt");
            while ((line = saveFile.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            saveFile.Close();
            MessageBox.Show("Loading success.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter saveFile = new System.IO.StreamWriter("D:\\winrar\\file.txt");
            foreach (var item in listBox1.Items)
            {
                saveFile.WriteLine(item.ToString());
            }
            saveFile.Close();
            MessageBox.Show("Saving success.");
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Molimo odaberite studenta za brisanje.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addNewStudent_Click(object sender, EventArgs e)
        {
            addStud addStud = new addStud();
            addStud.ShowDialog();
            name = addStud.name;
            surname = addStud.surname;
            date = addStud.date;
            direction = addStud.direction;
            index = addStud.index;
            study = addStud.studyType;
            Students students = new Students(study, name, surname, date, direction, index);
            listBox1.Items.Add(students.ToString());
        }
    }
}