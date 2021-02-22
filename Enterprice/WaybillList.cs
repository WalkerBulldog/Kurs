using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprice
{
    public class WaybillList
    {
        private List<Waybill> Waybills = new List<Waybill>();

        public void Add(Waybill WB)
        {
            Waybills.Add(WB);
        }
        public void Remove(Waybill WB)
        {
            Waybills.Remove(WB);
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
        public double GetFullDistance(string FIO)
        {
            double sum = 0;
            foreach (Waybill wb in Waybills)
                if (wb.GetFullName() == FIO)
                    sum += wb.GetDistance();
            return sum;
        }
    }
}
