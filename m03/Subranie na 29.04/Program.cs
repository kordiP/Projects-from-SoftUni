using System;
using System.Collections.Generic;
using System.Linq;
namespace Subranie_na_29._04
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> bankAccounts = new List<BankAccount>();
        public List<BankAccount> BankAccounts
        {
            get { return bankAccounts; }
            set { bankAccounts = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double GetAllMoney() => bankAccounts.Sum(x => x.Balance);   // The First " => " Is The Replacement Of " return ".
        public override string ToString() => $"{name} {age} {bankAccounts.Count} - {GetAllMoney()}";
    }
    class BankAccount
    {
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public BankAccount()
        {

        }
    }
    internal class Program
    {
        static void Main()
        {
            Person Ivan = new Person();
            Ivan.Name = "Ivan";
            Ivan.Age = 25;

            BankAccount ba1 = new BankAccount();
            ba1.ID = "ba1";
            ba1.Balance = 100;

            BankAccount ba2 = new BankAccount();
            ba2.ID = "ba2";
            ba2.Balance = 200;

            BankAccount ba3 = new BankAccount();
            ba3.ID = "ba3";
            ba3.Balance = 300;

            Ivan.BankAccounts.Add(ba1);
            Ivan.BankAccounts.Add(ba2);
            Ivan.BankAccounts.Add(ba3);

            //Console.WriteLine(Ivan.GetAllMoney());
            Console.WriteLine(Ivan.ToString());
        }
    }
}
