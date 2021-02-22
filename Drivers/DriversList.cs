using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers
{
    public class DriversList
    {
        private List<Driver> List = new List<Driver>();
        public void Add(Driver dr)
        {
            List.Add(dr);
        }
        public void Remove(Driver dr)
        {
            List.Remove(dr);
        }
    }
}
