using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    internal class Gorilla:Mammal
    {
        public Gorilla(string name) : base(name)
        {
            base.Name = name;
        }
        public override string ToString()
        {
            return $"Gorilla's name: {Name}";
        }
    }
}
