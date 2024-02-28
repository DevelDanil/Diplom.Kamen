using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection.Emit;

namespace Diplom
{
    public partial class Form8 : Form
    {

        public Form8()
        {
            InitializeComponent();

        }
        double mg = 1;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //mg = double.Parse(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double R = double.Parse(textBox3.Text);
        }


        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                return;
            }
            double a = double.Parse(textBox4.Text);
            if (a <= 0 || a >= 10000000)
            {
                MessageBox.Show("Введите корректное значение переменной a");
            }
            else
            {

            }



        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

            //double F = double.Parse(textBox2.Text);

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            double Nitog = Convert.ToDouble(textBox8.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            double Nitog = 1;

            if (textBox8.Text.Length > 0)
            {
                Nitog = Convert.ToDouble(textBox8.Text);

            }
            if (textBox4.Text.Length == 0)
            {
                return;
            }
            if (textBox10.Text.Length == 0)
            {
                return;
            }
            if (textBox3.Text.Length == 0)
            {
                return;
            }

            double fi = Convert.ToDouble(comboBox4.Text.Replace(".", ","));
            double mg = Convert.ToDouble(textBox1.Text.Replace(".", ","));
            //double F = Convert.ToDouble(textBox2.Text);
            double R = Convert.ToDouble(textBox3.Text.Replace(".", ","));
            double a = Convert.ToDouble(textBox4.Text.Replace(".", ",")) * Edinici.Razmer * Edinici.Razmer;
            double b = Convert.ToDouble(textBox10.Text.Replace(".", ","));


            textBox9.Text = (Convert.ToString("" + fi * (a * b) * R * Nitog / Edinici.RazmerOtvet * Edinici.RazmerOtvetkgtm));
            double per1 = Convert.ToDouble(textBox11.Text) / Edinici.RazmerOtvet;
            double per2 = Convert.ToDouble(textBox9.Text) / Edinici.RazmerOtvet;
            if (per1 > per2)
            {
                label18.Visible = true;
                label16.Visible = false;
            }
            else
            {
                label16.Visible = true;
                label18.Visible = false;
            }

            textBox12.Text = (Convert.ToString(per2 / per1 * 100));
            if (textBox9.TextLength == 0)
            {
                textBox4.BackColor = Color.Red;
                textBox10.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox8.BackColor = Color.Red;
                comboBox4.BackColor = Color.Red;
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double Ng = double.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double nu = double.Parse(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double N = double.Parse(textBox7.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                return;
            }
            if (textBox10.Text.Length == 0)
            {
                return;
            }
            double b = double.Parse(textBox10.Text);
            double h = Convert.ToDouble(textBox4.Text);
            if (b <= 0 || b >= 1000000000000)
            {
                MessageBox.Show("Введите корректное значение переменной b");
            }
            else
            {

            }
            textBox2.Text = (Convert.ToString(b * h));
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            double fi = double.Parse(comboBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Ng = Convert.ToDouble(textBox5.Text);
            double nu = Convert.ToDouble(textBox6.Text);
            double N = Convert.ToDouble(textBox7.Text);

            textBox8.Text = (Convert.ToString(1 - nu * Ng / N));
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                {
                    textBox8.Visible = true;
                    textBox1.Visible = false;
                    groupBox1.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label8.Visible = true;

                }
            }
            if (checkBox1.Checked == false)
            {
                {
                    textBox8.Visible = false;
                    textBox1.Visible = true;
                    groupBox1.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label8.Visible = false;
                }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            radioButton2.Visible = true;

            if (comboBox1.SelectedIndex == 0) // "марки кирпича или камня" из таблицы 6.1
            {
                comboBox2.Items.AddRange(new object[] { "300", "250", "200", "150", "125", "100", "75", "50", "35" });
            }
            else if (comboBox1.SelectedIndex == 1) // таблица 6.2
            {
                radioButton2.Visible = false;
                comboBox2.Items.AddRange(new object[] { "300", "250", "200", "150", "125", "100", "75", "50" });
            }

            else if (comboBox1.SelectedIndex == 2) // таблица 6.3 
            {
                radioButton2.Visible = true;
                comboBox2.Items.AddRange(new object[] { "B7,5", "B5", "B3,5", "B2,5", "B2", "B1,5" });
            }

            else if (comboBox1.SelectedIndex == 3) // таблица 6.4 
            {
                radioButton2.Visible = true;
                comboBox2.Items.AddRange(new object[] { "B80(1000)", "B62,5(800)", "B45(600)", "B40(500)", "B30(400)", "B22,5(300)", "B20(250)", "B15(200)", "B12(150)", "B7,5(100)", "B5(75)", "B4(50)", "B2,5(35)", "B2(25)" });
            }

            else if (comboBox1.SelectedIndex == 4) // таблица 6.5 
            {
                radioButton2.Visible = true;
                comboBox2.Items.AddRange(new object[] { "1000", "800", "600", "500", "400", "300", "200", "150", "100", "75", "50", "35", "25", "15" });
            }

            else if (comboBox1.SelectedIndex == 5) // таблица 6.6 
            {
                radioButton2.Visible = true;
                comboBox2.Items.AddRange(new object[] { "300", "200", "150", "125", "100", "75", "50", "35", "25", "15" });
            }
            else if (comboBox1.SelectedIndex == 6) // таблица 6.7 
            {
                radioButton2.Visible = false;
                comboBox2.Items.AddRange(new object[] { "300", "250", "200", "150", "125", "100", "75" });
            }

            else if (comboBox1.SelectedIndex == 7) // таблица 6.8 
            {
                radioButton2.Visible = true;
                comboBox2.Items.AddRange(new object[] { "25", "15", "10", "7" });
            }

            else if (comboBox1.SelectedIndex == 8) // таблица 6. 
            {
                radioButton2.Visible = true;
                comboBox2.Items.AddRange(new object[] { "10", "7", "4" });
            }

            else if (comboBox1.SelectedIndex == 9) // таблица 6.8 
            {
                radioButton2.Visible = true;
                comboBox2.Items.AddRange(new object[] { "1000", "800", "600", "500", "400", "300", "200", "150", "100", "50", "35", "25" });
            }

            else if (comboBox1.SelectedIndex == 10) // таблица 6.8 
            {
                radioButton2.Visible = false;
                comboBox2.Items.AddRange(new object[] { "200", "100", "50" });
            }

            else if (comboBox1.SelectedIndex == 11) // таблица 6.8 
            {
                radioButton2.Visible = true;
                comboBox2.Items.AddRange(new object[] { "Осевое напряжение по перевязанному сечению для камней правильной формы Rt", "Осевое напряжение по перевязонному сечению для камней правильной формы", "Осевое напряжение по перевязонному сечению для бутовой кладки", "Растяжение по неперевязонному сечению для кладки по косой штробе", "Растяжение по перевязонному сечению кладки из камней правильной формы", "Растяжение по перевязонному сечению для бутовой кладки", "В срез по неперязонному сечению для кладки всех видов", "В срез по перевязонному сечению для бутовой кладки" });
            }

            else if (comboBox1.SelectedIndex == 12) // таблица 6.8 
            {
                radioButton2.Visible = false;
                comboBox2.Items.AddRange(new object[] { "Осевое растяжение Rt", "Растяжение при изгибе и главные растягивающие напряжения Rtb(Rtw)", "Срез Rsq" });
            }

            else if (comboBox1.SelectedIndex == 13) // таблица 6.8 
            {
                radioButton2.Visible = false;
                comboBox2.Items.AddRange(new object[] { "Осевое растяжение и главные растягивающие напряжения Rt(Rtw)", "Растяжения при изгибе Rtb" });
            }

            comboBox2.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton1.Checked = true;
            comboBox3.SelectedIndex = 0;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();


            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedIndex == 0) // проверили что выбрана таблица 6.1
                    comboBox3.Items.AddRange(new object[] { "200", "150", "100", "75", "50", "25", "10", "4" });
                else if (comboBox1.SelectedIndex == 1) // таблица 6.2 и т.д.
                    comboBox3.Items.AddRange(new object[] { "200", "150", "100", "75", "50" });

                else if (comboBox1.SelectedIndex == 2) // проверили что выбрана таблица 6.3
                    comboBox3.Items.AddRange(new object[] { "100", "75", "50", "25", "10", "4" });

                else if (comboBox1.SelectedIndex == 3) // проверили что выбрана таблица 6.4
                    comboBox3.Items.AddRange(new object[] { "200", "150", "100", "75", "50", "25", "10" });

                else if (comboBox1.SelectedIndex == 4) // проверили что выбрана таблица 6.5
                    comboBox3.Items.AddRange(new object[] { "200", "150", "100", "75", "50", "25", "10", "4" });

                else if (comboBox1.SelectedIndex == 5) // проверили что выбрана таблица 6.6
                    comboBox3.Items.AddRange(new object[] { "100", "75", "50", "25", "10", "4" });

                else if (comboBox1.SelectedIndex == 6) // проверили что выбрана таблица 6.7
                    comboBox3.Items.AddRange(new object[] { "200", "150", "100", "75", "50" });

                else if (comboBox1.SelectedIndex == 7) // проверили что выбрана таблица 6.8
                    comboBox3.Items.AddRange(new object[] { "25", "10", "4" });

                else if (comboBox1.SelectedIndex == 8) // проверили что выбрана таблица 6.9
                    comboBox3.Items.AddRange(new object[] { "25", "10", "4" });

                else if (comboBox1.SelectedIndex == 9) // проверили что выбрана таблица 6.9
                    comboBox3.Items.AddRange(new object[] { "100", "75", "50", "25", "10", "4" });

                else if (comboBox1.SelectedIndex == 10) // проверили что выбрана таблица 6.9
                    comboBox3.Items.AddRange(new object[] { "B15", "B12,5", "B10", "B7,5", "B3,5", "B2,5" });

                else if (comboBox1.SelectedIndex == 11) // проверили что выбрана таблица 6.9
                    comboBox3.Items.AddRange(new object[] { "50", "25", "10", "4" });

                else if (comboBox1.SelectedIndex == 12) // проверили что выбрана таблица 6.9
                    comboBox3.Items.AddRange(new object[] { "200", "150", "100", "75", "50", "35", "25", "15", "10" });

                else if (comboBox1.SelectedIndex == 13) // проверили что выбрана таблица 6.9
                    comboBox3.Items.AddRange(new object[] { "B15", "B12,5", "B7,5", "B5", "B3,5", "B2,5" });

                if (comboBox3.Items.Count != 0) comboBox3.SelectedIndex = 0;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            if (radioButton2.Checked)
            {
                if (comboBox1.SelectedIndex == 0) // проверили что выбрана таблица 6.1
                    comboBox3.Items.AddRange(new object[] { "0,2", "нулевой" });
                //else if (comboBox1.SelectedIndex == 2) // у таблицы 6.2 прочности нет, поэтому здесь таблица 6.3 и т.д.
                else if (comboBox1.SelectedIndex == 2)
                    comboBox3.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox1.SelectedIndex == 3)
                    comboBox3.Items.AddRange(new object[] { "нулевой" });
                else if (comboBox1.SelectedIndex == 4)
                    comboBox3.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox1.SelectedIndex == 5)
                    comboBox3.Items.AddRange(new object[] { "0,2", "нулевой" });

                else if (comboBox1.SelectedIndex == 7)
                    comboBox3.Items.AddRange(new object[] { "0,2", "нулевой" });

                else if (comboBox1.SelectedIndex == 8)
                    comboBox3.Items.AddRange(new object[] { "0,2", "нулевой" });

                else if (comboBox1.SelectedIndex == 9)
                    comboBox3.Items.AddRange(new object[] { "0,2", "нулевой" });

                else if (comboBox1.SelectedIndex == 11)
                    comboBox3.Items.AddRange(new object[] { "0,2" });

                if (comboBox3.Items.Count != 0) comboBox3.SelectedIndex = 0;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox3.Text == "") return;

            if (comboBox1.SelectedIndex == 0) // проверили что выбрана таблица 6.1
            {
                if (comboBox2.Text == "300")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "3,9";
                        else if (comboBox3.Text == "150") textBox3.Text = "3,6";
                        else if (comboBox3.Text == "100") textBox3.Text = "3,3";
                        else if (comboBox3.Text == "75") textBox3.Text = "3,0";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "2,5";
                        else if (comboBox3.Text == "10") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,8";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "1,5";
                    }
                }
                else if (comboBox2.Text == "250")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "3,6";
                        else if (comboBox3.Text == "150") textBox3.Text = "3,3";
                        else if (comboBox3.Text == "100") textBox3.Text = "3,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,8";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,5";
                        else if (comboBox3.Text == "25") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,9";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,6";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "1,3";
                    }
                }
                else if (comboBox2.Text == "200")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "3,2";
                        else if (comboBox3.Text == "150") textBox3.Text = "3,0";
                        else if (comboBox3.Text == "100") textBox3.Text = "2,7";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,5";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,6";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,4";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "1,0";
                    }
                }
                else if (comboBox2.Text == "150")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "2,6";
                        else if (comboBox3.Text == "150") textBox3.Text = "2,4";
                        else if (comboBox3.Text == "100") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,2";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,8";
                    }
                }
                else if (comboBox2.Text == "125")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "150") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "100") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,9";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,2";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,1";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,7";
                    }
                }
                else if (comboBox2.Text == "100")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "150") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "100") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,9";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,6";
                    }
                }
                else if (comboBox2.Text == "75")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "150") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "100") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,7";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,6";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,5";
                    }
                }
                else if (comboBox2.Text == "50")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "150") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "100") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,6";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,5";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,35";
                    }
                }
                else if (comboBox2.Text == "35")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "150") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "100") textBox3.Text = "отсутствует";
                        else if (comboBox3.Text == "75") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,6";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,45";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,4";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,25";
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1) // таблица 6.2 и т.д.
            {
                {
                    if (comboBox2.Text == "300")
                    {
                        if (radioButton1.Checked) // значит ищем по маркам
                        {
                            if (comboBox3.Text == "200") textBox3.Text = "4,1";
                            else if (comboBox3.Text == "150") textBox3.Text = "3,8";
                            else if (comboBox3.Text == "100") textBox3.Text = "3,5";
                            else if (comboBox3.Text == "75") textBox3.Text = "3,2";
                            else if (comboBox3.Text == "50") textBox3.Text = "3,0";
                        }
                    }

                    else if (comboBox2.Text == "250")
                    {
                        if (radioButton1.Checked) // значит ищем по маркам
                        {
                            if (comboBox3.Text == "200") textBox3.Text = "3,7";
                            else if (comboBox3.Text == "150") textBox3.Text = "3,6";
                            else if (comboBox3.Text == "100") textBox3.Text = "3,2";
                            else if (comboBox3.Text == "75") textBox3.Text = "3,0";
                            else if (comboBox3.Text == "50") textBox3.Text = "2,7";

                        }
                    }
                    else if (comboBox2.Text == "200")
                    {
                        if (radioButton1.Checked) // значит ищем по маркам
                        {
                            if (comboBox3.Text == "200") textBox3.Text = "3,5";
                            else if (comboBox3.Text == "150") textBox3.Text = "3,2";
                            else if (comboBox3.Text == "100") textBox3.Text = "2,9";
                            else if (comboBox3.Text == "75") textBox3.Text = "2,7";
                            else if (comboBox3.Text == "50") textBox3.Text = "2,4";

                        }
                    }
                    else if (comboBox2.Text == "150")
                    {
                        if (radioButton1.Checked) // значит ищем по маркам
                        {
                            if (comboBox3.Text == "200") textBox3.Text = "2,8";
                            else if (comboBox3.Text == "150") textBox3.Text = "2,6";
                            else if (comboBox3.Text == "100") textBox3.Text = "2,4";
                            else if (comboBox3.Text == "75") textBox3.Text = "2,3";
                            else if (comboBox3.Text == "50") textBox3.Text = "2,2";

                        }
                    }
                    else if (comboBox2.Text == "125")
                    {
                        if (radioButton1.Checked) // значит ищем по маркам
                        {
                            if (comboBox3.Text == "200") textBox3.Text = "-";
                            else if (comboBox3.Text == "150") textBox3.Text = "2,5";
                            else if (comboBox3.Text == "100") textBox3.Text = "2,3";
                            else if (comboBox3.Text == "75") textBox3.Text = "2,2";
                            else if (comboBox3.Text == "50") textBox3.Text = "2,1";

                        }
                    }
                    else if (comboBox2.Text == "100")
                    {
                        if (radioButton1.Checked) // значит ищем по маркам
                        {
                            if (comboBox3.Text == "200") textBox3.Text = "-";
                            else if (comboBox3.Text == "150") textBox3.Text = "2,2";
                            else if (comboBox3.Text == "100") textBox3.Text = "2,0";
                            else if (comboBox3.Text == "75") textBox3.Text = "1,9";
                            else if (comboBox3.Text == "50") textBox3.Text = "1,8";

                        }
                    }
                    else if (comboBox2.Text == "75")
                    {
                        if (radioButton1.Checked) // значит ищем по маркам
                        {
                            if (comboBox3.Text == "200") textBox3.Text = "-";
                            else if (comboBox3.Text == "150") textBox3.Text = "-";
                            else if (comboBox3.Text == "100") textBox3.Text = "1,6";
                            else if (comboBox3.Text == "75") textBox3.Text = "1,5";
                            else if (comboBox3.Text == "50") textBox3.Text = "1,4";

                        }
                    }
                    else if (comboBox2.Text == "50")
                    {
                        if (radioButton1.Checked) // значит ищем по маркам
                        {
                            if (comboBox3.Text == "200") textBox3.Text = "-";
                            else if (comboBox3.Text == "150") textBox3.Text = "-";
                            else if (comboBox3.Text == "100") textBox3.Text = "-";
                            else if (comboBox3.Text == "75") textBox3.Text = "1,1";
                            else if (comboBox3.Text == "50") textBox3.Text = "1,0";

                        }
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 2) // таблица 6.2 и т.д.
            {
                if (comboBox2.Text == "B7,5")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "2,3";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,5";
                    }

                }
                else if (radioButton2.Checked) // значит ищем по прочности
                {
                    if (comboBox3.Text == "0,2") textBox3.Text = "1,3";
                    else if (comboBox3.Text == "нулевой") textBox3.Text = "1,0";
                }

                else if (comboBox2.Text == "B5")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "1,9";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,2";

                    }
                }
                else if (radioButton2.Checked) // значит ищем по прочности
                {
                    if (comboBox3.Text == "0,2") textBox3.Text = "1,1";
                    else if (comboBox3.Text == "нулевой") textBox3.Text = "0,8";
                }

                else if (comboBox2.Text == "B3,5")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,2";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,9";

                    }
                }
                else if (radioButton2.Checked) // значит ищем по прочности
                {
                    if (comboBox3.Text == "0,2") textBox3.Text = "0,8";
                    else if (comboBox3.Text == "нулевой") textBox3.Text = "0,6";
                }

                else if (comboBox2.Text == "B2,5")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,95";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,85";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,7";

                    }
                }
                else if (radioButton2.Checked) // значит ищем по прочности
                {
                    if (comboBox3.Text == "0,2") textBox3.Text = "0,6";
                    else if (comboBox3.Text == "нулевой") textBox3.Text = "0,45";
                }

                else if (comboBox2.Text == "B2")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,75";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,65";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,55";

                    }
                }
                else if (radioButton2.Checked) // значит ищем по прочности
                {
                    if (comboBox3.Text == "0,2") textBox3.Text = "0,5";
                    else if (comboBox3.Text == "нулевой") textBox3.Text = "0,35";
                }

                else if (comboBox2.Text == "B1,5")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,6";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,56";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,49";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,41";

                    }
                }
                else if (radioButton2.Checked) // значит ищем по прочности
                {
                    if (comboBox3.Text == "0,2") textBox3.Text = "0,38";
                    else if (comboBox3.Text == "нулевой") textBox3.Text = "0,26";
                }

            }

            if (comboBox1.SelectedIndex == 3) // проверили что выбрана таблица 6.4
            {
                if (comboBox2.Text == "B80(1000)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "17,9";
                        else if (comboBox3.Text == "150") textBox3.Text = "17,5";
                        else if (comboBox3.Text == "100") textBox3.Text = "17,1";
                        else if (comboBox3.Text == "75") textBox3.Text = "16,8";
                        else if (comboBox3.Text == "50") textBox3.Text = "16,5";
                        else if (comboBox3.Text == "25") textBox3.Text = "15,8";
                        else if (comboBox3.Text == "10") textBox3.Text = "14,5";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "11,3";
                    }
                }


                else if (comboBox2.Text == "B62,5(800)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "15,2";
                        else if (comboBox3.Text == "150") textBox3.Text = "14,8";
                        else if (comboBox3.Text == "100") textBox3.Text = "14,4";
                        else if (comboBox3.Text == "75") textBox3.Text = "14,1";
                        else if (comboBox3.Text == "50") textBox3.Text = "13,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "13,3";
                        else if (comboBox3.Text == "10") textBox3.Text = "12,3";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "9,4";
                    }
                }


                else if (comboBox2.Text == "B45(600)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "12,8";
                        else if (comboBox3.Text == "150") textBox3.Text = "12,4";
                        else if (comboBox3.Text == "100") textBox3.Text = "12,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "11,7";
                        else if (comboBox3.Text == "50") textBox3.Text = "11,4";
                        else if (comboBox3.Text == "25") textBox3.Text = "10,9";
                        else if (comboBox3.Text == "10") textBox3.Text = "9,9";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "7,3";
                    }
                }


                else if (comboBox2.Text == "B40(500)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "11,1";
                        else if (comboBox3.Text == "150") textBox3.Text = "10,7";
                        else if (comboBox3.Text == "100") textBox3.Text = "10,3";
                        else if (comboBox3.Text == "75") textBox3.Text = "10,1";
                        else if (comboBox3.Text == "50") textBox3.Text = "9,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "9,3";
                        else if (comboBox3.Text == "10") textBox3.Text = "8,7";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "6,3";
                    }
                }


                else if (comboBox2.Text == "B30(400)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "9,3";
                        else if (comboBox3.Text == "150") textBox3.Text = "9,0";
                        else if (comboBox3.Text == "100") textBox3.Text = "8,7";
                        else if (comboBox3.Text == "75") textBox3.Text = "8,4";
                        else if (comboBox3.Text == "50") textBox3.Text = "8,2";
                        else if (comboBox3.Text == "25") textBox3.Text = "7,7";
                        else if (comboBox3.Text == "10") textBox3.Text = "7,4";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "5,3";
                    }
                }


                else if (comboBox2.Text == "B22,5(300)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "7,5";
                        else if (comboBox3.Text == "150") textBox3.Text = "7,2";
                        else if (comboBox3.Text == "100") textBox3.Text = "6,9";
                        else if (comboBox3.Text == "75") textBox3.Text = "6,7";
                        else if (comboBox3.Text == "50") textBox3.Text = "6,5";
                        else if (comboBox3.Text == "25") textBox3.Text = "6,2";
                        else if (comboBox3.Text == "10") textBox3.Text = "5,7";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "4,4";
                    }
                }


                else if (comboBox2.Text == "B20(250)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "6,7";
                        else if (comboBox3.Text == "150") textBox3.Text = "6,4";
                        else if (comboBox3.Text == "100") textBox3.Text = "6,1";
                        else if (comboBox3.Text == "75") textBox3.Text = "5,9";
                        else if (comboBox3.Text == "50") textBox3.Text = "5,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "5,4";
                        else if (comboBox3.Text == "10") textBox3.Text = "4,9";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "3,8";
                    }
                }


                else if (comboBox2.Text == "B15(200)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "5,4";
                        else if (comboBox3.Text == "150") textBox3.Text = "5,2";
                        else if (comboBox3.Text == "100") textBox3.Text = "5,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "4,9";
                        else if (comboBox3.Text == "50") textBox3.Text = "4,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "4,3";
                        else if (comboBox3.Text == "10") textBox3.Text = "4,0";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "3,0";
                    }
                }


                else if (comboBox2.Text == "B12(150)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "4,6";
                        else if (comboBox3.Text == "150") textBox3.Text = "4,4";
                        else if (comboBox3.Text == "100") textBox3.Text = "4,2";
                        else if (comboBox3.Text == "75") textBox3.Text = "4,1";
                        else if (comboBox3.Text == "50") textBox3.Text = "3,9";
                        else if (comboBox3.Text == "25") textBox3.Text = "3,7";
                        else if (comboBox3.Text == "10") textBox3.Text = "3,4";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "2,4";
                    }
                }


                else if (comboBox2.Text == "B7,5(100)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "3,3";
                        else if (comboBox3.Text == "100") textBox3.Text = "3,1";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,9";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "2,6";
                        else if (comboBox3.Text == "10") textBox3.Text = "2,4";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "1,7";
                    }
                }


                else if (comboBox2.Text == "B5(75)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "2,3";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,1";
                        else if (comboBox3.Text == "25") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,8";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "1,3";
                    }
                }


                else if (comboBox2.Text == "B4(50)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,6";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,2";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "0,85";
                    }
                }


                else if (comboBox2.Text == "B2,5(35)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,9";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "0,6";
                    }
                }


                else if (comboBox2.Text == "B2(25)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,7";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "нулевой") textBox3.Text = "0,5";
                    }
                }

            }
            if (comboBox1.SelectedIndex == 4)
            {
                if (comboBox2.Text == "1000")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "13,0";
                        else if (comboBox3.Text == "150") textBox3.Text = "12,5";
                        else if (comboBox3.Text == "100") textBox3.Text = "12,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "11,5";
                        else if (comboBox3.Text == "50") textBox3.Text = "11,0";
                        else if (comboBox3.Text == "25") textBox3.Text = "10,5";
                        else if (comboBox3.Text == "10") textBox3.Text = "9,5";
                        else if (comboBox3.Text == "4") textBox3.Text = "8,5";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "8,3";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "8,0";
                    }
                }


                else if (comboBox2.Text == "800")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "11,0";
                        else if (comboBox3.Text == "150") textBox3.Text = "10,5";
                        else if (comboBox3.Text == "100") textBox3.Text = "10,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "9,5";
                        else if (comboBox3.Text == "50") textBox3.Text = "9,0";
                        else if (comboBox3.Text == "25") textBox3.Text = "8,5";
                        else if (comboBox3.Text == "10") textBox3.Text = "8,0";
                        else if (comboBox3.Text == "4") textBox3.Text = "7,0";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "6,8";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "6,5";
                    }
                }


                else if (comboBox2.Text == "600")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "9,0";
                        else if (comboBox3.Text == "150") textBox3.Text = "8,5";
                        else if (comboBox3.Text == "100") textBox3.Text = "8,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "7,8";
                        else if (comboBox3.Text == "50") textBox3.Text = "7,5";
                        else if (comboBox3.Text == "25") textBox3.Text = "7,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "6,0";
                        else if (comboBox3.Text == "4") textBox3.Text = "5,5";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "5,3";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "5,0";
                    }
                }



                else if (comboBox2.Text == "500")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "7,8";
                        else if (comboBox3.Text == "150") textBox3.Text = "7,3";
                        else if (comboBox3.Text == "100") textBox3.Text = "6,9";
                        else if (comboBox3.Text == "75") textBox3.Text = "6,7";
                        else if (comboBox3.Text == "50") textBox3.Text = "6,4";
                        else if (comboBox3.Text == "25") textBox3.Text = "6,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "5,3";
                        else if (comboBox3.Text == "4") textBox3.Text = "4,8";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "4,6";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "4,3";
                    }
                }


                else if (comboBox2.Text == "400")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "6,5";
                        else if (comboBox3.Text == "150") textBox3.Text = "6,0";
                        else if (comboBox3.Text == "100") textBox3.Text = "5,8";
                        else if (comboBox3.Text == "75") textBox3.Text = "5,5";
                        else if (comboBox3.Text == "50") textBox3.Text = "5,3";
                        else if (comboBox3.Text == "25") textBox3.Text = "5,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "4,5";
                        else if (comboBox3.Text == "4") textBox3.Text = "4,0";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "3,8";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "3,5";
                    }
                }


                else if (comboBox2.Text == "300")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "5,8";
                        else if (comboBox3.Text == "150") textBox3.Text = "4,9";
                        else if (comboBox3.Text == "100") textBox3.Text = "4,7";
                        else if (comboBox3.Text == "75") textBox3.Text = "4,5";
                        else if (comboBox3.Text == "50") textBox3.Text = "4,3";
                        else if (comboBox3.Text == "25") textBox3.Text = "4,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "3,7";
                        else if (comboBox3.Text == "4") textBox3.Text = "3,3";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "3,1";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "2,8";
                    }
                }


                else if (comboBox2.Text == "200")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "4,0";
                        else if (comboBox3.Text == "150") textBox3.Text = "3,8";
                        else if (comboBox3.Text == "100") textBox3.Text = "3,6";
                        else if (comboBox3.Text == "75") textBox3.Text = "3,5";
                        else if (comboBox3.Text == "50") textBox3.Text = "3,3";
                        else if (comboBox3.Text == "25") textBox3.Text = "3,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "2,8";
                        else if (comboBox3.Text == "4") textBox3.Text = "2,5";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "2,3";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "2,0";
                    }
                }


                else if (comboBox2.Text == "150")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "3,3";
                        else if (comboBox3.Text == "150") textBox3.Text = "3,1";
                        else if (comboBox3.Text == "100") textBox3.Text = "2,9";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,8";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,6";
                        else if (comboBox3.Text == "25") textBox3.Text = "2,4";
                        else if (comboBox3.Text == "10") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "4") textBox3.Text = "2,0";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "1,5";
                    }
                }


                else if (comboBox2.Text == "100")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "2,5";
                        else if (comboBox3.Text == "150") textBox3.Text = "2,4";
                        else if (comboBox3.Text == "100") textBox3.Text = "2,3";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,5";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "1,0";
                    }
                }


                else if (comboBox2.Text == "75")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "1,9";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,2";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,8";
                    }
                }


                else if (comboBox2.Text == "50")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,2";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,9";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,6";
                    }
                }


                else if (comboBox2.Text == "35")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,95";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,85";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,7";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,6";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,45";
                    }
                }


                else if (comboBox2.Text == "25")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,75";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,65";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,55";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,5";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,35";
                    }
                }


                else if (comboBox2.Text == "15")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "-";
                        else if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "-";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,5";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,45";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,38";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,35";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,25";
                    }
                }

            }
            if (comboBox1.SelectedIndex == 5)
            {
                if (comboBox2.Text == "300")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "4,6";
                        else if (comboBox3.Text == "75") textBox3.Text = "4,4";
                        else if (comboBox3.Text == "50") textBox3.Text = "4,2";
                        else if (comboBox3.Text == "25") textBox3.Text = "3,9";
                        else if (comboBox3.Text == "10") textBox3.Text = "3,6";
                        else if (comboBox3.Text == "4") textBox3.Text = "3,2";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "3,0";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "2,7";
                    }
                }


                else if (comboBox2.Text == "200")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "3,4";
                        else if (comboBox3.Text == "75") textBox3.Text = "3,3";
                        else if (comboBox3.Text == "50") textBox3.Text = "3,0";
                        else if (comboBox3.Text == "25") textBox3.Text = "2,9";
                        else if (comboBox3.Text == "10") textBox3.Text = "2,6";
                        else if (comboBox3.Text == "4") textBox3.Text = "2,4";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "2,1";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "1,7";
                    }
                }


                else if (comboBox2.Text == "150")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "2,7";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,6";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,4";
                        else if (comboBox3.Text == "25") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "10") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,8";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "1,3";
                    }
                }


                else if (comboBox2.Text == "125")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "2,4";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,3";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,1";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,9";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,6";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "1,1";
                    }
                }


                else if (comboBox2.Text == "100")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,6";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,3";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,9";
                    }
                }


                else if (comboBox2.Text == "75")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "1,6";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "10") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "4") textBox3.Text = "1,0";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,7";
                    }
                }


                else if (comboBox2.Text == "50")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "1,2";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,15";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,8";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,5";
                    }
                }


                else if (comboBox2.Text == "35")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,6";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,55";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,4";
                    }
                }


                else if (comboBox2.Text == "25")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,65";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,55";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,5";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,45";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,3";
                    }
                }


                else if (comboBox2.Text == "15")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "-";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,45";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,4";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,35";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,3";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,2";
                    }
                }

            }
            if (comboBox1.SelectedIndex == 6)
            {
                if (comboBox2.Text == "300")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "5,6";
                        else if (comboBox3.Text == "150") textBox3.Text = "5,3";
                        else if (comboBox3.Text == "100") textBox3.Text = "4,8";
                        else if (comboBox3.Text == "75") textBox3.Text = "4,5";
                        else if (comboBox3.Text == "50") textBox3.Text = "4,2";

                    }

                }

                else if (comboBox2.Text == "250")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "5,2";
                        else if (comboBox3.Text == "150") textBox3.Text = "4,9";
                        else if (comboBox3.Text == "100") textBox3.Text = "4,4";
                        else if (comboBox3.Text == "75") textBox3.Text = "4,1";
                        else if (comboBox3.Text == "50") textBox3.Text = "3,7";

                    }

                }

                else if (comboBox2.Text == "200")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "4,8";
                        else if (comboBox3.Text == "150") textBox3.Text = "4,5";
                        else if (comboBox3.Text == "100") textBox3.Text = "4,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "3,6";
                        else if (comboBox3.Text == "50") textBox3.Text = "3,3";

                    }

                }

                else if (comboBox2.Text == "150")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "4,0";
                        else if (comboBox3.Text == "150") textBox3.Text = "3,7";
                        else if (comboBox3.Text == "100") textBox3.Text = "3,3";
                        else if (comboBox3.Text == "75") textBox3.Text = "3,1";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,7";

                    }

                }

                else if (comboBox2.Text == "125")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "3,6";
                        else if (comboBox3.Text == "150") textBox3.Text = "3,3";
                        else if (comboBox3.Text == "100") textBox3.Text = "3,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,9";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,5";

                    }

                }

                else if (comboBox2.Text == "100")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "3,1";
                        else if (comboBox3.Text == "150") textBox3.Text = "2,9";
                        else if (comboBox3.Text == "100") textBox3.Text = "2,7";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,6";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,3";

                    }

                }

                else if (comboBox2.Text == "75")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "-";
                        else if (comboBox3.Text == "150") textBox3.Text = "2,5";
                        else if (comboBox3.Text == "100") textBox3.Text = "2,3";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "50") textBox3.Text = "2,0";

                    }

                }
            }
            if (comboBox1.SelectedIndex == 7)
            {
                if (comboBox2.Text == "25")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "25") textBox3.Text = "0,6";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,45";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,35";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,3";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,2";
                    }
                }



                else if (comboBox2.Text == "15")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "25") textBox3.Text = "0,4";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,35";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,25";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,13";
                    }
                }



                else if (comboBox2.Text == "10")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "25") textBox3.Text = "0,3";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,2";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,18";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,1";
                    }
                }



                else if (comboBox2.Text == "7")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "25") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,18";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,15";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,07";
                    }
                }
            }

            if (comboBox1.SelectedIndex == 8)
            {
                if (comboBox2.Text == "10")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "25") textBox3.Text = "0,38";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,33";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,28";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,2";
                    }
                }



                else if (comboBox2.Text == "7")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "25") textBox3.Text = "0,28";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,23";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,12";
                    }
                }



                else if (comboBox2.Text == "4")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "25") textBox3.Text = "-";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,15";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,14";
                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,12";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,08";
                    }

                }
            }
            if (comboBox1.SelectedIndex == 9)
            {
                if (comboBox2.Text == "1000")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "2,5";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,2";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,5";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,4";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,33";
                    }
                }



                else if (comboBox2.Text == "800")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "75") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,6";
                        else if (comboBox3.Text == "25") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,45";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,33";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,28";
                    }
                }



                else if (comboBox2.Text == "600")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,65";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,4";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,3";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,22";
                    }
                }


                else if (comboBox2.Text == "500")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,4";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,85";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,6";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,38";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,27";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,18";
                    }
                }



                else if (comboBox2.Text == "400")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "1,5";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "50") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,55";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,33";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,23";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,15";
                    }
                }



                else if (comboBox2.Text == "300")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "1,3";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,15";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,95";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,5";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,3";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,12";
                    }
                }



                else if (comboBox2.Text == "200")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "1,1";
                        else if (comboBox3.Text == "75") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,6";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,45";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,28";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,18";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,08";
                    }
                }



                else if (comboBox2.Text == "150")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "0,9";
                        else if (comboBox3.Text == "75") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,55";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,4";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,25";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,17";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,07";
                    }
                }



                else if (comboBox2.Text == "100")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "0,75";
                        else if (comboBox3.Text == "75") textBox3.Text = "0,7";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,6";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,5";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,35";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,23";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,15";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,05";
                    }
                }



                else if (comboBox2.Text == "50")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,45";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,35";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,2";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,13";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,03";
                    }
                }



                else if (comboBox2.Text == "35")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,36";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,29";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,22";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,18";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,12";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,02";
                    }
                }



                else if (comboBox2.Text == "25")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "100") textBox3.Text = "-";
                        else if (comboBox3.Text == "75") textBox3.Text = "-";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,3";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,15";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,1";
                        else if (comboBox3.Text == "нулевой") textBox3.Text = "0,02";
                    }
                }

            }

            if (comboBox1.SelectedIndex == 10)
            {
                if (comboBox2.Text == "200")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "B15") textBox3.Text = "4";
                        else if (comboBox3.Text == "B12,5") textBox3.Text = "3,5";
                        else if (comboBox3.Text == "B10") textBox3.Text = "3";
                        else if (comboBox3.Text == "B7,5") textBox3.Text = "2,5";
                        else if (comboBox3.Text == "B3,5") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "B2,5") textBox3.Text = "1,7";

                    }

                }

                else if (comboBox2.Text == "100")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "B15") textBox3.Text = "-";
                        else if (comboBox3.Text == "B12,5") textBox3.Text = "-";
                        else if (comboBox3.Text == "B10") textBox3.Text = "-";
                        else if (comboBox3.Text == "B7,5") textBox3.Text = "2,2";
                        else if (comboBox3.Text == "B3,5") textBox3.Text = "1,8";
                        else if (comboBox3.Text == "B2,5") textBox3.Text = "1,5";

                    }

                }

                else if (comboBox2.Text == "50")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "B15") textBox3.Text = "-";
                        else if (comboBox3.Text == "B12,5") textBox3.Text = "-";
                        else if (comboBox3.Text == "B10") textBox3.Text = "-";
                        else if (comboBox3.Text == "B7,5") textBox3.Text = "2,0";
                        else if (comboBox3.Text == "B3,5") textBox3.Text = "1,7";
                        else if (comboBox3.Text == "B2,5") textBox3.Text = "1,3";

                    }

                }
            }

            if (comboBox1.SelectedIndex == 11)
            {
                if (comboBox2.Text == "Осевое напряжение по перевязанному сечению для камней правильной формы Rt")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "50") textBox3.Text = "0,08";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,05";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,03";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,01";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,005";

                    }
                }



                else if (comboBox2.Text == "Осевое напряжение по перевязонному сечению для камней правильной формы")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "50") textBox3.Text = "0,16";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,11";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,05";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,02";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,001";

                    }
                }



                else if (comboBox2.Text == "Осевое напряжение по перевязонному сечению для бутовой кладки")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "50") textBox3.Text = "0,12";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,08";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,04";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,02";

                    }

                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,001";

                    }
                }


                else if (comboBox2.Text == "Растяжение по неперевязонному сечению для кладки по косой штробе")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "50") textBox3.Text = "0,12";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,08";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,04";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,02";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,001";

                    }
                }





                else if (comboBox2.Text == "Растяжение по перевязонному сечению кладки из камней правильной формы")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "50") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,16";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,08";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,04";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,002";

                    }
                }



                else if (comboBox2.Text == "Растяжение по перевязонному сечению для бутовой кладки")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "50") textBox3.Text = "0,18";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,12";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,06";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,03";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,0015";

                    }
                }




                else if (comboBox2.Text == "В срез по неперязонному сечению для кладки всех видов")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "50") textBox3.Text = "0,16";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,11";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,05";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,02";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,001";

                    }
                }




                else if (comboBox2.Text == "В срез по перевязонному сечению для бутовой кладки")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "50") textBox3.Text = "0,24";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,16";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,08";
                        else if (comboBox3.Text == "4") textBox3.Text = "0,04";

                    }
                    else if (radioButton2.Checked) // значит ищем по прочности
                    {
                        if (comboBox3.Text == "0,2") textBox3.Text = "0,002";

                    }
                }

            }

            if (comboBox1.SelectedIndex == 12)
            {
                if (comboBox2.Text == "Осевое растяжение Rt")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "150") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "100") textBox3.Text = "0,18";
                        else if (comboBox3.Text == "75") textBox3.Text = "0,13";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,1";
                        else if (comboBox3.Text == "35") textBox3.Text = "0,08";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,06";
                        else if (comboBox3.Text == "15") textBox3.Text = "0,05";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,03";
                    }

                }

                else if (comboBox2.Text == "Растяжение при изгибе и главные растягивающие напряжения Rtb(Rtw)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "0,4";
                        else if (comboBox3.Text == "150") textBox3.Text = "0,3";
                        else if (comboBox3.Text == "100") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "75") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,16";
                        else if (comboBox3.Text == "35") textBox3.Text = "0,12";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,1";
                        else if (comboBox3.Text == "15") textBox3.Text = "0,07";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,05";
                    }

                }

                else if (comboBox2.Text == "Срез Rsq")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "200") textBox3.Text = "1,0";
                        else if (comboBox3.Text == "150") textBox3.Text = "0,8";
                        else if (comboBox3.Text == "100") textBox3.Text = "0,65";
                        else if (comboBox3.Text == "75") textBox3.Text = "0,55";
                        else if (comboBox3.Text == "50") textBox3.Text = "0,4";
                        else if (comboBox3.Text == "35") textBox3.Text = "0,3";
                        else if (comboBox3.Text == "25") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "15") textBox3.Text = "0,14";
                        else if (comboBox3.Text == "10") textBox3.Text = "0,09";
                    }

                }
            }

            if (comboBox1.SelectedIndex == 13)
            {
                if (comboBox2.Text == "Осевое растяжение и главные растягивающие напряжения Rt(Rtw)")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "B15") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "B12,5") textBox3.Text = "0,18";
                        else if (comboBox3.Text == "B7,5") textBox3.Text = "0,16";
                        else if (comboBox3.Text == "B5") textBox3.Text = "0,14";
                        else if (comboBox3.Text == "B3,5") textBox3.Text = "0,12";
                        else if (comboBox3.Text == "B2,5") textBox3.Text = "0,1";
                    }

                }

                else if (comboBox2.Text == "Растяжения при изгибе Rtb")
                {
                    if (radioButton1.Checked) // значит ищем по маркам
                    {
                        if (comboBox3.Text == "B15") textBox3.Text = "0,27";
                        else if (comboBox3.Text == "B12,5") textBox3.Text = "0,25";
                        else if (comboBox3.Text == "B7,5") textBox3.Text = "0,23";
                        else if (comboBox3.Text == "B5") textBox3.Text = "0,2";
                        else if (comboBox3.Text == "B3,5") textBox3.Text = "0,18";
                        else if (comboBox3.Text == "B2,5") textBox3.Text = "0,16";
                    }

                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "") comboBox3_SelectedIndexChanged(sender, e);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }



        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            object missing = Type.Missing;
            var wdApp = new Word.Application();
            wdApp.Visible = true;
            var wdDoc = wdApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            Word.Paragraph para = wdDoc.Paragraphs.Add(ref missing);

            para.Range.Text = "                                            Расчет центрально сжатых столбов";
            para.Range.InsertParagraphAfter();

            para.Range.Text = "   ";
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Считается по формуле N >= mg * φ * R * A";
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Вы ввели значение коэффициента ф " + comboBox4.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Две стороны столба (h b) " + textBox4.Text + textBox10.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Далее выбрали материал кладки " + comboBox1.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Марку камня " + comboBox2.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Марку раствора " + comboBox3.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Действующей нагрузки на столб = " + textBox11.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Расчетная несущая способность = " + textBox9.Text;
            para.Range.InsertParagraphAfter();

        }
        private void Form8_Load(object sender, EventArgs e)
        {
            label10.Text = Edinici.Textavse;
            label12.Text = Edinici.Textavse;
            label19.Text = Edinici.Textavse;
            label22.Text = Edinici.TextavseOtvet;
            label23.Text = Edinici.TextavseOtvet;

            panel1.BackColor = Color.FromArgb(61, 26, 1);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

