using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account_Simulator
{
    class BankAccount
    {//field to hold the balance 
        private decimal _balance;

        //Constructor for class BankAccount
        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }
        //Balance property a read only var 
        public decimal Balance
        {
            get { return _balance; }
        }
        //Deposit method- adds money to the balance
        public void Deposit(decimal amount)
        {
            //add the depoist amount var val to the balance var val
            _balance += amount;
        }
        //overloading the Deposit method to accept a double as well, and 
        //converting to decimal so that it accepts the argument.
        public void Deposit(double amount)
        {
            _balance += (decimal)amount;
        }
        //Withdraw method- removes money from the balance
        public void Withdraw(decimal amount)
        {
            //subtract the amount var val from the balance var val
            _balance -= amount;
        }
        //overloading the Withdraw method to accept a double as well, and 
        //converting to decimal so that it accepts the argument.
        public void Withdraw(double amount)
        {
            //subtract the amount var val from the balance var val
            _balance -= (decimal)amount;
        }
    }
}
