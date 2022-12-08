using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    internal class Lizard:Reptile
    {
        public Lizard(string name) : base(name)
        {
            base.Name = name;
        }
        public override string ToString()
        {
            return $"Lizard's name: {Name}";
        }
    }
}
