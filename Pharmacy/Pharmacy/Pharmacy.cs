using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Pharmacy
    {
        private string name;
        private List<Medicine> medicines = new List<Medicine>();
        public Pharmacy(string name)
        {
            this.name = name;
            medicines = new List<Medicine>(); // No Validation
        }
        public string Name
        {
            get { return name; }
            set 
            {
                if (name.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value; 
            }
        }
        public override string ToString()
        {
            if (medicines.Count >= 1)
            {
                string output = $"Pharmacy {this.Name} has {this.medicines.Count} medicines and they are: \n";
                output += string.Join("\n", medicines);
                return output;
            }
            else
            {
                return $"Pharmacy {this.Name} has 0 medicines and they are: \nN/A";
            }
        }
        public void Order(Medicine medicine)
        {
            medicines.Add(medicine);
        }
        public bool Sell(Medicine medicine)
        {
            if (medicines.Contains(medicine))
            {
                medicines.Remove(medicine);
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculateTotalPrice()
        {
            return 1;
        }
        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }
        public void SellAllMedicines()
        {
            medicines.Clear();
        }
        public Medicine GetMedicineWithHighestPrice()
        {
            return medicines.OrderByDescending(x => x.Price).First();
        }
        public Medicine GetMedicineWithLowestPrice()
        {
            return medicines.OrderBy(x => x.Price).First();
        }
    }
}
