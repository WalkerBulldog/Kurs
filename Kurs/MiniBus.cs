using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace Cars
{
    public class MiniBus : Car, IPassangers
    {
        private readonly int passcapacity;
        int IPassangers.PassCapacity =>  passcapacity;


        public MiniBus(int id, double GasUse, int passcapacity)
            : base(id, "VAN", GasUse)
        {
            this.passcapacity = passcapacity;
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
            return TypeOfCar + ", " + GasUse + "л / 100 км, " + passcapacity + "чел.";
        }
    }
}
