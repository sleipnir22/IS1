namespace IS1
{
    partial class MainApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ramBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diagonalBox = new System.Windows.Forms.ComboBox();
            this.cpuBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.driveBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.batteryBox = new System.Windows.Forms.ComboBox();
            this.cameraTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подобрать рекомендацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(218, 42);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(170, 22);
            this.priceTextBox.TabIndex = 1;
            this.priceTextBox.Text = "0";
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Желаемый бюджет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Энергоёмкость батареи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оперативная память:";
            // 
            // ramBox
            // 
            this.ramBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ramBox.FormattingEnabled = true;
            this.ramBox.Items.AddRange(new object[] {
            "Не имеет значения",
            "2",
            "3",
            "4",
            "6",
            "8",
            "16"});
            this.ramBox.Location = new System.Drawing.Point(218, 139);
            this.ramBox.Name = "ramBox";
            this.ramBox.Size = new System.Drawing.Size(170, 24);
            this.ramBox.TabIndex = 6;
            this.ramBox.SelectedIndexChanged += new System.EventHandler(this.ramBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Диагональ дисплея:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Рейтинг процессора:";
            // 
            // diagonalBox
            // 
            this.diagonalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diagonalBox.FormattingEnabled = true;
            this.diagonalBox.Items.AddRange(new object[] {
            "Не имеет значения"});
            this.diagonalBox.Location = new System.Drawing.Point(218, 188);
            this.diagonalBox.Name = "diagonalBox";
            this.diagonalBox.Size = new System.Drawing.Size(170, 24);
            this.diagonalBox.TabIndex = 9;
            this.diagonalBox.SelectedIndexChanged += new System.EventHandler(this.diagonalBox_SelectedIndexChanged);
            // 
            // cpuBox
            // 
            this.cpuBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpuBox.FormattingEnabled = true;
            this.cpuBox.Items.AddRange(new object[] {
            "Не имеет значения",
            "A+",
            "B",
            "C",
            "D",
            "F"});
            this.cpuBox.Location = new System.Drawing.Point(627, 83);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(170, 24);
            this.cpuBox.TabIndex = 10;
            this.cpuBox.SelectedIndexChanged += new System.EventHandler(this.cpuBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Объем памяти:";
            // 
            // driveBox
            // 
            this.driveBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveBox.FormattingEnabled = true;
            this.driveBox.Items.AddRange(new object[] {
            "Не имеет значения",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512"});
            this.driveBox.Location = new System.Drawing.Point(627, 134);
            this.driveBox.Name = "driveBox";
            this.driveBox.Size = new System.Drawing.Size(170, 24);
            this.driveBox.TabIndex = 13;
            this.driveBox.SelectedIndexChanged += new System.EventHandler(this.driveBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Камера";
            // 
            // batteryBox
            // 
            this.batteryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.batteryBox.FormattingEnabled = true;
            this.batteryBox.Items.AddRange(new object[] {
            "Не имеет значения",
            "2000-2500",
            "2500-3000",
            "3000-3500",
            "3500-4000",
            "4000-4500",
            "4500-5000",
            "5000-5500"});
            this.batteryBox.Location = new System.Drawing.Point(218, 85);
            this.batteryBox.Name = "batteryBox";
            this.batteryBox.Size = new System.Drawing.Size(170, 24);
            this.batteryBox.TabIndex = 17;
            this.batteryBox.SelectedIndexChanged += new System.EventHandler(this.batteryBox_SelectedIndexChanged);
            // 
            // cameraTextBox
            // 
            this.cameraTextBox.Location = new System.Drawing.Point(627, 188);
            this.cameraTextBox.Name = "cameraTextBox";
            this.cameraTextBox.Size = new System.Drawing.Size(170, 22);
            this.cameraTextBox.TabIndex = 18;
            this.cameraTextBox.Text = "0";
            this.cameraTextBox.TextChanged += new System.EventHandler(this.cameraTextBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(466, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(206, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Камера не имеет значения";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 453);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cameraTextBox);
            this.Controls.Add(this.batteryBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.driveBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cpuBox);
            this.Controls.Add(this.diagonalBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ramBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Экспертная система";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ramBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox diagonalBox;
        private System.Windows.Forms.ComboBox cpuBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox driveBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox batteryBox;
        private System.Windows.Forms.TextBox cameraTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

