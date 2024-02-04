using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductenLibrary.Classen
{
    public class SchrijfNaarBestand 
    {
        private string bestandNaam = "BestellingenTest.txt";

        public void SchrijfLijstNaarBestand(List<Product> producten)
        {
            using (StreamWriter writer = new StreamWriter(bestandNaam, false))
            {
                foreach (var product in producten)
                {
                    writer.WriteLine(product.ToString());
                }
            }
        }
    }
}
