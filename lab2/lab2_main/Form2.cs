using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_main
{
    public partial class Form2 : Form
    {
        Form1 formLink;

        int[] array = new int[20];
        int arr_len = 20;

        int manual_input = 0;

        Random rnd = new Random();
        Timer timer;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            formLink = f;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            update_len();

            if (manual_input == 1)
            {
                try
                {
                    manual_input_array(ref array, arr_len, ref dataGridView1);
                }
                catch(Exception ex)
                {
                    printErData(ref formLink.debugBox, ex);
                    errorLable.Text = $"Некорректные данные массива";
                    return;
                }
            }

            int a = 0, b = 0, k = 0, k1 = 0, k2 = 0;

            try
            {
                a = Int32.Parse(numA.Text);
            }
            catch (FormatException ex)
            {
                printErData(ref formLink.debugBox, ex);
                errorLable.Text = $"Некорректное значение A";
                return;
            }
            catch (Exception ex)
            {

                printErData(ref formLink.debugBox, ex);
                errorLable.Text =  $"A: {ex.Message}";
                return;
            }

            try
            {
                b = Int32.Parse(numB.Text);

                if (a > b)
                    throw new Exception("A не может быть больше B");
            }
            catch (FormatException ex)
            {
                printErData(ref formLink.debugBox, ex);
                errorLable.Text = $"Некорректное значение B";
                return;
            }
            catch (Exception ex)
            {

                printErData(ref formLink.debugBox, ex);
                errorLable.Text = $"B: {ex.Message}";
                return;
            }
                    
            try
            {
                k = Int32.Parse(numK.Text);
                
            }
            catch (FormatException ex)
            {
                printErData(ref formLink.debugBox, ex);
                errorLable.Text = $"Некорректное значение K";
                return;
            }
            catch (Exception ex)
            {
                printErData(ref formLink.debugBox, ex);
                errorLable.Text = $"{ex.Message}";
                return;
            }

            for (int i = 0; i < arr_len; i++)   // Первое задание
                if (i < array.Length && array[i] >= a && array[i] <= b && array[i] % 7 == 0)
                    delete_arr(ref array, i);

            arr_len = array.Length;

            try
            {
                k1 = Int32.Parse(numK1.Text);
                k2 = Int32.Parse(numK2.Text);

                if (k1 > arr_len || k1 < 0 || k2 > arr_len || k2 < k1)
                    throw new Exception("k1/k2 за пределами массива");

                for (int i = 0; i < arr_len; i++)   // Третье задание
                    if (i >= k1 && i <= k1 + (k2 - k1) / 2 && k2 < arr_len)
                        swap(ref array[i], ref array[k2 - (i - k1)]);

                errorLable.Text = "";
            }
            catch (FormatException ex)
            {
                printErData(ref formLink.debugBox, ex);
                errorLable.Text = $"Некорректное значение k1/k2 \r\nПерестановка выполняться не будет";
            }
            catch (Exception ex)
            {
                printErData(ref formLink.debugBox, ex);
                errorLable.Text = $"{ex.Message} \r\nПерестановка выполнятся не будет";
            }
            

            int ir = 1;

            while (ir < array.Length) // Второе задание
            {
                if ((array[ir] >= 0 && array[ir - 1] >= 0) || (array[ir] < 0 && array[ir - 1] < 0))
                    addNum(ir++, k, ref array);  // ir++ чтобы не было бесконечного цикла

                ir++;
            }

            printArray(ref array, ref dataGridView1, 1);

        }


        void addNum(int index, int num, ref int[] array)
        {
            int len = array.Length;
            Array.Resize<int>(ref array, len + 1);
            
            for (int i = len; i > index; i--)
                array[i] = array[i - 1];

            array[index] = num;

            //return newArray; // А можно выделить массив и вернуть ссылку на него, чтобы не тратить лишнюю память?
        }


        void swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }


        void printArray(ref int[] array, ref DataGridView field, int row = 0)
        {
            int len = array.Length;
            
            while (field.ColumnCount < len)
                field.Columns.Add($"col_{field.ColumnCount}", $"{field.ColumnCount}");

            for (int i = 0; i < len; i++)
                field.Rows[row].Cells[i].Value = array[i];

        }

       
        void update_len()
        {
            try
            {
                arr_len = Convert.ToInt32(arrayLen.Value);
            }
            catch
            {
                formLink.debugBox.Text += $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}: Lab2 error parse arr len \r\n";
                arr_len = 20;
            }
        }


        void create_grid(ref DataGridView dataGrid1, int len = 20)
        {
            dataGrid1.Columns.Clear();
            for (int i = 0; i < len; i++)
                dataGrid1.Columns.Add($"col_{i}", $"{i}");

            if (dataGrid1.ColumnCount > 0)
            {
                dataGrid1.Rows.Add();

                dataGrid1.Rows[0].HeaderCell.Value = "Исходный массив";
                dataGrid1.Rows[1].HeaderCell.Value = "Новый массив";
            }
        }


        void gen_rand_array(ref int[] num_array, int len)
        {
            num_array = new int[len];
            for (int i = 0; i < len; i++)
                array[i] = rnd.Next(-45, 95);
        }


        private void radioRandom_Click(object sender, EventArgs e)
        {
            if (radioRandom.Checked)
            {
                update_len();
                create_grid(ref dataGridView1, arr_len);
                gen_rand_array(ref array, arr_len);
                printArray(ref array, ref dataGridView1);
                dataGridView1.ReadOnly = true;
                manual_input = 0;
            }
        }


        private void radioManual_Click(object sender, EventArgs e)
        {
            update_len();
            create_grid(ref dataGridView1, arr_len);
            dataGridView1.ReadOnly = false;
            manual_input = 1;

            Array.Resize<int>(ref array, arr_len);
            //array = new int[arr_len];
            printArray(ref array, ref dataGridView1);

        }

        private void radioTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTime.Checked)
            {
                timer = new Timer() { Interval = 5000 };
                timer.Tick += update_array;
                timer.Start();
            }
            else
                timer.Stop();
        }


        void manual_input_array(ref int[] manual_array, int len, ref DataGridView dataGrid)
        {
            manual_array = new int[len];
            for (int i = 0; i < len; i++)
                if (Convert.ToString(dataGrid.Rows[0].Cells[i].Value) != "")
                    manual_array[i] = Convert.ToInt32(dataGrid.Rows[0].Cells[i].Value);
                else
                    throw new Exception("В массиве не должно быть пустых ячеек");
            
        }


        private void arrayLen_ValueChanged(object sender, EventArgs e)
        {
            update_len();
            create_grid(ref dataGridView1, arr_len);
            while (array.Length > arr_len)
                delete_arr(ref array, array.Length - 1);

            while (array.Length < arr_len)
                if (manual_input == 0)
                    addNum(array.Length, rnd.Next(-45, 95), ref array);
                else
                    addNum(array.Length, 0, ref array);

            printArray(ref array, ref dataGridView1);

        }


        void delete_arr(ref int[] old_array, int index)
        {
            int[] temp = new int[old_array.Length];
            Array.Copy(old_array, temp, old_array.Length);

            Array.Resize<int>(ref old_array, old_array.Length - 1);

            int j = 0;
            //MessageBox.Show($"New len {old_array.Length}");
            for (int i = 0; i < old_array.Length; i++)
            {
                if (i == index)
                    j++;
                
                old_array[i] = temp[j];


                j++;
            }
        }


        void update_array(object sender, EventArgs e)
        {
            create_grid(ref dataGridView1, arr_len);
            gen_rand_array(ref array, arr_len);
            printArray(ref array, ref dataGridView1);
        }


        void printErData(ref TextBox box, Exception ex)
        {
            box.Text += $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} Lab2: {ex.InnerException}\r\n{ex.Message}\r\n{ex.Source}\r\n{ex.StackTrace}\r\n{ex.TargetSite}\r\n";
        }
    }

}
