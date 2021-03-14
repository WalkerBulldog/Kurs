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
        public bool Add(Driver dr)
        {
            foreach (Driver driver in List)
                if (driver.Id == dr.Id)
                    return false;

            List.Add(dr);
            return true;
        }
        public bool Remove(Driver dr)
        {
            return List.Remove(dr);
        }
    }
}
