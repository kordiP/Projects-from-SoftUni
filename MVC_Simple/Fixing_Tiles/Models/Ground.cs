using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixing_Tiles.Models
{
    public class Ground
    {
        public int Side { get; set; }
        public Ground(int side)
        {
            Side = side;    
        }
        public int CalculateSquare()
        {
            return Side * Side;
        }
    }
}
