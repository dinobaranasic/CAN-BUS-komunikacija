﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_BUS_komunikacija.Message
{
    public abstract class Poruka
    {
        //public string Payload { get; set; }
        //public string CanId { get; set; }
        //public string PayCanIDPoruka() => CanId + " " + Payload;

        public abstract string Vratiporuku();
    }
}
