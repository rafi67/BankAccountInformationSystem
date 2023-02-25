using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInformationRepositoryPattern.DataAccessLayer
{
    internal interface IAccountRepository
    {
        List<Account> Get();
        Account Get(int id);
        bool Add(Account model);
        bool Update(Account model);
        bool Delete(int id);
    }
}
