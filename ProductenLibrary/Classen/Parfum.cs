using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductenLibrary.Classen
{
    public class Parfum : Product 
    {
        public Parfum(int productNummer, string merk, string naam, int volume, double prijs) : base(productNummer, merk, naam, volume, prijs)
        {
        }
    }
}
