using Studenti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace radSaViseFormi
{
    public partial class studentDisplayScreen : Form
    {
        public string imeStudenta, prezimeStudenta, smjerStudenta, brojIndeksaStudenta, datumRodjenjaStudenta, vrstaStudija;

        private void deleteAllStudents_Click(object sender, EventArgs e)
        {
            studentDisplay.Items.Clear();
        }

        private void saveToTxt_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamWriter saveFile = new System.IO.StreamWriter("C:\\Users\\ucenik\\Documents\\fileGoHere\\students.txt");
                foreach (var item in studentDisplay.Items)
                {
                    saveFile.WriteLine(item.ToString());
                }
                saveFile.Close();
                MessageBox.Show("Saving success.");

            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Saving failed.");
            }
        }

        private void loadFromTxt_Click(object sender, EventArgs e)
        {
            try
            {
                studentDisplay.Items.Clear();
                string line;
                System.IO.StreamReader saveFile = new System.IO.StreamReader("C:\\Users\\ucenik\\Documents\\fileGoHere\\students.txt");
                while ((line = saveFile.ReadLine()) != null)
                {
                    studentDisplay.Items.Add(line);
                }
                saveFile.Close();
                MessageBox.Show("Loading success.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Saving failed.");
            }
        }

        private void deleteOneStudent_Click(object sender, EventArgs e)
        {
            if (studentDisplay.SelectedItem != null)
            {
                studentDisplay.Items.Remove(studentDisplay.SelectedItem);
            }
            else
            {
                MessageBox.Show("Molimo odaberite studenta za brisanje.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public studentDisplayScreen()
        {
            InitializeComponent();
        }
        private void openNewStudentForm()
        {
            addNewStudent studentForm = new addNewStudent();
            DialogResult rezultat = studentForm.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                imeStudenta = studentForm.name;
                prezimeStudenta = studentForm.surname;
                smjerStudenta = studentForm.direction;
                brojIndeksaStudenta = studentForm.index;
                datumRodjenjaStudenta = studentForm.dateOfBirth;
                vrstaStudija = studentForm.typeOfStudy;
                Student noviStudent = new Student(imeStudenta, prezimeStudenta, smjerStudenta, vrstaStudija, brojIndeksaStudenta, datumRodjenjaStudenta);
                studentDisplay.Items.Add(noviStudent.ToString());
            }
        }
        private void addNewStudent_Click(object sender, EventArgs e)
        {
            openNewStudentForm();
            
        }
    }
}