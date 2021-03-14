using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace Cars
{
    public class CarList
    {
        private List<Car> List = new List<Car>();
        public bool Add(Car Newcar)
        {
            foreach (Car car in List)
                if (Newcar.id == car.id)
                    return false;
            List.Add(Newcar);
            return true;
        }
        public bool Remove(Car car)
        {        
           return List.Remove(car);
        }
    }
}
