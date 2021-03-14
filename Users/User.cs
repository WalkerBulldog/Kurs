using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class User
    {
        public string Login { get; }
        public string PassWord { get; }
        public string UserName { get; }

        public User(string Login, string PassWord, string UserName)
        {
            this.Login = Login;
            this.PassWord = PassWord;
            this.UserName = UserName;
        }
        public void GetInfo()
        {

        }
    }
}
