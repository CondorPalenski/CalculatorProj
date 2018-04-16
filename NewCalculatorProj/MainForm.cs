using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculatorProj
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            result = 0;
            press_equality = false;
        }
        decimal result;//Store total result
        byte last_operation;//Store last operation for equality
        bool press_equality;//Indicator for checking pressing of Equality
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel("0");
                resultLabel.Text += "0";
                BlockButton(true);
            }
            else
            {
                ShiftResultLabel(" ");
                resultLabel.Text = "0";
            }
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel("1");
                resultLabel.Text += "1";
                BlockButton(true);
            }
            else
            {
                ShiftResultLabel(" ");
                resultLabel.Text = "1";
            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (press_equality==true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel("2");
                resultLabel.Text += "2";
                BlockButton(true);
            }
            else
            {
                ShiftResultLabel(" ");
                resultLabel.Text = "2";
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel(threeButton.Text);
                resultLabel.Text += "3";
                BlockButton(true);
            }
            else
            {
                resultLabel.Text = "3";
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel(fourButton.Text);
                resultLabel.Text += "4";
                BlockButton(true);
            }
            else
            {
                resultLabel.Text = "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel(fiveButton.Text);
                resultLabel.Text += "5";
                BlockButton(true);
            }
            else
            {
                resultLabel.Text = "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel(nineButton.Text);
                resultLabel.Text += "6";
                BlockButton(true);
            }
            else
            {
                resultLabel.Text = "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel(nineButton.Text);
                resultLabel.Text += "7";
                BlockButton(true);
            }
            else
            {
                resultLabel.Text = "7";
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                ShiftResultLabel(nineButton.Text);
                resultLabel.Text += "8";
                BlockButton(true);
            }
            else
            {
                resultLabel.Text = "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0')&&(divisionButton.Enabled==true))
            {
                ShiftResultLabel(nineButton.Text);
                resultLabel.Text += "9";
                BlockButton(true);
            }
            else
            {
                resultLabel.Text = "9";
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            result = Decimal.Parse(resultLabel.Text);
            resultLabel.Text = "0";
            ShiftResultLabel(" ");
            last_operation = 1;
            press_equality = false;
        }

        //Block or unblock all buttons except for digitals and C,CE,<<
        private void BlockButton(bool status)
        {
            changeSignButton.Enabled = status;
            commaButton.Enabled = status;
            plusButton.Enabled = status;
            minusButton.Enabled = status;
            multiplicationButton.Enabled = status;
            divisionButton.Enabled = status;
            percentButton.Enabled = status;
            squareRootButton.Enabled = status;
            squaringButton.Enabled = status;
            fractionButton.Enabled = status;           
        }

        //Add number to result
        private void Plus()
        {
            try
            {
                string res = resultLabel.Text;
                if(press_equality==true)
                {
                    res = "0";
                }
                result += Decimal.Parse(res);
                resultLabel.Text = "0";
                ShiftResultLabel(" ");
                BlockButton(true);
                last_operation = 1;
            }
            catch
            {
                resultLabel.Text = "Invalid input";
                BlockButton(false);
            }
        }

        //Subtract number to result
        private void Minus()
        {
            try
            {
                string res = resultLabel.Text;
                if (press_equality == true)
                {
                    res = "0";
                }
                result -= Decimal.Parse(res);
                resultLabel.Text = "0";
                ShiftResultLabel(" ");
                BlockButton(true);
                last_operation = 2;
            }
            catch
            {
                resultLabel.Text = "Invalid input";
                BlockButton(false);
            }
        }
        //Shift resultLabel before adding of resut
        private void ShiftResultLabel(string text)
        {
            Size len = TextRenderer.MeasureText(text, resultLabel.Font);
            if (this.Width - (resultLabel.Width + len.Width) > (5))
            {
                resultLabel.Location = new Point(this.Width - len.Width - resultLabel.Width, resultLabel.Location.Y);
            }
        }

        private void EqualityButton_Click(object sender, EventArgs e)
        {
            if (last_operation == 1)
            {
                Plus();
                resultLabel.Text = " ";
                ShiftResultLabel(result.ToString());

            }
            else if(last_operation==2)
            {
                Minus();
                resultLabel.Text = " ";
                ShiftResultLabel(result.ToString());
            }
            else
            {
                resultLabel.Text = " ";
                ShiftResultLabel(result.ToString());
            }
            resultLabel.Text = result.ToString();
            last_operation = 0;
            press_equality = true;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            result = Decimal.Parse(resultLabel.Text);
            resultLabel.Text = "0";
            ShiftResultLabel(" ");
            last_operation = 2;
            press_equality = false;
        }
    }
}
