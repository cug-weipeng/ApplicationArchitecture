using System;
using System.Data.SqlClient;
using System.Data.Common;

namespace ClassicThreeLayer.DAL.Implement
{
    public abstract class DaoBase<TEntity> : IDisposable
        where TEntity : class
    {
        protected readonly SqlConnection _connection;

        protected DaoBase(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException("existingDatabaseConnection");
            }

            this._connection = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            this._connection.Dispose();
        }
    }
}
