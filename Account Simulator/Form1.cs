using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        //create a private BankAccount object and pass an
        //argument of 1000 to its constructor.
        //essentially, it fills the BankAccount() _balance
        //field with a starting balance of $1000.
        //it is accessible by all of the methods in Form1.
        private BankAccount account = new BankAccount(1000);
        public Form1()
        {
            InitializeComponent();
        }
        //when the form loads, the code in the following runs
        private void Form1_Load(object sender, EventArgs e)
        {
            //display the starting balance in the balanceLabel text box
            //and converts the balance amount to currency. 
            balanceLabel.Text = account.Balance.ToString("c");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            //var to hold the amount of deposit
            decimal amount;

            //convert user entered amount to decimal + adds to balance
            //try parse checks the value to be compatible with decimal.
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                //if decimal, deposit amount to account balance
                account.Deposit(amount);

                //display new balance in the balanceLabel as currency.
                balanceLabel.Text = account.Balance.ToString("C");

                //clear the depositTextBox
                depositTextBox.Clear();
            }
            else
            {
                //display error message for invalid user input
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            //var to hold the amount of withdrawl
            decimal amount;

            //convert user entered amount to decimal + removes from balance
            //try parse checks the value to be compatible with decimal.
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                //remove amount user entered from account balance
                account.Withdraw(amount);

                //display new balance after withdrawl converted to currency
                balanceLabel.Text = account.Balance.ToString("c");

                //clear user entered information in the withdrawTextBox
                withdrawTextBox.Clear();
            }
            else
            {
                //Display an error message.
                MessageBox.Show("Invalid amount entered.");
            }

        }
        //exit the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form + exit the program
            this.Close();
        }
    }
}
