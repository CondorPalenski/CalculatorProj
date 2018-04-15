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
        }
        decimal result;
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("0", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width)>0)
                {
                    resultLabel.Text += "0";
                    resultLabel.Location = new Point(this.Width-20-resultLabel.Width,resultLabel.Location.Y);
                }
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "1";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "1";
                }
            }
            else
            {
                resultLabel.Text = "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "2";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "2";
                }
            }
            else
            {
                resultLabel.Text = "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "3";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "3";
                }
            }
            else
            {
                resultLabel.Text = "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "4";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "4";
                }
            }
            else
            {
                resultLabel.Text = "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "5";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "5";
                }
            }
            else
            {
                resultLabel.Text = "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "6";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "6";
                }
            }
            else
            {
                resultLabel.Text = "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "7";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "7";
                }
            }
            else
            {
                resultLabel.Text = "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "8";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "8";
                }
            }
            else
            {
                resultLabel.Text = "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text[0] != '0')
            {
                Size len = TextRenderer.MeasureText("1", resultLabel.Font);
                if (this.Width - (resultLabel.Width + len.Width) > 0)
                {
                    resultLabel.Text += "9";
                    resultLabel.Location = new Point(this.Width - 20 - resultLabel.Width, resultLabel.Location.Y);
                }
                else
                {
                    resultLabel.Text += "9";
                }
            }
            else
            {
                resultLabel.Text = "9";
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            try
            {
                result += Decimal.Parse(resultLabel.Text);
                resultLabel.Text = "0";
            }
            catch
            {
                resultLabel.Text = "Invalid input";
                BlockButton(false);
            }
        }

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
    }
}
