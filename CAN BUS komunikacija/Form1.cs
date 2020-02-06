using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAN_BUS_komunikacija.Properties;

namespace CAN_BUS_komunikacija
{
    //Dino Baranašić
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        
        //Svojstvo checkBox i checkBoxo --> ako jedan on njih posatane oznaćen automatski postane i drugi, isto tako vrijedi i za odznačivanje
        //Samo vizualni dizajn
        #region checkBox
        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox0.Checked == true)
            {
                checkBox0o.Checked = true;
            }
            else if (checkBox0.Checked == false)
            {
                checkBox0o.Checked = false;
            }
        }
        private void checkBox0o_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox0o.Checked == true)
            {
                checkBox0.Checked = true;
            }
            else if (checkBox0o.Checked == false)
            {
                checkBox0.Checked = false;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1o.Checked = true;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox1o.Checked = false;
            }
        }
        private void checkBox1o_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1o.Checked == true)
            {
                checkBox1.Checked = true;
            }
            else if (checkBox1o.Checked == false)
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2o.Checked = true;
            }
            else if (checkBox2.Checked == false)
            {
                checkBox2o.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3o.Checked = true;
            }
            else if (checkBox3.Checked == false)
            {
                checkBox3o.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox4o.Checked = true;
            }
            else if (checkBox4.Checked == false)
            {
                checkBox4o.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox5o.Checked = true;
            }
            else if (checkBox5.Checked == false)
            {
                checkBox5o.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6o.Checked = true;
            }
            else if (checkBox6.Checked == false)
            {
                checkBox6o.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox7o.Checked = true;
            }
            else if (checkBox7.Checked == false)
            {
                checkBox7o.Checked = false;
            }
        }

        private void checkBox2o_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2o.Checked == true)
            {
                checkBox2.Checked = true;
            }
            else if (checkBox2o.Checked == false)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox3o_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3o.Checked == true)
            {
                checkBox3.Checked = true;
            }
            else if (checkBox3o.Checked == false)
            {
                checkBox3.Checked = false;
            }
        }

        private void checkBox4o_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4o.Checked == true)
            {
                checkBox4.Checked = true;
            }
            else if (checkBox4o.Checked == false)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox5o_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5o.Checked == true)
            {
                checkBox5.Checked = true;
            }
            else if (checkBox5o.Checked == false)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox6o_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6o.Checked == true)
            {
                checkBox6.Checked = true;
            }
            else if (checkBox6o.Checked == false)
            {
                checkBox6.Checked = false;
            }
        }

        private void checkBox7o_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7o.Checked == true)
            {
                checkBox7.Checked = true;
            }
            else if (checkBox7o.Checked == false)
            {
                checkBox7.Checked = false;
            }
        }
        #endregion

        //Ispis CopyTelegram


        

        

        //Ucitavanje forme
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_BROJ_Poruka.SelectedIndex = 0;
            comboBox_MS.SelectedIndex = 0;
            textBox0_0.Text = "01";
            textBox1_O.Text = "23";
            textBox2_0.Text = "45";
            textBox3_0.Text = "67";
            textBox4_0.Text = "89";
            textBox5_0.Text = "AB";
            textBox6_0.Text = "CD";
            textBox7_0.Text = "EF";
            textBox0I.Text = "EF";
            textBox1I.Text = "CD";
            textBox2I.Text = "AB";
            textBox3I.Text = "11";
            textBox4I.Text = "22";
            textBox5I.Text = "33";
            textBox6I.Text = "44";
            textBox7I.Text = "55";
            send.ReadOnly = true;
        }

        private void buttonCopyTelegram_Click(object sender, EventArgs e)
        {

        }
    }
}
