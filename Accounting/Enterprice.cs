using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using WayBills;
using Drivers;

namespace Accounting
{
    public class Enterprice
    {
        public DriversList driversList { get; private set; }
        public CarList carList { get; private set; }
        public WaybillList WaybillList { get; private set; }
        private double FuelCost = 1.9;

        public Enterprice(DriversList driversList, CarList carList, WaybillList waybillList)
        {
            this.carList = carList;
            this.driversList = driversList;
            this.WaybillList = waybillList;
        }
        public Enterprice()
        {
            driversList = new DriversList();
            carList = new CarList();
            WaybillList = new WaybillList();
        }
        public bool AddDriver(int id, string FIO, ClassOfDriver qualification)
        {
            return driversList.Add(new Driver(id, FIO, qualification));
        }
        public bool AddBus(int id, double GasUse, int pc, double cp)
        {
            return carList.Add(new Bus(id, GasUse, cp, pc));
        }
        public bool AddTruck(int id, double GasUse, double cp)
        {
            return carList.Add(new Truck(id, GasUse, cp));
        }
        public bool AddMiniBus(int id, double GasUse, int pc)
        {
            return carList.Add(new MiniBus(id, GasUse, pc));
        }
        public bool AddWayBill(string fn, double dist, DateTime dt, int carid, int drid)
        {
            WaybillList.Add(new Waybill(fn, dist, dt, carid, drid));
            return true;
        }

        public double GetCost(Waybill WB)
        {
            return WB.Distance * carList.GetCar(WB.CarId).GasUse * FuelCost + driversList.GetDriver(WB.DriverId).GetSalary(WB) + carList.GetCar(WB.CarId).Service(WB.Distance);
        }
        public double GetProfit(Waybill WB) => GetCost(WB) * 1.2;
        public double GetFullCost()
        {
            double cost = 0;
            for (int i = 0; i < WaybillList.Count; i++)
                cost += GetCost(WaybillList[i]);
            return cost;
        }
        public string GetMostProfitDriver(DateTime dateBottom, DateTime dateUp, Car car)
        {
            List<Waybill> WBList = WaybillList.GetWaybills(dateBottom, dateUp);
            List<double> ProfitList = new List<double>();
            foreach (Waybill WB in WBList)
                if (car.TypeOfCar != carList.GetCar(WB.CarId).TypeOfCar)
                    WBList.Remove(WB);
            foreach (Waybill WB in WBList)
            {
                ProfitList.Add(GetProfit(WB));
            }
            return driversList.GetDriver(ProfitList.IndexOf(ProfitList.Max())).ToString() + " " + ProfitList.Max();
        }
    }
}
