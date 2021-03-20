using System;
using System.Collections;
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
        public Driver GetDriver(int id)
        {
            foreach (Driver driver in List)
                if (driver.Id == id)
                    return driver;
            return null;
        }
        public Driver GetDriver(string Name)
        {
            foreach (Driver driver in List)
                if (driver.Name == Name)
                    return driver;
            return null;
        }
        public override string ToString()
        {
            string str = "";
            foreach (Driver wb in List)
                str += wb.ToString();
            return str;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
