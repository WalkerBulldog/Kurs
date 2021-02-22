using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprice
{
    public class Waybill
    {
        private string FullName;
        private double Distance;
        public Waybill(string FIO, double Distance)
        {
            if (!CheckDistance(Distance))
                throw new Exception("Дистанция не может быть меньше либо равна нулю.");
            this.Distance = Distance;
            if (FIO == null)
                throw new Exception("Введите имя");
            FullName = FIO;
        }
        public string GetFullName() => FullName;
        public double GetDistance() => Distance;

        public bool Edit(string fio)
        {
            if (fio == null)
                return false;
            FullName = fio;
            return true;
        }
        public bool Edit(double distance)
        {
            if (distance <= 0)
                return false;
            Distance = distance;
            return true;
        }

        public static bool CheckDistance(double Distance)
        {
            if (Distance <= 0)
                return false;
            return true;
        }
    }
}
