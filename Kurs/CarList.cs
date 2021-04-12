using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace Cars
{
    public class CarList : IEnumerable<Car>
    {
        private List<Car> List = new List<Car>();
        public bool Add(Car Newcar)
        {
            List.Add(Newcar);
            return true;
        }
        public bool Remove(Car car)
        {        
           return List.Remove(car);
        }
        public Car GetCar(int id)
        {
            IEnumerable<Car> cars = (from Car car in List
                                           where car.id == id
                                           select car);
            return cars.First();
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder("");
            foreach (Car wb in List)
                str.Append(wb.ToString() + "\n");
            return str.ToString();
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return ((IEnumerable<Car>)List).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)List).GetEnumerator();
        }
    }
}
