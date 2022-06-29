using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preobrazuvane_na_broini_sist
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Nachin s convert ili sus smetki?");
            string koi_nachin = Console.ReadLine();
            if (koi_nachin == "convert")
            {
                Nachin_s_convert();
            }
            
        }
        static void Nachin_s_convert()
        {
            Console.WriteLine("Vuvedete chislo v decimal: ");
            string dec = Console.ReadLine();
            string bin = Convert.ToString(Convert.ToInt32(dec, 10), 2); //pravim go v string, sled tova v int i v tozi int pishem koe chislo iskame da promenim, ot koq broina sistema e to i posle izvun skobite v koq broichan sistema iskame da go prevurnem.
            string hex = Convert.ToString(Convert.ToInt32(dec, 10), 16);
            Console.WriteLine($"dec {dec} bin {bin} hex {hex}");
        }              
       }
    }
