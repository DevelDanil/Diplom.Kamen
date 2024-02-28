using System.Windows.Forms;
using System.Drawing;

namespace Diplom
{
    partial class Form12
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
            label1 = new Label();
            comboBox10 = new ComboBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 0;
            label1.Text = "Ввод значений единиц измерения";
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "мм", "см", "м" });
            comboBox10.Location = new Point(83, 39);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(125, 23);
            comboBox10.TabIndex = 1;
            comboBox10.SelectedIndexChanged += comboBox10_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(34, 3);
            button1.Name = "button1";
            button1.Size = new Size(224, 34);
            button1.TabIndex = 2;
            button1.Text = "Меню";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Н", "кН", "кгс", "тс" });
            comboBox1.Location = new Point(83, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 77);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 3;
            label2.Text = "Вывод значений единиц измерения";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 52);
            panel1.TabIndex = 5;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(294, 187);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(comboBox10);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox10;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Panel panel1;
    }
}