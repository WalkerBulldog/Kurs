using Drivers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public class ConnectorToDrivers : Connector<Driver>
    { 
        public ConnectorToDrivers(DBConnection connection):base(connection)
        {
        }
        public override bool Create(Driver driver)
        {
            connection.Command.CommandText = "insert into водители (ФИО, Классность) values (@FIO, @qual)";
            connection.Command.Parameters.AddWithValue("@FIO", driver.Name);
            connection.Command.Parameters.AddWithValue("@qual", driver.qualification.ToString());
            int result = connection.Command.ExecuteNonQuery();
            if (result == -1)
                return false;
            return true;
        }

        public override bool Delete(int id)
        {
            connection.Command.CommandText = "delete from водители where ID=@drID";
            connection.Command.Parameters.AddWithValue("@drID", id);
            int result = connection.Command.ExecuteNonQuery();
            if (result == -1)
                return false;
            return true;
        }

        public override Driver Get(int id)
        {
            connection.Command.CommandText = "select * from водители where ID=@drID";
            connection.Command.Parameters.AddWithValue("@drID", id);
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
                object name = null;
                object driverId = 0;
                object qualification = default;
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        driverId = reader.GetValue(0);
                        name = reader.GetValue(1);
                        qualification = reader.GetValue(2);
                    }
                    return fabric.GetObject(driverId, name, qualification);
                }
            }
            return null;
            
            

        }

        public override IEnumerable<Driver> GetAll()
        {
            connection.Command.CommandText = "select * from водители";
            DriversList list = new DriversList();
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
               
                if (reader.HasRows) // если есть данные
                    while (reader.Read())
                        list.Add(fabric.GetObject(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2)));               
            }
            return list;
        }
        public override Driver Update(Driver newDriver)
        {
            connection.Command.CommandText = "update водители set ФИО=@FIO, Классность=@qual where ID=@drivID";
            connection.Command.Parameters.AddWithValue("@drivID", newDriver.Id);
            connection.Command.Parameters.AddWithValue("@FIO", newDriver.Name);
            connection.Command.Parameters.AddWithValue("@qual", newDriver.qualification.ToString());
            connection.Command.ExecuteNonQuery();
            return Get(newDriver.Id);
        }
    }
}
