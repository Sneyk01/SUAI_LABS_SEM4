
namespace lab2_main
{
    partial class Form2
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
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.radioManual = new System.Windows.Forms.RadioButton();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.numA = new System.Windows.Forms.TextBox();
            this.numB = new System.Windows.Forms.TextBox();
            this.numK = new System.Windows.Forms.TextBox();
            this.numK1 = new System.Windows.Forms.TextBox();
            this.numK2 = new System.Windows.Forms.TextBox();
            this.arrayLen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrayLen)).BeginInit();
            this.SuspendLayout();
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Checked = true;
            this.radioRandom.Location = new System.Drawing.Point(635, 29);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(146, 21);
            this.radioRandom.TabIndex = 0;
            this.radioRandom.TabStop = true;
            this.radioRandom.Text = "Случайные числа";
            this.radioRandom.UseVisualStyleBackColor = true;
            this.radioRandom.Click += new System.EventHandler(this.radioRandom_Click);
            // 
            // radioManual
            // 
            this.radioManual.AutoSize = true;
            this.radioManual.Location = new System.Drawing.Point(635, 56);
            this.radioManual.Name = "radioManual";
            this.radioManual.Size = new System.Drawing.Size(86, 21);
            this.radioManual.TabIndex = 1;
            this.radioManual.Text = "Вручную";
            this.radioManual.UseVisualStyleBackColor = true;
            this.radioManual.Click += new System.EventHandler(this.radioManual_Click);
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Location = new System.Drawing.Point(635, 83);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(143, 21);
            this.radioTime.TabIndex = 2;
            this.radioTime.Text = "Авто обновление";
            this.radioTime.UseVisualStyleBackColor = true;
            this.radioTime.CheckedChanged += new System.EventHandler(this.radioTime_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Способ ввода массива";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 107);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Длина массива";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(714, 261);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // numA
            // 
            this.numA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numA.Location = new System.Drawing.Point(39, 235);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(78, 22);
            this.numA.TabIndex = 9;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(39, 267);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(78, 22);
            this.numB.TabIndex = 10;
            // 
            // numK
            // 
            this.numK.Location = new System.Drawing.Point(168, 235);
            this.numK.Name = "numK";
            this.numK.Size = new System.Drawing.Size(78, 22);
            this.numK.TabIndex = 11;
            // 
            // numK1
            // 
            this.numK1.Location = new System.Drawing.Point(300, 235);
            this.numK1.Name = "numK1";
            this.numK1.Size = new System.Drawing.Size(78, 22);
            this.numK1.TabIndex = 12;
            // 
            // numK2
            // 
            this.numK2.Location = new System.Drawing.Point(300, 263);
            this.numK2.Name = "numK2";
            this.numK2.Size = new System.Drawing.Size(78, 22);
            this.numK2.TabIndex = 13;
            // 
            // arrayLen
            // 
            this.arrayLen.Location = new System.Drawing.Point(15, 29);
            this.arrayLen.Name = "arrayLen";
            this.arrayLen.Size = new System.Drawing.Size(120, 22);
            this.arrayLen.TabIndex = 14;
            this.arrayLen.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.arrayLen.ValueChanged += new System.EventHandler(this.arrayLen_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "K:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "K1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "K2:";
            // 
            // errorLable
            // 
            this.errorLable.ForeColor = System.Drawing.Color.Red;
            this.errorLable.Location = new System.Drawing.Point(384, 235);
            this.errorLable.Name = "errorLable";
            this.errorLable.Size = new System.Drawing.Size(324, 49);
            this.errorLable.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.errorLable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrayLen);
            this.Controls.Add(this.numK2);
            this.Controls.Add(this.numK1);
            this.Controls.Add(this.numK);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioTime);
            this.Controls.Add(this.radioManual);
            this.Controls.Add(this.radioRandom);
            this.Name = "Form2";
            this.Text = "Лабораторная работа №2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrayLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.RadioButton radioManual;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.TextBox numA;
        public System.Windows.Forms.TextBox numB;
        public System.Windows.Forms.TextBox numK;
        public System.Windows.Forms.TextBox numK1;
        public System.Windows.Forms.TextBox numK2;
        private System.Windows.Forms.NumericUpDown arrayLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label errorLable;
    }
}