using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Diplom
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //***************************ШЕСТАЯ ФОРМА ОБЩИЕ ДАННЫЕ*******************************************//
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //********************************КОНСТРУКЦИЯ******************************************//

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label20.Visible = true;
            label23.Visible = true;
            label22.Visible = true;
            label24.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            label25.Visible = false;
            label26.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label20.Visible = true;
            label23.Visible = true;
            label22.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            label27.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            label20.Visible = false;
            label23.Visible = false;
            label22.Visible = true;
            label24.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            label27.Visible = true;
            textBox19.Visible = true;
            textBox20.Visible = false;
            textBox21.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            label20.Visible = false;
            label23.Visible = false;
            label22.Visible = true;
            label24.Visible = true;
            textBox13.Visible = false;
            textBox14.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            label27.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = true;
            textBox21.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                {
                    label18.Visible = true;
                    textBox12.Visible = true;
                    label19.Visible = true;
                }
            }
            if (checkBox3.Checked == false)
            {
                {
                    label18.Visible = false;
                    textBox12.Visible = false;
                    label19.Visible = false;

                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        //********************************РАСЧЕТНАЯ ВЫСОТА XOY******************************************//


        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            textBox22.Visible = false;
            button25.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {


            groupBox4.Visible = true;
            groupBox5.Visible = false;
            textBox22.Visible = false;
            button25.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            textBox2.Visible = false;
            label15.Visible = false;
            button25.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox4.Visible = false;
            button25.Visible = true;
            textBox2.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            textBox22.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            textBox22.Visible = true;
            button25.Visible = false;
            textBox2.Visible = false;
            label15.Visible = false;


        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            textBox8.Visible = true;
            textBox9.Visible = false;
            textBox10.Visible = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {


            if (Convert.ToInt32(textBox1.Text) <= 24 || Convert.ToInt32(textBox1.Text) >= 101)
            {

                MessageBox.Show("Вы должны ввести диапазон от 25 до 100");
            }
            else
            {
                tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];

            }


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox12.Text) <= -1 || Convert.ToDouble(textBox12.Text) >= 4.9982922559)
            {

                MessageBox.Show("Вы должны ввести диапазон от 0 до 4.9982922559");
            }
            else
            {
                tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Visible = true;
        }


        private void button25_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                button25.Enabled = false;
                textBox11.Enabled = false;
            }
            else
                MessageBox.Show("Вы должны ввести число");

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                {
                    listBox1.Enabled = true;
                }
            }
            if (checkBox1.Checked == false)
            {
                {
                    listBox1.Enabled = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                {
                    radioButton10.Enabled = true;
                    label17.Enabled = true;
                    comboBox6.Enabled = true;
                    groupBox7.Enabled = true;
                }
            }
            if (checkBox2.Checked == false)
            {
                {
                    radioButton10.Enabled = false;
                    label17.Enabled = false;
                    comboBox6.Enabled = false;
                    groupBox7.Enabled = false;
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
           
            double a = Convert.ToDouble(comboBox1.Text);
            


            double b = Convert.ToDouble(textBox1.Text);
            MessageBox.Show(Convert.ToString(a + b));
        }
    }
}