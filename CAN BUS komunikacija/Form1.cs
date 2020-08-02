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
        //OBJ
        Message.Inputporuka input= new Message.Inputporuka();
        Message.Outputporuka output = new Message.Outputporuka();

        public Form1()
        {
            InitializeComponent();
        }

        //Samo vizualni dizajn
        #region Vizualni dio
        //Svojstvo checkBox i checkBoxo --> ako jedan on njih posatane oznaćen automatski postane i drugi, isto tako vrijedi i za odznačivanje
        #region checkBox

        private void checkBoxIzgled(object sender, EventArgs e, string svojstvo) {
            List<CheckBox> checkBoxesInput = new List<CheckBox>();
            checkBoxesInput.Add(checkBox0);
            checkBoxesInput.Add(checkBox1);
            checkBoxesInput.Add(checkBox2);
            checkBoxesInput.Add(checkBox3);
            checkBoxesInput.Add(checkBox4);
            checkBoxesInput.Add(checkBox5);
            checkBoxesInput.Add(checkBox6);
            checkBoxesInput.Add(checkBox7);
            List<CheckBox> checkBoxesOutput = new List<CheckBox>();
            checkBoxesOutput.Add(checkBox0o);
            checkBoxesOutput.Add(checkBox1o);
            checkBoxesOutput.Add(checkBox2o);
            checkBoxesOutput.Add(checkBox3o);
            checkBoxesOutput.Add(checkBox4o);
            checkBoxesOutput.Add(checkBox5o);
            checkBoxesOutput.Add(checkBox6o);
            checkBoxesOutput.Add(checkBox7o);

            if (svojstvo == "izgled")
            {
                //Vizualni dio checkbox
                for (int i = 0; i < 8; i++)
                {
                    if (checkBoxesInput[i].Checked == true || checkBoxesOutput[i].Checked == true)
                    {
                        checkBoxesOutput[i].Checked = true;
                        checkBoxesInput[i].Checked = true;
                    }
                }
            }
            else if (svojstvo == "clear")
            {
                for (int i = 0; i < 8; i++)
                {
                        checkBoxesOutput[i].Checked = false;
                        checkBoxesInput[i].Checked = false;
                }
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
            input.Inputcanid_property = textBox_CAN_ID_INPUT.Text;
            input.Inputpayload_property = textBox0I.Text + textBox1I.Text + textBox2I.Text + textBox3I.Text + textBox4I.Text + textBox5I.Text + textBox6I.Text + textBox7I.Text;
            return input.Vratiporuku();
        }

        //Dohvat podataka Output preko klase Outputporuka
        public string OutputPoruka()
        {
            output.Outputcanid_property = textBox_CAN_ID_OUTPUT.Text;
            output.Outputpayload_property = textBox0_0.Text + textBox1_O.Text + textBox2_0.Text + textBox3_0.Text + textBox4_0.Text + textBox5_0.Text + textBox6_0.Text + textBox7_0.Text;
            return output.Vratiporuku();
        }

        public string OutputPorukaRandom()
        {
            output.Outputcanid_property = textBox_CAN_ID_OUTPUT.Text;
            Random rnd = new Random();
            for (int i = 0; i < 15; i++) {
                int br = rnd.Next(1, 10);
                output.Outputpayload_property += br.ToString();
            }
            return output.Vratiporuku();
        }
        //Output poruka poslije CopyTelegram
        public string OutputPorukaPoslije()
        {
            output.Outputcanid_property = textBox_CAN_ID_OUTPUT.Text;
            input.Inputpayload_property = textBox0I.Text + textBox1I.Text + textBox2I.Text + textBox3I.Text + textBox4I.Text + textBox5I.Text + textBox6I.Text + textBox7I.Text;
            return "Output CAN ID: " + output.Outputcanid_property + "\nOutput payload: " + input.Inputpayload_property + "\n";
        }

        //Output poruka poslije CopySignal
        public string OutputPorukaCopysignal()
        {
            output.Outputcanid_property = textBox_CAN_ID_OUTPUT.Text;
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
            input.Inputpayload_property = a + b + c + d + e + f + g + h;
            return "Output CAN ID: " + output.Outputcanid_property + "\nOutput payload: " + input.Inputpayload_property + "\n";
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
            #region textBox - Clear
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
            #endregion
            checkBoxIzgled(sender, e, "clear");
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
                        if (pr == 1) { 
                            send.Text += OutputPoruka();
                        }
                        else{
                            send.Text += OutputPorukaRandom();
                        }
                        send.Text += "---------------------------------------------> After Send <---------------------------------------------" + Environment.NewLine;
                        send.Text += InputPoruka();
                        send.Text += OutputPorukaPoslije();
                        send.Text += Environment.NewLine;
                        pr = pr + 1;
                    }
                    while (pr == brporuka);
                }
            }
        }

        //CopySignal
        private void buttonCopySignal_Click(object sender, EventArgs e)
        {
            checkBoxIzgled(sender, e, "izgled");
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
