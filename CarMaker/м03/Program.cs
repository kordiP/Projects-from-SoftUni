using System;

namespace м03
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public Car()
        {

        }
        public Car(string brand, string model, string color, int doors, double price, int year)
        {
            //brand = Brand;
            //model = Model;
            //color = Color;
            //doors = Doors;
            //price = Price;
            //year = Year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car FirstCar = new Car("Subaru", "WRX", "Blue", 4, 8000.00, 2010);
            Car car = new Car();
            car.Brand = "Toyota";
            car.Model = "Celica";
            car.Color = "Midnight purple";
            car.Doors = 4;
            car.Price = 6000.00;
            car.Year = 2006;
            //Car car = new Car(); -> demolish that vehicle
        }
    }
}
