using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_wf_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string num = numBox.Text;

            if (num == "")
            {
                answerLable.ForeColor = System.Drawing.Color.Red;
                answerLable.Text = "Введите натуральное число";
                return;
            }

            foreach (char s in num)
            {
                if (!char.IsNumber(s))
                {
                    answerLable.ForeColor = System.Drawing.Color.Red;
                    answerLable.Text = "Некорректное число";
                    return;
                }
            }

            string k = kBox.Text;

            if (k == "")
            {
                answerLable.ForeColor = System.Drawing.Color.Red;
                answerLable.Text = "Введите число K";
                return;
            }

            if (!(k[0] == '-' || char.IsNumber(k[0])))
            {
                answerLable.ForeColor = System.Drawing.Color.Red;
                answerLable.Text = "Некорректное число";
                return;
            }

            for (int i = 1; i < k.Length; i++)
            {
                if (!char.IsNumber(k[i]))
                {
                    answerLable.ForeColor = System.Drawing.Color.Red;
                    answerLable.Text = "Некорректное число";
                    return;
                }
            }

            int count = 1;
            int num1 = Int32.Parse(num);
            int num2 = Int32.Parse(k);

            for (int i = (num2+1); i < num1; i++)
            {
                if (i != 0) 
                    if ((num1 % i) == 0)
                        count++;
            }

            answerLable.ForeColor = System.Drawing.Color.Green;
            answerLable.Text = count.ToString();
        }
    }
}
