using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Rides
    {
        public double Distance;
        public int Time;
        public Rides(double Distance,int Time)
        {
            this.Distance = Distance;
            this.Time = Time;
        }
    }
}
