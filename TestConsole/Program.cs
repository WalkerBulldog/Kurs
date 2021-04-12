using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM;
using Drivers;
using WayBills;

namespace TestConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleEnterprice tc = new ConsoleEnterprice();
            tc.Menu();
            ConnectorToWaybills c = new ConnectorToWaybills();
            Console.ReadKey();
        }
        
    }
}
