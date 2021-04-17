using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace Drivers
{
    public class Driver
    {
        public int Id { get; }
        public string Name { get; }
        public ClassOfDriver Qualification { get; }


        public Driver(int Id, string Name, ClassOfDriver Qualification)
        {
            this.Id = Id;
            this.Name = Name;
            this.Qualification = Qualification;
        }
        public Driver(string Name, ClassOfDriver Qualification)
        {
            Id = 0;
            this.Name = Name;
            this.Qualification = Qualification;
        }
        public Driver(int Id, string Name, string Qualification)
        {
            this.Id = Id;
            this.Name = Name;
            this.Qualification = (ClassOfDriver)Enum.Parse(typeof(ClassOfDriver), Qualification);
        }

        public Driver()
        {
        }

        public double GetDistance(WaybillList WBList)
        {
            return WBList.GetFullDistanceForDriverId(Id);
        }
        public double GetSalary(double distance)
        {
            return 100 * distance * (double)Qualification;
        }
        public double GetSalary(Waybill WB)
        {
            return 100 * WB.Distance * (double)Qualification;
        }
        public override string ToString() => Name + ", классность - " + Qualification;


    }
}
