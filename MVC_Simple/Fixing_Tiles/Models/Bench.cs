using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixing_Tiles.Models
{
    public class Bench
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public Bench(int sideA, int sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public int CalculateSquare()
        {
            return SideA * SideB;
        }
    }
}
