using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using Connection;

namespace ORM
{
    class ConnectorToUsers
    {
        private protected DBConnection connection = DBConnection.Instance;
        private int GetLastId()
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select MAX(Id) as Id from users";
            return (int)connection.Command.ExecuteScalar();
        }
        public User Create(User entity)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "insert into users (login, password, userType, userName) values (@login, @password,@ut, @un)";
            connection.Command.Parameters.AddWithValue("@login", entity.Login);
            connection.Command.Parameters.AddWithValue("@password", entity.PassWord);
            connection.Command.Parameters.AddWithValue("@ut", entity.Status[0]);
            connection.Command.Parameters.AddWithValue("@un", entity.UserName);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return null;
            return Get(GetLastId());
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from users where id=@id";
            connection.Command.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        if ((string)reader.GetValue(3) == "D")
                            return new Driver((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(4));
                        else if ((string)reader.GetValue(3) == "O")
                            return new Operator((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(4));
                        else if ((string)reader.GetValue(3) == "A")
                            return new Admin((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(4));
                    }
                }
            }
            return null;

        }

        public IEnumerable<User> GetAll()
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from users";
            List<User> list = new List<User>();
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        if ((string)reader.GetValue(3) == "D")
                            list.Add(new Driver((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(4)));
                        else if ((string)reader.GetValue(3) == "O")
                            list.Add(new Operator((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(4)));
                        else if ((string)reader.GetValue(3) == "A")
                            list.Add(new Admin((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(4)));
                    }
                }
            }
            return list;
        }

        public User Update(User entity)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "update users set login=@login, password=@password, userType = @ut, userName=@un where id=@id";
            connection.Command.Parameters.AddWithValue("@id", entity.Id);
            connection.Command.Parameters.AddWithValue("@login", entity.Login);
            connection.Command.Parameters.AddWithValue("@password", entity.PassWord);
            connection.Command.Parameters.AddWithValue("@ut", entity.Status[0]);
            connection.Command.Parameters.AddWithValue("@un", entity.UserName);
            connection.Command.ExecuteNonQuery();
            return Get(entity.Id);
        }
    }
}
