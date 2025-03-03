using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string mat = ""; // Stores the entered expression
        private readonly char[] operators = { '+', '-', '*', '/' }; // Array of valid operators

        public Form1()
        {
            InitializeComponent();
        }

        // Appends a value to the expression and updates the display
        private void AppendToMat(string value)
        {
            mat += value;
            lblDisplay.Text = mat;
        }

        // Returns true if the last character is an operator
        private bool IsLastCharOperator()
        {
            return mat.Length > 0 && operators.Contains(mat.Last());
        }

        // Gets the last number segment after the last operator
        private string GetLastNumberSegment()
        {
            int lastOperatorIndex = mat.LastIndexOfAny(operators);
            return lastOperatorIndex == -1 ? mat : mat.Substring(lastOperatorIndex + 1);
        }

        // Ensures 0 is added correctly (e.g., prevents "00", but allows "0.1")
        private bool CanAddZero()
        {
            string lastSegment = GetLastNumberSegment();

            // Allow zero if it's after a decimal (e.g., "0.1", "2.03")
            if (lastSegment.Contains(".")) return true;

            // Prevent multiple leading zeros in a whole number
            return lastSegment.Length > 0 && lastSegment != "0";
        }

        // Ensures decimals are added correctly (e.g., prevents "5.3.2")
        private bool CanAddDecimal()
        {
            string lastSegment = GetLastNumberSegment();

            // Allow decimal at the beginning or after an operator
            if (lastSegment.Length == 0) return true;

            // Allow decimal only if the segment does NOT already contain one
            return !lastSegment.Contains(".");
        }

        // Number buttons
        private void button1_Click(object sender, EventArgs e) => AppendToMat("1");
        private void button2_Click(object sender, EventArgs e) => AppendToMat("2");
        private void button3_Click(object sender, EventArgs e) => AppendToMat("3");
        private void button4_Click(object sender, EventArgs e) => AppendToMat("4");
        private void button5_Click(object sender, EventArgs e) => AppendToMat("5");
        private void button6_Click(object sender, EventArgs e) => AppendToMat("6");
        private void button7_Click(object sender, EventArgs e) => AppendToMat("7");
        private void button8_Click(object sender, EventArgs e) => AppendToMat("8");
        private void button9_Click(object sender, EventArgs e) => AppendToMat("9");
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (mat.Length == 0 || IsLastCharOperator()) return; // Prevent invalid calculations

                // Replace ',' with '.' in case of incorrect formatting
                string formattedExpression = mat.Replace(",", ".");

                DataTable dt = new DataTable();
                var result = dt.Compute(formattedExpression, "");

                // Convert result to string and format correctly
                lblDisplay.Text = Convert.ToDouble(result).ToString();
                mat = lblDisplay.Text; // Store the result for further calculations
            }
            catch
            {
                lblDisplay.Text = "Error";
                mat = "";
            }
        }


        // Zero button (prevents leading zero issues)
        private void button0_Click(object sender, EventArgs e)
        {
            if (CanAddZero()) AppendToMat("0");
        }

        // Decimal button (prevents multiple decimals in a number)
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (CanAddDecimal()) AppendToMat(".");
        }

        // Operator buttons (prevents multiple consecutive operators)
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

        // Clears everything
        private void btnClear_Click(object sender, EventArgs e)
        {
            mat = "";
            lblDisplay.Text = "0"; // Reset display
        }

        // Deletes the last character (backspace)
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (mat.Length > 0)
            {
                mat = mat.Substring(0, mat.Length - 1);
                lblDisplay.Text = mat.Length > 0 ? mat : "0";
            }
        }

        // Clears the last entered number (not the entire expression)
        private void btnCE_Click(object sender, EventArgs e)
        {
            if (mat.Length == 0) return;

            int lastOperatorIndex = mat.LastIndexOfAny(operators);
            if (lastOperatorIndex == -1) // If no operator, clear everything
            {
                mat = "";
            }
            else
            {
                mat = mat.Substring(0, lastOperatorIndex + 1);
            }

            lblDisplay.Text = mat.Length > 0 ? mat : "0";
        }
    }
}
