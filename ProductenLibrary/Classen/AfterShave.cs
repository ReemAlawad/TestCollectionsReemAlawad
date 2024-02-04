using ProductenLibrary.Enumetion;
using ProductenLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductenLibrary.Classen
{
    public class AfterShave : Product
    {
        public Soort Soort { get; }
        public AfterShave(int productNummer, string merk, string naam, int volume, double prijs, Soort soort) : base(productNummer, merk, naam, volume, prijs)
        {
            Soort = Soort;
        }
        public override string ToString()
        {
            return base.ToString() + $" {Soort}";
        }
    }


}
