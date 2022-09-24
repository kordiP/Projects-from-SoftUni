using System;
using System.Collections.Generic;
using System.Text;

namespace People_and_money
{
    internal class DataClass
    {
        private Dictionary<string, Person > people = new Dictionary<string, Person>();
        private Dictionary<string, BankAccount > bankAccounts = new Dictionary<string, BankAccount>();
    }
}
