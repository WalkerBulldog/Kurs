using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Operator : User
    {
        public Operator(string Login, string PassWord, string UserName) : base(Login, PassWord, UserName)
        {
        }
        public bool AppendRoadList()
        {
            return true;
        }
        public bool AppendCar()
        {
            return true;
        }
        public bool EditRoadList()
        {
            return true;
        }
        public bool EditCar()
        {
            return true;
        }
    }
}
