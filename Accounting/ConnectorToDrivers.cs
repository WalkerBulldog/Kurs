using Drivers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ConnectorToDrivers : Connector<Driver>
    { 
        public override IEnumerable<Driver> Create(Driver driver)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "insert into водители (ФИО, Классность) values (@FIO, @qual)";
            connection.Command.Parameters.AddWithValue("@FIO", driver.Name);
            connection.Command.Parameters.AddWithValue("@qual", driver.Qualification.ToString());
            connection.Command.ExecuteNonQuery();
            return GetAll();
        }

        public override IEnumerable<Driver> Delete(int id)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "delete from водители where ID=@drID";
            connection.Command.Parameters.AddWithValue("@drID", id);
            connection.Command.ExecuteNonQuery();
            return GetAll();
        }

        public override Driver Get(int id)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from водители where ID=@dID";
            connection.Command.Parameters.AddWithValue("@dID", id);
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            { 
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                        return new Driver((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2));
                }
            }
            return null;
        }
        public Driver Get(string name)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from водители where ФИО=@name";
            connection.Command.Parameters.AddWithValue("@name", name);
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                        return new Driver((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2));
                }
            }
            return null;
        }

        public override IEnumerable<Driver> GetAll()
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from водители";
            DriversList list = new DriversList();
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
               
                if (reader.HasRows) // если есть данные
                    while (reader.Read())
                        list.Add(new Driver((int)reader.GetValue(0),(string)reader.GetValue(1),(string)reader.GetValue(2)));               
            }
            return list;
        }
        public override IEnumerable<Driver> Update(Driver newDriver)
        {
            connection.Command.Parameters.Clear();
            if (newDriver.Id == 0)
                return null;
            connection.Command.CommandText = "update водители set ФИО=@FIO, Классность=@qual where ID=@drivID";
            connection.Command.Parameters.AddWithValue("@drivID", newDriver.Id);
            connection.Command.Parameters.AddWithValue("@FIO", newDriver.Name);
            connection.Command.Parameters.AddWithValue("@qual", newDriver.Qualification.ToString());
            connection.Command.ExecuteNonQuery();
            return GetAll();
        }
    }
}
