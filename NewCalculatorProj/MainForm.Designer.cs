namespace NewCalculatorProj
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.operationsQueueLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.percentButton = new System.Windows.Forms.Button();
            this.cleanEntireButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.squareRootButton = new System.Windows.Forms.Button();
            this.squaringButton = new System.Windows.Forms.Button();
            this.fractionButton = new System.Windows.Forms.Button();
            this.cleanAllButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.equalityButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operationsQueueLabel
            // 
            this.operationsQueueLabel.AutoSize = true;
            this.operationsQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsQueueLabel.ForeColor = System.Drawing.Color.Gray;
            this.operationsQueueLabel.Location = new System.Drawing.Point(366, 16);
            this.operationsQueueLabel.Name = "operationsQueueLabel";
            this.operationsQueueLabel.Size = new System.Drawing.Size(0, 18);
            this.operationsQueueLabel.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(362, 49);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(36, 37);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "0";
            // 
            // percentButton
            // 
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentButton.Location = new System.Drawing.Point(12, 111);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(92, 47);
            this.percentButton.TabIndex = 2;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = true;
            // 
            // cleanEntireButton
            // 
            this.cleanEntireButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanEntireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanEntireButton.Location = new System.Drawing.Point(12, 164);
            this.cleanEntireButton.Name = "cleanEntireButton";
            this.cleanEntireButton.Size = new System.Drawing.Size(92, 47);
            this.cleanEntireButton.TabIndex = 3;
            this.cleanEntireButton.Text = "CE";
            this.cleanEntireButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(12, 217);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(92, 47);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(12, 270);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(92, 47);
            this.fourButton.TabIndex = 5;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(12, 323);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(92, 47);
            this.oneButton.TabIndex = 6;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // changeSignButton
            // 
            this.changeSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSignButton.Location = new System.Drawing.Point(12, 376);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Size = new System.Drawing.Size(92, 47);
            this.changeSignButton.TabIndex = 7;
            this.changeSignButton.Text = "±";
            this.changeSignButton.UseVisualStyleBackColor = true;
            // 
            // squareRootButton
            // 
            this.squareRootButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.squareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareRootButton.Location = new System.Drawing.Point(110, 111);
            this.squareRootButton.Name = "squareRootButton";
            this.squareRootButton.Size = new System.Drawing.Size(92, 47);
            this.squareRootButton.TabIndex = 8;
            this.squareRootButton.Text = "√";
            this.squareRootButton.UseVisualStyleBackColor = true;
            // 
            // squaringButton
            // 
            this.squaringButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.squaringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squaringButton.Location = new System.Drawing.Point(208, 111);
            this.squaringButton.Name = "squaringButton";
            this.squaringButton.Size = new System.Drawing.Size(92, 47);
            this.squaringButton.TabIndex = 9;
            this.squaringButton.Text = "x²";
            this.squaringButton.UseVisualStyleBackColor = true;
            // 
            // fractionButton
            // 
            this.fractionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fractionButton.Location = new System.Drawing.Point(306, 111);
            this.fractionButton.Name = "fractionButton";
            this.fractionButton.Size = new System.Drawing.Size(92, 47);
            this.fractionButton.TabIndex = 10;
            this.fractionButton.Text = "1/x";
            this.fractionButton.UseVisualStyleBackColor = true;
            // 
            // cleanAllButton
            // 
            this.cleanAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanAllButton.Location = new System.Drawing.Point(110, 164);
            this.cleanAllButton.Name = "cleanAllButton";
            this.cleanAllButton.Size = new System.Drawing.Size(92, 47);
            this.cleanAllButton.TabIndex = 11;
            this.cleanAllButton.Text = "C";
            this.cleanAllButton.UseVisualStyleBackColor = true;
            // 
            // divisionButton
            // 
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(306, 164);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(92, 47);
            this.divisionButton.TabIndex = 13;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            // 
            // eightButton
            // 
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightButton.Location = new System.Drawing.Point(110, 217);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(92, 47);
            this.eightButton.TabIndex = 14;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(208, 217);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(92, 47);
            this.nineButton.TabIndex = 15;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationButton.Location = new System.Drawing.Point(306, 217);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(92, 47);
            this.multiplicationButton.TabIndex = 16;
            this.multiplicationButton.Text = "X";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            // 
            // fiveButton
            // 
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(110, 270);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(92, 47);
            this.fiveButton.TabIndex = 17;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(208, 270);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(92, 47);
            this.sixButton.TabIndex = 18;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(306, 270);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(92, 47);
            this.minusButton.TabIndex = 19;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(110, 323);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(92, 47);
            this.twoButton.TabIndex = 20;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(208, 323);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(92, 47);
            this.threeButton.TabIndex = 21;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(306, 323);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(92, 47);
            this.plusButton.TabIndex = 22;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(110, 376);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(92, 47);
            this.zeroButton.TabIndex = 23;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // commaButton
            // 
            this.commaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commaButton.Location = new System.Drawing.Point(208, 376);
            this.commaButton.Name = "commaButton";
            this.commaButton.Size = new System.Drawing.Size(92, 47);
            this.commaButton.TabIndex = 24;
            this.commaButton.Text = ",";
            this.commaButton.UseVisualStyleBackColor = true;
            // 
            // equalityButton
            // 
            this.equalityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalityButton.Location = new System.Drawing.Point(306, 376);
            this.equalityButton.Name = "equalityButton";
            this.equalityButton.Size = new System.Drawing.Size(92, 47);
            this.equalityButton.TabIndex = 25;
            this.equalityButton.Text = "=";
            this.equalityButton.UseVisualStyleBackColor = true;
            this.equalityButton.Click += new System.EventHandler(this.EqualityButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(208, 164);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 47);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "<<";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 428);
            this.Controls.Add(this.equalityButton);
            this.Controls.Add(this.commaButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cleanAllButton);
            this.Controls.Add(this.fractionButton);
            this.Controls.Add(this.squaringButton);
            this.Controls.Add(this.squareRootButton);
            this.Controls.Add(this.changeSignButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.cleanEntireButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.operationsQueueLabel);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label operationsQueueLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button cleanEntireButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button changeSignButton;
        private System.Windows.Forms.Button squareRootButton;
        private System.Windows.Forms.Button squaringButton;
        private System.Windows.Forms.Button fractionButton;
        private System.Windows.Forms.Button cleanAllButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.Button equalityButton;
    }
}

