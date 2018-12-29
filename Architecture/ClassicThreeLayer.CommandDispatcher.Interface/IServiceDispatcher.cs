using System;
using System.Threading.Tasks;

namespace ClassicThreeLayer.BLL.Interface
{
    public class IServiceInvoker
    {
        private IService _service;

        public void SetService(IService service)
        {
            this._service = service;
        }

        public void Invoke()
        {
            this._service.Excute();
        }

        public async Task InvokeAsync()
        {
            await _service.ExcuteAsync();
        }
    }
}
