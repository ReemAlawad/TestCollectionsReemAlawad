using ProductenLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductenLibrary.Classen
{
    public class Bestelling : IBerekenbaar, IBestelling
    {
        public List<Product> Bestellingen { get; set; } = new List<Product>();
        
        
        private static int productNummer = 1000;
        private List<Product> products = new List<Product>();
        public void SorteerBestellingen()
        {
            products.Sort();
        }


        public void VoegProductToe(Product product)
        {
            product.ProductNummer = productNummer++;
            Bestellingen.Add(product);
        }

        public void ToonLijst()
        {
            var sortedProducts = Bestellingen.OrderBy(product => product.Merk).ToList();

            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public void ToonPerMerk(string merk)
        {
            foreach (var product in Bestellingen)
            {
                if (product.Merk.Equals(merk, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
        public Product ZoekDuursteProduct()
        {
            //  return Bestellingen.OrderByDescending(s => s.Prijs).FirstOrDefault();
            //if (Bestellingen.Count == 0)
            //{
            //    return null;
            //}
            Product duursteProduct = Bestellingen[0];
            foreach (var product in Bestellingen)
            {
                if (product.Prijs > duursteProduct.Prijs)
                {
                    duursteProduct = product;
                }
            }
            return duursteProduct;
        }

        public void ToonParfums()
        {
            foreach (var product in Bestellingen)
            {
                if (product is Parfum)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
        public double TotalePrijs()
        {
            double total = 0;
            foreach (var product in Bestellingen)
            {
                total += product.Prijs;
            }
            return total;
        }


    }
}
