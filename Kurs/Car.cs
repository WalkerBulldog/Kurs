using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprice;

namespace Cars
{
    public abstract class Car
    {
        public string Mark { get; }
        public double GasUse { get; }
        public double Distance { get; protected set; }
       
        public Car(string Mark, double GasUse, double Distance)
        {
            this.Mark = Mark;
            this.GasUse = GasUse;
            this.Distance = Distance;
        }
        public abstract double GetFullDistance(string fio);

    }
}
