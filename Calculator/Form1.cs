using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string mat = "";
        private readonly char[] operators = { '+', '-', '*', '/' };

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendToMat(string value)
        {
            mat += value;
            lblDisplay.Text = mat;
        }

        private bool IsLastCharOperator()
        {
            return mat.Length > 0 && operators.Contains(mat.Last());
        }

        private string GetLastNumberSegment()
        {
            int lastOperatorIndex = mat.LastIndexOfAny(operators);
            return lastOperatorIndex == -1 ? mat : mat.Substring(lastOperatorIndex + 1);
        }

        private bool CanAddZero()
        {
            string lastSegment = GetLastNumberSegment();
            if (lastSegment.Contains(".")) return true;
            if (mat.Length == 0 || IsLastCharOperator()) return true;
            return lastSegment.Length > 0 && lastSegment != "0";
        }

        private bool CanAddDecimal()
        {
            string lastSegment = GetLastNumberSegment();
            if (lastSegment.Length == 0) return true;
            return !lastSegment.Contains(".");
        }

        private void button1_Click(object sender, EventArgs e) => AppendToMat("1");
        private void button2_Click(object sender, EventArgs e) => AppendToMat("2");
        private void button3_Click(object sender, EventArgs e) => AppendToMat("3");
        private void button4_Click(object sender, EventArgs e) => AppendToMat("4");
        private void button5_Click(object sender, EventArgs e) => AppendToMat("5");
        private void button6_Click(object sender, EventArgs e) => AppendToMat("6");
        private void button7_Click(object sender, EventArgs e) => AppendToMat("7");
        private void button8_Click(object sender, EventArgs e) => AppendToMat("8");
        private void button9_Click(object sender, EventArgs e) => AppendToMat("9");

        private void button0_Click(object sender, EventArgs e)
        {
            if (CanAddZero())
            {
                AppendToMat("0");
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (CanAddDecimal())
            {
                if (mat.Length == 0 || IsLastCharOperator())
                {
                    AppendToMat("0.");
                }
                else
                {
                    AppendToMat(".");
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!IsLastCharOperator()) AppendToMat("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!IsLastCharOperator()) AppendToMat("-");
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (!IsLastCharOperator()) AppendToMat("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!IsLastCharOperator()) AppendToMat("/");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mat = "";
            lblDisplay.Text = "0";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (mat.Length > 0)
            {
                mat = mat.Substring(0, mat.Length - 1);
                lblDisplay.Text = mat.Length > 0 ? mat : "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            mat = "0";
            lblDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (mat.Length == 0 || IsLastCharOperator()) return;
                string formattedExpression = mat.Replace(",", ".");

                if (formattedExpression.Contains("/0"))
                {
                    string[] parts = formattedExpression.Split('/');
                    if (parts.Length > 1 && parts.Last() == "0")
                    {
                        lblDisplay.Text = "Error: Division by zero";
                        mat = "";
                        return;
                    }
                }

                DataTable dt = new DataTable();
                var result = dt.Compute(formattedExpression, "");
                lblDisplay.Text = Convert.ToDouble(result).ToString();
                mat = lblDisplay.Text;
            }
            catch
            {
                lblDisplay.Text = "Error";
                mat = "";
            }
        }
    }
}
