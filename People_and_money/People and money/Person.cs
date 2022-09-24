using System;
using System.Collections.Generic;
using System.Text;

namespace People_and_money
{
    internal class Person
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private List<BankAccount> bankAccounts;
        public List<BankAccount> BankAccounts
        {
            get { return bankAccounts; }
            set { bankAccounts = value; }
        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Person(string name, int age, string phone, int id)
        {
            Name = name;
            Age = age;  
            Phone = phone;
            ID = id;
            bankAccounts = new List<BankAccount>();
        }
    }
}
