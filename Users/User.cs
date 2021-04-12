using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllAccounting;

namespace Users
{
    public abstract class User
    {
        protected Enterprice Enterprice = new Enterprice();
        public int Id { get; }
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
        public User(int id, string Login, string PassWord, string UserName)
        {
            this.Id = id;
            this.Login = Login;
            this.PassWord = PassWord;
            this.UserName = UserName;
        }
    }
}
