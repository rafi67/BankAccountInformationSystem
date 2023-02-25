using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInformationRepositoryPattern.DataAccessLayer
{
    internal class AccountRepository : IAccountRepository
    {
        List<Account> listAccount = new List<Account>()
        {
            new Account(1, "Rafi", 1235434, 50000000, "12/2/2022"),
            new Account(2, "Arafat", 14000, 100000000, "11/10/2022"),
            new Account(3, "Shaymol", 14500, 120000000, "20/2/2023"),
            new Account(4, "Raj", 13000, 600000, "31/12/2022")
        };
        public List<Account> Get()
        {
            return listAccount.OrderBy(x => x.Name).ToList();
        }
        public Account Get(int id)
        {
            Account oAccount = listAccount.Where(x => x.ID==id).FirstOrDefault();
            return oAccount;
        }
        public bool Add(Account model)
        {
            listAccount.Add(model);
            return true;
        }
        public bool Update(Account model)
        {
            bool isExecuted = false;
            Account oAccount = listAccount.Where(x => x.ID==model.ID).FirstOrDefault();
            if(oAccount!=null) 
            {
                listAccount.Remove(oAccount);
                listAccount.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
        public bool Delete(int id)
        {
            bool isExecuted = false;
            Account oAccount = listAccount.Where(x => x.ID == id).FirstOrDefault();
            if(oAccount!=null)
            {
                listAccount.Remove(oAccount);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
