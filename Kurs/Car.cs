﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace Cars
{
    public abstract class Car
    {
        public int id { get; }
        public string TypeOfCar { get; }
        public double GasUse { get; }
       
        public Car(int id, string Mark, double GasUse)
        {
            this.TypeOfCar = Mark;
            this.GasUse = GasUse;
            this.id = id;
        }
        public double GetDistance(WaybillList WBList)
        {
            return WBList.GetFullDistanceForCarId(id);
        }
        public abstract double Service(double Distance);
        public override abstract string ToString();

    }
}
