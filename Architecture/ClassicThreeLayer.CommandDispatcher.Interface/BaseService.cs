using ClassicThreeLayer.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassicThreeLayer.BLL.Interfaces
{
    abstract class BaseService : IService
    {
        abstract public void Excute();

        public Task ExcuteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
