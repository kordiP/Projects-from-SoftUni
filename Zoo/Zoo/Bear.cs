using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    internal class Bear:Mammal
    {
        public Bear(string name) : base(name)
        {
        }
        public override string ToString()
        {
            return $"Bear's name: {Name}";
        }
    }
}
