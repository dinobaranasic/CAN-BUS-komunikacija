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
        
    }
}
