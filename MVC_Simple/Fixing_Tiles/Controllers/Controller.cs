using Fixing_Tiles.Models;
using Fixing_Tiles.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixing_Tiles.Controllers
{
    public class Controller
    {
        private Display display;
        private Ground ground;
        private Plate plate;
        private Bench bench;
        
        public Controller()
        {
            display = new Display();
            ground = new Ground(display.SideGround);
            plate = new Plate(display.SideAPlate, display.SideBPlate);
            bench = new Bench(display.SideABench, display.SideBBench);
        }
        public void Start()
        {
            int groundSquare = ground.CalculateSquare();
            int benchSquare = bench.CalculateSquare();

            int totalSqare = groundSquare - benchSquare;

            double plateSquare = plate.CalculateSquare();

            display.PlateCount = totalSqare / plateSquare;
            display.Time = plate.TimeForPlacement;

            display.Print();
        }
    }
}
