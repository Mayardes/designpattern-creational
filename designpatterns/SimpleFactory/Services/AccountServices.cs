using SimpleFactory.Entity;
using SimpleFactory.Enum;
using SimpleFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Services
{
    public class AccountServices
    {
        private readonly IAccountFactory _accountFactory;
        public AccountServices(IAccountFactory accountFactory)
        {
            _accountFactory = accountFactory;
        }

        public IAccount GenerateAccount(decimal balance, TypeAccountEnum typeAccount)
        {
            return _accountFactory.MakeFactory(balance, typeAccount);
        }
    }
}
