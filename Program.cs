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
           //how to use a static variable
           Checking.AccountBank = "ChaterOne";
           Console.WriteLine($"welcome to {Checking.AccountBank} bank");



            //not defined so the constructor will take care of the information
             Checking customer0 = new Checking();

            Console.WriteLine("");
             Console.WriteLine($"This Account belongs to { customer0.AccountOwner},{customer0.AccountType}, {customer0.AccountNumber}, {Checking.AccountBank}");



            Console.WriteLine("");  

          //  Account customer1 = new Account();
            //used the contructor to take in class information
            Checking customer1 = new Checking("Hope Morehead","checking",098765);
            Console.WriteLine($"This account belongs to {customer1.AccountOwner}" +
            $" with the account type {customer1.AccountType}" +
            $" and accountnumber {customer1.AccountNumber} ");
            
         //You don't want parameters when it's a changing value with the same instance
            //Will not let me call an instance just the class
            Console.WriteLine(customer1.Deposit());
            Console.WriteLine(customer1.Deposit());
            Console.WriteLine(customer1.Deposit());
            Console.WriteLine(customer1.AccountBalance);

            Savings customer2 = new Savings();
            Console.WriteLine(customer2.Withdrawal());
          
        }
    }
}
