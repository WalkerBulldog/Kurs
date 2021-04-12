using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Users
{
    public class Operator : User
    {
        public override string Status { get { return "Operator"; } }

        public Operator(string Login, string PassWord, string UserName) : base
            (Login, PassWord, UserName)
        {
        }
        public Operator(int id, string Login, string PassWord, string UserName) : base
           (id, Login, PassWord, UserName)
        {
        }
        public bool AddWayBill(double distance, DateTime dateTime, int carid, int driverid)
        {
            return Enterprice.AddWayBill(distance, dateTime, carid, driverid);
        }
        public bool AddBus(double GasUse, double Capacity, int PassCapacity)
        {
            return Enterprice.AddBus(GasUse, PassCapacity, Capacity);
        }
        public bool AddTruck(double GasUse, double Capacity)
        {
            return Enterprice.AddTruck(GasUse, Capacity);
        }
        public bool AddVan(double GasUse, int PassCapacity)
        {
            return Enterprice.AddVan(GasUse, PassCapacity);
        }      

        public override string ToString()
        {
            return UserName + ", " + Status;
        }

    }
}
