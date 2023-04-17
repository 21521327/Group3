using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap2_21521327_GiaQUan
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        static double Evaluate(string expression)
        {
            Stack<char> operators = new Stack<char>();
            Stack<double> operands = new Stack<double>();
            double operand = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (ch == '(')
                {
                    operators.Push(ch);
                }
                else if (ch == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        Calculate(operators, operands);
                    }
                    operators.Pop();
                }
                else if (IsOperator(ch))
                {
                    while (operators.Count > 0 && Priority(operators.Peek()) >= Priority(ch))
                    {
                        Calculate(operators, operands);
                    }
                    operators.Push(ch);
                }
                else if (char.IsDigit(ch))
                {
                    operand = (operand * 10) + (ch - '0');

                    if (i + 1 == expression.Length || !char.IsDigit(expression[i + 1]))
                    {
                        operands.Push(operand);
                        operand = 0;
                    }
                }
            }

            while (operators.Count > 0)
            {
                Calculate(operators, operands);
            }

            return operands.Pop();
        }

        static void Calculate(Stack<char> operators, Stack<double> operands)
        {
            char op = operators.Pop();
            double b = operands.Pop();
            double a = operands.Pop();
            double result;

            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    throw new InvalidOperationException("Phép tính không hợp lệ.");
            }

            operands.Push(result);
        }

        static int Priority(char op)
        {
            switch (op)
            {
                case '(':
                case ')':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    throw new InvalidOperationException("Phép tính không hợp lệ.");
            }
        }

        static bool IsOperator(char ch)
        {
            return ch == '+' || ch == '-' || ch == '*' || ch == '/';
        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            rtb_keuqua.Text = " ";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fs);
            string str = read.ReadToEnd();
            string[] strings = str.Split('\n');

            for (int i = 0; i < strings.Length; i++)
            {
                double result = Evaluate(strings[i]);
                rtb_keuqua.AppendText(strings[i] + " = " + result.ToString());

                rtb_keuqua.Text += "\n";
            }
            fs.Flush();
            fs.Close();
        }
    }
}
