﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_BUS_komunikacija.Message
{
    class Outputporuka : Poruka
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

        //Dohvača te vraća output poruko prije zamjene
        public override string Vratiporuku()
        {
            outputporuka = "Output CAN ID: " + outputcanid + "\nOutput payload: " + outputpayload + "\n";
            return outputporuka;
        }

    }
}
