using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayBills
{
    public class WaybillList : IEnumerable<Waybill>
    {
        private List<Waybill> List = new List<Waybill>();
        public Waybill this[int index] => List[index];
        public double Count => List.Count;
        public bool Add(Waybill WB)
        {
            if (WB.Id > 0)
            {
                List.Add(WB);
                return true;
            }
            return false;
        }
        public bool Remove(Waybill WB)
        {
            return List.Remove(WB);
        }

        public void Edit(Waybill WB, double NewDistance)
        {
            bool flag = List.Find(item => item.Equals(WB)).Edit(NewDistance);
            if (!flag)
                throw new Exception("Не удалось изменить");
        }
        public void Edit(Waybill WB, DateTime date)
        {
            bool flag = List.Find(item => item.Equals(WB)).Edit(date);
            if (!flag)
                throw new Exception("Не удалось изменить");
        }
        public double GetFullDistanceForDriverId(int Id)
        {
            IEnumerable<double> distances = (from Waybill wbl in List
                                             where wbl.DriverId == Id
                                             select wbl.Distance);

            return distances.Sum();
        }
        public double GetFullDistanceForCarId(int Id)
        {
            IEnumerable<double> distances = (from Waybill wbl in List
                                             where wbl.CarId == Id
                                             select wbl.Distance);

            return distances.Sum();
        }
        public List<Waybill> GetWaybills(int id)
        {
            IEnumerable<Waybill> waybills = ((IEnumerable<Waybill>)(from Waybill wbl in List
                                             where wbl.Id == id
                                             select wbl.Distance));
            return waybills.ToList();
        }
        public List<Waybill> GetWaybillsByCarId(int CarId)
        {
            IEnumerable<Waybill> waybills = (IEnumerable<Waybill>)(from Waybill wbl in List
                                             where wbl.CarId == CarId
                                             select wbl.Distance);

            return waybills.ToList();
        }
        public List<Waybill> GetWaybillsByDriverId(int DriverId)
        {
            IEnumerable<Waybill> waybills = (IEnumerable<Waybill>)(from Waybill wbl in List
                                                                   where wbl.DriverId == DriverId
                                                                   select wbl.Distance);

            return waybills.ToList();
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder("");
            foreach (Waybill wb in List)
                str.Append(wb.ToString() + "\n");
            return str.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)List).GetEnumerator();
        }

        IEnumerator<Waybill> IEnumerable<Waybill>.GetEnumerator()
        {
            return ((IEnumerable<Waybill>)List).GetEnumerator();
        }
    }
}
