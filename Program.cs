using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account customer1 = new Account("Hope_Morehead", "checking",1234567890);

            Console.WriteLine($"This account belongs to {customer1.AccountOwner}with the account type {customer1.AccountType} and account number {customer1.AccountNumber} and account balance{customer1.AccountBalance}");
            Account.AccountBank = "CharterOne";
            Console.WriteLine(Account.AccountBank);
            customer1.deposit(100);
            Console.WriteLine(customer1.AccountBalance);
            //  Console.WriteLine($"{customer1.AccountOwner}");
                       
            //when you make a new object you call the constructor
            //get the class prepared intialize
        }
    }
}
