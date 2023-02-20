using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixing_Tiles.Views
{
    public class Display
    {
        public int SideGround { get; set; }
        public double SideAPlate { get; set; }
        public double SideBPlate { get; set; }
        public int SideABench { get; set; }
        public int SideBBench { get; set; }
        public double PlateCount { get; set; }
        public double Time { get; set; }
        public Display()
        {
            GetValues();
        }

        private void GetValues()
        {
            SideGround = int.Parse(Console.ReadLine());
            SideAPlate = double.Parse(Console.ReadLine());
            SideBPlate = double.Parse(Console.ReadLine());
            SideABench = int.Parse(Console.ReadLine());
            SideBBench = int.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine(PlateCount);
            Console.WriteLine(Time);
        }
    }
}
