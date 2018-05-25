using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBankAccount
{
      // By default all classes are internal I don't need the access modifier.
     // Using this access modifier is  just a reminder to myself.
    
    // class is abstract because account never has to be intialized
    internal abstract class Account
    {
           //By default all instances variable are private.I don't need the access modifier

         //static varables belong to the class. I can't make an instances of it.
        //accountBank will be the same value in all classes when it is first intialized.
       //Account.accountBank="";
  //     private static string accountBank;
      private string accountOwner;
     //   private string accountType;
       private int accountNumber;
        private double accountBalance;



        //constructors

        //By default we are given a parmeterless constructor to set up classes.
        //I want to avoid null values or 0 so I use the parmeterless constructor and gave it default values
        internal Account()
        {
            this.accountNumber = AccountNumber;

           // AccountNumber != 0;
            if (this.accountNumber == 0)
              {
             
                Console.WriteLine("Please provide valid input");
              }
            Account.AccountBank = "Please provide institution";//the property value is used because accountBank is auto-implemented and 
             //We don't have access to the instance variable

            this.accountOwner = "Please provide new account owner"; //I want to use the this keyword, because name hiding is present.
            //The this keyword always points the variable with the largest scope and that is the private instances class variable.

            this.AccountType = "Please provide account type";

        }

        //I've decided to use internal as the access modifier, so anyone who shares the project has access,but not everyone.
        //Internal is alittle safer then public.

        // this constructor  is used to set values that I don't want to intialize individually
       
        internal Account(string accountOwner, string accountType, int accountNumber)
        {
            //instance variable
            this.accountOwner = accountOwner;

            //properties
            this.AccountType = accountType;
            this.AccountNumber = accountNumber;
        }



        //properties
        //auto-implemented instance variable have to point to these properties.
        internal string AccountType { get; set; }
        internal int AccountNumber { get; set; }
        internal static string AccountBank { get; set; }

       

        //not auto-implemented instances variables are being passed values
        internal string AccountOwner
        {
            get
            {
                return accountOwner;
            }
            set
            {
                accountOwner = value;
            }
        }



        //if i autoimplement I will not have access to the backingfeild and the math won't add right
        internal double AccountBalance
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

        /// <summary>
        ///Abstract Methods are virtual by default
        /// </summary>
        /// <param name="N/A"></param>
        /// <returns>new account balance</returns>
        /// 


        internal abstract double Withdrawal();
        internal abstract double Deposit();

    }
}   

