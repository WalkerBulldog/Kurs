using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM;

namespace Users
{
    public class UnsignedUser
    {
        private ConnectorToUsers connector = new ConnectorToUsers();
        public User Enter(string login, string password)
        {
            int id = connector.UserExists(login, password);
            if (id == 0)
                return null;
            return connector.Get(id);
        }
    }
}
