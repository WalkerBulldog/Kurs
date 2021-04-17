    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using MySql.Data.MySqlClient;

namespace ORM
{
    public class ConnectorToCars : Connector<Car>
    {
        private int CheckCarType(Car car)
        {
            if (car.GetType() == typeof(Truck))
                return 1;
            if (car.GetType() == typeof(Van))
                return 2;
            if (car.GetType() == typeof(Bus))
                return 3;
            return 0;
        }
        public override IEnumerable<Car> Create(Car car)
        {
            int type = CheckCarType(car);
            if (type == 1)
                return CreateTruck((Truck)car);
            if (type == 2)
                return CreateVan((Van)car);
            if (type == 3)
                return CreateBus((Bus)car);
            return null;
        }

        private CarList CreateTruck(Truck truck)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "INSERT INTO общиемашины(Тип,Расход,Грузоподъемность) VALUES(@Tip,@use,@cap)";
            connection.Command.Parameters.AddWithValue("@Tip", truck.TypeOfCar);
            connection.Command.Parameters.AddWithValue("@use", truck.GasUse);
            connection.Command.Parameters.AddWithValue("@cap", truck.Capacity);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return null;
            return (CarList)GetAll();
        }
        private IEnumerable<Car> CreateBus(Bus bus)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "INSERT INTO общиемашины(Тип,Расход,Грузоподъемность,Пассажироемкость) VALUES(@tip,@useg,@capp,@pass)";
            connection.Command.Parameters.AddWithValue("@tip", bus.TypeOfCar);
            connection.Command.Parameters.AddWithValue("@useg", bus.GasUse);
            connection.Command.Parameters.AddWithValue("@capp", bus.Capacity);
            connection.Command.Parameters.AddWithValue("@pass", bus.PassCapacity);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return null;
            return GetAll();
        }
        private IEnumerable<Car> CreateVan(Van van)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "INSERT INTO общиемашины(Тип,Расход,Пассажироемкость) VALUES(@tip,@useg,@pass)";
            connection.Command.Parameters.AddWithValue("@tip", van.TypeOfCar);
            connection.Command.Parameters.AddWithValue("@useg", van.GasUse);
            connection.Command.Parameters.AddWithValue("@pass", van.PassCapacity);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return null;
            return (CarList)GetAll();
        }

        public override IEnumerable<Car> Delete(int id)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "delete from общиемашины where ID=@carID";
            connection.Command.Parameters.AddWithValue("@carID", id);
            connection.Command.ExecuteNonQuery();
            return (CarList)GetAll();
        }

        public override Car Get(int id)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from общиемашины where ID=@cID";
            connection.Command.Parameters.AddWithValue("@cID", id);
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        var x = reader.GetValue(3);
                        var y = reader.GetValue(4);
                        if (x.GetType() == typeof(DBNull))
                            return new Van((int)reader.GetValue(0), (double)reader.GetValue(2), (int)reader.GetValue(4));
                        else if (y.GetType() == typeof(DBNull))
                            return new Truck((int)reader.GetValue(0), (double)reader.GetValue(2), (double)reader.GetValue(3));                       
                        else
                            return new Bus((int)reader.GetValue(0), (double)reader.GetValue(2), (double)reader.GetValue(3), (int)reader.GetValue(4));
                    }
                }
            }
            return null;
        }

        public override IEnumerable<Car> GetAll()
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from общиемашины";
            CarList list = new CarList();
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        var x = reader.GetValue(3);
                        var y = reader.GetValue(4);
                        if (x.GetType() == typeof(DBNull))
                            list.Add(new Van((int)reader.GetValue(0), (double)reader.GetValue(2), (int)reader.GetValue(4)));
                        else if (y.GetType() == typeof(DBNull))
                            list.Add(new Truck((int)reader.GetValue(0), (double)reader.GetValue(2), (double)reader.GetValue(3)));
                        else
                            list.Add(new Bus((int)reader.GetValue(0), (double)reader.GetValue(2), (double)reader.GetValue(3), (int)reader.GetValue(4)));
                    }
                }
            }
            return list;
        }

        public override IEnumerable<Car> Update(Car car)
        {
            int type = CheckCarType(car);
            if (type == 1)
                return UpdateTruck((Truck)car);
            if (type == 2)
                return UpdateVan((Van)car);
            if (type == 3)
                return UpdateBus((Bus)car);
            return null;
        }
        private IEnumerable<Car> UpdateTruck(Truck truck)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "update общиемашины set Тип=@Tipp,Расход = @uses,Грузоподъемность=@caps where Id=@truckId";
            connection.Command.Parameters.AddWithValue("@Tipp", truck.TypeOfCar);
            connection.Command.Parameters.AddWithValue("@uses", truck.GasUse);
            connection.Command.Parameters.AddWithValue("@caps", truck.Capacity);
            connection.Command.Parameters.AddWithValue("@truckId", truck.id);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return null;
            return GetAll();
        }
        private IEnumerable<Car> UpdateBus(Bus bus)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "update общиемашины set Тип=@Tippb,Расход = @usesb,Грузоподъемность=@capsb, Пассажироемкость=@pcapb where Id=@busId";
            connection.Command.Parameters.AddWithValue("@Tippb", bus.TypeOfCar);
            connection.Command.Parameters.AddWithValue("@usesb", bus.GasUse);
            connection.Command.Parameters.AddWithValue("@capsb", bus.Capacity);
            connection.Command.Parameters.AddWithValue("@busId", bus.id);
            connection.Command.Parameters.AddWithValue("@pcapb", bus.PassCapacity);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return null;
            return GetAll();
        }
        private IEnumerable<Car> UpdateVan(Van van)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "update общиемашины set Тип=@Tipvp,Расход = @usesv,Пассажироемкость=@passv where Id=@vanId";
            connection.Command.Parameters.AddWithValue("@Tippv", van.TypeOfCar);
            connection.Command.Parameters.AddWithValue("@usesv", van.GasUse);
            connection.Command.Parameters.AddWithValue("@vanId", van.id);
            connection.Command.Parameters.AddWithValue("@passv", van.PassCapacity);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return null;
            return GetAll();
        }
    }
}
