using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Truck : Car, ICargo
    {
        public Truck(int id, double GasUse, double Capacity) : base(id, "TRUCK", GasUse)
        {
            this.Capacity = Capacity;
        }

        public double Capacity { get; }
        public override double Service(double Distance)
        {
            if (Distance <= 100)
                return 800;
            else if (Distance <= 250)
                return 1200;
            else
                return 1900;
        }
        public override string ToString()
        {
            return TypeOfCar + ", " + GasUse + "л / 100 км, " + Capacity + "кг.";
        }
    }
}
