using org.mariuszgromada.math.mxparser;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.XPath;

namespace App
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            lbl_screen.Text = "0";
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            var keys = new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down };
            if (keys.Contains(keyData))
                return true;
            else
                return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Delete:
                    btn_clear.PerformClick();
                    break;
                case Keys.Subtract:
                    btn_minus.PerformClick();
                    break;
                case Keys.Multiply:
                    btn_multiply.PerformClick();
                    break;
                case Keys.Divide:
                    btn_divide.PerformClick();
                    break;
                case Keys.Decimal:
                    btn_decimal.PerformClick();
                    break;
                case Keys.Back:
                    btn_clearEntry.PerformClick();
                    break;
                case Keys.Enter:
                    btn_equals.PerformClick();
                    break;
                default:
                    return false;
                    //return base.ProcessCmdKey(ref msg, keyData);
            }

            return false;
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "0";
            }

            btn_equals.Focus();
        }
        private void btn_one_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "1";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "1";
            }

            btn_equals.Focus();
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "2";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "2";
            }

            btn_equals.Focus();
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "3";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "3";
            }

            btn_equals.Focus();
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "4";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "4";
            }

            btn_equals.Focus();
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "5";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "5";
            }

            btn_equals.Focus();
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "6";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "6";
            }

            btn_equals.Focus();
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "7";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "7";
            }

            btn_equals.Focus();
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "8";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "8";
            }

            btn_equals.Focus();
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {
                lbl_screen.Text = "9";
            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + "9";
            }

            btn_equals.Focus();
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {

            if (lbl_screen.Text.EndsWith(".") || lbl_screen.Text.EndsWith(" "))
            {

            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + ".";
            }

            btn_equals.Focus();
        }

        private void btn_opposite_Click(object sender, EventArgs e)
        {
            string[] splitOp = lbl_screen.Text.Split(" ");
            List<string> listOp = new List<string>(splitOp);

            string lastOp = listOp[listOp.Count - 1];
            decimal lastN = 0;

            if (lastOp != "+" && lastOp != "-" && lastOp != "/" && lastOp != "*" && lastOp != "%" && lastOp != "")
            {
                lastN = Convert.ToDecimal(lastOp);
                lastN = lastN * -1;
                lastOp = lastN.ToString();

                listOp.RemoveAt(splitOp.Length - 1);

                listOp.Add(lastOp);
            }

            lbl_screen.Text = string.Join(" ", listOp);
            listOp.Clear();

            btn_equals.Focus();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text.EndsWith("+ ") || lbl_screen.Text.EndsWith("- ") || lbl_screen.Text.EndsWith("/ ") || lbl_screen.Text.EndsWith("* ") || lbl_screen.Text.EndsWith("% "))
            {

            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + " + ";
            }

            btn_equals.Focus();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text.EndsWith("+ ") || lbl_screen.Text.EndsWith("- ") || lbl_screen.Text.EndsWith("/ ") || lbl_screen.Text.EndsWith("* ") || lbl_screen.Text.EndsWith("% "))
            {

            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + " - ";
            }

            btn_equals.Focus();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text.EndsWith("+ ") || lbl_screen.Text.EndsWith("- ") || lbl_screen.Text.EndsWith("/ ") || lbl_screen.Text.EndsWith("* ") || lbl_screen.Text.EndsWith("% "))
            {

            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + " / ";
            }

            btn_equals.Focus();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text.EndsWith("+ ") || lbl_screen.Text.EndsWith("- ") || lbl_screen.Text.EndsWith("/ ") || lbl_screen.Text.EndsWith("* ") || lbl_screen.Text.EndsWith("% "))
            {

            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + " * ";
            }

            btn_equals.Focus();
        }

        private void btn_modulo_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text.EndsWith("+ ") || lbl_screen.Text.EndsWith("- ") || lbl_screen.Text.EndsWith("/ ") || lbl_screen.Text.EndsWith("* ") || lbl_screen.Text.EndsWith("% "))
            {

            }
            else
            {
                lbl_screen.Text = lbl_screen.Text + " % ";
            }

            btn_equals.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_screen.Text = "0";

            btn_equals.Focus();
        }

        private void btn_clearEntry_Click(object sender, EventArgs e)
        {
            //if (lbl_screen.Text == "" || lbl_screen.Text == "0")
            //{
            //    lbl_screen.Text = "0";
            //}
            if (lbl_screen.Text != "" && lbl_screen.Text != "0")
            {
                string[] splitCE = lbl_screen.Text.Split(" ");
                List<string> listCE = new List<string>(splitCE);

                if (listCE.Last() == "")
                {
                    listCE.RemoveRange(splitCE.Length - 2, 2);
                    lbl_screen.Text = string.Join(" ", listCE);
                }
                else
                {
                    listCE.RemoveAt(splitCE.Length - 1);
                    lbl_screen.Text = string.Join(" ", listCE) + " ";
                }
            }
            else
            {
                lbl_screen.Text = "0";
            }

            if (lbl_screen.Text == "" || lbl_screen.Text == " ")
            {
                lbl_screen.Text = "0";
            }

            btn_equals.Focus();

        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (lbl_screen.Text == "0")
            {

            }
            if (lbl_screen.Text.Contains("NaN"))
            {
                lbl_screen.Text = "0";
            }
            else if (lbl_screen.Text.Contains(" "))
            {
                Expression result = new Expression(lbl_screen.Text);

                lbl_screen.Text = Convert.ToString(result.calculate());

                btn_equals.Focus();
            }
        }
    }
}