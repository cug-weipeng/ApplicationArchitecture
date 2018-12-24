using System;

namespace ClassicThreeLayer.DAL.Implement
{
    public abstract class DaoBase<TEntity> : IDisposable
        where TEntity : class
    {
        private readonly string _connection;

        public DaoBase(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
            {
                throw new ArgumentNullException("existingDatabaseConnection");
            }

            this._connection = connection;
        }

        public void Dispose()
        {
            //this._connection.Dispose();
        }
    }
}
