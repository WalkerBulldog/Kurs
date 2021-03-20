using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;

namespace Users
{
    public class Driver : User
    {

        public override string Status { get { return "Driver"; } }
        public Driver(string Login, string PassWord, string UserName) : base(Login, PassWord, UserName)
        {
        }

        public override string GetInfo()
        {
            string info = Enterprice.GetInfo(UserName);
            if (info == null || info.Count() == 0)
                return "Инофрмации о вас не обнаружено.";
            return Status + " " + info;
        }
    }
}
