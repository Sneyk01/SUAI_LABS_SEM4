using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            if (name == "")
            {
                answerLable.ForeColor = System.Drawing.Color.Red;
                answerLable.Text = "Введите имя";
                return;
            }

            if (!check_field(name))
                return;


            string lastname = lastnameBox.Text;
            if (lastname == "")
            {
                answerLable.ForeColor = System.Drawing.Color.Red;
                answerLable.Text = "Введите фамилию";
                return;
            }


            if (!check_field(lastname))
                return;


            string name3 = textBox1.Text;
            if (name3 == "")
            {
                answerLable.ForeColor = System.Drawing.Color.Red;
                answerLable.Text = "Введите отчество";
                return;
            }


            if (!check_field(name3))
                return;

            string answer = "";
            string temp = lastname;
            int len = name.Length;
            if (lastname.Length < len)
            {
                len = lastname.Length;
                temp = name;
            }

            for (int i = 0; i < len; i++)
                answer += (char)((short)name[i] + (short)lastname[i]);

            for (int i = len; i < temp.Length; i++)
                answer += temp[i];


            name = ""; //fast

            len = answer.Length;
            temp = name3;
            if (answer.Length > name3.Length)
            {
                len = name3.Length;
                temp = answer;
            }

            for (int i = 0; i < len; i++)
                name += (char)((short)name3[i] + (short)answer[i]);

            for (int i = len; i < temp.Length; i++)
                name += temp[i];

            answerLable.ForeColor = System.Drawing.Color.Black;
            answerLable.Text = name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            answerLable.Text = "Введите данные";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private bool check_field(string str)
        {
            foreach (char s in str)
                if (!char.IsLetter(s))
                {
                    answerLable.ForeColor = System.Drawing.Color.Red;
                    answerLable.Text = "Некорректные данные";
                    return false;
                }

            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
