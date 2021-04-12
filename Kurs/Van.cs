using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace Cars
{
    public class Van : Car, IPassangers
    {
        public int PassCapacity { get; }


        public Van(int id, double GasUse, int passcapacity)
            : base(id, "VAN", GasUse)
        {
            this.PassCapacity = passcapacity;
        }
        public Van(double GasUse, int passcapacity)
           : base("VAN", GasUse)
        {
            this.PassCapacity = passcapacity;
        }
        public override double Service(double Distance)
        {
            if (Distance <= 100)
                return 500;
            else if (Distance <= 250)
                return 1000;
            else
                return 1500;
        }
        public override string ToString()
        {
            return TypeOfCar + ", " + GasUse + "л / 100 км, " + PassCapacity + "чел.";
        }
    }
}
