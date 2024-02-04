using ProductenLibrary.Enumetion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductenLibrary.Classen
{
    public class Deodorant : Product
    {
        public DeoType Soort { get; }
        public Deodorant(int productNummer, string merk, string naam, int volume, double prijs, DeoType soort) : base(productNummer, merk, naam, volume, prijs)
        {
            Soort = soort;
        }
        public override string ToString()
        {
            return base.ToString() + $" {Soort}";
        }
    }
}
