using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_BUS_komunikacija
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Inicijalizacija na početne vrijednosti
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
        }

        //Svojstvo checkBox i checkBoxo --> ako jedan on njih posatane oznaćen automatski postane i drugi, isto tako vrijedi i za odznačivanje
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

        //Svojstvo da se mogu upisati samo brojevi te se oni kasnije pretvraju u Hex brojeve.
        #region CAN ID
        private void textBox_CAN_ID_OUTPUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        //Svojstvo da se mogu upisati samo Hex brojevi maksimalne dužine 2
        #region Hex brojevi
        string HexNiz = Podaci.HexLetters.ToString();
        private void textBox7I_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (!HexNiz.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_0_KeyPress(object sender, KeyPressEventArgs e)
        {
        if (!HexNiz.Contains(e.KeyChar))
        {
            e.Handled = true;
        }
    }


        #endregion

        //Svojstvo o radu s greškama
        #region Greške
        //Greška -> CAN ID
        private void greškaCanId()
        {
            textBoxSend.Clear();
            string message = "Ne možete poslati bez CAN ID! \nUpišite CAN ID.";
            string title = "Greška -> CAN ID";
            MessageBox.Show(message, title);
            textBoxSend.Text += "Molim upišite u Input i Output CAN ID." + Environment.NewLine;
        }
        //Greška -> Payload
        private void greškaPayload()
        {
            textBoxSend.Clear();
            string message = "Ne možete poslati bez Payloada! \nUpišite Payload.";
            string title = "Greška -> Payload";
            MessageBox.Show(message, title);
            textBoxSend.Text += "Molim upišite u Input i Output Payload." + Environment.NewLine;
        }
        #endregion

        //Svojstvo dohvačanja podatak iz textboxa
        #region Dohvat Payloada
        //0
        private string i0 (){
            string vrijednost1bayta = textBox0I.Text.ToUpper();
            return vrijednost1bayta;
        }
        private string o0()
        {
            string vrijednost1bayta = textBox0_0.Text.ToUpper();
            return vrijednost1bayta;
        }
        //1
        private string i1()
        {
            string vrijednost1bayta = textBox1I.Text.ToUpper();
            return vrijednost1bayta;
        }
        private string o1()
        {
            string vrijednost1bayta = textBox1_O.Text.ToUpper();
            return vrijednost1bayta;
        }
        //2
        private string i2()
        {
            string vrijednost1bayta = textBox2I.Text.ToUpper();
            return vrijednost1bayta;
        }
        private string o2()
        {
            string vrijednost1bayta = textBox2_0.Text.ToUpper();
            return vrijednost1bayta;
        }
        //3
        private string i3()
        {
            string vrijednost1bayta = textBox3I.Text.ToUpper();
            return vrijednost1bayta;
        }
        private string o3()
        {
            string vrijednost1bayta = textBox3_0.Text.ToUpper();
            return vrijednost1bayta;
        }
        //4
        private string i4()
        {
            string vrijednost1bayta = textBox4I.Text.ToUpper();
            return vrijednost1bayta;
        }
        private string o4()
        {
            string vrijednost1bayta = textBox4_0.Text.ToUpper();
            return vrijednost1bayta;
        }
        //5
        private string i5()
        {
            string vrijednost1bayta = textBox5I.Text.ToUpper();
            return vrijednost1bayta;
        }
        private string o5()
        {
            string vrijednost1bayta = textBox5_0.Text.ToUpper();
            return vrijednost1bayta;
        }
        //6
        private string i6()
        {
            string vrijednost1bayta = textBox6I.Text.ToUpper();
            return vrijednost1bayta;
        }
        private string o6()
        {
            string vrijednost1bayta = textBox6_0.Text.ToUpper();
            return vrijednost1bayta;
        }
        //7
        private string i7()
        {
            string vrijednost1bayta = textBox7I.Text.ToUpper();
            return vrijednost1bayta;
        }
        private string o7()
        {
            string vrijednost1bayta = textBox7_0.Text.ToUpper();
            return vrijednost1bayta;
        }
        #endregion

        //Svojstvo ispisa payloada
        #region Ispis Payloada
        //Input
        private string inputPayloadIspis()
        {
            string payload = i0() + i1() + i2() + i3() + i4() + i5() + i6() + i7();
            return payload;
        }
        private string outputPayloadIspis()
        {
            string payload = o0() + o1() + o2() + o3() + o4() + o5() + o6() + o7();
            return payload;
        }
        //Output
        #endregion


        //button CopyTelegram
        private void buttonCopyTelegram_Click(object sender, EventArgs e)
        {
            if (textBox_CAN_ID_INPUT.Text == "" || textBox_CAN_ID_OUTPUT.Text == "")
            {
                greškaCanId();
            }
            else if (textBox0I.Text=="" || textBox0_0.Text=="" || textBox1I.Text=="" || textBox1_O.Text=="" || textBox2I.Text=="" || textBox2_0.Text=="" || textBox3I.Text=="" || textBox3_0.Text=="" || textBox4I.Text=="" || textBox4_0.Text=="" ||textBox5I.Text=="" ||textBox5_0.Text=="" ||textBox6I.Text=="" ||textBox6_0.Text=="" || textBox7I.Text=="" || textBox7_0.Text=="" )
            {
                greškaPayload();
            }
            else {
                string canidinput = textBox_CAN_ID_INPUT.Text;
                int br = Int32.Parse(canidinput);
                string hexValue = br.ToString("X");

                string canidoutput = textBox_CAN_ID_OUTPUT.Text;
                int brout = Int32.Parse(canidoutput);
                string hexValueout = brout.ToString("X");


                textBoxSend.Clear();
                textBoxSend.Text += "--------------------------------------------> Before Send <--------------------------------------------" + Environment.NewLine;
                textBoxSend.Text += "Input -> CAN ID: " + hexValue.ToString() + " [Hex]" + Environment.NewLine;
                textBoxSend.Text += "Input -> Payload: " + inputPayloadIspis() + Environment.NewLine;
                textBoxSend.Text += "Output -> CAN ID: " + hexValueout.ToString() + " [Hex]" + Environment.NewLine;
                textBoxSend.Text += "Output -> Payload: " + outputPayloadIspis() + Environment.NewLine;
                textBoxSend.Text += "---------------------------------------------> After Send <---------------------------------------------" + Environment.NewLine;
                textBoxSend.Text += "Input -> CAN ID: " + hexValue.ToString() + " [Hex]" + Environment.NewLine;
                textBoxSend.Text += "Input -> Payload: " + inputPayloadIspis() + Environment.NewLine;
                textBoxSend.Text += "Output -> CAN ID: " + hexValueout.ToString() + " [Hex]" + Environment.NewLine;
                textBoxSend.Text += "Output -> Payload: " + outputPayloadIspis() + Environment.NewLine;


            }
           



        }

        //button Default
        private void buttondefault_Click(object sender, EventArgs e)
        {
            textBox_CAN_ID_INPUT.Clear();
            textBox_CAN_ID_OUTPUT.Clear();
            textBox0I.Clear();
            textBox1I.Clear();
            textBox2I.Clear();
            textBox3I.Clear();
            textBox4I.Clear();
            textBox5I.Clear();
            textBox6I.Clear();
            textBox7I.Clear();
            Form1_Load(sender,e);
            textBoxSend.Clear();
            
        }

    }
}
