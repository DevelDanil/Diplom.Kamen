using System.Windows.Forms;
using System.Drawing;

namespace Diplom
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
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(705, 0);
            button1.Name = "button1";
            button1.Size = new Size(291, 50);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(17, 3);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "СП 15.13330.2020";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(996, 575);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Камень";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 500;
            // 
            // Column2
            // 
            Column2.HeaderText = "Вес";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 500;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HotTrack;
            label2.Location = new Point(28, 18);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "СП 15.13330.2020";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Location = new Point(42, 33);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "СП 15.13330.2020";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 625);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 50);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 50);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(174, 30);
            label4.TabIndex = 12;
            label4.Text = "Объемные веса";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 675);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(1012, 714);
            MinimumSize = new Size(1012, 714);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
    }
}