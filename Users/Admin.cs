using Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace Users
{
    public class Admin : Operator
    {
        public override string Status { get { return "Admin"; } }


        public Admin(string Login, string PassWord, string UserName) : base(Login, PassWord, UserName)
        {
        }
    }
}
