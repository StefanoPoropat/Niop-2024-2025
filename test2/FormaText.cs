using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace test2
{
    public partial class FormaText : Form
    {
        public string text { get; private set; }
        public string description{ get; private set; }

        public FormaText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Spremaj tekstove iz textBox-ova u svojstva
            text = textBox1.Text;
            description = textBox2.Text;

            // Zatvori formu kad korisnik klikne "Send Text"
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
