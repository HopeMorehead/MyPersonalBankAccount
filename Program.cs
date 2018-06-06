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
          

            Checking.AccountBank = "ChaterOne";
            Console.WriteLine($"welcome to {Checking.AccountBank} bank");


         


            Console.WriteLine("");  

         
            Checking customer1 = new Checking("Hope Morehead","checking",098765);
            Console.WriteLine($"This account belongs to {Checking.AccountOwner}" +
            $" with the account type {customer1.AccountType}" +
            $" and accountnumber {customer1.AccountNumber} ");
            
            
            Console.WriteLine(customer1.Deposit());
            Console.WriteLine(customer1.Deposit());
            Console.WriteLine(customer1.Deposit());
            Console.WriteLine(customer1.AccountBalance);
            Console.WriteLine(customer1.Withdrawal());

              Savings customer2 = new Savings();
            Console.WriteLine(customer2.Withdrawal());


           Savings customer = new Savings("Hope Morehead", "checking", 098765);
            Console.WriteLine($"This account belongs to {Checking.AccountOwner}" +
            $" with the account type {customer1.AccountType}" +
            $" and accountnumber {customer1.AccountNumber} ");




        }
    }
}
