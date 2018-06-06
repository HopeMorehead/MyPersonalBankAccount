using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBankAccount
{
    class Checking : Account
    {

        internal Checking()
        {
        }


        public Checking(string accountOwner, string accountType, int accountNumber)
        {
           Console.WriteLine("Who is the owner of this account");
           AccountOwner = accountOwner = Console.ReadLine();
           Console.WriteLine("What the account Type");
           AccountType = accountType=Console.ReadLine();
           Console.WriteLine("What is the Account Number");
           AccountNumber = accountNumber=int.Parse(Console.ReadLine());
        }
       

        internal override double Deposit()
        {
            Console.WriteLine(" How Much do you want to deposit");
              double deposit = double.Parse(Console.ReadLine()) + AccountBalance;
              this.AccountBalance =deposit;
            Console.WriteLine(AccountBalance+"ds");

            return deposit;
        }


        internal override double Withdrawal()
        {
            {
                Console.WriteLine("How much do you want to withdraw");
                double withdrawal = AccountBalance - double.Parse(Console.ReadLine());
                this.AccountBalance = withdrawal;
                if (AccountBalance < 0)
                {
                    Console.WriteLine("insuffiecient funds");
                }
                return AccountBalance;
            }
        }

     

     }
 }

