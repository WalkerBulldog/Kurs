using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using WayBills;

namespace Users
{
    public class Operator : User, IOperator
    {
        public override string Status { get { return "Operator"; } }

        public Operator(string Login, string PassWord, string UserName) : base
            (Login, PassWord, UserName)
        {
        }
        public bool AddWayBill(string driverName, double distance, DateTime dateTime, int carid, int driverid)
        {
            return Enterprice.AddWayBill(driverName, distance, dateTime, carid, driverid);
        }
        public bool AddBus(int id, double GasUse, double Capacity, int PassCapacity)
        {
            return Enterprice.AddBus(id, GasUse, PassCapacity, Capacity);
        }
        public bool AddTruck(int id, double GasUse, double Capacity)
        {
            return Enterprice.AddTruck(id, GasUse, Capacity);
        }
        public bool AddMiniBus(int id, double GasUse, int PassCapacity)
        {
            return Enterprice.AddMiniBus(id, GasUse, PassCapacity);
        }

        public bool RemoveCar(Car car)
        {
            return Enterprice.RemoveCar(car);
        }

        public bool RemoveWayBill(Waybill wb)
        {
            return Enterprice.RemoveWayBill(wb);
        }

        public override string GetInfo()
        {
            return UserName + ", " + Status;
        }

    }
}
