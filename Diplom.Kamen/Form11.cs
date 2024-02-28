using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            label23.Text = Edinici.Textavse;
            label24.Text = Edinici.Textavse;
            label48.Text = Edinici.Textavse;
            label28.Text = Edinici.Textavse;
            label25.Text = Edinici.Textavse;
            label42.Text = Edinici.Textavse;
            label46.Text = Edinici.Textavse;
            label47.Text = Edinici.Textavse;
            label26.Text = Edinici.TextavseOtvet;
            label35.Text = Edinici.TextavseOtvet;

            panel1.BackColor = Color.FromArgb(61, 26, 1);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            {
                return;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                return;
            }
            if (textBox5.Text.Length == 0)
            {
                return;
            }
            double b = double.Parse(textBox4.Text) * Edinici.Razmer;
            double h = Convert.ToDouble(textBox5.Text);
            textBox6.Text = (Convert.ToString(b * h));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (textBox5.Text.Length == 0)
            {
                return;
            }
            if (textBox4.Text.Length == 0)
            {
                return;
            }

            double h = double.Parse(textBox5.Text) * Edinici.Razmer;
            textBox7.Text = (Convert.ToString(h - 2));
            double b = Convert.ToDouble(textBox4.Text);
            textBox6.Text = (Convert.ToString(b * h * Edinici.Razmer));
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            if (textBox5.Text.Length == 0)
            {
                return;
            }
            if (textBox6.Text.Length == 0)
            {
                return;
            }

            double h = Convert.ToDouble(textBox5.Text);
            double A = Convert.ToDouble(textBox6.Text);

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text.Length == 0)
            {
                return;
            }
            double f = Convert.ToDouble(textBox14.Text);
            textBox19.Text = (Convert.ToString((f + 1) / 2));
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == 0)
            {
                return;
            }
            if (textBox5.Text.Length == 0)
            {
                return;
            }
            double b = Convert.ToDouble(textBox5.Text);
            double H = double.Parse(textBox9.Text) / Edinici.Razmer;
            textBox8.Text = (Convert.ToString(((b / 3.4641016151378) + (H / 3.4641016151378)) / 2));    //3.4641016151378

            if (textBox8.Text.Length == 0)
            {
                return;
            }
            if (textBox7.Text.Length == 0)
            {
                return;
            }

            double ic = Convert.ToDouble(textBox8.Text);
            double hc = Convert.ToDouble(textBox7.Text);


            textBox10.Text = (Convert.ToString(H / hc));
            textBox11.Text = (Convert.ToString(H / ic));
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 0)
            {
                return;
            }
            double ic = double.Parse(textBox8.Text);
            if (textBox9.Text.Length == 0)
            {
                return;
            }

            if (textBox8.Text.Length == 0)
            {
                return;
            }
            if (textBox7.Text.Length == 0)
            {
                return;
            }


            double hc = Convert.ToDouble(textBox7.Text);
            double H = double.Parse(textBox9.Text);
            textBox10.Text = (Convert.ToString(H / hc));
            textBox11.Text = (Convert.ToString(H / ic));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {

                double h = Convert.ToDouble(textBox5.Text);

            }
            else textBox15.Text = (Convert.ToString("1"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {

                double h = Convert.ToDouble(textBox5.Text);

            }
            else textBox15.Text = (Convert.ToString("1"));
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.AddRange(new object[] { "Из крупных блоков, изготовленных из тяжелого и крупнопористого бетона на тяжелых заполнителях и из тяжелого природного камня (λ >= 1800 кг/м3)", "Из камней, изготовленных из тяжелого бетона, тяжелых природных камней и бута", "Из крупных блоков, изготовленных из бетона на пористых заполнителях и поризонного крупнопористого бетона", "Из крупных блоков из ячистых бетонов автоклавных", "Из крупных блоков из ячистых бетонов неавтоклавных", "Из камней, изготовленных из ячеистых бетонов автоклавных", "Из камней, изготовленных из ячеистых бетонов неавтоклавных", "Из камней, изготовленных из ячеистых бетонов автоклавных", "Из керамических камней (кроме крупноформатных)", "Из кирпича керамического пластического прессования полнотелого и пустотелого, из пустотелых силикатных камней, из камней, изготовленных из бетона на пористых заполнителях и оризованного, из легких природных камней", "Из кирпича силикатного полнотелого и пустотелого", "Из кирпича керамического полусухого прессования полнотелого и пустотелого" });

            radioButton3.Checked = false;
            radioButton3.Checked = true;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                if (comboBox4.Text == "Из крупных блоков, изготовленных из тяжелого и крупнопористого бетона на тяжелых заполнителях и из тяжелого природного камня (λ >= 1800 кг/м3)")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "1500";
                        else if (comboBox5.Text == "10") textBox12.Text = "1000";
                        else if (comboBox5.Text == "4") textBox12.Text = "750";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "750";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "500";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 1)
            {
                if (comboBox4.Text == "Из камней, изготовленных из тяжелого бетона, тяжелых природных камней и бута")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "1500";
                        else if (comboBox5.Text == "10") textBox12.Text = "1000";
                        else if (comboBox5.Text == "4") textBox12.Text = "750";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "500";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "350";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 2)
            {
                if (comboBox4.Text == "Из крупных блоков, изготовленных из бетона на пористых заполнителях и поризонного крупнопористого бетона")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "1000";
                        else if (comboBox5.Text == "10") textBox12.Text = "750";
                        else if (comboBox5.Text == "4") textBox12.Text = "500";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "500";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "350";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 3)
            {
                if (comboBox4.Text == "Из крупных блоков из ячистых бетонов автоклавных")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "750";
                        else if (comboBox5.Text == "10") textBox12.Text = "750";
                        else if (comboBox5.Text == "4") textBox12.Text = "500";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "500";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "350";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 4)
            {
                if (comboBox4.Text == "Из крупных блоков из ячистых бетонов неавтоклавных")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "500";
                        else if (comboBox5.Text == "10") textBox12.Text = "500";
                        else if (comboBox5.Text == "4") textBox12.Text = "350";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "350";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "350";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 5)
            {
                if (comboBox4.Text == "Из камней, изготовленных из ячеистых бетонов автоклавных")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "750";
                        else if (comboBox5.Text == "10") textBox12.Text = "500";
                        else if (comboBox5.Text == "4") textBox12.Text = "350";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "350";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "200";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 6)
            {
                if (comboBox4.Text == "Из камней, изготовленных из ячеистых бетонов неавтоклавных")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "500";
                        else if (comboBox5.Text == "10") textBox12.Text = "350";
                        else if (comboBox5.Text == "4") textBox12.Text = "200";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "200";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "200";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 7)
            {
                if (comboBox4.Text == "Из керамических камней (кроме крупноформатных)")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "1200";
                        else if (comboBox5.Text == "10") textBox12.Text = "1000";
                        else if (comboBox5.Text == "4") textBox12.Text = "750";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "500";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "350";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 8)
            {
                if (comboBox4.Text == "Из кирпича керамического пластического прессования полнотелого и пустотелого, из пустотелых силикатных камней, из камней, изготовленных из бетона на пористых заполнителях и оризованного, из легких природных камней")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "1000";
                        else if (comboBox5.Text == "10") textBox12.Text = "750";
                        else if (comboBox5.Text == "4") textBox12.Text = "500";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "350";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "200";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 9)
            {
                if (comboBox4.Text == "Из кирпича силикатного полнотелого и пустотелого")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "750";
                        else if (comboBox5.Text == "10") textBox12.Text = "500";
                        else if (comboBox5.Text == "4") textBox12.Text = "350";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "350";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "200";
                    }
                }

            }
            else if (comboBox4.SelectedIndex == 10)
            {
                if (comboBox4.Text == "Из кирпича керамического полусухого прессования полнотелого и пустотелого")
                {
                    if (radioButton3.Checked)
                    {
                        if (comboBox5.Text == "25-200") textBox12.Text = "500";
                        else if (comboBox5.Text == "10") textBox12.Text = "500";
                        else if (comboBox5.Text == "4") textBox12.Text = "350";

                    }
                    else if (radioButton4.Checked)
                    {
                        if (comboBox5.Text == "0,2") textBox12.Text = "350";
                        else if (comboBox5.Text == "нулевой") textBox12.Text = "200";
                    }
                }

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            if (radioButton3.Checked)
            {
                if (comboBox4.SelectedIndex == 0)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 1)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 2)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 3)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 4)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 5)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 6)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 7)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 8)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 9)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
                else if (comboBox4.SelectedIndex == 10)
                    comboBox5.Items.AddRange(new object[] { "25-200", "10", "4" });
            }

            if (comboBox5.Items.Count != 0) comboBox5.SelectedIndex = 0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            if (radioButton4.Checked)
            {
                if (comboBox4.SelectedIndex == 0)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 1)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 2)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 3)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 4)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 5)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 6)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 7)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 8)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 9)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
                else if (comboBox4.SelectedIndex == 10)
                    comboBox5.Items.AddRange(new object[] { "0,2", "нулевой" });
            }

            if (comboBox5.Items.Count != 0) comboBox5.SelectedIndex = 0;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text.Length == 0)
            {
                return;
            }
            if (textBox10.Text.Length == 0)
            {
                return;
            }
            double Lh = Convert.ToDouble(textBox10.Text);
            Lh = Math.Round(Lh);
            double Li = Convert.ToDouble(textBox11.Text);
            double Alf = Convert.ToDouble(textBox12.Text);


            if (Lh >= 2 & Lh <= 5) //4
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("1"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("1"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("1"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,98"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,94"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,9"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("0,82"));
                }
            }
            else if (Lh >= 5.1 & Lh <= 7) //6 
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,98"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,96"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,95"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,91"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,88"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,81"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("0,68"));
                }
            }
            else if (Lh >= 7.1 & Lh <= 9) //8
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,95"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,92"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,9"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,85"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,8"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,7"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("0,54"));
                }
            }
            else if (Lh >= 9.1 & Lh <= 11) //10 
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,92"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,88"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,84"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,79"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,72"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,6"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("0,43"));
                }
            }
            else if (Lh >= 11.1 & Lh <= 13) //12
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,88"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,84"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,79"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,72"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,64"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,51"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("0,34"));
                }
            }
            else if (Lh >= 13.1 & Lh <= 15) // 14
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,85"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,79"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,73"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,66"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,57"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,43"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("0,28"));
                }
            }
            else if (Lh >= 15.1 & Lh <= 17) //16 
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,81"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,74"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,68"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,59"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,5"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,37"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("0,23"));
                }
            }
            else if (Lh >= 17.1 & Lh <= 21)//18
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,77"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,7"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,63"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,53"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,45"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,32"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 21.1 & Lh <= 24) //22 
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,69"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,61"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,53"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,43"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,35"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,24"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 24.1 & Lh <= 28)//26
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,61"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,52"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,45"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,36"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,29"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,2"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 28.1 & Lh <= 29)// 30
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,53"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,45"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,39"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,32"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,25"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,17"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 29.1 & Lh <= 34)//30
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,44"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,38"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,32"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,26"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,21"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,14"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 34.1 & Lh <= 40) // 38
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,36"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,31"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,26"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,21"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,17"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,12"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 40.1 & Lh <= 44)//42
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,29"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,25"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,21"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,17"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,14"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,09"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 44.1 & Lh <= 48)//46
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,21"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,18"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,16"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,13"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,1"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,07"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 48.1 & Lh <= 52)//50
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,17"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,15"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,13"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,1"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,08"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,05"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
            else if (Lh >= 52.1 & Lh <= 54)// 54
            {
                if (Alf == 1500)
                {
                    textBox14.Text = (Convert.ToString("0,13"));

                }
                else if (Alf == 1000)
                {
                    textBox14.Text = (Convert.ToString("0,12"));
                }
                else if (Alf == 750)
                {
                    textBox14.Text = (Convert.ToString("0,1"));
                }
                else if (Alf == 500)
                {
                    textBox14.Text = (Convert.ToString("0,08"));
                }
                else if (Alf == 350)
                {
                    textBox14.Text = (Convert.ToString("0,06"));
                }
                else if (Alf == 200)
                {
                    textBox14.Text = (Convert.ToString("0,04"));
                }
                else if (Alf == 100)
                {
                    textBox14.Text = (Convert.ToString("-"));
                }
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "") comboBox3_SelectedIndexChanged(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {

            ////////////////////////САМ РАСЧЕТ///////////////////////
            double A = Convert.ToDouble(textBox6.Text.Replace(".", ","));
            double mg = Convert.ToDouble(textBox1.Text.Replace(".", ","));
            double fi = Convert.ToDouble(textBox14.Text.Replace(".", ","));
            double Rsk = Convert.ToDouble(textBox20.Text.Replace(".", ","));
            textBox16.Text = (Convert.ToString(mg * fi * Rsk * A * Edinici.RazmerOtvet * Edinici.RazmerOtvetkgtm));
            ////////////////////////САМ РАСЧЕТ///////////////////////           
            double per1 = Convert.ToDouble(textBox16.Text.Replace(".", ","));
            double per2 = Convert.ToDouble(textBox17.Text.Replace(".", ","));

            textBox18.Text = (Convert.ToString(per1 / per2 * 100));
            if (per1 > per2)
            {
                label31.Visible = true;
                label30.Visible = false;
            }
            else
            {
                label31.Visible = false;
                label30.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }



        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                textBox15.Text = (Convert.ToString("2,0"));
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {

                textBox15.Text = (Convert.ToString("1,5"));
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {

                textBox15.Text = (Convert.ToString("1,0"));
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text.Length == 0)
            {
                return;
            }

            double R = Convert.ToDouble(textBox3.Text);
            double pi = Convert.ToDouble(textBox15.Text);
            double mu = Convert.ToDouble(textBox21.Text);
            double Rs = Convert.ToDouble(textBox24.Text);
            textBox20.Text = (Convert.ToString(R + ((pi * mu * Rs) / 100)));
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox6.SelectedIndex == 0)
            {
                textBox24.Text = "240";
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                textBox24.Text = "300";
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                textBox24.Text = "400";
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                textBox24.Text = "500";
            }
            else if (comboBox6.SelectedIndex == 4)
            {
                textBox24.Text = "540";
            }
            else if (comboBox6.SelectedIndex == 5)
            {
                textBox24.Text = "600";
            }
            else if (comboBox6.SelectedIndex == 6)
            {
                textBox24.Text = "800";
            }
            else if (comboBox6.SelectedIndex == 7)
            {
                textBox24.Text = "1000";
            }
            else if (comboBox6.SelectedIndex == 8)
            {
                textBox24.Text = "500";
            }
            else if (comboBox6.SelectedIndex == 9)
            {
                textBox24.Text = "1200";
            }
            else if (comboBox6.SelectedIndex == 10)
            {
                textBox24.Text = "1300";
            }
            else if (comboBox6.SelectedIndex == 11)
            {
                textBox24.Text = "1400";
            }
            else if (comboBox6.SelectedIndex == 12)
            {
                textBox24.Text = "1500";
            }
            else if (comboBox6.SelectedIndex == 13)
            {
                textBox24.Text = "1400";
            }
            else if (comboBox6.SelectedIndex == 14)
            {
                textBox24.Text = "1500";
            }
            else if (comboBox6.SelectedIndex == 15)
            {
                textBox24.Text = "1500";
            }

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            ///////////////////Rsk/////////////
            if (textBox9.Text.Length == 0)
            {
                return;
            }
            if (textBox15.Text.Length == 0)
            {
                return;
            }
            if (textBox21.Text.Length == 0)
            {
                return;
            }
            double R = Convert.ToDouble(textBox3.Text);
            double pi = Convert.ToDouble(textBox15.Text);
            double nu = Convert.ToDouble(textBox21.Text);
            double Rs = Convert.ToDouble(textBox24.Text);
            textBox20.Text = (Convert.ToString(R + ((pi * nu * Rs) / 100)));
            ////////////////////Rsk//////////////
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text.Length == 0)
            {
                return;
            }
            double va = double.Parse(textBox25.Text);
            textBox27.Text = (Convert.ToString(va / 2));

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == 0)
            {
                return;
            }
            if (textBox26.Text.Length == 0)
            {
                return;
            }
            ///////////////////////Объем арматуры/////////////////
            double radius = Convert.ToDouble(textBox27.Text);
            double H = Convert.ToDouble(textBox9.Text);
            double Kolvostr = Convert.ToDouble(textBox26.Text);
            textBox22.Text = (Convert.ToString((3.1415 * (radius * radius) * (H - (30 * 2))) * Kolvostr));
            ///////////////////////Объем арматуры/////////////////
            ///////////////////////Объем кладки/////////////////
            double Varm = Convert.ToDouble(textBox22.Text);
            double A = Convert.ToDouble(textBox6.Text);
            textBox23.Text = (Convert.ToString(A * H - Varm));
            ///////////////////////Объем кладки/////////////////
            double Vkld = Convert.ToDouble(textBox23.Text);
            textBox21.Text = (Convert.ToString(Varm / Vkld * 100));
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            object missing = Type.Missing;
            var wdApp = new Word.Application();
            wdApp.Visible = true;
            var wdDoc = wdApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            Word.Paragraph para = wdDoc.Paragraphs.Add(ref missing);

            para.Range.Text = "                                            Расчет центрально сжатых армированных столбов";
            para.Range.InsertParagraphAfter();

            para.Range.Text = "   ";
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Считается по формуле N >= mg * φ * Rsk * A";
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Rsk сопротивление при центральном сжатие будет равно: " + textBox20.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Две стороны столба (h b) " + textBox4.Text + textBox5.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Высоту столба (H) " + textBox9.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "A: " + textBox6.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Материал: " + comboBox1.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Марку камня: " + comboBox2.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Марку раствора: " + comboBox3.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Вид кладки: " + comboBox4.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Коэффициент альфа " + textBox12.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Объем армирования арматуры: " + textBox22.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Диаметр арматуры: " + textBox25.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Количество стержней: " + textBox26.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Объем армирования кладки: " + textBox23.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "   ";
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Действующей нагрузки на столб: " + textBox17.Text;
            para.Range.InsertParagraphAfter();

            para.Range.Text = "Расчетная несущая способность: " + textBox16.Text;
            para.Range.InsertParagraphAfter();
        }
    }
}