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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox10.SelectedItem.ToString() == "мм")
            {
                Edinici.Razmer = 1;
                Edinici.Textavse = "мм";

            }
            else if (comboBox10.SelectedItem.ToString() == "см")
            {
                Edinici.Razmer = 10;
                Edinici.Textavse = "см";


            }
            else if (comboBox10.SelectedItem.ToString() == "м")
            {
                Edinici.Razmer = 1000;
                Edinici.Textavse = "м";

            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Н")
            {
                Edinici.RazmerOtvet = 1;
                Edinici.TextavseOtvet = "Н";

            }
            else if (comboBox1.SelectedItem.ToString() == "кН")
            {
                Edinici.RazmerOtvet = 1000;
                Edinici.TextavseOtvet = "кН";


            }
            else if (comboBox1.SelectedItem.ToString() == "кгс")
            {
                Edinici.RazmerOtvetkgtm = 0.10197162;
                Edinici.TextavseOtvet = "кгс";

            }
            else if (comboBox1.SelectedItem.ToString() == "тс")
            {
                Edinici.RazmerOtvetkgtm = 0.00010197162;
                Edinici.TextavseOtvet = "тс";

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
