using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ovo je informativna poruka. Želite li nastaviti?",
                                         "Informacija",
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Information);

            // Provjeravamo koji je gumb kliknut
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Odabrali ste 'Yes'.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Odabrali ste 'No'.");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Odabrali ste 'Cancel'.");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedProgram = comboBox1.SelectedItem?.ToString();
            if (selectedProgram == "Notepad")
            {
                Process.Start("notepad.exe");
            }
            else if (selectedProgram == "Paint")
            {
                Process.Start("mspaint.exe");
            }
            else
            {
                MessageBox.Show("Please select a program to run.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = checkBox1.Checked;
        }
        public string text, description;

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // Prikazujemo MessageBox s Yes i No gumbima za potvrdu izlaska
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite izaći iz aplikacije?",
                                                  "Potvrda izlaska",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Provjeravamo je li korisnik kliknuo na Yes
            if (result == DialogResult.Yes)
            {
                // Zatvaramo aplikaciju
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            // Otvori FormaText i prenesi podatke ako korisnik klikne "Send Text"
            FormaText formaText= new FormaText();
            formaText.ShowDialog();
            text = formaText.text;
            description = formaText.description;
            textEdit textEdit = new textEdit(text,description);
            textBox1.Text = (textEdit.ToString());
            textBox2.Text = (textEdit.ToString2());
        }
    
    }
}
