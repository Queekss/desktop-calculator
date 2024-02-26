namespace FinalCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            resultBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonOpenBracket = new Button();
            buttonCloseBracket = new Button();
            buttonEquals = new Button();
            button10 = new Button();
            buttonAdd = new Button();
            buttonDivide = new Button();
            button11 = new Button();
            buttonPercent = new Button();
            buttonSqrt = new Button();
            buttonPower = new Button();
            buttonUndo = new Button();
            buttonClear = new Button();
            buttonSave = new Button();
            buttonRetrieve = new Button();
            buttonDecimal = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.Font = new Font("Segoe UI", 13F);
            resultBox.Location = new Point(28, 34);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(584, 98);
            resultBox.TabIndex = 0;
            resultBox.KeyPress += resultBox_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(28, 251);
            button1.Name = "button1";
            button1.Size = new Size(112, 96);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(146, 251);
            button2.Name = "button2";
            button2.Size = new Size(112, 96);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(264, 251);
            button3.Name = "button3";
            button3.Size = new Size(112, 96);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(28, 353);
            button4.Name = "button4";
            button4.Size = new Size(112, 96);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(146, 353);
            button5.Name = "button5";
            button5.Size = new Size(112, 96);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F);
            button6.Location = new Point(264, 353);
            button6.Name = "button6";
            button6.Size = new Size(112, 96);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F);
            button7.Location = new Point(28, 455);
            button7.Name = "button7";
            button7.Size = new Size(112, 96);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15F);
            button8.Location = new Point(146, 455);
            button8.Name = "button8";
            button8.Size = new Size(112, 96);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15F);
            button9.Location = new Point(264, 455);
            button9.Name = "button9";
            button9.Size = new Size(112, 96);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15F);
            button0.Location = new Point(382, 455);
            button0.Name = "button0";
            button0.Size = new Size(112, 96);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button1_Click;
            // 
            // buttonOpenBracket
            // 
            buttonOpenBracket.Font = new Font("Segoe UI", 15F);
            buttonOpenBracket.Location = new Point(28, 149);
            buttonOpenBracket.Name = "buttonOpenBracket";
            buttonOpenBracket.Size = new Size(112, 96);
            buttonOpenBracket.TabIndex = 11;
            buttonOpenBracket.Text = "(";
            buttonOpenBracket.UseVisualStyleBackColor = true;
            buttonOpenBracket.Click += button1_Click;
            // 
            // buttonCloseBracket
            // 
            buttonCloseBracket.Font = new Font("Segoe UI", 15F);
            buttonCloseBracket.Location = new Point(146, 149);
            buttonCloseBracket.Name = "buttonCloseBracket";
            buttonCloseBracket.Size = new Size(112, 96);
            buttonCloseBracket.TabIndex = 12;
            buttonCloseBracket.Text = ")";
            buttonCloseBracket.UseVisualStyleBackColor = true;
            buttonCloseBracket.Click += button1_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Segoe UI", 15F);
            buttonEquals.Location = new Point(500, 557);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(112, 96);
            buttonEquals.TabIndex = 13;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 15F);
            button10.Location = new Point(500, 353);
            button10.Name = "button10";
            button10.Size = new Size(112, 96);
            button10.TabIndex = 14;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 15F);
            buttonAdd.Location = new Point(382, 353);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 96);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 15F);
            buttonDivide.Location = new Point(382, 251);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(112, 96);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += button1_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 15F);
            button11.Location = new Point(382, 149);
            button11.Name = "button11";
            button11.Size = new Size(112, 96);
            button11.TabIndex = 17;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button1_Click;
            // 
            // buttonPercent
            // 
            buttonPercent.Font = new Font("Segoe UI", 15F);
            buttonPercent.Location = new Point(264, 149);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(112, 96);
            buttonPercent.TabIndex = 18;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += buttonPercent_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Font = new Font("Segoe UI", 15F);
            buttonSqrt.Location = new Point(500, 455);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(112, 96);
            buttonSqrt.TabIndex = 19;
            buttonSqrt.Text = "√";
            buttonSqrt.UseVisualStyleBackColor = true;
            buttonSqrt.Click += buttonPercent_Click;
            // 
            // buttonPower
            // 
            buttonPower.Font = new Font("Segoe UI", 15F);
            buttonPower.Location = new Point(382, 557);
            buttonPower.Name = "buttonPower";
            buttonPower.Size = new Size(112, 96);
            buttonPower.TabIndex = 20;
            buttonPower.Text = "^";
            buttonPower.UseVisualStyleBackColor = true;
            buttonPower.Click += button1_Click;
            // 
            // buttonUndo
            // 
            buttonUndo.Font = new Font("Segoe UI", 15F);
            buttonUndo.Location = new Point(500, 251);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(112, 96);
            buttonUndo.TabIndex = 21;
            buttonUndo.Text = "C";
            buttonUndo.UseVisualStyleBackColor = true;
            buttonUndo.Click += buttonClear_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 15F);
            buttonClear.Location = new Point(500, 149);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 96);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "CE";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 11F);
            buttonSave.Location = new Point(28, 557);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 96);
            buttonSave.TabIndex = 23;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonRetrieve
            // 
            buttonRetrieve.Font = new Font("Segoe UI", 11F);
            buttonRetrieve.Location = new Point(146, 557);
            buttonRetrieve.Name = "buttonRetrieve";
            buttonRetrieve.Size = new Size(112, 96);
            buttonRetrieve.TabIndex = 24;
            buttonRetrieve.Text = "RETRIEVE";
            toolTip1.SetToolTip(buttonRetrieve, "Enter your equation in the text box, and press RETRIEVE to check it exists");
            buttonRetrieve.UseVisualStyleBackColor = true;
            buttonRetrieve.Click += buttonRetrieve_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Segoe UI", 15F);
            buttonDecimal.Location = new Point(264, 557);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(112, 96);
            buttonDecimal.TabIndex = 25;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += button1_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 100;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 674);
            Controls.Add(buttonDecimal);
            Controls.Add(buttonRetrieve);
            Controls.Add(buttonSave);
            Controls.Add(buttonClear);
            Controls.Add(buttonUndo);
            Controls.Add(buttonPower);
            Controls.Add(buttonSqrt);
            Controls.Add(buttonPercent);
            Controls.Add(button11);
            Controls.Add(buttonDivide);
            Controls.Add(buttonAdd);
            Controls.Add(button10);
            Controls.Add(buttonEquals);
            Controls.Add(buttonCloseBracket);
            Controls.Add(buttonOpenBracket);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(resultBox);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonOpenBracket;
        private Button buttonCloseBracket;
        private Button buttonEquals;
        private Button button10;
        private Button buttonAdd;
        private Button buttonDivide;
        private Button button11;
        private Button buttonPercent;
        private Button buttonSqrt;
        private Button buttonPower;
        private Button buttonUndo;
        private Button buttonClear;
        private Button buttonSave;
        private Button buttonRetrieve;
        private Button buttonDecimal;
        private ToolTip toolTip1;
    }
}
