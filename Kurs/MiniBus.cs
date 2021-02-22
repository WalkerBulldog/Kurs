using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprice;

namespace Cars
{
    public class MiniBus : Car, IPassangers
    {
        private readonly int passcapacity;
        int IPassangers.PassCapacity =>  passcapacity;
        public WaybillList Waybills = new WaybillList(); // Как сделать это наследуемым, если оно изначально должно быть пустым
        private double Service
        {
            get
            {
                if (Distance < 10000)
                    return 100;
                else if (Distance < 50000)
                    return 500;
                else return 1000;
            }
        }


        public MiniBus(string Mark, double GasUse, double Distance, int passcapacity) 
            : base(Mark, GasUse, Distance)
        {
            this.passcapacity = passcapacity;
        }

        public override double GetFullDistance(string fio) => Waybills.GetFullDistance(fio);



    }
}
