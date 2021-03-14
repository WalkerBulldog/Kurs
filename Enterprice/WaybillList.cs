using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayBills
{
    public class WaybillList
    {
        private List<Waybill> Waybills = new List<Waybill>();
        public Waybill this[int index] => Waybills[index];
        public double Count => Waybills.Count;
        public void Add(Waybill WB)
        {
            Waybills.Add(WB);
        }
        public bool Remove(Waybill WB)
        {
            return Waybills.Remove(WB);
        }
        public void Edit(Waybill WB, string NewFullName)
        {
            bool flag = Waybills.Find(item => item.Equals(WB)).Edit(NewFullName);
            if (!flag)
                throw new Exception("Не удалось изменить");
        }
        public void Edit(Waybill WB, double NewDistance)
        {
            bool flag = Waybills.Find(item => item.Equals(WB)).Edit(NewDistance);
            if (!flag)
                throw new Exception("Не удалось изменить");
        }
        public void Edit(Waybill WB, DateTime date)
        {
            bool flag = Waybills.Find(item => item.Equals(WB)).Edit(date);
            if (!flag)
                throw new Exception("Не удалось изменить");
        }
        public double GetFullDistanceForDriverId(int Id)
        {
            double sum = 0;
            foreach (Waybill wb in Waybills)
                if (wb.DriverId == Id)
                    sum += wb.Distance;
            return sum;
        }
        public double GetFullDistanceForCarId(int Id)
        {
            double sum = 0;
            foreach (Waybill wb in Waybills)
                if (wb.CarId == Id)
                    sum += wb.Distance;
            return sum;
        }
        public List<Waybill> GetWaybills(string fio)
        {
            List<Waybill> wbl = new List<Waybill>();
            foreach (Waybill wb in Waybills)
                if (wb.FullName == fio)
                    wbl.Add(wb);
            return wbl;
        }
        public List<Waybill> GetWaybills(DateTime firstDate, DateTime secondDate)
        {
            List<Waybill> wbl = new List<Waybill>();
            foreach (Waybill wb in Waybills)
                if (wb.Date >= firstDate && wb.Date <= secondDate)
                    wbl.Add(wb);
            return wbl;
        }
        public List<Waybill> GetWaybillsByCarId(int CarId)
        {
            List<Waybill> wbl = new List<Waybill>();
            foreach (Waybill wb in Waybills)
                if (wb.CarId == CarId)
                    wbl.Add(wb);
            return wbl;
        }
        public List<Waybill> GetWaybillsByDriverId(int DriverId)
        {
            List<Waybill> wbl = new List<Waybill>();
            foreach (Waybill wb in Waybills)
                if (wb.DriverId == DriverId)
                    wbl.Add(wb);
            return wbl;
        }
        public override string ToString()
        {
            string str = "";
            foreach (Waybill wb in Waybills)
                str += wb.ToString();
            return str;
        }
    }
}
