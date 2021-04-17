using Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;
using Drivers;
using AllAccounting;
using ORM;

namespace Users
{
    public class Admin : Operator
    {
        public override string Status { get { return "Admin"; } }
        private ConnectorToUsers connector = new ConnectorToUsers();

        public override string ToString()
        {
            return UserName + ", " + Status;
        }
        public Admin(string Login, string PassWord, string UserName) : base(Login, PassWord, UserName)
        {
        }
        public Admin(int id, string Login, string PassWord, string UserName) : base(id, Login, PassWord, UserName)
        {
        }
        public bool Add(string login, string password, string userName, ClassOfDriver qualification)
        {
            UserDriver driver = new UserDriver(login, password, userName);
            if (connector.Create(driver) != null)
            {
                bool result = Enterprice.AddDriver(userName, qualification);
                if (result)
                    return true;
                else
                {
                    connector.Delete(driver.Id);
                    return false;
                }
            }
            else return false;
        }
        public bool Remove(Car car)
        {
            return Enterprice.Delete(car);
        }

        public bool Remove(Waybill wb)  
        {
            return Enterprice.Delete(wb);
        }
        public bool Remove(Drivers.Driver driver)
        {
            return Enterprice.Delete(driver);
        }
        public User AddOperator(string login, string password, string userName)
        {
            return connector.Create(new Operator(login, password, userName));
        }
        public User AddAdmin(string login, string password, string userName)
        {
            return connector.Create(new Admin(login, password, userName));
        }
        public bool Remove(int id)
        {
            return connector.Delete(id);
        }
        public User Update(User newUser)
        {
            return connector.Update(newUser);
        }
        public Waybill Update(Waybill wb)
        {
            return Enterprice.Update(wb);
        }
        public Car Update(Car car)
        {
            return Enterprice.Update(car);
        }
        public Drivers.Driver Update(Drivers.Driver driver)
        {
            return Enterprice.Update(driver);
        }
        public string GetMostProfitDrivers(DateTime bottom, DateTime up, string carType)
        {
            return Enterprice.GetMostProfitDriver(bottom, up, carType);
        }
        public string GetCost(Waybill wb)
        {
            return Enterprice.GetCost(wb).ToString();
        }
        public string GetFullCost()
        {
            return Enterprice.GetFullCost().ToString();
        }
        public string GetProfit(Waybill wb)
        {
            return Enterprice.GetProfit(wb).ToString();
        }
        public string GetFullProfit()
        {
            return Enterprice.GetFullProfit().ToString();
        }
    }
}
