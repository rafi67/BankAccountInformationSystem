using BankInformationRepositoryPattern.BusinessLayer;
using BankInformationRepositoryPattern.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInformationRepositoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(new AccountRepository());
            bool isRunning = true;
            while(isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update, 'D' for Delete, 'S' for Search, 'C' for Clear, 'E' for Exit");
                    string command = Console.ReadLine();
                    if(command=="L")
                    {
                        List<Account> _listAccount = bankAccount.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("ID |  Name | AccountNumber | Balance | Deposit Date Time");
                        foreach (Account _account in _listAccount)
                            Console.WriteLine(_account.ID + " | " + _account.Name + " | " + _account.AccountNumber + " | " + _account.Balance + " | " + _account.DepositDate);
                    }
                    else if(command=="S")
                    {
                        Console.WriteLine("Input a id to find Account Information:");
                        string id = Console.ReadLine();
                        Account aAccount = bankAccount.Get(int.Parse(id));
                        Console.WriteLine("ID: " + aAccount.ID + ", Name: " + aAccount.Name + ", Account Number:  " + aAccount.AccountNumber + ", Balance: " + aAccount.Balance + ", Deposit Date: " + aAccount.DepositDate + ".");
                    }
                    else if(command=="A") 
                    {
                        Console.WriteLine("Input ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input a Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Account Number:");
                        int accNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Balance to Deposit:");
                        double balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance Deposit Date:");
                        string date = Console.ReadLine();
                        Account account = new Account();
                        account.ID = id;
                        account.Name = name;
                        account.AccountNumber = accNum;
                        account.Balance = balance;
                        account.DepositDate = date;
                        bool isExecuted = bankAccount.Add(account);
                        if(isExecuted)
                        {
                            Console.WriteLine("Added succesfully");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if(command=="U")
                    {
                        Console.WriteLine("Input ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input a Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Account Number:");
                        int accNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Balance to Deposit:");
                        double balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance Deposit Date:");
                        string date = Console.ReadLine();
                        Account account = new Account();
                        account.ID = id;
                        account.Name = name;
                        account.AccountNumber = accNum;
                        account.Balance = balance;
                        account.DepositDate = date;
                        bool isExecuted = bankAccount.Update(account);
                        if(isExecuted) 
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if(command=="D")
                    {
                        Console.WriteLine("Input a id:");
                        int id = int.Parse(Console.ReadLine());
                        bool isExecuted = bankAccount.Delete(id);
                        if(isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failde to delete.");
                        }
                    }
                    else if(command=="C")
                    {
                        Console.Clear();
                    }
                    else if(command=="E")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}
