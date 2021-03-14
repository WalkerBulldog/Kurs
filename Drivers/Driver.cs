using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprice;

namespace Drivers
{
    public class Driver
    {
        public int Id { get; }
        private string fio { get; }
        private ClassOfDriver qualification { get; }
        public double Distance { get; protected set; }
        private double Money { get; }


        public Driver(int id,string fio, ClassOfDriver qualification)
        {
            this.Id = id;
            this.fio = fio;
            this.qualification = qualification;
        }
        public bool UpdateDistance(List<Waybill> list)
        {
            double distance = 0;
            if (list == null)
                return false;
            foreach (Waybill wb in list)
                if (wb.GetFullName() == fio)
                    distance += wb.GetDistance();
            Distance = distance;
            return true;
        }



    }
}
