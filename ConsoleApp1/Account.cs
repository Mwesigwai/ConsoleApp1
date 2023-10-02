using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        private int _accountNumber;
        private int _accountBalance;
        private string _accountName;

        public Account(int accountNumber, int accountBalance, string accountName)
        {
            if (accountBalance < 0)
                throw new ApplicationException("Account balance cannot be a negative");
            else
            {
                this._accountBalance = accountBalance;
            }
            this._accountNumber = accountNumber;
            this._accountName = accountName;
        }
        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public int AccountBalance
        {
            get { return _accountBalance; }
        }
        public string AccountName
        {
            get { return _accountName; }
        }

        public override string ToString()
        {
            return "Account number: "+_accountNumber + "\n" + "Name " + _accountName + "\n" + "Balance: "+ _accountBalance + "\n";
        }
    } 
}
