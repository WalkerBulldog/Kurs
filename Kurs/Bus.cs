using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Bus : Car, ICargo, IPassangers
    {
        public double Capacity { get; }

        public int PassCapacity { get; }
        public Bus(int id, string Mark, double GasUse, double Capacity, int PassCapacity) : base(id, Mark, GasUse)
        {
            this.PassCapacity = PassCapacity;
            this.Capacity = Capacity;
        }
    }
}
