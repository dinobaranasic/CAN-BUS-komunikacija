using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_BUS_komunikacija.Message
{
    public abstract class Poruke 
    {
        protected string payload;
        protected string canid;
        protected string poruka;
    }
}
