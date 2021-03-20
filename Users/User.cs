using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;

namespace Users
{
    public abstract class User
    {
        protected Enterprice Enterprice = new Enterprice();
        public string Login { get; }
        public string PassWord { get; }
        public string UserName { get; }
        public abstract string Status { get; }

        public User(string Login, string PassWord, string UserName)
        {
            this.Login = Login;
            this.PassWord = PassWord;
            this.UserName = UserName;
        }
        public abstract string GetInfo();
    }
}
