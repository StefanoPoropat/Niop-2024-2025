using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace test2
{
    internal class textEdit
    {
        public string _text, _description;
        private string text { get => _text; set => _text = value; }
        private string description { get => _description; set => _description = value; }

        public textEdit(string text, string description)
        {
           _text = text;
           _description = description;
        }
        public override string ToString()
        {
            return $"{text}";
        }
        public string ToString2()
        {
            return $"{description}";
        }


    }
}
