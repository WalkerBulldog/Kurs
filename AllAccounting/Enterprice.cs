using System;
using System.Collections.Generic;
using System.Linq;
using Cars;
using WayBills;
using Drivers;
using System.Collections;
using ORM;

namespace AllAccounting
{
    public class Enterprice
    {
        private ConnectorToCars DBCars = new ConnectorToCars();
        private ConnectorToDrivers DBDrivers = new ConnectorToDrivers();
        private ConnectorToWaybills DBWaybills = new ConnectorToWaybills();
        private double fuelCost = 1.9;

        public Enterprice()
        {
        }
        public List<Driver> AddDriver(string fio, ClassOfDriver qualification) => (List<Driver>)DBDrivers.Create(new Driver(fio, qualification));
        public List<Car> AddBus(double gasoline, int passcapacity, double capacity) => (List<Car>)DBCars.Create(new Bus(gasoline, capacity, passcapacity));

        public List<Car> AddTruck(double gasoline, double cp) => (List<Car>)DBCars.Create(new Truck(gasoline, cp));
        public List<Car> AddVan(double gasoline, int passcapacity) => (List<Car>)DBCars.Create(new Van(gasoline, passcapacity));
        public List<Waybill> AddWayBill(double distance, DateTime date, int carid, int driverid) => (List<Waybill>)DBWaybills.Create(new Waybill(distance, date, carid, driverid));

        public List<Car> Delete(Car car) => (List<Car>)DBCars.Delete(car.id);
        public List<Waybill> Delete(Waybill wb) => (List<Waybill>)DBWaybills.Delete(wb.Id);
        public List<Driver> Delete(Driver driver) => (List<Driver>)DBDrivers.Delete(driver.Id);


        public double GetCost(Waybill WB)
        {
            return WB.Distance / 100 * DBCars.Get(WB.CarId).GasUse * fuelCost + DBDrivers.Get(WB.DriverId).GetSalary(WB) + DBCars.Get(WB.CarId).Service(WB.Distance);
        }
        public double GetProfit(Waybill WB) => GetCost(WB) * 0.2;
        public double GetFullCost()
        {
            double cost = 0;
            foreach (Waybill wb in DBWaybills.GetAll())
                cost += GetCost(wb);
            return cost;
        }
        public double GetFullProfit() => GetFullCost() * 0.2;
        public string GetMostProfitDriver(DateTime dateBottom, DateTime dateUp, string car)
        {            
            List<Waybill> list = (List<Waybill>)from Waybill WB in (WaybillList)DBWaybills.GetAll()
                                                    where WB.Date > dateBottom && WB.Date < dateUp && car == DBCars.Get(WB.CarId).TypeOfCar
                                                    select WB;
            if (list == null)
                return "Данных не обнаружено!";
            Dictionary<int, double> drivers = new Dictionary<int, double>(list.Count);
            drivers.Add(list[0].DriverId, GetProfit(list[0]));
            for (int i = 1; i < list.Count; i++)
            {
                bool itsNew = true;
                foreach (var driver in drivers)
                {
                    if (list[i].DriverId == driver.Key)
                    {
                        itsNew = false;
                        drivers[driver.Key] += GetProfit(list[i]);
                        break;
                    }
                }
                if (itsNew)
                    drivers.Add(list[i].DriverId, GetProfit(list[i]));
            }
            return DBDrivers.Get(drivers.Where(x => x.Value == drivers.Values.Max()).FirstOrDefault().Key).ToString() + " " + drivers.Values.Max();
        }

        public string GetInfo(string UserName)
        {
            Driver currentDriver = DBDrivers.Get(UserName);
            string driverInfo = currentDriver.ToString();
            double distance = ((List<double>)from Waybill wb in DBWaybills.GetAll()
                                             where wb.DriverId == currentDriver.Id
                                             select wb.Distance).Sum();
            string waybillsInfo = distance.ToString();
            string salaryInfo = DBDrivers.Get(UserName).GetSalary(distance).ToString();
            return driverInfo + "\nОбщий километраж: " + waybillsInfo + "\nВсего заработано: " + salaryInfo;
        }
        public Car GetCar(int id) => DBCars.Get(id);
        public Driver GetDriver(int id) => DBDrivers.Get(id);
        public Waybill GetWaybill(int id) => DBWaybills.Get(id);

        public List<Waybill> GetWaybillsByUserName(string userName)
        {
            IEnumerable<int> id = (from Driver dr in DBDrivers.GetAll()
                          where dr.Name == userName
                          select dr.Id).ToList();
            List<Waybill> list = (from Waybill wb in DBWaybills.GetAll()
                                  where wb.DriverId == id.First()
                                  select wb).ToList();
            return list;
        }
    }
}
