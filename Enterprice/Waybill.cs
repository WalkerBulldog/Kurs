using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayBills
{
    public class Waybill
    {
        private string FullName;
        private double Distance;
        private DateTime Date;
        public int CarId { get; }
        public int DriverId { get; }
        public Waybill(string FIO, double Distance, DateTime Date, int CarId, int DriverId)
        {
            if (!CheckDistance(Distance))
                throw new Exception("Дистанция не может быть меньше либо равна нулю.");
            this.Distance = Distance;
            if (FIO == null)
                throw new Exception("Введите имя");
            FullName = FIO;
            this.CarId = CarId;
            this.DriverId = DriverId;
            this.Date = Date;
        }
        public string GetFullName() => FullName;
        public double GetDistance() => Distance;
        public DateTime GetDate() => Date;

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
        public bool Edit(DateTime date)
        {
            if (date == null)
                return false;
            Date = date;
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
