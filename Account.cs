using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBankAccount
{
    // by default all classes are internal.Using this access modifier is  just a reminder to myself.

    // Are class objects also data types?
   internal class  Account
    {
        private static string accountBank;
        //private by default
        private string accountOwner;
        private string accountType;
        private int accountNumber;
        private double accountBalance;


        //because the parameter in the constructor is the same name and case as the instanse variable name hiding is enabled, 
        // I don't want name hiding and I want class scope not just scope within the constructor....
        //so I have to redirect the parameter back to the instance variable. The THIS keyword does this.
        
            

            //constructors
        static Account()
        {
         //   Account.accountBank = accountBank; this is redundent;
        }

        public Account()
        {
            this.accountOwner ="newuser";
            this.accountType = "Savings";
            this.accountNumber = 0987654321;

        }
        public Account(string accountOwner)
        {
            this.accountOwner = accountOwner;
        }

        public Account(string accountOwner,string accountType,int accountNumber)
        {
            this.accountOwner = accountOwner;
            this.accountType = accountType;
            this.accountNumber = accountNumber;
        }

        public Account(double accountBalance)
        {
            this.accountBalance = accountBalance;
        }

        //properties

        public static string AccountBank
        {

            //get is used if someone is trying to retrieve info
            get
            {
                return accountBank;
            }
            //set is used if someone is trying to change info
            set
            {
                accountBank = value;
            }
        }


        public string AccountOwner
        {

            //get is used if someone is trying to retrieve info
            get
            {
                return accountOwner;
            }
            //set is used if someone is trying to change info
            set
            {
                accountOwner = value;
            }
        }

        public string AccountType
        {

            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            }
        }

        public int AccountNumber
        {

            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public double AccountBalance
        {

            get
            {
             return accountBalance;
             }
            set
            {
                accountBalance = value;
            }
         }

        public double withdrawal(double withdrawalBalance )
        {
            AccountBalance -= accountBalance;
            withdrawalBalance = AccountBalance;
            return AccountBalance;
        }

       public void deposit(double depositBalance)
        {
           
          accountBalance= depositBalance += accountBalance;
 
            Console.WriteLine(depositBalance);

        }


    }
}
