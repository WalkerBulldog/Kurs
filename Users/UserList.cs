using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;

namespace Users
{
    public class UserList
    {
        List<User> List = new List<User>();
        Enterprice Enterprice = new Enterprice();
        public UserList()
        {

        }
        public bool Add(User user)
        {
            if (user == null && CheckEntry(user.Login, user.PassWord) != null)
                return false;
            List.Add(user);
            return true;
        }
        public bool Remove(User user)
        {
            return List.Remove(user);
        }
        public User CheckEntry(string Login, string Password)
        {
            User YourUser = null;
            foreach (User user in List)
            {
                if (user.Login == Login && user.PassWord == Password)
                {
                    YourUser = user;
                    break;
                }               
            }
            return YourUser;
        }
    }
}
