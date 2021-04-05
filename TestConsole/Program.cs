using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;
using Drivers;

namespace TestConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleEnterprice tc = new ConsoleEnterprice();
            //tc.Menu();
            DBConnection connection = DBConnection.Instance;
            ConnectorToDrivers conn = new ConnectorToDrivers(connection);
            conn.Update(new Driver(4,"csssss","second"));
            foreach (var d in conn.GetAll())
                Console.WriteLine(d.ToString() + "\n");
            Console.ReadKey();
        }
        
    }
}
