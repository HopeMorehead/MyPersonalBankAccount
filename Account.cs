using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBankAccount
{
     
    internal abstract class Account
    {
      //  public double deposit;
        internal double AccountBalance { get; set; }
        internal string AccountType { get; set; }
        internal int AccountNumber { get; set; }
        internal static string AccountBank { get; set; }
        internal static string AccountOwner{ get; set; }

        internal abstract double Withdrawal();
        internal abstract double Deposit();



    
    }
}   

