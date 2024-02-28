using System.Windows.Forms;
using System.Drawing;

namespace Diplom
{
    partial class Form4
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            dataGridView4 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(35, 3);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 1;
            label1.Text = "Классификация повреждений";
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1289, 0);
            button1.Name = "button1";
            button1.Size = new Size(319, 50);
            button1.TabIndex = 3;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1600, 512);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Характер повреждения кладки стен, столбов и простенков";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 900;
            // 
            // Column2
            // 
            Column2.HeaderText = "Коэффициент снижения несущей способности при кладке";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 900;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Location = new Point(57, 18);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 4;
            label2.Text = "Классификация повреждений";
            label2.Click += label2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1608, 551);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1600, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Механические повреждения кладки стен, столбов, простенков";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1600, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Механические повреждения кладки опор балок, ферм, перемычек";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1601, 514);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // Column3
            // 
            Column3.HeaderText = "Характер повреждения кладки стен, столбов и простенков";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 900;
            // 
            // Column4
            // 
            Column4.HeaderText = "Коэффициент снижения несущей способности при кладке";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 900;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1600, 523);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Повреждения кладки стен, столбов, простенков при пожаре";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6 });
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(1599, 512);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Column5
            // 
            Column5.HeaderText = "Глубина повреждения кладки (без штукатурки), см";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 900;
            // 
            // Column6
            // 
            Column6.HeaderText = "Коэффициент снижения несущей способности";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 900;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1600, 523);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Виды повреждений и рекомендации по временному усилению ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10 });
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(1599, 512);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // Column7
            // 
            Column7.HeaderText = "Повреждение";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 450;
            // 
            // Column8
            // 
            Column8.HeaderText = "Снижение несущей способности конструкций при повреждений, %";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 450;
            // 
            // Column9
            // 
            Column9.HeaderText = "Вид повреждения";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 450;
            // 
            // Column10
            // 
            Column10.HeaderText = "Мероприятия по временному усилению";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 450;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Location = new Point(77, 33);
            label3.Name = "label3";
            label3.Size = new Size(172, 15);
            label3.TabIndex = 6;
            label3.Text = "Классификация повреждений";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1606, 50);
            panel2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(325, 30);
            label4.TabIndex = 12;
            label4.Text = "Классификация повреждений";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 586);
            panel1.Name = "panel1";
            panel1.Size = new Size(1606, 50);
            panel1.TabIndex = 7;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1606, 636);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private TabPage tabPage4;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Panel panel1;
    }
}