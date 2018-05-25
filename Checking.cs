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
          : base()
        {
        }


        public Checking(string accountOwner, string accountType, int accountNumber)
           : base(accountOwner, accountType, accountNumber)
            // : base("Hope Morhead","checking",246801357)
        {
           
        }

        internal override double Deposit()
        {
              double deposit = double.Parse(Console.ReadLine()) + AccountBalance;
            //referencing property
              this.AccountBalance =deposit;
              return deposit;   


        }


        internal override double Withdrawal()
        {
            {
                double withdrawal = AccountBalance - double.Parse(Console.ReadLine());
                this.AccountBalance = withdrawal;

                if (AccountBalance < 0)
                {
                    Console.WriteLine("insuffiecient funds");
                }

                return withdrawal;
            }
                //   return base.Withdrawal();I can always refer back to my base class
            }
        }
 }

