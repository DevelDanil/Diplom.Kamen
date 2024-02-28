using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public void addGridParam(string[] N, DataGridView Grid)      //Метод на добавление строк
        {
            while (N.Length > Grid.ColumnCount)
            {
                Grid.Columns.Add("", "");
            }
            Grid.Rows.Add(N);
        }
        public void styletable(DataGridView Grid)
        {
            Grid.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;              // закрасить ячейки
            Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;             // перенос строки
            Grid.RowHeadersVisible = false;                                         // удалить 1й столбик 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form9_Load(object sender, EventArgs e)
        {
            tab1();
            tab2();
            tab3();
            tab4();
            tab5();
            tab6();
            tab7();
            tab8();
            tab9();
            tab10();
            tab11();
            tab12();
            tab13();
            tab14();
            tab15();
            tab16();
            tab17();
            tab18();

            panel1.BackColor = Color.FromArgb(61, 26, 1);
            panel2.BackColor = Color.FromArgb(61, 26, 1);
            panel3.BackColor = Color.FromArgb(61, 26, 1);


        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void tab1()
        {
            styletable(dataGridView1);
            string[] S1 = { "300", "3,9", "3,6", "3,3", "3,0", "2,8", "2,5", "2,2", "1,8", "1,7", "1,5" };
            string[] S2 = { "250", "3,6", "3,3", "3,0", "2,8", "2,5", "2,2", "1,9", "1,6", "1,5", "1,3" };
            string[] S3 = { "200", "3,2", "3,0", "2,7", "2,5", "2,2", "1,8", "1,6", "1,4", "1,3", "1,0" };
            string[] S4 = { "150", "2,6", "2,4", "2,2", "2,0", "1,8", "1,5", "1,3", "1,2", "1,0", "0,8" };
            string[] S5 = { "125", "-", "2,2", "2,0", "1,9", "1,7", "1,4", "1,2", "1,1", "0,9", "0,7" };
            string[] S6 = { "100", "-", "2,0", "1,8", "1,7", "1,5", "1,3", "1,0", "0,9", "0,8", "0,6" };
            string[] S7 = { "75", "-", "-", "1,5", "1,4", "1,3", "1,1", "0,9", "0,7", "0,6", "0,5" };
            string[] S8 = { "50", "-", "-", "-", "1,1", "1,0", "0,9", "0,7", "0,6", "0,5", "0,35" };
            string[] S9 = { "35", "-", "-", "-", "0,9", "0,8", "0,7", "0,6", "0,45", "0,4", "0,25" };



            addGridParam(S1, dataGridView1);
            addGridParam(S2, dataGridView1);
            addGridParam(S3, dataGridView1);
            addGridParam(S4, dataGridView1);
            addGridParam(S5, dataGridView1);
            addGridParam(S6, dataGridView1);
            addGridParam(S7, dataGridView1);
            addGridParam(S8, dataGridView1);
            addGridParam(S9, dataGridView1);


        }

        public void tab2()
        {
            styletable(dataGridView2);
            string[] S1 = { "300", "4,1", "3,8", "3,5", "3,2", "3,0" };
            string[] S2 = { "250", "3,7", "3,6", "3,2", "3,0", "2,7" };
            string[] S3 = { "200", "3,5", "3,2", "2,9", "2,7", "2,4" };
            string[] S4 = { "150", "2,8", "2,6", "2,4", "2,3", "2,2" };
            string[] S5 = { "125", "-", "2,5", "2,3", "2,2", "2,1" };
            string[] S6 = { "100", "-", "2,2", "2,0", "1,9", "1,8" };
            string[] S7 = { "75", "-", "-", "1,6", "1,5", "1,4" };
            string[] S8 = { "50", "-", "-", "-", "1,1", "1,0" };




            addGridParam(S1, dataGridView2);
            addGridParam(S2, dataGridView2);
            addGridParam(S3, dataGridView2);
            addGridParam(S4, dataGridView2);
            addGridParam(S5, dataGridView2);
            addGridParam(S6, dataGridView2);
            addGridParam(S7, dataGridView2);
            addGridParam(S8, dataGridView2);



        }
        public void tab3()
        {
            styletable(dataGridView3);
            string[] S1 = { "B7,5", "2,3", "2,2", "2,0", "1,8", "1,7", "1,5", "1,3", "1,0" };
            string[] S2 = { "B5", "1,9", "1,8", "1,7", "1,5", "1,4", "1,2", "1,1", "0,8" };
            string[] S3 = { "B3,5", "1,5", "1,4", "1,3", "1,2", "1,0", "0,9", "0,8", "0,6" };
            string[] S4 = { "B2,5", "-", "-", "1,0", "0,95", "0,85", "0,7", "0,6", "0,45" };
            string[] S5 = { "B2", "-", "-", "0,8", "0,75", "0,65", "0,55", "0,5", "0,35" };
            string[] S6 = { "B1,5", "-", "-", "0,6", "0,56", "0,49", "0,41", "0,38", "0,26" };




            addGridParam(S1, dataGridView3);
            addGridParam(S2, dataGridView3);
            addGridParam(S3, dataGridView3);
            addGridParam(S4, dataGridView3);
            addGridParam(S5, dataGridView3);
            addGridParam(S6, dataGridView3);



        }

        public void tab4()
        {
            styletable(dataGridView4);
            string[] S1 = { "B7,5", "2,3", "2,2", "2,0", "1,8", "1,7", "1,5", "1,3", "1,0" };
            string[] S2 = { "B5", "1,9", "1,8", "1,7", "1,5", "1,4", "1,2", "1,1", "0,8" };
            string[] S3 = { "B3,5", "1,5", "1,4", "1,3", "1,2", "1,0", "0,9", "0,8", "0,6" };
            string[] S4 = { "B2,5", "-", "-", "1,0", "0,95", "0,85", "0,7", "0,6", "0,45" };
            string[] S5 = { "B2", "-", "-", "0,8", "0,75", "0,65", "0,55", "0,5", "0,35" };
            string[] S6 = { "B1,5", "-", "-", "0,6", "0,56", "0,49", "0,41", "0,38", "0,26" };




            addGridParam(S1, dataGridView4);
            addGridParam(S2, dataGridView4);
            addGridParam(S3, dataGridView4);
            addGridParam(S4, dataGridView4);
            addGridParam(S5, dataGridView4);
            addGridParam(S6, dataGridView4);



        }
        public void tab5()
        {
            styletable(dataGridView5);
            string[] S1 = { "1000", "13,0", "12,5", "12,0", "11,5", "11,0", "10,5", "9,5", "8,5", "8,3", "8,0" };
            string[] S2 = { "800", "11,0", "10,5", "10,0", "9,5", "9,0", "8,5", "8,0", "7,0", "6,8", "6,5" };
            string[] S3 = { "600", "9,0", "8,5", "8,0", "7,8", "7,5", "7,0", "6,0", "5,5", "5,3", "5,0" };
            string[] S4 = { "500", "7,8", "7,3", "6,9", "6,7", "6,4", "6,0", "5,3", "4,8", "4,6", "4,3" };
            string[] S5 = { "400", "6,5", "6,0", "5,8", "5,5", "5,3", "5,0", "4,5", "4,0", "3,8", "3,5" };
            string[] S6 = { "300", "5,8", "4,9", "4,7", "4,5", "4,3", "4,0", "3,7", "3,3", "3,1", "2,8" };
            string[] S7 = { "200", "4,0", "3,8", "3,6", "3,5", "3,3", "3,0", "2,8", "2,5", "2,3", "2,0" };
            string[] S8 = { "150", "3,3", "3,1", "2,9", "2,8", "2,6", "2,4", "2,2", "2,0", "1,8", "1,5" };
            string[] S9 = { "100", "2,5", "2,4", "2,3", "2,2", "2,0", "1,8", "1,7", "1,5", "1,3", "1,0" };
            string[] S10 = { "75", "-", "-", "1,9", "1,8", "1,7", "1,5", "1,4", "1,2", "1,1", "0,8" };
            string[] S11 = { "50", "-", "-", "1,5", "1,4", "1,3", "1,2", "1,0", "0,9", "0,8", "0,6" };
            string[] S12 = { "35", "-", "-", "-", "-", "1,0", "0,95", "0,85", "0,7", "0,6", "0,45" };
            string[] S13 = { "25", "-", "-", "-", "-", "0,8", "0,75", "0,65", "0,55", "0,5", "0,35" };
            string[] S14 = { "15", "-", "-", "-", "-", "-", "0,5", "0,45", "0,38", "0,35", "0,25" };





            addGridParam(S1, dataGridView5);
            addGridParam(S2, dataGridView5);
            addGridParam(S3, dataGridView5);
            addGridParam(S4, dataGridView5);
            addGridParam(S5, dataGridView5);
            addGridParam(S6, dataGridView5);
            addGridParam(S7, dataGridView5);
            addGridParam(S8, dataGridView5);
            addGridParam(S9, dataGridView5);
            addGridParam(S10, dataGridView5);
            addGridParam(S11, dataGridView5);
            addGridParam(S12, dataGridView5);
            addGridParam(S13, dataGridView5);
            addGridParam(S14, dataGridView5);

        }
        public void tab6()
        {
            styletable(dataGridView6);
            string[] S1 = { "300", "4,6", "4,4", "4,2", "3,9", "3,6", "3,2", "3,0", "2,7" };
            string[] S2 = { "200", "3,4", "3,3", "3,0", "2,9", "2,6", "2,4", "2,1", "1,7" };
            string[] S3 = { "150", "2,7", "2,6", "2,4", "2,2", "2,0", "1,8", "1,7", "1,3" };
            string[] S4 = { "125", "2,4", "2,3", "2,1", "1,9", "1,7", "1,6", "1,4", "1,1" };
            string[] S5 = { "100", "2,0", "1,8", "1,7", "1,6", "1,4", "1,3", "1,1", "0,9" };
            string[] S6 = { "75", "1,6", "1,5", "1,4", "1,3", "1,1", "1,0", "0,9", "0,7" };
            string[] S7 = { "50", "1,2", "1,15", "1,1", "1,0", "0,9", "0,8", "0,7", "0,5" };
            string[] S8 = { "35", "-", "1,0", "0,9", "0,8", "0,7", "0,6", "0,55", "0,4" };
            string[] S9 = { "25", "-", "-", "0,7", "0,65", "0,55", "0,5", "0,45", "0,3" };
            string[] S10 = { "15", "-", "-", "-", "0,45", "0,4", "0,35", "0,3", "0,2" };




            addGridParam(S1, dataGridView6);
            addGridParam(S2, dataGridView6);
            addGridParam(S3, dataGridView6);
            addGridParam(S4, dataGridView6);
            addGridParam(S5, dataGridView6);
            addGridParam(S6, dataGridView6);
            addGridParam(S7, dataGridView6);
            addGridParam(S8, dataGridView6);
            addGridParam(S9, dataGridView6);
            addGridParam(S10, dataGridView6);



        }
        public void tab7()
        {
            styletable(dataGridView7);
            string[] S1 = { "300", "5,6", "5,3", "4,8", "4,5", "4,2" };
            string[] S2 = { "250", "5,2", "4,9", "4,4", "4,1", "3,7" };
            string[] S3 = { "200", "4,8", "4,5", "4,0", "3,6", "3,3" };
            string[] S4 = { "150", "4,0", "3,7", "3,3", "3,1", "2,7" };
            string[] S5 = { "125", "3,6", "3,3", "3,0", "2,9", "2,5" };
            string[] S6 = { "100", "3,1", "2,9", "2,7", "2,6", "2,3" };
            string[] S7 = { "75", "-", "2,5", "2,3", "2,2", "2,0" };





            addGridParam(S1, dataGridView7);
            addGridParam(S2, dataGridView7);
            addGridParam(S3, dataGridView7);
            addGridParam(S4, dataGridView7);
            addGridParam(S5, dataGridView7);
            addGridParam(S6, dataGridView7);
            addGridParam(S7, dataGridView7);

        }
        public void tab8()
        {
            styletable(dataGridView8);
            string[] S1 = { "     ", "    ", "25", "10", "4", "0,2", "нулевой" };
            string[] S2 = { "Из природных камней при высоте ряда до 150 мм", "25", "0,6", "0,45", "0,35", "0,3", "0,2" };
            string[] S3 = { "Из природных камней при высоте ряда до 150 мм", "15", "0,4", "0,35", "0,25", "0,2", "0,13" };
            string[] S4 = { "Из природных камней при высоте ряда до 150 мм", "10", "0,3", "0,25", "0,2", "0,18", "0,1" };
            string[] S5 = { "Из природных камней при высоте ряда до 150 мм", "7", "0,25", "0,2", "0,18", "0,15", "0,07" };
            string[] S6 = { "Из природных камней при высоте ряда 200 - 300 мм", "10", "0,38", "0,33", "0,28", "0,25", "0,2" };
            string[] S7 = { "Из природных камней при высоте ряда 200 - 300 мм", "7", "2,8", "0,25", "0,23", "0,2", "0,12" };
            string[] S8 = { "Из природных камней при высоте ряда 200 - 300 мм", "4", "-", "0,15", "0,14", "0,12", "0,08" };




            addGridParam(S1, dataGridView8);
            addGridParam(S2, dataGridView8);
            addGridParam(S3, dataGridView8);
            addGridParam(S4, dataGridView8);
            addGridParam(S5, dataGridView8);
            addGridParam(S6, dataGridView8);
            addGridParam(S7, dataGridView8);
            addGridParam(S8, dataGridView8);

        }

        public void tab9()
        {
            styletable(dataGridView9);
            string[] S1 = { "1000", "2,5", "2,2", "1,8", "1,2", "0,8", "0,5", "0,4", "0,33" };
            string[] S2 = { "800", "2,2", "2,0", "1,6", "1,0", "0,7", "0,45", "0,33", "0,28" };
            string[] S3 = { "600", "2,0", "1,7", "1,4", "0,9", "0,65", "0,4", "0,3", "0,22" };
            string[] S4 = { "500", "1,8", "1,5", "1,3", "0,85", "0,6", "0,38", "0,27", "0,18" };
            string[] S5 = { "400", "1,5", "1,3", "1,1", "0,8", "0,55", "0,33", "0,23", "0,15" };
            string[] S6 = { "300", "1,3", "1,15", "0,95", "0,7", "0,5", "0,3", "0,2", "0,12" };
            string[] S7 = { "200", "1,1", "1,0", "0,8", "0,6", "0,45", "0,28", "0,18", "0,08" };
            string[] S8 = { "150", "0,9", "0,8", "0,7", "0,55", "0,4", "0,25", "0,17", "0,07" };
            string[] S9 = { "100", "0,75", "0,7", "0,6", "0,5", "0,35", "0,23", "0,15", "0,05" };
            string[] S10 = { "50", "-", "-", "0,45", "0,35", "0,25", "0,2", "0,13", "0,03" };
            string[] S11 = { "35", "-", "-", "0,36", "0,29", "0,22", "0,18", "0,12", "0,02" };
            string[] S12 = { "25", "-", "-", "0,3", "0,25", "0,2", "0,15", "0,1", "0,02" };




            addGridParam(S1, dataGridView9);
            addGridParam(S2, dataGridView9);
            addGridParam(S3, dataGridView9);
            addGridParam(S4, dataGridView9);
            addGridParam(S5, dataGridView9);
            addGridParam(S6, dataGridView9);
            addGridParam(S7, dataGridView9);
            addGridParam(S8, dataGridView9);
            addGridParam(S9, dataGridView9);
            addGridParam(S10, dataGridView9);
            addGridParam(S11, dataGridView9);
            addGridParam(S12, dataGridView9);

        }

        public void tab10()
        {
            styletable(dataGridView10);
            string[] S1 = { "С рваным бутовым камнем марки: 200 и выше", "4", "3,5", "3", "2,5", "2,0", "1,7" };
            string[] S2 = { "100", "-", "-", "-", "2,2", "1,8", "1,5" };
            string[] S3 = { "50 или с кирпичным боем", "-", "-", "-", "2,0", "1,7", "1,3" };


            addGridParam(S1, dataGridView10);
            addGridParam(S2, dataGridView10);
            addGridParam(S3, dataGridView10);


        }
        public void tab11()
        {
            styletable(dataGridView11);
            string[] S1 = { "", "", "50 и выше", "25", "10", "4", " " };
            string[] S2 = { "А Осевое растяжение 1. По неперевязонному сечению (рис 6.1) для кладки всех видов (нормальное сцепление)", "Rt", "0,08", "0,05", "0,03", "0,01", "0,005" };
            string[] S3 = { "2. По перевязонному сечению (рис 6.2):", " ", " ", " ", " ", " ", " " };
            string[] S4 = { "а) для кладки из камней правильной формы", " ", "0,11", "0,05", "0,02", "0,01" };
            string[] S5 = { "б) для бутовой кладки", "0,12", "0,08", "0,04", "0,02", "0,01" };
            string[] S6 = { "Б растяжение при изгибе", "Rtb(Rtw)", "", "", "", "", "" };
            string[] S7 = { "3. По неперевязонному сечению для кладки всех видов и по косой штробе (главные растягивающие напряжения при изгибе)", "", "0,12", "0,08", "0,04", "0.02", "0.01" };
            string[] S8 = { "4. По перевязонному сечению (рис 6.3)", "", "", "", "", "", "" };
            string[] S9 = { "а) для кладки из камней правильной формы", "", "0,25", "0,16", "0,08", "0,04", "0,02" };
            string[] S10 = { "б) для бутовой кладки", "", "0,18", "0,12", "0,06", "0,03", "0,015" };
            string[] S11 = { "В Срез", "Rsq", "  ", "  ", " ", " ", " " };
            string[] S12 = { "5. По неперевязонному сечению для кладки всех видов (касательное сцепление)", " ", "0,16", "0,11", "0,05", "0,02", "0,01" };
            string[] S13 = { "6. По перевязонному сечению для бутовой кладки", " ", "0,24", "0,16", "0,08", "0,04", "0,02" };

            addGridParam(S1, dataGridView11);
            addGridParam(S2, dataGridView11);
            addGridParam(S3, dataGridView11);
            addGridParam(S4, dataGridView11);
            addGridParam(S5, dataGridView11);
            addGridParam(S6, dataGridView11);
            addGridParam(S7, dataGridView11);
            addGridParam(S8, dataGridView11);
            addGridParam(S9, dataGridView11);
            addGridParam(S10, dataGridView11);
            addGridParam(S11, dataGridView11);
            addGridParam(S12, dataGridView11);
            addGridParam(S13, dataGridView11);
        }
        public void tab12()
        {
            styletable(dataGridView12);
            string[] S1 = { "1. Осевое растяжение", "Rt", "0,25", "0,2", "0,18", "0,13", "0,1", "0,08", "0,06", "0,05", "0,03" };
            string[] S2 = { "2. Растяжение при изгибе и главный растягивающие напряжение", "Rtb(Rtw)", "0,4", "0,3", "0,25", "0,2", "0,16", "0,12", "0,1", "0,07", "0,05" };
            string[] S3 = { "3. Срез", "Rsq", "1,0", "0,8", "0,65", "0,55", "0,4", "0,3", "0,2", "0,14", "0,09" };


            addGridParam(S1, dataGridView12);
            addGridParam(S2, dataGridView12);
            addGridParam(S3, dataGridView12);

        }
        public void tab13()
        {
            styletable(dataGridView13);
            string[] S1 = { "1. Осевое растяжение и главные растягивающие напряжения", "Rt(Rtw)", "0,2", "0,18", "0,16", "0,14", "0,12", "0,1" };
            string[] S2 = { "2. Растяжение при изгибе", "Rtw", "0,27", "0,25", "0,23", "0,2", "0,18", "0,16" };


            addGridParam(S1, dataGridView13);
            addGridParam(S2, dataGridView13);


        }

        public void tab14()
        {
            styletable(dataGridView14);
            string[] S1 = { "1. Сетчатое армирование", "0,75", "-", "0,6" };
            string[] S2 = { "2. Продольная арматура в кладке:", "", "", "" };
            string[] S3 = { "а) продольная арматура растянутая", "0,8", "0,9", "0,7" };
            string[] S4 = { "б) то же, сжатая", "0,85", "0,7", "0,6" };
            string[] S5 = { "в) отогнутая арматура и хомуты", "0,8", "0,8", "0,6" };
            string[] S6 = { "3. Анкеры и связи в кладке:", "", "", "" };
            string[] S7 = { "а) на растворе марки 25 и выше", "0,9", "0,9", "0,8" };
            string[] S8 = { "б) на растворе марки 10 и ниже", "0,5", "0,5", "0,6" };


            addGridParam(S1, dataGridView14);
            addGridParam(S2, dataGridView14);
            addGridParam(S3, dataGridView14);
            addGridParam(S4, dataGridView14);
            addGridParam(S5, dataGridView14);
            addGridParam(S6, dataGridView14);
            addGridParam(S7, dataGridView14);
            addGridParam(S8, dataGridView14);



        }

        public void tab15()
        {
            styletable(dataGridView15);
            string[] S1 = { "Для стен толщиной более 20 см из кирпича и камней всех видов, из крупных блоков, кирпичная вибрированная при проценте пустот не более 55% рваного бута и бутобетона", "2,0", "2,35" };
            string[] S2 = { "Для стен толщиной более 20 см из кирпича и камней всех видов, из крупных блоков при проценте пустот более 55%", "2,3", "2,4" };
            string[] S3 = { "Для стен из кирпича, камней, блоков толщиной 20 см, но не менее 8,5 см", "2,3", "по непревязонному сечению 4.0*" };
            string[] S4 = { "Для стен из кирпича, камней, блоков толщиной 20 см, но не менее 8,5 см", "2,3", "по перевязонному сечению: 2,4" };
            string[] S5 = { "Из крупных и мелких блоков из ячистых бетонов", "2,2", "2,25" };



            addGridParam(S1, dataGridView15);
            addGridParam(S2, dataGridView15);
            addGridParam(S3, dataGridView15);
            addGridParam(S4, dataGridView15);
            addGridParam(S5, dataGridView15);

        }


        public void tab16()
        {
            styletable(dataGridView16);
            string[] S1 = { "1. Из крупных блоков, изготовленных из тяжелого и крупнопористого бетона на тяжелых заполнителях и из тяжелого природного камня (y>= 1800 кг/м3)", "1500", "1000", "750", "750", "500" };
            string[] S2 = { "2. Из камней, изготовленных из тяжелого бетона, тяжелых природных камней и бута", "1500", "1000", "750", "500", "350" };
            string[] S3 = { "3. Из крупных блоков, изготовленных из бетона на пористых заполнителях и поризованного, крупнопористого бетона на легких заполнителях, плотного силикатного бетона и из легкого природного камня", "1000", "750", "500", "500", "350" };
            string[] S4 = { "4. Из крупных блоков, изготовленных из ячеистых бетонов:", "", "", "", "", "" };
            string[] S5 = { "автоклавных", "750", "750", "500", "500", "350" };
            string[] S6 = { "неавтоклавных", "500", "500", "350", "350", "350" };
            string[] S7 = { "5. Из камней, изготовленных из ячистых бетонов", "", "", "", "", "" };
            string[] S8 = { "автокалвных", "750", "500", "350", "350", "200" };
            string[] S9 = { "неавтоклавных", "500", "350", "200", "200", "200" };
            string[] S10 = { "6. Из керамических камней (кроме крупноформатных", "1200", "1000", "750", "500", "350" };
            string[] S11 = { "7. Из кирпича керамического пластического прессования полнотелого и пустотелого, из пустотелых силикатных камней, из камней, изготовленных из бетона на пористых заполнителях и поризованного, из легких природных камней", "1000", "750", "500", "350", "200" };
            string[] S12 = { "8. Из кирпича силикатного полнотелого и пустотелого", "750", "500", "350", "350", "200" };
            string[] S13 = { "9. Из кирпича керамического полусухого прессования полнотелого и пустотелого", "500", "500", "350", "350", "200" };



            addGridParam(S1, dataGridView16);
            addGridParam(S2, dataGridView16);
            addGridParam(S3, dataGridView16);
            addGridParam(S4, dataGridView16);
            addGridParam(S5, dataGridView16);
            addGridParam(S6, dataGridView16);
            addGridParam(S7, dataGridView16);
            addGridParam(S8, dataGridView16);
            addGridParam(S9, dataGridView16);
            addGridParam(S10, dataGridView16);
            addGridParam(S11, dataGridView16);
            addGridParam(S12, dataGridView16);
            addGridParam(S13, dataGridView16);


        }


        public void tab17()
        {
            styletable(dataGridView17);
            string[] S1 = { "1. Кирпич керамический полнотелый, пустотелый и керамические камни ", "0,000005" };
            string[] S2 = { "2. Кирпич силикатный, камни и блоки бетонные и бутобетон", "0,00001" };
            string[] S3 = { "3. Природные камни, камни и блоки из ячеистых бетонов", "0,000008" };


            addGridParam(S1, dataGridView17);
            addGridParam(S2, dataGridView17);
            addGridParam(S3, dataGridView17);

        }
        public void tab18()
        {
            styletable(dataGridView18);
            string[] S1 = { "1. Кладка по кладке или бетону", "0,7", "0,6" };
            string[] S2 = { "2. Дерево по кладке или бетону", "0,6", "0,5" };
            string[] S3 = { "3. Сталь по кладке или бетону", "0,45", "0,35" };
            string[] S4 = { "4. Кладка или бетон по песку или гравию", "0,6", "0,5" };
            string[] S5 = { "5. То же, по суглинку", "0,55", "0,4" };
            string[] S6 = { ">>, по глине", "0,5", "0,3" };


            addGridParam(S1, dataGridView18);
            addGridParam(S2, dataGridView18);
            addGridParam(S3, dataGridView18);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            dataGridView1.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = true;
            dataGridView2.Visible = true;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = true;
            textBox6.Visible = true;
            dataGridView3.Visible = true;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = true;
            textBox8.Visible = true;
            dataGridView4.Visible = true;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }




        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = true;
            textBox10.Visible = true;
            dataGridView5.Visible = true;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = true;
            textBox12.Visible = true;
            dataGridView6.Visible = true;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = true;
            textBox14.Visible = true;
            dataGridView7.Visible = true;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = true;
            dataGridView8.Visible = true;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = true;
            textBox17.Visible = true;
            dataGridView9.Visible = true;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = true;
            textBox19.Visible = true;
            dataGridView10.Visible = true;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = true;
            textBox21.Visible = true;
            dataGridView11.Visible = true;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = true;
            textBox23.Visible = true;
            dataGridView12.Visible = true;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = true;
            dataGridView13.Visible = true;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = true;
            textBox26.Visible = true;
            dataGridView14.Visible = true;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = true;
            dataGridView15.Visible = true;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = true;
            textBox29.Visible = true;
            dataGridView16.Visible = true;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = true;
            textBox31.Visible = true;
            dataGridView17.Visible = true;
            textBox32.Visible = false;
            dataGridView18.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView3.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            dataGridView4.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dataGridView5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            dataGridView6.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            dataGridView7.Visible = false;
            textBox15.Visible = false;
            dataGridView8.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            dataGridView9.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            dataGridView10.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            dataGridView11.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            dataGridView12.Visible = false;
            textBox24.Visible = false;
            dataGridView13.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            dataGridView14.Visible = false;
            textBox27.Visible = false;
            dataGridView15.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            dataGridView16.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            dataGridView17.Visible = false;
            textBox32.Visible = true;
            dataGridView18.Visible = true;
        }
    }
}
