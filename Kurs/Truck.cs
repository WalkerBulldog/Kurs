using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Truck : Car, ICargo
    {
        public Truck(int id, string Mark, double GasUse, double Capacity) : base(id, Mark, GasUse)
        {
            this.Capacity = Capacity;
        }

        public double Capacity { get; }
    }
}
