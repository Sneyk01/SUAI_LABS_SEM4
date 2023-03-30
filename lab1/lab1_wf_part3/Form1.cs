using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_wf_part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string answer = "a^2 * b = c \r\n";

                for (int a = 1; a < 21; a++)
                {
                    if (a * a > 20)
                        break;

                    for (int b = 1; b < 21; b++)
                    {
                        if (a * a * b > 20)
                            break;

                        if (a * a * b > 0 && a * a * b < 21)
                            answer += $"{a}^2 * {b} = {a*a*b} \r\n";
                    }
                }

            answerBox.Text = answer;
        }
    }
}
