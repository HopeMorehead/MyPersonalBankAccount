using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyPersonalBankAccount
{



    class Savings:Checking
    {
        public Savings()
        {
        }


        public Savings(string accountOwner, string accountType, int accountNumber)
           :base (accountOwner, accountType, accountNumber)
        {

        }


    }
}
