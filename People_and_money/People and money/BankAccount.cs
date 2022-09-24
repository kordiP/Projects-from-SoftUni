using System;
using System.Collections.Generic;
using System.Text;

namespace People_and_money
{
    internal class BankAccount
    {
		private decimal balance;

		public decimal Balance
		{
			get { return balance; }
			set { balance = value; }
		}
		// Add person's ID
		public BankAccount(decimal balance)
		{
			Balance = balance;
		}
	}
}
