using System.Collections.Generic;
using System.Linq;
using System;

namespace RegularExam
{
    internal class FlowerStore
    {
        private string name;
        private List<Flower> flowers;
        public FlowerStore(string name)
        {
            Name = name;
            flowers = new List<Flower>();
        }
        public List<Flower> Flowers
        {
            get { return flowers; }
            set { flowers = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 6)
                    name = value;
                else
                    throw new ArgumentException("Invalid flower store name!");
            }
        }

        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
        }

        public bool SellFlower(Flower flower)
        {
            Flower temp = flowers.Find(x => x.Type == flower.Type);
            if (temp != null)
            {
                flowers.Remove(temp);
                return true;
            }
            return false;
        }

        public double CalculateTotalPrice()
        {
            return Flowers.Sum(x => x.Price);
        }

        public Flower GetFlowerWithHighestPrice()

        {
            return Flowers.OrderByDescending(x => x.Price).First();
        }

        public Flower GetFlowerWithLowestPrice()

        {
            return Flowers.OrderByDescending(x => x.Price).Last();
        }

        public void RenameFlowerStore(string newName)

        {
            Name = newName;
        }

        public void SellAllFlowers()

        {
            Flowers.Clear();
        }

        public override string ToString()

        {
            if (Flowers.Count != 0)
            {
                return $"Flower store {Name} has {Flowers.Count} flower/s:\n{String.Join("\n", flowers)}";
            }
            else return $"Flower store {Name} has no available flowers.";
        }
    }
}
