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


        public MiniBus(int id, string Mark, double GasUse, int passcapacity)
            : base(id, Mark, GasUse)
        {
            this.passcapacity = passcapacity;
        }
    }
}
