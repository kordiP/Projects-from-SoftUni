using System;

namespace Village
{
    class Rebel : Person
    {
        private string nameRebel;
        public string NameRebel
        {
            get { return nameRebel; }
            set { nameRebel = value; }
        }
        private int ageRebel;

        public int AgeRebel
        {
            get { return ageRebel; }
            set 
            {
                if (value <= 50) ageRebel = value;
                else throw new ArgumentException("Age should be less or equal to 50!");
            }
        }
        private int harm;
        public int Harm
        {
            get { return harm; }
            set 
            {
                if (value > 0) harm = value;
                else throw new ArgumentException("Harm should be greater than 0!");
            }
        }
        public Rebel(string name, int age, int harm) : base(name, age)
        {
            Name = name;
            Age = age;
            Harm = harm;
            AgeRebel = age;
            NameRebel = name;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nHarm: {Harm}\n";
        }
    }
}