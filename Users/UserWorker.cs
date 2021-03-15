using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;

namespace Users
{
    public class UserWorker
    {
        private Enterprice factory = new Enterprice();
        public string EnteredLogin { get; }
        public string EnteredPassword { get; }
        public UserWorker(string EnteredLogin, string EnteredPassword)
        {
            this.EnteredLogin = EnteredLogin;
            this.EnteredPassword = EnteredPassword;
        }
    }
}
