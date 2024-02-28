using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void styletable(DataGridView Grid)
        {
            Grid.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;              // закрасить ячейки
            Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;             // перенос строки
            Grid.RowHeadersVisible = false;                                         // удалить 1й столбик 
        }

        public void tab1()
        {
            styletable(dataGridView1);
            string[] S1 = { "Кирпич (в том числе силикатный сплошной", "1800" };
            string[] S2 = { "Силикатный пустотелый кирпич H = 88мм.", "1550" };
            string[] S3 = { "Силикатный камень H = 138мм.", "1850" };
            string[] S4 = { "Керамические камни H <= 150мм.", "1800" };
            string[] S5 = { "Бетонные камни 200мм <= H <= 300мм.", "2100" };
            string[] S6 = { "Бетонные камни из крупнопористых бетонов и ячеистых бетонов по ГОСТ 25485-82 200мм <= H <= 300мм ", "1700" };
            string[] S7 = { "Бетонные камни из ячеистых бетонов вида Б по СНиП ж/б 200 мм <= H <= 300мм ", "1700" };
            string[] S8 = { "Гипсобетонные камни сплошные 200 мм <= H <= 300 мм ", "1600" };
            string[] S9 = { "Гипсобетонные камни пустотелые 200 мм <= H <= 300мм", "1300" };
            string[] S10 = { "Шлакобетонные камни сплошные 200 мм <= H <= 300мм ", "1600" };
            string[] S11 = { "Шлакобетонные камни сплошные на угольных шлаках 200 мм <= H <= 300мм", "1600" };
            string[] S12 = { "Шлакобетонные камни пустотелые 200мм <= H <= 300", "1300" };
            string[] S13 = { "Шлакобетонные камни пустотолые на угольных шлаках 200мм <= H <= 300мм", "1300" };
            string[] S14 = { "Природные камни низкой прочности (пиленые и чистой тески) H <= 150мм", "1700" };
            string[] S15 = { "Природные камни низкой прочности (получистой тески) H <= 150мм", "1700" };
            string[] S16 = { "Природные камни низкой прочности (грубой тески) H <= 150мм", "1700" };
            string[] S17 = { "Природные камни нормальной прочности (пиленые и чистой тески) 200мм <= H <= 300мм", "2100" };
            string[] S18 = { "Природные камни нормальной прочности (получистой тески) 200мм <= H <= 300мм", "2100" };
            string[] S19 = { "Природные камни нормальной прочности (грубой тески) 200мм <= H <= 300мм", "2100" };
            string[] S20 = { "Природные камни низкой прочности (пиленые и чистой тески) 200 мм <= H <= 300 мм", "1700" };
            string[] S21 = { "Природные камни низкой прочности (получистой тески) 200мм <= H <= 300мм", "1700" };
            string[] S22 = { "Природные камни низкой прочности (грубой тески) 200мм <= H <= 300мм", "1700" };
            string[] S23 = { "Постелистый бут", "2100" };
            string[] S24 = { "Рваный бут", "2100" };


            addGridParam(S1, dataGridView1);
            addGridParam(S2, dataGridView1);
            addGridParam(S3, dataGridView1);
            addGridParam(S4, dataGridView1);
            addGridParam(S5, dataGridView1);
            addGridParam(S6, dataGridView1);
            addGridParam(S7, dataGridView1);
            addGridParam(S8, dataGridView1);
            addGridParam(S9, dataGridView1);
            addGridParam(S10, dataGridView1);
            addGridParam(S11, dataGridView1);
            addGridParam(S12, dataGridView1);
            addGridParam(S13, dataGridView1);
            addGridParam(S14, dataGridView1);
            addGridParam(S15, dataGridView1);
            addGridParam(S16, dataGridView1);
            addGridParam(S17, dataGridView1);
            addGridParam(S18, dataGridView1);
            addGridParam(S19, dataGridView1);
            addGridParam(S20, dataGridView1);
            addGridParam(S21, dataGridView1);
            addGridParam(S22, dataGridView1);
            addGridParam(S23, dataGridView1);
            addGridParam(S24, dataGridView1);


        }
        public void addGridParam(string[] N, DataGridView Grid)      //Метод на добавление строк
        {
            while (N.Length > Grid.ColumnCount)
            {
                Grid.Columns.Add("", "");
            }
            Grid.Rows.Add(N);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tab1();

            panel1.BackColor = Color.FromArgb(61, 26, 1);
            panel2.BackColor = Color.FromArgb(61, 26, 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
