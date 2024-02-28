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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            tab4();
            tab5();
            tab6();
            tab7();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            DialogResult = DialogResult.OK;

        }

        public void tab4()
        {
            styletable(dataGridView1);



            string[] S1 = { "", "неармированной", "армированной" };
            string[] S2 = { "Трещины в отдельных кирпичах, не пересекающие растворные швы", "1.0", "1.0" };
            string[] S3 = { "Волосные трещины, пересекающие не более двух рядов кладки (длиной 15-18 см)", "0.9", "1.0" };
            string[] S4 = { "То же, при пересечении не более четырех рядов кладки (длинной до 30 - 35 см) при числе трещин не более четырех на 1 м ширины (толищны) стены, столба или простенка", "0.75", "0.9" };
            string[] S5 = { "Трещины с раскрытием до 2 мм, пересекающие не более весьми рядов кладки (длиной до 60 - 65 см) при числе трещин не более четырех на 1 м ширины (толщины) стены, столба, простенка", "0.5", "0.7" };
            string[] S6 = { "То же, при пересечении более весьми рядов (длиной более 65 см)", "0.0", "0.5" };



            addGridParam(S1, dataGridView1);
            addGridParam(S2, dataGridView1);
            addGridParam(S3, dataGridView1);
            addGridParam(S4, dataGridView1);
            addGridParam(S5, dataGridView1);
            addGridParam(S6, dataGridView1);




        }
        public void tab5()
        {
            styletable(dataGridView2);



            string[] S1 = { "", "неармированной", "армированной" };
            string[] S2 = { "Местное (краевое) повреждение кладки на глубину до 2 см (мелкие трещины, отслоение в виде лещадок) и образование вертикальных трещин по концам опор(или опорных подушек) белок, ферм и перемычек, пересекающих не более двух рядов кладки (длиной до 30 - 35 см)", "0.75", "0.9" };
            string[] S3 = { "То же, при пересечении трещинами не более четырех рядов кладки (длиной до 30 - 35 см)", "0.5", "0.75" };
            string[] S4 = { "Краевое повреждение кладки на глубину более 2 см и образование вертикальных и косых трещин по концам и под опорами (опорными подушками) балок и ферм, пересекающих более четырех рядов кладки (длиной более 30 см)", "0", "0.5" };




            addGridParam(S1, dataGridView2);
            addGridParam(S2, dataGridView2);
            addGridParam(S3, dataGridView2);
            addGridParam(S4, dataGridView2);





        }
        public void tab6()
        {
            styletable(dataGridView3);



            string[] S1 = { "", "стены толщиной 38 см и более при огевом повреждении", "", "столбы при наибольшем размере сечения 38 см и более" };
            string[] S2 = { "", "одностороннем", "двустороннем", "" };
            string[] S3 = { "До 0.5", "1.0", "0.95", "0.9" };
            string[] S4 = { "До 2", "0.95", "0.9", "0.85" };
            string[] S5 = { "До 5-6", "0.9", "0.8", "0.7" };




            addGridParam(S1, dataGridView3);
            addGridParam(S2, dataGridView3);
            addGridParam(S3, dataGridView3);
            addGridParam(S4, dataGridView3);
            addGridParam(S5, dataGridView3);





        }

        public void tab7()
        {
            styletable(dataGridView4);


            //Первых блок "Среднее"
            string[] S1 = { "Среднее", "До 25", "Размораживание и выветривание кладки отслоение облицовки на глубину до 25% толщины", "Поверочный расчет несущей способности конструкций, при временном усилении - установка дополнительных стоек, упоров, стяжек, расчалок", "" };
            string[] S2 = { "Среднее", "До 25", "Вертикальные и косые трещины в несущих стенах и столбах на высоту не более четырех рядов кладки.", "" };
            string[] S3 = { "Среднее", "До 25", "Наклон и выпучивание стен и фундаментов в пределах этажа не более чем на 1/6 их толщины.", "Поверочный расчет несущей способности конструкций при временном усилие - установка дополнительных стоек, упоров, стяжек, расчалок." };
            string[] S4 = { "Среднее", "До 25", "Образование вертикальных трещин между продольными и поперечными стенами разрывы или выдергивание отдельных стальных связей и анкеров крепления стен к колоннам и перекрытиям.", "" };
            string[] S5 = { "Среднее", "До 25", "Местное (краевое) повреждение кладки на глубину до 2 см под опорами ферм, балок, прогонов и перемычек в виде трещин и лещадок, вериткальные трещины по концам опор, пересекающие не более двух рядов кладки.", "" };
            string[] S6 = { "Среднее", "До 25", "Смещение плит перекрытий на опорах не более 1/5 глубины заделки, но не более 2 см. Огневое повреждение при пожаре кладки армированных и неармированных стен и столбов на глубину до 2 см (без штукатурки).", "ТЕКСТ", "" };
            // Второй блок "Сильное"
            string[] S7 = { "Сильное", "до 50", "Большие обвалы в стеных", "Капитальное восстановление производится по проекту: при временном усилении - установка допольнительных стоек, упоров, расчалок, стяжек" };
            string[] S8 = { "Сильное", "до 50", "Размораживание и выветривание кладки на глубину до 40% толщины", "     " };
            string[] S9 = { "Сильное", "до 50", "Вертикальные и косые трещины ( исключеная температурные и осадочные) в несущих стенах и столбах на высоту не более восьми рядов кладки.", "     " };
            string[] S10 = { "Сильное", "до 50", "Наклон и выпучивание стен в пределах этажа на 1/3 их толщины и более.", "    " };
            string[] S11 = { "Сильное", "до 50", "Смещение (сдвиг) стен, столбов и фундаментов по горизонтальным швам или косой штрабе", "    " };
            string[] S12 = { "Сильное", "до 50", "Отрыв продольных стен от поперечных в местах и их пересечения, разрывы или выдергивание стальных связей и анкеров, крепящих стены к колоннам и перекрытиям.", "    " };
            string[] S13 = { "Сильное", "до 50", "Повреждение кладки под опорами ферм, балок и перемычек в виде трещин, раздробление камня или смещения рядов кладки по горизонтальным швам на глубину более 2 см, образование вертикальных или косых трещин, пересекающих до четырех рядов кладки.", "     " };
            string[] S14 = { "Сильное", "до 50", "Смещение плит перекрытий на опорах более 1/5 глубины заделки в стене", "        " };
            string[] S15 = { "Сильное", "до 50", "Огневое повреждение кладки стен и столбов при пожаре достигает 5 - 6 см.", "       " };
            // Третий блок "Полное"
            string[] S16 = { "Полное", "Свыше 50 или при полной потере несущей способности конструкции", "Разрушение отдаленных конструкций и частей здания.", "Конструкции подлежат разборке" };
            string[] S17 = { "Полное", "Свыше 50 или при полной потере несущей способности конструкции", "Размораживание и выветривание кладки на глубину 50% толщины стены и более", "Конструкции подлежат разборке" };


            // Console.WriteLine("Виды повреждения и рекомендации по временному усилию" + string[a]);



            addGridParam(S1, dataGridView4);
            addGridParam(S2, dataGridView4);
            addGridParam(S3, dataGridView4);
            addGridParam(S4, dataGridView4);
            addGridParam(S5, dataGridView4);
            addGridParam(S6, dataGridView4);
            addGridParam(S7, dataGridView4);
            addGridParam(S8, dataGridView4);
            addGridParam(S9, dataGridView4);
            addGridParam(S10, dataGridView4);
            addGridParam(S11, dataGridView4);
            addGridParam(S12, dataGridView4);
            addGridParam(S13, dataGridView4);
            addGridParam(S14, dataGridView4);
            addGridParam(S15, dataGridView4);
            addGridParam(S16, dataGridView4);
            addGridParam(S17, dataGridView4);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        public void addGridParam(string[] N, DataGridView Grid)      //Метод на добавление строк
        {
            while (N.Length > Grid.ColumnCount)
            {
                Grid.Columns.Add("", "");
            }
            Grid.Rows.Add(N);
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(61, 26, 1);
            panel2.BackColor = Color.FromArgb(61, 26, 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
