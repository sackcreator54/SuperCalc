using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int currentLine = 0;

        private void clear_Click(object sender, EventArgs e)
        {
            this.input.Clear();
            this.output.Clear();
        }

        private void negative_Click(object sender, EventArgs e)
        {

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            string _line = this.input.Lines[currentLine];
            _line.Substring(0, _line.Length - 1);
            this.input.Lines[currentLine] = _line;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            this.input.AppendText("/");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.input.AppendText("9");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.input.AppendText("8");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.input.AppendText("7");
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.input.AppendText("4");
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.input.AppendText("1");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.input.AppendText("0");
        }

        private void deci_Click(object sender, EventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {
            this.input.AppendText("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.input.AppendText("3");
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.input.AppendText("6");
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.input.AppendText("5");
        }

        private void enter_Click(object sender, EventArgs e)
        {
            Regex splitRegex = new Regex(@"([+/*-])");
            string[] matches = splitRegex.Split(this.input.Lines[currentLine]);
            float _output = 0;
            switch (matches[1]) {
                case "+":
                    _output = Convert.ToSingle(matches[0]) + Convert.ToSingle(matches[2]);
                    break;
                case "-":
                    _output = Convert.ToSingle(matches[0]) - Convert.ToSingle(matches[2]);
                    break;
                case "*":
                    _output = Convert.ToSingle(matches[0]) * Convert.ToSingle(matches[2]);
                    break;
                case "/":
                    _output = Convert.ToSingle(matches[0]) / Convert.ToSingle(matches[2]);
                    break;

            }
            this.output.AppendText(_output.ToString());
            this.output.AppendText(Environment.NewLine);
            this.input.AppendText(Environment.NewLine);
            currentLine++;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            this.input.AppendText("+");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.input.AppendText("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            this.input.AppendText("*");
        }
    }
}
