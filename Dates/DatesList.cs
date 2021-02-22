using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    public class DatesList
    {
        public List<Date> List = new List<Date>();
        public void Add(Date dt)
        {
            List.Add(dt);
        }
        public void Remove(Date dt)
        {
            List.Remove(dt);
        }
    }
}
