using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInformationRepositoryPattern.DataAccessLayer
{
    internal class Account
    {
        public int ID;
        public string Name;
        public int AccountNumber;
        public double Balance;
        public string DepositDate;
        public Account() { }
        public Account(int id, string name, int accountNumber, double balance, string depositDate)
        {
            ID = id;
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
            DepositDate = depositDate;
        }
    }
}
