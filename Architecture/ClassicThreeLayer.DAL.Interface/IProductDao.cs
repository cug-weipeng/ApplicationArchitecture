using ClassicThreeLayer.Entities;

namespace ClassicThreeLayer.DAL.Interface
{
    public interface IProductDao
    {
        Product GetProductByID(int productId);
    }
}
