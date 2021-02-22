using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class CarList
    {
        private List<Car> List = new List<Car>();
        public void Add(Car car)
        {
            List.Add(car);
        }
        public void Remove(Car car)
        {
            List.Remove(car);
        }
        public double GetFullDistance(string fio)
        {
            double sum = 0;
            foreach (Car car in List)
                sum += car.GetFullDistance(fio);
            return sum;
        }
    }
}
