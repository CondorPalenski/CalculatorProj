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
        #region Digits buttons
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (press_equality == true)
            {
                resultLabel.Text = "0";
                press_equality = false;
            }
            if ((resultLabel.Text[0] != '0') && (divisionButton.Enabled == true))
            {
                resultLabel.Text += "0";
                BlockButton(true);
            }
            else
            {
                resultLabel.Text = "0";
            }
            BlockButton(true);
            ShiftResultLabel(" ");
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
                resultLabel.Text += "1";
            }
            else
            {
                resultLabel.Text = "1";
            }
            BlockButton(true);
            ShiftResultLabel("1");
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
                resultLabel.Text += "2";
            }
            else
            {
                resultLabel.Text = "2";
            }
            BlockButton(true);
            ShiftResultLabel("2");
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
                resultLabel.Text += "3";
            }
            else
            {
                resultLabel.Text = "3";
            }
            BlockButton(true);
            ShiftResultLabel(threeButton.Text);
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
                resultLabel.Text += "4";
            }
            else
            {
                resultLabel.Text = "4";
            }
            BlockButton(true);
            ShiftResultLabel(fourButton.Text);
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
                resultLabel.Text += "5";
            }
            else
            {
                resultLabel.Text = "5";
            }
            ShiftResultLabel(fiveButton.Text);
            BlockButton(true);
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
                resultLabel.Text += "6";
            }
            else
            {
                resultLabel.Text = "6";
            }
            ShiftResultLabel(sixButton.Text);
            BlockButton(true);
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
                resultLabel.Text += "7";
            }
            else
            {
                resultLabel.Text = "7";
            }
            ShiftResultLabel(sevenButton.Text);
            BlockButton(true);
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
                resultLabel.Text += "8";
            }
            else
            {
                resultLabel.Text = "8";
            }
            ShiftResultLabel(eightButton.Text);
            BlockButton(true);
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
                resultLabel.Text += "9";            }
            else
            {
                resultLabel.Text = "9";
            }
            ShiftResultLabel(nineButton.Text);
            BlockButton(true);
        }
        #endregion
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
        //Subtract number to result
        private void Minus()
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
        private void Multiplicate()
        {
                string res = resultLabel.Text;
                if (press_equality == true)
                {
                    res = "0";
                }
                result *= Decimal.Parse(res);
                resultLabel.Text = "0";
                ShiftResultLabel(" ");
                BlockButton(true);
                last_operation = 3;
        }
        private void Division()
        {
                string res = resultLabel.Text;
                if (press_equality == true)
                {
                    res = "0";
                }
                result /= Decimal.Parse(res);
                resultLabel.Text = "0";
                ShiftResultLabel(" ");
                BlockButton(true);
                last_operation = 4;
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
        #region OperationsButton
        private void EqualityButton_Click(object sender, EventArgs e)
        {
            press_equality = true;
            if (last_operation == 1)
            {
                try
                {
                    Plus();
                    resultLabel.Text = " ";
                    ShiftResultLabel(result.ToString());
                }
                catch
                {
                    resultLabel.Text = "Invalid input";
                    ShiftResultLabel(" ");
                    BlockButton(false);
                    return;
                }
            }
            else if(last_operation==2)
            {
                try
                {
                    Minus();
                    resultLabel.Text = " ";
                    ShiftResultLabel(result.ToString());
                }
                catch
                {
                    resultLabel.Text = "Invalid input";
                    ShiftResultLabel(" ");
                    BlockButton(false);
                    return;
                }
            }
            else if(last_operation==3)
            {
                try
                {
                    Multiplicate();
                    resultLabel.Text = " ";
                    ShiftResultLabel(result.ToString());
                }
                catch
                {
                    resultLabel.Text = "Invalid input";
                    ShiftResultLabel(" ");
                    BlockButton(false);
                    return;
                }
            }
            else if(last_operation==4)
            {
                try
                {
                    Division();
                    resultLabel.Text = " ";
                    ShiftResultLabel(result.ToString());
                }
                catch
                {
                    resultLabel.Text = "Invalid input";
                    ShiftResultLabel(" ");
                    BlockButton(false);
                    return;
                }

            }
            resultLabel.Text = result.ToString();
            last_operation = 0;
        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            result = Decimal.Parse(resultLabel.Text);
            resultLabel.Text = "0";
            ShiftResultLabel(" ");
            last_operation = 2;
            press_equality = false;
        }
        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            result = Decimal.Parse(resultLabel.Text);
            resultLabel.Text = "0";
            ShiftResultLabel(" ");
            last_operation = 3;
            press_equality = false;
        }
        private void divisionButton_Click(object sender, EventArgs e)
        {
            result = Decimal.Parse(resultLabel.Text);
            resultLabel.Text = "0";
            ShiftResultLabel(" ");
            last_operation = 4;
            press_equality = false;
        }
        private void PlusButton_Click(object sender, EventArgs e)
        {
            result = Decimal.Parse(resultLabel.Text);
            resultLabel.Text = "0";
            ShiftResultLabel(" ");
            last_operation = 1;
            press_equality = false;
        }
        #endregion
    }
}
