using System.Windows.Forms;
using System.Drawing;

namespace Diplom
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button5 = new Button();
            button7 = new Button();
            button3 = new Button();
            button6 = new Button();
            button4 = new Button();
            button9 = new Button();
            menuStrip1 = new MenuStrip();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(298, 124);
            button1.TabIndex = 2;
            button1.Text = "Объемные веса";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(174, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 121);
            button2.Name = "button2";
            button2.Size = new Size(298, 124);
            button2.TabIndex = 4;
            button2.Text = "Классификация повреждений";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 242);
            button5.Name = "button5";
            button5.Size = new Size(298, 121);
            button5.TabIndex = 9;
            button5.Text = "Расчетные характеристики";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Tan;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(633, 260);
            button7.Name = "button7";
            button7.Size = new Size(324, 177);
            button7.TabIndex = 10;
            button7.Text = "Внецентренно сжатые \r\nармированные столбы";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(633, 74);
            button3.Name = "button3";
            button3.Size = new Size(324, 188);
            button3.TabIndex = 9;
            button3.Text = "Центрально сжатые \r\nармированные столбы";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Tan;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(294, 260);
            button6.Name = "button6";
            button6.Size = new Size(341, 177);
            button6.TabIndex = 8;
            button6.Text = "Внецентренно сжатые столбы";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(294, 73);
            button4.Name = "button4";
            button4.Size = new Size(341, 188);
            button4.TabIndex = 8;
            button4.Text = "Центрально сжатые столбы";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Right;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(700, 0);
            button9.Name = "button9";
            button9.Size = new Size(257, 52);
            button9.TabIndex = 9;
            button9.Text = "Выход";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(957, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.BackColor = Color.White;
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button9);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 437);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 52);
            panel1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(165, 17);
            label3.TabIndex = 13;
            label3.Text = "Нормы проектирования";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 50);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(430, 4);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 12;
            label2.Text = "Расчеты";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(277, 30);
            label1.TabIndex = 11;
            label1.Text = "Справочная информация";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 363);
            panel3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 489);
            Controls.Add(button7);
            Controls.Add(panel3);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(973, 528);
            MinimumSize = new Size(973, 528);
            Name = "Form1";
            Text = "Каменные конструкции";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button9;
        private Button button6;
        private Button button4;
        private Button button5;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private Button button7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}