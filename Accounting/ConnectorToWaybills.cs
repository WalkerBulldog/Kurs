using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBills;

namespace ORM
{
    public class ConnectorToWaybills : Connector<Waybill>
    {
        private int GetLastId()
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select MAX(Id) as Id from путевые_листы";
            return (int)connection.Command.ExecuteScalar();
        }
        public override Waybill Create(Waybill waybill)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "insert into путевые_листы (IdАвтомобиля, IdВодителя, Расстояние, Дата) values (@IDcar, @IDdriver,@Dist,@Date)";
            connection.Command.Parameters.AddWithValue("@IDcar", waybill.CarId);
            connection.Command.Parameters.AddWithValue("@IDdriver", waybill.DriverId);
            connection.Command.Parameters.AddWithValue("@Dist", waybill.Distance);
            connection.Command.Parameters.AddWithValue("@Date", waybill.Date);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return null;
            return Get(GetLastId());
        }

        public override bool Delete(int id)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "delete from путевые_листы where ID=@wbID";
            connection.Command.Parameters.AddWithValue("@wbID", id);
            int result = connection.Command.ExecuteNonQuery();
            if (result == 0)
                return false;
            return true;
        }

        public override Waybill Get(int id)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from путевые_листы where ID=@wayID";
            connection.Command.Parameters.AddWithValue("@wayID", id);
            Waybill wb = null;
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while(reader.Read())
                        wb = new Waybill((int)reader.GetValue(0),(double)reader.GetValue(3),(DateTime)reader.GetValue(4),(int)reader.GetValue(1), (int)reader.GetValue(2));
                }
            }
            return wb;



        }

        public override IEnumerable<Waybill> GetAll()
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "select * from путевые_листы";
            WaybillList list = new WaybillList();
            using (MySqlDataReader reader = connection.Command.ExecuteReader())
            {

                if (reader.HasRows) // если есть данные
                    while (reader.Read())
                        list.Add(new Waybill((int)reader.GetValue(0), (double)reader.GetValue(3), (DateTime)reader.GetValue(4), (int)reader.GetValue(1), (int)reader.GetValue(2)));
            }
            return list;
        }
        public override Waybill Update(Waybill waybill)
        {
            connection.Command.Parameters.Clear();
            connection.Command.CommandText = "update путевые_листы set IdАвтомобиля = @carId, IdВодителя = @driverId, Расстояние = @dist, Дата = @date where ID=@WBID";
            connection.Command.Parameters.AddWithValue("@WBID", waybill.Id);
            connection.Command.Parameters.AddWithValue("@carId", waybill.CarId);
            connection.Command.Parameters.AddWithValue("@driverId", waybill.DriverId);
            connection.Command.Parameters.AddWithValue("@dist", waybill.Distance);
            connection.Command.Parameters.AddWithValue("@date", waybill.Date);
            connection.Command.ExecuteNonQuery();
            return Get(waybill.Id);
        }
    }
}
