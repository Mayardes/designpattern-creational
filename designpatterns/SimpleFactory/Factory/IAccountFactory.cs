using SimpleFactory.Entity;
using SimpleFactory.Enum;

namespace SimpleFactory.Factory
{
    public interface IAccountFactory
    {
        IAccount MakeFactory(decimal balance, TypeAccountEnum typeAccount);
    }
}
