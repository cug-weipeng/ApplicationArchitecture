using ClassicThreeLayer.BLL.Interface;
using System;
using ClassicThreeLayer.DAL.Factory;

namespace ClassicThreeLayer.BLL.ServiceHandlers
{
    public abstract class BaseServiceHandler 
    {
        protected DaoFactory daoFactory = null;

        public BaseServiceHandler()
        {
            daoFactory = new DaoFactory();
        }

        public void Receive()
        {
            Handler();
        }

        protected abstract void Handler();

    }
}
