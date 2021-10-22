
namespace TelepadGuru
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lab = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.processList = new System.Windows.Forms.ComboBox();
            this.refreshProcessList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iy = new System.Windows.Forms.TextBox();
            this.ix = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.d2yBox = new System.Windows.Forms.TextBox();
            this.d2xBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dyBox = new System.Windows.Forms.TextBox();
            this.dxBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ryb = new System.Windows.Forms.TextBox();
            this.rxb = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.setPow = new System.Windows.Forms.ComboBox();
            this.setElev = new System.Windows.Forms.TextBox();
            this.offElevation = new System.Windows.Forms.Label();
            this.setBear = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.offBearing = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.offPower = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.processList);
            this.groupBox1.Controls.Add(this.refreshProcessList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Процесс игры";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Калибровка (0 45 30), (0 50 30)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(141, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Отк-ть воронку";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(6, 99);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(43, 15);
            this.lab.TabIndex = 6;
            this.lab.Text = "Статус";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Процесс и порт игры для внесения данных";
            // 
            // processList
            // 
            this.processList.FormattingEnabled = true;
            this.processList.Location = new System.Drawing.Point(6, 22);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(78, 23);
            this.processList.TabIndex = 1;
            // 
            // refreshProcessList
            // 
            this.refreshProcessList.Location = new System.Drawing.Point(177, 21);
            this.refreshProcessList.Name = "refreshProcessList";
            this.refreshProcessList.Size = new System.Drawing.Size(75, 23);
            this.refreshProcessList.TabIndex = 0;
            this.refreshProcessList.Text = "Обновить";
            this.refreshProcessList.UseVisualStyleBackColor = true;
            this.refreshProcessList.Click += new System.EventHandler(this.refreshProcessList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кнопки управления";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Открыть воронку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вычислить настройки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вычислить смещение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.iy);
            this.groupBox3.Controls.Add(this.ix);
            this.groupBox3.Location = new System.Drawing.Point(12, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Координаты телепада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // iy
            // 
            this.iy.Location = new System.Drawing.Point(152, 22);
            this.iy.Name = "iy";
            this.iy.Size = new System.Drawing.Size(100, 23);
            this.iy.TabIndex = 1;
            this.iy.Text = "133";
            // 
            // ix
            // 
            this.ix.Location = new System.Drawing.Point(26, 22);
            this.ix.Name = "ix";
            this.ix.Size = new System.Drawing.Size(100, 23);
            this.ix.TabIndex = 0;
            this.ix.Text = "170";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.d2yBox);
            this.groupBox4.Controls.Add(this.d2xBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dyBox);
            this.groupBox4.Controls.Add(this.dxBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Для расчета смещения";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(152, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Рассчитать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Рассчитать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "X2";
            // 
            // d2yBox
            // 
            this.d2yBox.Location = new System.Drawing.Point(96, 51);
            this.d2yBox.Name = "d2yBox";
            this.d2yBox.Size = new System.Drawing.Size(44, 23);
            this.d2yBox.TabIndex = 5;
            this.d2yBox.Text = "0";
            // 
            // d2xBox
            // 
            this.d2xBox.Location = new System.Drawing.Point(26, 51);
            this.d2xBox.Name = "d2xBox";
            this.d2xBox.Size = new System.Drawing.Size(44, 23);
            this.d2xBox.TabIndex = 4;
            this.d2xBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "X1";
            // 
            // dyBox
            // 
            this.dyBox.Location = new System.Drawing.Point(96, 22);
            this.dyBox.Name = "dyBox";
            this.dyBox.Size = new System.Drawing.Size(44, 23);
            this.dyBox.TabIndex = 1;
            this.dyBox.Text = "0";
            // 
            // dxBox
            // 
            this.dxBox.Location = new System.Drawing.Point(26, 22);
            this.dxBox.Name = "dxBox";
            this.dxBox.Size = new System.Drawing.Size(44, 23);
            this.dxBox.TabIndex = 0;
            this.dxBox.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.ryb);
            this.groupBox5.Controls.Add(this.rxb);
            this.groupBox5.Location = new System.Drawing.Point(12, 211);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(268, 62);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Координаты GPS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "X";
            // 
            // ryb
            // 
            this.ryb.Location = new System.Drawing.Point(152, 22);
            this.ryb.Name = "ryb";
            this.ryb.Size = new System.Drawing.Size(100, 23);
            this.ryb.TabIndex = 1;
            this.ryb.Text = "0";
            // 
            // rxb
            // 
            this.rxb.Location = new System.Drawing.Point(26, 22);
            this.rxb.Name = "rxb";
            this.rxb.Size = new System.Drawing.Size(100, 23);
            this.rxb.TabIndex = 0;
            this.rxb.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.setPow);
            this.groupBox6.Controls.Add(this.setElev);
            this.groupBox6.Controls.Add(this.offElevation);
            this.groupBox6.Controls.Add(this.setBear);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.offBearing);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.offPower);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(286, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(196, 122);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Результаты";
            // 
            // setPow
            // 
            this.setPow.FormattingEnabled = true;
            this.setPow.Location = new System.Drawing.Point(73, 25);
            this.setPow.Name = "setPow";
            this.setPow.Size = new System.Drawing.Size(69, 23);
            this.setPow.TabIndex = 6;
            // 
            // setElev
            // 
            this.setElev.Location = new System.Drawing.Point(73, 87);
            this.setElev.Name = "setElev";
            this.setElev.Size = new System.Drawing.Size(69, 23);
            this.setElev.TabIndex = 5;
            // 
            // offElevation
            // 
            this.offElevation.AutoSize = true;
            this.offElevation.Location = new System.Drawing.Point(169, 90);
            this.offElevation.Name = "offElevation";
            this.offElevation.Size = new System.Drawing.Size(13, 15);
            this.offElevation.TabIndex = 2;
            this.offElevation.Text = "0";
            // 
            // setBear
            // 
            this.setBear.Location = new System.Drawing.Point(73, 57);
            this.setBear.Name = "setBear";
            this.setBear.Size = new System.Drawing.Size(69, 23);
            this.setBear.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Смещение";
            // 
            // offBearing
            // 
            this.offBearing.AutoSize = true;
            this.offBearing.Location = new System.Drawing.Point(169, 60);
            this.offBearing.Name = "offBearing";
            this.offBearing.Size = new System.Drawing.Size(13, 15);
            this.offBearing.TabIndex = 1;
            this.offBearing.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Elevation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bearing";
            // 
            // offPower
            // 
            this.offPower.AutoSize = true;
            this.offPower.Location = new System.Drawing.Point(169, 28);
            this.offPower.Name = "offPower";
            this.offPower.Size = new System.Drawing.Size(13, 15);
            this.offPower.TabIndex = 0;
            this.offPower.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Power";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.comboBox2);
            this.groupBox7.Location = new System.Drawing.Point(286, 279);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(196, 92);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Координаты";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 51);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Открыть";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(99, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Обновить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 23);
            this.comboBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 374);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TelepadGuru";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox processList;
        private System.Windows.Forms.Button refreshProcessList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iy;
        private System.Windows.Forms.TextBox ix;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox d2yBox;
        private System.Windows.Forms.TextBox d2xBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dyBox;
        private System.Windows.Forms.TextBox dxBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ryb;
        private System.Windows.Forms.TextBox rxb;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox setElev;
        private System.Windows.Forms.TextBox setBear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label offPower;
        private System.Windows.Forms.Label offBearing;
        private System.Windows.Forms.Label offElevation;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox setPow;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button7;
    }
}

