using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayBills
{
    public class Waybill
    {
        public int Id { get; private set; }      
        public double Distance { get; private set; }
        public DateTime Date { get; private set; }
        public int CarId { get; }
        public int DriverId { get; }
        public Waybill( double Distance, DateTime Date, int CarId, int DriverId)
        {
            Id = 0;
            if (!CheckDistance(Distance))
                throw new Exception("Дистанция не может быть меньше либо равна нулю.");
            this.Distance = Distance;
            this.CarId = CarId;
            this.DriverId = DriverId;
            this.Date = Date;
        }
        public Waybill(int id, double Distance, DateTime Date, int CarId, int DriverId)
        {
            this.Id = id;
            if (!CheckDistance(Distance))
                throw new Exception("Дистанция не может быть меньше либо равна нулю.");
            this.Distance = Distance;
            this.CarId = CarId;
            this.DriverId = DriverId;
            this.Date = Date;
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
        public override string ToString()
        {
            return "Водитель " + Id + "\nДистанция: " + Distance + "\nДата: " + Date.ToString() + "\nНомер машины: " + CarId;
        }
    }
}
