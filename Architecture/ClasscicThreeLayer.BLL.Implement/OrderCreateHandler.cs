using ClassicThreeLayer.DAL.Interface;
using ClassicThreeLayer.Entities;
using System;

namespace ClassicThreeLayer.BLL.ServiceHandlers
{
    public class OrderCreateHandler : BaseServiceHandler
    {
        private Order _order = null;
        public void Initialize(Order order)
        {
            _order = order;
        }

        protected override void Handler()
        {
            if(_order == null)
            {
                throw new Exception("带创建的订单为空，您必须确保已经调用了Initialize方法且传入的Order不为空");
            }

            using (IOrderDao dao = daoFactory.Create<IOrderDao>())
            {
                dao.CreateOrder(_order);
            }
        }
    }
}
