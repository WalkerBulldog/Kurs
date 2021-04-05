using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public abstract class Connector<TEntity>
    {
        private protected DBConnection connection;
        private protected ObjectFabric<TEntity> fabric = new ObjectFabric<TEntity>();

        public Connector(DBConnection connection)
        {
            this.connection = connection;
        }
        public abstract IEnumerable<TEntity> GetAll();
        public abstract bool Create(TEntity entity);
        public abstract bool Delete(int id);
        public abstract TEntity Update(TEntity entity);
        public abstract TEntity Get(int id);
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
