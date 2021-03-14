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
        private string fio { get; }
        private ClassOfDriver qualification { get; }
        public double Distance { get; protected set; }


        public Driver(int Id, string fio, ClassOfDriver qualification)
        {
            this.Id = Id;
            this.fio = fio;
            this.qualification = qualification;
        }
        public double GetDistance(WaybillList WBList)
        {
            return WBList.GetFullDistanceForDriverId(Id);
        }
        public double GetSalary(WaybillList WBList)
        {
            return 100 * GetDistance(WBList) * (int)qualification;
        }


    }
}
