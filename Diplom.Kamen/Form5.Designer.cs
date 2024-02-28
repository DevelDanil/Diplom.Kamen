using System.Windows.Forms;
using System.Drawing;

namespace Diplom
{
    partial class Form5
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView6 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView7 = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridView4 = new DataGridView();
            tabPage4 = new TabPage();
            dataGridView5 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 51);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1611, 554);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1603, 526);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Механические повреждения кладки стен, столбов, простенков";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1605, 517);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Характер повреждения кладки стен, столбов и простенков";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 900;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Коэффициент снижения несущей способности при кладке";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 900;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(5, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1596, 517);
            dataGridView2.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView6);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1603, 526);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Механические повреждения кладки опор балок, ферм, перемычек";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView6.Location = new Point(0, 0);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.RowTemplate.Height = 25;
            dataGridView6.Size = new Size(1601, 514);
            dataGridView6.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Характер повреждения кладки стен, столбов и простенков";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 900;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Коэффициент снижения несущей способности при кладке";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 900;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(1601, 514);
            dataGridView3.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView7);
            tabPage3.Controls.Add(dataGridView4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1603, 526);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Повреждения кладки стен, столбов, простенков при пожаре";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView7.Location = new Point(0, 0);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.RowTemplate.Height = 25;
            dataGridView7.Size = new Size(1601, 514);
            dataGridView7.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Глубина повреждения кладки (без штукатурки), см";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 900;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Коэффициент снижения несущей способности";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 900;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(-3, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(1601, 514);
            dataGridView4.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView5);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1603, 526);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Виды повреждений и рекомендации по временному усилению ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10 });
            dataGridView5.Location = new Point(-4, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(1601, 517);
            dataGridView5.TabIndex = 0;
            dataGridView5.CellContentClick += dataGridView5_CellContentClick;
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
            // Column6
            // 
            Column6.HeaderText = "Коэффициент снижения несущей способности";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 900;
            // 
            // Column5
            // 
            Column5.HeaderText = "Глубина повреждения кладки (без штукатурки), см";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 900;
            // 
            // Column4
            // 
            Column4.HeaderText = "Коэффициент снижения несущей способности при кладке";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 900;
            // 
            // Column3
            // 
            Column3.HeaderText = "Характер повреждения кладки стен, столбов и простенков";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 900;
            // 
            // Column2
            // 
            Column2.HeaderText = "Коэффициент снижения несущей способности при кладке";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 900;
            // 
            // Column1
            // 
            Column1.HeaderText = "Характер повреждения кладки стен, столбов и простенков";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 900;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Location = new Point(101, 15);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 7;
            label1.Text = "Классификация повреждений";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1301, 0);
            button1.Name = "button1";
            button1.Size = new Size(312, 50);
            button1.TabIndex = 8;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 614);
            panel1.Name = "panel1";
            panel1.Size = new Size(1613, 50);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1613, 50);
            panel2.TabIndex = 10;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1613, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage4;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private TabPage tabPage1;
        private DataGridView dataGridView2;
        private TabPage tabPage2;
        private DataGridView dataGridView3;
        private TabPage tabPage3;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridView6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridView7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
    }
}