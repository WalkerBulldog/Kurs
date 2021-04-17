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
        }
        public bool AddDriver(string fio, ClassOfDriver qualification)
        {
            Driver driver = DBDrivers.Create(new Driver(fio, qualification));
            return driversList.Add(driver);
        }
        public bool AddBus(double gasoline, int passcapacity, double capacity)
        {
            Bus bus =(Bus)DBCars.Create(new Bus(gasoline, capacity, passcapacity));
            return carList.Add(bus);
        }
        public bool AddTruck(double gasoline, double cp)
        {
            Truck truck = (Truck)DBCars.Create(new Truck(gasoline, cp));
            return carList.Add(truck);
        }
        public bool AddVan(double gasoline, int passcapacity)
        {
            Van van = (Van)DBCars.Create(new Van(gasoline, passcapacity));
            return carList.Add(van);
        }
        public bool AddWayBill(double distance, DateTime date, int carid, int driverid)
        {
            Waybill wb = DBWaybills.Create(new Waybill(distance, date, carid, driverid));           
            return waybillList.Add(wb);
        }
        public bool Delete(Car car)
        {
            carList = (CarList)DBCars.GetAll();
            if (DBCars.Delete(car.id))             
                return carList.Remove(car);
            return false;
        }
        public bool Delete(Waybill wb)
        {
            carList = (CarList)DBCars.GetAll();
            if (DBWaybills.Delete(wb.Id))
                return waybillList.Remove(wb);
            return false;
        }
        public bool Delete(Driver driver)
        {
            carList = (CarList)DBCars.GetAll();
            if (DBDrivers.Delete(driver.Id))
                return driversList.Remove(driver);
            return false;
        }


        public double GetCost(Waybill WB)
        {
            return WB.Distance / 100 * carList.GetCar(WB.CarId).GasUse * fuelCost + driversList.GetDriver(WB.DriverId).GetSalary(WB) + carList.GetCar(WB.CarId).Service(WB.Distance);
        }
        public double GetProfit(Waybill WB) => GetCost(WB) * 0.2;
        public double GetFullCost()
        {
            waybillList = (WaybillList)DBWaybills.GetAll();
            double cost = 0;
            for (int i = 0; i < waybillList.Count; i++)
                cost += GetCost(waybillList[i]);
            return cost;
        }
        public double GetFullProfit() => GetFullCost() * 0.2;
        public string GetMostProfitDriver(DateTime dateBottom, DateTime dateUp, string car)
        {
            //List<double> ProfitList = (List<double>)from Waybill WB in (WaybillList)DBWaybills.GetAll()
            //                      where WB.Date > dateBottom && WB.Date < dateUp && car == carList.GetCar(WB.CarId).TypeOfCar
            //                      select GetProfit(WB);                  
            //return driversList.GetDriver(ProfitList.IndexOf(ProfitList.Max())).ToString() + " " + ProfitList.Max();
            
            List<Waybill> list = (List<Waybill>)from Waybill WB in (WaybillList)DBWaybills.GetAll()
                                                    where WB.Date > dateBottom && WB.Date < dateUp && car == carList.GetCar(WB.CarId).TypeOfCar
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
            return driversList.GetDriver(drivers.Where(x => x.Value == drivers.Values.Max()).FirstOrDefault().Key).ToString() + " " + drivers.Values.Max();
        }

        public string GetInfo(string UserName)
        {
            driversList = (DriversList)DBDrivers.GetAll();
            waybillList = (WaybillList)DBWaybills.GetAll();
            string driverInfo = driversList.GetDriver(UserName).ToString();
            string waybillsInfo = waybillList.GetFullDistanceForDriverId(driversList.GetDriver(UserName).Id).ToString();
            string salaryInfo = driversList.GetDriver(UserName).GetSalary(waybillList).ToString();
            return driverInfo + "\nОбщий километраж: " + waybillsInfo + "\nВсего заработано: " + salaryInfo;
        }
        public Car GetCar(int id) => DBCars.Get(id);
        public Driver GetDriver(int id) => DBDrivers.Get(id);
        public Waybill GetWaybill(int id) => DBWaybills.Get(id);
        public void UpdateALL()
        {
            driversList = (DriversList)DBDrivers.GetAll();
            carList = (CarList)DBCars.GetAll();
            waybillList = (WaybillList)DBWaybills.GetAll(); 
        }
        public List<string> GetWaybillsByUserName(string userName)
        {
            waybillList = (WaybillList)DBWaybills.GetAll();
            driversList = (DriversList)DBDrivers.GetAll();
            IEnumerable<int> id = (from Driver dr in driversList
                          where dr.Name == userName
                          select dr.Id).ToList();
            List<string> list = (List<string>)(from Waybill wb in waybillList
                                where wb.DriverId == id.First()
                                select wb.ToString()).ToList<string>();
            return list;
        }

        public Car Update(Car car)
        {
            return DBCars.Update(car);
        }
        public Waybill Update(Waybill wb)
        {
            return DBWaybills.Update(wb);
        }
        public Driver Update(Driver driver)
        {
            return DBDrivers.Update(driver);
        }
    }
}
