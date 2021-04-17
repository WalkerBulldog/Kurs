using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connection;

namespace ORM
{
    public abstract class Connector<TEntity>
    {
        private protected DBConnection connection = DBConnection.Instance;
        private protected ObjectFabric<TEntity> fabric = new ObjectFabric<TEntity>();
        public abstract IEnumerable<TEntity> GetAll();
        public abstract IEnumerable<TEntity> Create(TEntity entity);
        public abstract IEnumerable<TEntity> Delete(int id);
        public abstract IEnumerable<TEntity> Update(TEntity entity);
        public abstract TEntity Get(int id);
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
