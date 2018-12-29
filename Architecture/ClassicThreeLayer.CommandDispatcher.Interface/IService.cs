using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassicThreeLayer.BLL.Interface
{
    public interface IService
    {
        void Excute();
        Task ExcuteAsync();
    }
}
