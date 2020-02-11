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

namespace CAN_BUS_komunikacija.Message
{
    // Nasljeđeni razred : Bazni razred
    public class Inputporuka : Form1
    {
        //Varijable za rad sa Input porukama
        protected string inputpayload;
        protected string inputcanid;
        protected string inputporuka;

        //Get set
        public string Inputpayload_property
        {
            get { return inputpayload; }   // get method
            set { inputpayload = value; }  // set method
        }

        //Get set
        public string Inputcanid_property
        {
            get { return inputcanid; }   // get method
            set { inputcanid = value; }  // set method
        }
       
        //Lista u koju spremamo checkboxe
        protected List<string> listcheckbox = new List<string>();

        //Dohvača te vraća insput poruko
        public string VratiInput()
        {
            inputporuka = "Input CAN ID: " + inputcanid + "\nInput payload: " + inputpayload +"\n";
            return inputporuka;
        }

    }
}
