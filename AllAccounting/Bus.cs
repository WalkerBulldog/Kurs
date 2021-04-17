using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAccounting
{
    public class Bus : Car, ICargo, IPassangers
    {
        public double Capacity { get; }

        public int PassCapacity { get; }
        public Bus(int id, double GasUse, double Capacity, int PassCapacity) : base(id, "BUS", GasUse)
        {
            this.PassCapacity = PassCapacity;
            this.Capacity = Capacity;
        }
        public Bus(double GasUse, double Capacity, int PassCapacity) : base("BUS", GasUse)
        {
            this.PassCapacity = PassCapacity;
            this.Capacity = Capacity;
        }
        public override double Service(double Distance)
        {
            if (Distance <= 100)
                return 1000;
            else if (Distance <= 250)
                return 2000;
            else
                return 3000;
        }
        public override string ToString()
        {
            return TypeOfCar + ", " + GasUse + "л / 100 км, " + Capacity + "кг, " + PassCapacity + "чел.";
        }
    }
}
