using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_BUS_komunikacija.Message
{
    // Nasljeđeni razred : Bazni razred

    class Inputporuka : Poruke
    {
        protected string inputpay;
        protected string inputcanid;
        protected string inputporuka;
    }
}
