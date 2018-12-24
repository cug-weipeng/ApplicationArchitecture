using ClassicThreeLayer.Entities;

namespace ClassicThreeLayer.DAL.Interface
{
    public interface IAccountDao
    {
        long CreateAccount(AccountDetail account);
    }
}
