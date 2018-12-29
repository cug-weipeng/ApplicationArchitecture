using System;

namespace ClassicThreeLayer.Database
{
    public abstract class UnitOfWork : IDisposable 
    {
        public bool Transaction { get; set; }

        abstract public bool Commit();

        abstract public bool Rollback();

        abstract public void Dispose();
    }
}
