using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Admin : Operator
    {
        public Admin(string Login, string PassWord, string UserName) : base(Login, PassWord, UserName)
        {
        }
    }
}
