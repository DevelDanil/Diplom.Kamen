using System.Windows.Forms;
using System.Drawing;

namespace Diplom
{
    partial class Form8
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox9 = new TextBox();
            label11 = new Label();
            button4 = new Button();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox3 = new ComboBox();
            label13 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            textBox10 = new TextBox();
            label12 = new Label();
            label14 = new Label();
            textBox8 = new TextBox();
            textBox11 = new TextBox();
            label17 = new Label();
            comboBox4 = new ComboBox();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            textBox2 = new TextBox();
            label20 = new Label();
            textBox12 = new TextBox();
            label21 = new Label();
            button5 = new Button();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            panel1 = new Panel();
            label25 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(333, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "1";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 55);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 1;
            label1.Text = "φ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 63);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 2;
            label2.Text = "R";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 153);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "mg";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(43, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(124, 23);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 97);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 10;
            label4.Text = "h";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(333, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 22;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(292, 0);
            button1.Name = "button1";
            button1.Size = new Size(521, 50);
            button1.TabIndex = 23;
            button1.Text = "Выполнить расчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(70, 41);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(54, 23);
            textBox5.TabIndex = 25;
            textBox5.Visible = false;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(161, 41);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(54, 23);
            textBox6.TabIndex = 26;
            textBox6.Visible = false;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(266, 41);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(54, 23);
            textBox7.TabIndex = 27;
            textBox7.Visible = false;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 44);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 28;
            label5.Text = "Ng";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 44);
            label6.Name = "label6";
            label6.Size = new Size(16, 15);
            label6.TabIndex = 29;
            label6.Text = "N";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 357);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Location = new Point(26, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 123);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(17, 81);
            button2.Name = "button2";
            button2.Size = new Size(379, 36);
            button2.TabIndex = 33;
            button2.Text = "Рассчитать коэффициент mg";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 44);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 32;
            label8.Text = " η";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(463, 63);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 33;
            label9.Text = "МПа";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(173, 97);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 34;
            label10.Text = "мм";
            label10.Click += label10_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(884, 260);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(121, 23);
            textBox9.TabIndex = 34;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(693, 263);
            label11.Name = "label11";
            label11.Size = new Size(188, 15);
            label11.TabIndex = 35;
            label11.Text = "Расчетная несущая способность";
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(275, 50);
            button4.TabIndex = 36;
            button4.Text = "Меню";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(23, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(252, 19);
            checkBox1.TabIndex = 37;
            checkBox1.Text = "Если столб имеет сечение меньше 30 см";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label15);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(529, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 166);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Материалы";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(104, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(399, 23);
            comboBox2.TabIndex = 29;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(138, 126);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(139, 19);
            radioButton2.TabIndex = 28;
            radioButton2.Text = "Прочность раствора";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(18, 126);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(114, 19);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Марка раствора";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(290, 124);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 23);
            comboBox3.TabIndex = 26;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 84);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 18;
            label13.Text = "Марка камня";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Кирпич всех видов и керамический камень со щелевидными вертикальными пустотами шириной до 12 мм при высоте ряда кладки 50 – 150 мм на тяжелых растворах", "Керамические крупноформатные камни пустотностью от 40% до 55% со щеловидным вертикальным расположением пустотами до 16мм, при высоте ряда кладки 200 - 250 мм на тяжелых растворах", "Ячистобетонные блоки на тяжелых растворах при высоте ряда кладки 150 - 300 мм", "Кладки из крупных сплошных блоков из бетонов всех видов, в том числе селикатных и блоков из природного камня при высоте кладки 500 - 1000 мм", "Сплошные бетонные, гипсобетонные и природные камни (пиленые или чистой тески) при высоте ряда кладки 200 - 300 мм ", "Кладка из бетонных камней и силикатных блоков пустотностью до 25% при высоте кладки 200 - 300 мм ", "Виброкирпичная кладка на тяжелых растворах", "Кладка из природных камней низкой прочности правильной формы (пиленых и чистой тески) до 150 мм", "Кладка из природных камней низкой прочности правильной формы (пиленых и чистой тески) 200 - 300 мм", "Бутовая кладка из рваного бута", "Бутобетон (невибрированный)", "Кладка из сплошных камней на цементно - известковых, цементно - глиняных и известковых растворах", "Кладка из кирпича и камней правильной формы", "Бутобетон по осевому растяжению" });
            comboBox1.Location = new Point(72, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(429, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 39);
            label15.Name = "label15";
            label15.Size = new Size(48, 15);
            label15.TabIndex = 13;
            label15.Text = "Камень";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(43, 134);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(124, 23);
            textBox10.TabIndex = 39;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(173, 137);
            label12.Name = "label12";
            label12.Size = new Size(25, 15);
            label12.TabIndex = 40;
            label12.Text = "мм";
            label12.Click += label12_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 137);
            label14.Name = "label14";
            label14.Size = new Size(14, 15);
            label14.TabIndex = 41;
            label14.Text = "b";
            label14.Click += label14_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(333, 150);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(124, 23);
            textBox8.TabIndex = 32;
            textBox8.Visible = false;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(884, 222);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(124, 23);
            textBox11.TabIndex = 43;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(726, 227);
            label17.Name = "label17";
            label17.Size = new Size(155, 15);
            label17.TabIndex = 42;
            label17.Text = "Действующая нагрузка (N)";
            label17.Click += label17_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0,5", "0,7", "1,0", "2,0" });
            comboBox4.Location = new Point(43, 55);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(123, 23);
            comboBox4.TabIndex = 44;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Lime;
            label16.Location = new Point(729, 303);
            label16.Name = "label16";
            label16.Size = new Size(136, 15);
            label16.TabIndex = 45;
            label16.Text = "Прочность обеспечена";
            label16.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Red;
            label18.Location = new Point(729, 303);
            label18.Name = "label18";
            label18.Size = new Size(152, 15);
            label18.TabIndex = 46;
            label18.Text = "Прочность не обеспечена";
            label18.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(463, 103);
            label19.Name = "label19";
            label19.Size = new Size(25, 15);
            label19.TabIndex = 49;
            label19.Text = "мм";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 23);
            textBox2.TabIndex = 48;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(312, 103);
            label20.Name = "label20";
            label20.Size = new Size(15, 15);
            label20.TabIndex = 47;
            label20.Text = "A";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(884, 300);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(64, 23);
            textBox12.TabIndex = 50;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(954, 303);
            label21.Name = "label21";
            label21.Size = new Size(17, 15);
            label21.TabIndex = 51;
            label21.Text = "%";
            // 
            // button5
            // 
            button5.Dock = DockStyle.Right;
            button5.FlatAppearance.MouseOverBackColor = Color.Navy;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(832, 0);
            button5.Name = "button5";
            button5.Size = new Size(216, 50);
            button5.TabIndex = 52;
            button5.Text = "Отчет";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(1014, 225);
            label22.Name = "label22";
            label22.Size = new Size(16, 15);
            label22.TabIndex = 53;
            label22.Text = "Н";
            label22.Click += label22_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(1015, 263);
            label23.Name = "label23";
            label23.Size = new Size(16, 15);
            label23.TabIndex = 54;
            label23.Text = "Н";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(485, 103);
            label24.Name = "label24";
            label24.Size = new Size(11, 15);
            label24.TabIndex = 55;
            label24.Text = "²";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 50);
            panel1.TabIndex = 56;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(12, 9);
            label25.Name = "label25";
            label25.Size = new Size(304, 30);
            label25.TabIndex = 57;
            label25.Text = "Центрально сжатые столбы";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 404);
            Controls.Add(label25);
            Controls.Add(panel1);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(textBox12);
            Controls.Add(label19);
            Controls.Add(textBox2);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(textBox8);
            Controls.Add(comboBox4);
            Controls.Add(textBox11);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(textBox10);
            Controls.Add(groupBox2);
            Controls.Add(checkBox1);
            Controls.Add(label11);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form8";
            Load += Form8_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label label8;
        private Button button2;
        private Label label9;
        private Label label10;
        private TextBox textBox9;
        private Label label11;
        private Button button3;
        private Button button4;
        public CheckBox checkBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox4;
        private Label label13;
        private ComboBox comboBox1;
        private Label label15;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TextBox textBox10;
        private Label label12;
        private Label label14;
        private TextBox textBox8;
        private TextBox textBox11;
        private Label label17;
        private Label label16;
        private Label label18;
        private Label label19;
        private TextBox textBox2;
        private Label label20;
        private TextBox textBox12;
        private Label label21;
        private Button button5;
        private Label label22;
        private Label label23;
        private Label label24;
        private Panel panel1;
        private Label label25;
    }
}