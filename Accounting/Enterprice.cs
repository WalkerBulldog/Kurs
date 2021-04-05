using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using WayBills;
using Drivers;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Accounting
{
    public class Enterprice
    {
        public DriversList driversList { get; private set; }
        public CarList carList { get; private set; }
        public WaybillList waybillList { get; private set; }
        private double fuelCost = 1.9;

        public Enterprice(DriversList driversList, CarList carList, WaybillList waybillList)
        {
            this.carList = carList;
            this.driversList = driversList;
            this.waybillList = waybillList;
        }
        public Enterprice()
        {
            driversList = new DriversList();
            carList = new CarList();
            waybillList = new WaybillList();
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
        public bool AddWayBill(string driverName, double distance, DateTime date, int carid, int driverid)
        {
            waybillList.Add(new Waybill(driverName, distance, date, carid, driverid));
            return true;
        }
        public bool RemoveCar(Car car)
        {
            return carList.Remove(car);
        }
        public bool RemoveWayBill(Waybill wb)
        {
            return waybillList.Remove(wb);
        }

        public double GetCost(Waybill WB)
        {
            return WB.Distance / 100 * carList.GetCar(WB.CarId).GasUse * fuelCost + driversList.GetDriver(WB.DriverId).GetSalary(WB) + carList.GetCar(WB.CarId).Service(WB.Distance);
        }
        public double GetProfit(Waybill WB) => GetCost(WB) * 1.2;
        public double GetFullCost()
        {
            double cost = 0;
            for (int i = 0; i < waybillList.Count; i++)
                cost += GetCost(waybillList[i]);
            return cost;
        }
        public string GetMostProfitDriver(DateTime dateBottom, DateTime dateUp, string car)
        {
            WaybillList tmp = waybillList;
            IEnumerable newList = from Waybill WB in tmp
                                  where WB.Date > dateBottom && WB.Date < dateUp && car == carList.GetCar(WB.CarId).TypeOfCar
                                  select WB;
            List<double> ProfitList = new List<double>();
            foreach (Waybill WB in newList)
                ProfitList.Add(GetProfit(WB));                  
            foreach (Waybill WB in newList)
                ProfitList.Add(GetProfit(WB));
            return driversList.GetDriver(ProfitList.IndexOf(ProfitList.Max())).ToString() + " " + ProfitList.Max();
        }

        public string GetInfo(string UserName)
        {
            string driverInfo = driversList.GetDriver(UserName).ToString();
            string waybillsInfo = waybillList.GetFullDistanceForDriverId(driversList.GetDriver(UserName).Id).ToString();
            string salaryInfo = driversList.GetDriver(UserName).GetSalary(waybillList).ToString();
            return driverInfo + "\nОбщий километраж: " + waybillsInfo + "\n Всего заработано: " + salaryInfo;
        }
    }
}
