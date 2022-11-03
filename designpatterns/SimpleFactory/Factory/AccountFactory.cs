using SimpleFactory.Entity;
using SimpleFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factory
{
    internal class AccountFactory : IAccountFactory
    {
        public IAccount MakeFactory(decimal balance, TypeAccountEnum typeAccount)
        {
            IAccount _account;

            switch (typeAccount)
            {
                case TypeAccountEnum.SavingsAccount:
                    return _account = new SavingsAccount();
                case TypeAccountEnum.CheckingAccount:
                    return _account = new CheckingAccount();
                default:
                    throw new Exception("Error type account does not exists");
            }
        }
    }
}
