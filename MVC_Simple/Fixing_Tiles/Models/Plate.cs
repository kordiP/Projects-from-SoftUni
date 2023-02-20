using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixing_Tiles.Models
{
    public class Plate
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double TimeForPlacement { get; } = 0.2;
        public Plate(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public double CalculateSquare()
        {
            return SideA * SideB;
        }
    }
}
