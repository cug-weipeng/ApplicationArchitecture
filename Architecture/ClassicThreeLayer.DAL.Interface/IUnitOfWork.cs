using System;

namespace ClassicThreeLayer.DAL.Interface
{
    public interface IUnitOfWork : IDisposable 
    {
        void Commit();
    }
}
