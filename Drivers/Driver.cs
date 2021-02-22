using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace Drivers
{
    public class Driver
    {
        private string fio;
        private ClassOfDriver qualification;
        private CarList List = new CarList();
        private double Distance
        {
            get
            {
                return GetFullDistance();
            }
        }
        private double Money;

        
        public Driver(string fio, ClassOfDriver qualification)
        {
            this.fio = fio;
            this.qualification = qualification;
        }

        private double GetFullDistance() => List.GetFullDistance(fio);

    }
}
