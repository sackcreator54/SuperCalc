namespace SuperCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zero = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 365);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(112, 41);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // deci
            // 
            this.deci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deci.Location = new System.Drawing.Point(130, 365);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(70, 41);
            this.deci.TabIndex = 1;
            this.deci.Text = ".";
            this.deci.UseVisualStyleBackColor = true;
            this.deci.Click += new System.EventHandler(this.deci_Click);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(211, 295);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(60, 111);
            this.enter.TabIndex = 2;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(14, 295);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(58, 64);
            this.one.TabIndex = 4;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(78, 295);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(58, 64);
            this.two.TabIndex = 5;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(142, 295);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(58, 64);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(142, 225);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(58, 64);
            this.six.TabIndex = 9;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(78, 225);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(58, 64);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(14, 225);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(58, 64);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(142, 159);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(58, 60);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(78, 159);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(58, 60);
            this.eight.TabIndex = 11;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(14, 159);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(58, 60);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(211, 193);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 28);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(211, 261);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 28);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(211, 227);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 28);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.divide.Location = new System.Drawing.Point(211, 159);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 28);
            this.divide.TabIndex = 18;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 28);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ReadOnly = true;
            this.input.Size = new System.Drawing.Size(122, 92);
            this.input.TabIndex = 19;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(142, 126);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(129, 27);
            this.clear.TabIndex = 20;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(78, 126);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(58, 27);
            this.negative.TabIndex = 22;
            this.negative.Text = "±";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(14, 126);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(58, 27);
            this.backspace.TabIndex = 23;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(150, 28);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(122, 92);
            this.output.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Output";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(134, 28);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 92);
            this.vScrollBar1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 418);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.input);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.zero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

