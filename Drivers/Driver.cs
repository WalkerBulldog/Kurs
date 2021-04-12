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
        public ClassOfDriver qualification { get; }


        public Driver(int Id, string Name, ClassOfDriver Qualification)
        {
            this.Id = Id;
            this.Name = Name;
            this.qualification = Qualification;
        }
        public Driver(string Name, ClassOfDriver Qualification)
        {
            Id = 0;
            this.Name = Name;
            this.qualification = Qualification;
        }
        public Driver(int Id, string Name, string Qualification)
        {
            this.Id = Id;
            this.Name = Name;
            this.qualification = (ClassOfDriver)Enum.Parse(typeof(ClassOfDriver), Qualification);
        }

        public Driver()
        {
        }

        public double GetDistance(WaybillList WBList)
        {
            return WBList.GetFullDistanceForDriverId(Id);
        }
        public double GetSalary(WaybillList WBList)
        {
            return 100 * GetDistance(WBList) * (double)qualification;
        }
        public double GetSalary(Waybill WB)
        {
            return 100 * WB.Distance * (double)qualification;
        }
        public override string ToString() => Name + ", классность - " + qualification.ToString();

    }
}
