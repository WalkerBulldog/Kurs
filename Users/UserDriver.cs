using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllAccounting;
using WayBills;

namespace Users
{
    public class UserDriver : User
    {

        public override string Status { get { return "Driver"; } }
        public UserDriver(string Login, string PassWord, string UserName) : base(Login, PassWord, UserName)
        {
        }
        public UserDriver(int id, string Login, string PassWord, string UserName) : base(id, Login, PassWord, UserName)
        {
        }

        public override string ToString()
        {           
            string info = Enterprice.GetInfo(UserName);
            if (info == null || info.Count() == 0)
                return "Инофрмации о вас не обнаружено.";
            return Status + " " + info;
        }
        public List<string> GetWaybills()
        {
            return Enterprice.GetWaybillsByUserName(UserName);
        }
     }
}
