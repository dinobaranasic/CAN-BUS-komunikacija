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

        //Samo vizualni dizajn
        #region Vizualni dio
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
        #endregion

        //Svojstva o CAN ID - Hex brojevi - Greške
        #region Svojstva
        //Svojstvo da se mogu upisati samo brojevi te se oni kasnije pretvraju u Hex brojeve.
        #region CAN ID
        private void textBox_CAN_ID_OUTPUT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
 
        //Svojstvo da se mogu upisati samo Hex brojevi maksimalne dužine 2
        #region Hex brojevi
        string HexNiz = "0123456789abcdefABCDEF\b";
        private void textBox7I_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!HexNiz.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_0_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
        #endregion

        //Svojstvo o radu s greškama
        #region Greške
        //Greška -> CAN ID
        private void greškaCanId()
        {
            send.Clear();
            string message = "Ne možete poslati bez CAN ID! \nUpišite CAN ID.";
            string title = "Greška -> CAN ID";
            MessageBox.Show(message, title);
            send.Text += "Molim upišite u Input i Output CAN ID." + Environment.NewLine;
        }
        //Greška -> Payload
        private void greškaPayload()
        {
            send.Clear();
            string message = "Ne možete poslati bez Payloada! \nUpišite Payload.";
            string title = "Greška -> Payload";
            MessageBox.Show(message, title);
            send.Text += "Molim upišite u Input i Output Payload." + Environment.NewLine;
        }
        #endregion
        #endregion

        //Dohvat podataka i rad s podacima
        #region Podaci
        //Dohvat podataka Inputa preko klase Inputporuka
        public string InputPoruka()
        {
            Message.Inputporuka inputporuka = new Message.Inputporuka();
            inputporuka.Inputcanid_property = textBox_CAN_ID_INPUT.Text;
            inputporuka.Inputpayload_property = textBox0I.Text + textBox1I.Text + textBox2I.Text + textBox3I.Text + textBox4I.Text + textBox5I.Text + textBox6I.Text + textBox7I.Text;
            return inputporuka.VratiInput();
        }

        //Dohvat podataka Output preko klase Outputporuka
        public string OutputPoruka()
        {
            Message.Outputporuka outputporuka = new Message.Outputporuka();
            outputporuka.Outputcanid_property = textBox_CAN_ID_OUTPUT.Text;
            outputporuka.Outputpayload_property = textBox0_0.Text + textBox1_O.Text + textBox2_0.Text + textBox3_0.Text + textBox4_0.Text + textBox5_0.Text + textBox6_0.Text + textBox7_0.Text;
            return outputporuka.VratiOutputPrije();
        }

        //Output poruka poslije CopyTelegram
        public string OutputPorukaPoslije()
        {
            Message.Outputporuka outputporuka = new Message.Outputporuka();
            Message.Inputporuka inputporuka = new Message.Inputporuka();
            outputporuka.Outputcanid_property = textBox_CAN_ID_OUTPUT.Text;
            inputporuka.Inputpayload_property = textBox0I.Text + textBox1I.Text + textBox2I.Text + textBox3I.Text + textBox4I.Text + textBox5I.Text + textBox6I.Text + textBox7I.Text;
            return "Output CAN ID: " + outputporuka.Outputcanid_property + "\nOutput payload: " + inputporuka.Inputpayload_property + "\n";
        }

        //Output poruka poslije CopySignal
        public string OutputPorukaCopysignal()
        {
         Message.Outputporuka outputporuka = new Message.Outputporuka();
        Message.Inputporuka inputporuka = new Message.Inputporuka();
        outputporuka.Outputcanid_property = textBox_CAN_ID_OUTPUT.Text;
            string a, b, c, d, e, f, g, h;
            //Provjera prije kopiranja
            if (checkBox0.Checked == true) { a = textBox0I.Text; } else { a = textBox0_0.Text; }
            if (checkBox1.Checked == true) { b = textBox1I.Text; } else { b = textBox1_O.Text; }
            if (checkBox2.Checked == true) { c = textBox2I.Text; } else { c = textBox2_0.Text; }
            if (checkBox3.Checked == true) { d = textBox3I.Text; } else { d = textBox3_0.Text; }
            if (checkBox4.Checked == true) { e = textBox4I.Text; } else { e = textBox4_0.Text; }
            if (checkBox5.Checked == true) { f = textBox5I.Text; } else { f = textBox5_0.Text; }
            if (checkBox6.Checked == true) { g = textBox6I.Text; } else { g = textBox6_0.Text; }
            if (checkBox7.Checked == true) { h = textBox7I.Text; } else { h = textBox7_0.Text; }
            inputporuka.Inputpayload_property = a + b + c + d + e + f + g + h;
            return "Output CAN ID: " + outputporuka.Outputcanid_property + "\nOutput payload: " + inputporuka.Inputpayload_property + "\n";
        }
        #endregion

        //Buttom
        #region Button
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
            textBox_CAN_ID_INPUT.Text = "123456";
            textBox_CAN_ID_OUTPUT.Text = "654321";
            send.ReadOnly = true;
        }

        //Default - Obriše sve
        private void buttondefault_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
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
            textBox0_0.Clear();
            textBox1_O.Clear();
            textBox2_0.Clear();
            textBox3_0.Clear();
            textBox4_0.Clear();
            textBox5_0.Clear();
            textBox6_0.Clear();
            textBox7_0.Clear();
            send.Clear();
        }

        //CopyTelegram
        private void buttonCopyTelegram_Click(object sender, EventArgs e)
        {
            if (textBox_CAN_ID_INPUT.Text == "" || textBox_CAN_ID_OUTPUT.Text == "")
            {
                greškaCanId();
            }
            else if (textBox0I.Text == "" || textBox0_0.Text == "" || textBox1I.Text == "" || textBox1_O.Text == "" || textBox2I.Text == "" || textBox2_0.Text == "" || textBox3I.Text == "" || textBox3_0.Text == "" || textBox4I.Text == "" || textBox4_0.Text == "" || textBox5I.Text == "" || textBox5_0.Text == "" || textBox6I.Text == "" || textBox6_0.Text == "" || textBox7I.Text == "" || textBox7_0.Text == "")
            {
                greškaPayload();
            }
            else
            {
                string canidinput = textBox_CAN_ID_INPUT.Text;
                int br = Int32.Parse(canidinput);
                string hexValue = br.ToString("X");

                string canidoutput = textBox_CAN_ID_OUTPUT.Text;
                int brout = Int32.Parse(canidoutput);
                string hexValueout = brout.ToString("X");

                if (comboBox_MS.SelectedIndex > 0 || comboBox_MS.SelectedIndex == 0 || comboBox_BROJ_Poruka.SelectedIndex > 0 || comboBox_BROJ_Poruka.SelectedIndex == 0)
                {
                    string ciklusslanja = comboBox_MS.SelectedItem.ToString();
                    int brojciklusa = Int32.Parse(ciklusslanja);
                    string brojporuka = comboBox_BROJ_Poruka.SelectedItem.ToString();
                    int brporuka = Int32.Parse(brojporuka);
                    int pr = 1;
                    send.Clear();
                    send.Text += "Copy Telegram kopira Input payload u Output payload." + Environment.NewLine;
                    send.Text += "Ciklus slanja poruka(ms): -> " + brojciklusa.ToString() + Environment.NewLine;
                    do
                    {
                        Thread.Sleep(brojciklusa);
                        send.Text += "Poruka broj: -> " + pr.ToString() + Environment.NewLine;
                        send.Text += "--------------------------------------------> Before Send <--------------------------------------------" + Environment.NewLine;
                        send.Text += InputPoruka();
                        send.Text += OutputPoruka();
                        send.Text += "---------------------------------------------> After Send <---------------------------------------------" + Environment.NewLine;
                        send.Text += InputPoruka();
                        send.Text += OutputPorukaPoslije();
                        send.Text += Environment.NewLine;
                        brporuka -= 1;
                        pr = pr + 1;
                    }
                    while (brporuka > 0);
                     }
            }
        }

        //CopySignal
        private void buttonCopySignal_Click(object sender, EventArgs e)
        {
            string canidinput = textBox_CAN_ID_INPUT.Text;
            int br = Int32.Parse(canidinput);
            string hexValue = br.ToString("X");

            string canidoutput = textBox_CAN_ID_OUTPUT.Text;
            int brout = Int32.Parse(canidoutput);
            string hexValueout = brout.ToString("X");

            send.Clear();
            send.Text += "Copy Signal kopira samo dio je potvrden u checkboxu iz Input payload u Output payload." + Environment.NewLine;
            send.Text += "Signal - Redni broj bytea unutar payloada se kopira iz Input u Output" + Environment.NewLine;
            send.Text += "--------------------------------------------> Before Send <--------------------------------------------" + Environment.NewLine;
            send.Text += InputPoruka();
            send.Text += OutputPoruka();
            send.Text += "---------------------------------------------> After Send <---------------------------------------------" + Environment.NewLine;
            send.Text += InputPoruka();
            send.Text += OutputPorukaCopysignal();
            comboBox_BROJ_Poruka.Text = "1";
            comboBox_MS.Text = "0";
        }
        #endregion
    }
}
