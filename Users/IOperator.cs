using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using WayBills;

namespace Users
{
    public interface IOperator
    {
        string Status { get; }
        bool AddBus(int id, double GasUse, double Capacity, int PassCapacity);
        bool AddTruck(int id, double GasUse, double Capacity);
        bool AddMiniBus(int id, double GasUse, int PassCapacity);       
        bool RemoveCar(Car car);
        bool AddWayBill(string driverName, double distance, DateTime dateTime, int carid, int driverid);
        bool RemoveWayBill(Waybill wb);

    }
}
