using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;

namespace Diplom
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "СП 15.13330.2020", "СНиП ||-22-81" }); //выбор сп
            comboBox1.SelectedIndex = 0;

            //this.BackColor = Color.FromArgb(78, 80, 113);


            // Оранж Вариант 1 ****************************
            //button1.BackColor = Color.FromArgb(163, 95, 3);
            //button2.BackColor = Color.FromArgb(163, 95, 3);
            //button5.BackColor = Color.FromArgb(163, 95, 3);

            //button3.BackColor = Color.FromArgb(181, 106, 5);
            //button4.BackColor = Color.FromArgb(181, 106, 5);
            //button6.BackColor = Color.FromArgb(181, 106, 5);
            //button7.BackColor = Color.FromArgb(181, 106, 5);

            //panel1.BackColor = Color.FromArgb(77, 45, 2);
            //panel2.BackColor = Color.FromArgb(77, 45, 2);

            // Оранж Вариант 2 ****************************
            button1.BackColor = Color.FromArgb(94, 40, 1);
            button2.BackColor = Color.FromArgb(94, 40, 1);
            button5.BackColor = Color.FromArgb(94, 40, 1);

            button3.BackColor = Color.FromArgb(145, 61, 1);
            button4.BackColor = Color.FromArgb(145, 61, 1);
            button6.BackColor = Color.FromArgb(145, 61, 1);
            button7.BackColor = Color.FromArgb(145, 61, 1);

            panel1.BackColor = Color.FromArgb(61, 26, 1);
            panel2.BackColor = Color.FromArgb(61, 26, 1);

            //// Оранж Вариант 3 ****************************
            //button1.BackColor = Color.FromArgb(163, 85, 13);
            //button2.BackColor = Color.FromArgb(163, 85, 13);
            //button5.BackColor = Color.FromArgb(163, 85, 13);

            //button3.BackColor = Color.FromArgb(219, 109, 7);
            //button4.BackColor = Color.FromArgb(219, 109, 7);
            //button6.BackColor = Color.FromArgb(219, 109, 7);
            //button7.BackColor = Color.FromArgb(219, 109, 7);

            //panel1.BackColor = Color.FromArgb(120, 66, 17);
            //panel2.BackColor = Color.FromArgb(120, 66, 17);


            //panel3.BackColor = Color.FromArgb(39, 39, 58);
            //panel5.BackColor = Color.FromArgb(78, 80, 113);

            //TempImpactButton.BackColor = Color.FromArgb(78, 80, 113);
            ////veterButton.BackColor = Color.FromArgb     (39, 39, 58);
            //tButton.BackColor = Color.FromArgb(78, 80, 113);
            //button8.BackColor = Color.FromArgb(78, 80, 113);
            //SnowButton.BackColor = Color.FromArgb(78, 80, 113);

            //button5.BackColor = Color.FromArgb(39, 39, 58);
            ////button6.BackColor = Color.FromArgb         (39, 39, 58);
            ////button1.BackColor = Color.FromArgb(51, 51, 76);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form f = new Form2();
                this.Hide();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
            else
            {
                Form f = new Form3();
                this.Hide();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }


            }

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form c = new Form4();
                this.Hide();

                if (c.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
            else
            {
                Form c = new Form5();
                this.Hide();

                if (c.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                Form c = new Form6();
                this.Hide();

                if (c.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
            else
            {
                Form c = new Form7();
                this.Hide();

                if (c.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }



        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                Form c = new Form9();
                this.Hide();

                if (c.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
            else
            {
                Form c = new Form9();
                this.Hide();

                if (c.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form sid = new Form10();
            sid.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form c = new Form6();
                this.Hide();

                if (c.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            Form a = new Form8();
            a.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Form af = new Form11();
            af.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form nastroik = new Form12();
            nastroik.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form si = new Form13();
            si.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}