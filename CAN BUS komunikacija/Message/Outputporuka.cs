using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_BUS_komunikacija.Message
{
    class Outputporuka : Inputporuka
    {
        protected string outputpayload;
        protected string outputcanid;
        protected string outputporuka;

        //Get set
        public string Outputpayload_property
        {
            get { return outputpayload; }   // get method
            set { outputpayload = value; }  // set method
        }

        //Get set
        public string Outputcanid_property
        {
            get { return outputcanid; }   // get method
            set { outputcanid = value; }  // set method
        }

        //Lista u koju spremamo checkboxe
        protected List<string> listcheckboxOutput = new List<string>();

        //Dohvača te vraća output poruko prije zamjene
        public string VratiOutputPrije()
        {
            outputporuka = "Output CAN ID: " + outputcanid + "\nOutput payload: " + outputpayload + "\n";
            return outputporuka;
        }

        //Dohvača te vraća output poruko nakon zamijene
        public string VratiOutputPoslije()
        {
            outputpayload = inputpayload;
            outputporuka = "Output CAN ID: " + outputcanid + "\nOutput payload: " + outputpayload + "\n";
            return outputporuka;
        }
    }
}
