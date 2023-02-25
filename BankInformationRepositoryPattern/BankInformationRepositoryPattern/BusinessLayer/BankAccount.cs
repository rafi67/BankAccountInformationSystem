using BankInformationRepositoryPattern.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BankInformationRepositoryPattern.BusinessLayer
{
    internal class BankAccount
    {
        IAccountRepository _accountRepository;
        public BankAccount(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public List<Account> Get()
        {
            return _accountRepository.Get();
        }
        public Account Get(int id)
        {
            return _accountRepository.Get(id);
        }
        public bool Add(Account model)
        {
            return _accountRepository.Add(model);
        }
        public bool Update(Account model)
        {
            return _accountRepository.Update(model);
        }
        public bool Delete(int id)
        {
            return _accountRepository.Delete(id);
        }
    }
}
