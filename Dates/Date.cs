using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drivers;

namespace Dates
{
    public class Date
    {
        private DateTime date;
        private DriversList List = new DriversList();
        public Date(DateTime date)
        {
            this.date = date;
        }
    }
}
