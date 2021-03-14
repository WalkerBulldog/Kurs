using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace Cars
{
    public abstract class Car
    {
        public int id { get; }
        public string Mark { get; }
        public double GasUse { get; }
       
        public Car(int id, string Mark, double GasUse)
        {
            this.Mark = Mark;
            this.GasUse = GasUse;
            this.id = id;
        }
        public double GetDistance(WaybillList WBList)
        {
            return WBList.GetFullDistanceForCarId(id);
        }



    }
}
