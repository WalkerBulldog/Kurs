using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAccounting
{
    public class DriversList : IEnumerable<Driver>
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
            IEnumerable<Driver> drivers = (from Driver dr in List
                                                 where dr.Id == id
                                                 select dr);
            return drivers.First();
        }
        public Driver GetDriver(string Name)
        {
            IEnumerable<Driver> drivers = (from Driver dr in List
                                                where dr.Name == Name
                                                select dr);
            return drivers.First();
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder("");
            foreach (Driver wb in List)
                str.Append(wb.ToString() + "\n");
            return str.ToString();
        }

        public IEnumerator<Driver> GetEnumerator()
        {
            return ((IEnumerable<Driver>)List).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)List).GetEnumerator();
        }
    }
}
