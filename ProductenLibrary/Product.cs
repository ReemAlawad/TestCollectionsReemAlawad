using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


namespace ProductenLibrary
{
    public class Product : IComparable<Product>, IProduct
    {
        public int ProductNummer { get; set; }
        public string Merk { get; set; }
        public string Naam { get; set; }
        public int Volume { get; set; }
        public double Prijs { get; set; }
        public string ProductCode { get; set; }
       // Thread.CurrentThread.CurrentCulture = new CultureInfo("nl-BE");

        //Console.WriteLine(String.Format("Dit is {0:C} ", 50));
        public Product(int productNummer, string merk, string naam, int volume, double prijs)
        {
            ProductNummer = productNummer;
            Merk = merk;
            Naam = naam;
            Volume = volume;
            Prijs = prijs;
            ProductCode = GetProductCode();
        }

        public int CompareTo(Product other)
        {
            return Merk.CompareTo(other.Merk);
        }

        public override string ToString()
        {
            return $"{ProductNummer} Merk:{Merk,-18} Naam:{Naam,-23} Volume:{Volume,-4}ml\t Prijs:{Prijs,-5} Code:{ProductCode,-5}";
        }

        public string GetProductCode()
        {
            string code = $"{Merk.Substring(0, 3)}{Naam.Substring(0, 3)}{Volume}".ToUpper().Replace(" ", "_");
            return code;
        }
    }
}
