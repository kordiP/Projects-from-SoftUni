using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    internal class Snake:Reptile
    {
        public Snake(string name) : base(name)
        {
            base.Name = name;
        }
        public override string ToString()
        {
            return $"Snake's name: {Name}";
        }
    }
}
