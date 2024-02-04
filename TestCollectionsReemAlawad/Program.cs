using ProductenLibrary;
using ProductenLibrary.Classen;
using ProductenLibrary.Enumetion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.Globalization;
using System.Threading;

namespace TestCollectionsReemAlawad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region bij UnityContainer           
            //try
            //{
            //    UnityContainer container = (UnityContainer)new UnityContainer().AddExtension(new Diagnostic());
            //    var info = container.Resolve<IBestelling>();
            //    info.VoegProductToe(new Parfum(0, "BVLGARI", "BLV", 75, 61.52));
            //    info.VoegProductToe(new Deodorant(0, "Cacharel", "Anais", 50, 24.50, DeoType.VAPO));
            //    info.VoegProductToe(new Deodorant(0, "DKNY", "Be Delicious Woman", 100, 33.65, DeoType.STICK));
            //    info.VoegProductToe(new Parfum(0, "Dolce & Gabbana", "Light Blue", 100, 66.72));
            //    info.VoegProductToe(new Parfum(0, "Georgio Armani", "Code Donna", 50, 59.32));
            //    info.VoegProductToe(new Parfum(0, "Georgio Armani", "Absolutely Irresistible Pour Elle", 30, 39.84));
            //    info.VoegProductToe(new Parfum(0, "Georgio Armani", "Jazz", 75, 76.00));
            //    info.VoegProductToe(new Parfum(0, "Givency", "BLV", 75, 75.42));
            //    info.VoegProductToe(new AfterShave(0, "Ted Lapidus", "Light Blue", 50, 44.48, Soort.VAPO));
            //    info.VoegProductToe(new AfterShave(0, "Yves Saint Laurent", "Code Donna", 50, 39.84, Soort.VAPO));


            //    Console.WriteLine("All Products:");
            //    info.ToonLijst();

            //    Console.WriteLine("Products voor Brand 'Georgio Armani':");
            //    info.ToonPerMerk("Georgio Armani");

            //    Console.WriteLine("All Perfumes:");
            //    info.ToonParfums();

            //    Product duursteProducte = info.ZoekDuursteProduct();
            //    Console.WriteLine($"Duurste Product:");
            //    Console.WriteLine(duursteProducte.ToString());

            //    Console.WriteLine($"Total Price:{info.TotalePrijs()}");

            //    SchrijfNaarBestand schrijfNaarBestande = new SchrijfNaarBestand();
            //    schrijfNaarBestande.SchrijfLijstNaarBestand(info.Bestellingen);
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine($"Error:{ex.Message}");
            //    WriteErrorToFile(ex);
            //}
            #endregion
            #region bij normal
            Bestelling bestelling = new Bestelling();
            bestelling.VoegProductToe(new Parfum(0, "BVLGARI", "BLV", 75, 61.52));
            bestelling.VoegProductToe(new Deodorant(0, "Dolce & Gabbana", "Light Blue", 100, 66.72, DeoType.VAPO));
            bestelling.VoegProductToe(new Deodorant(0, "Georgio Armani", "Code Donna", 50, 59.32, DeoType.STICK));
            bestelling.VoegProductToe(new Parfum(0, "Georgio Armani", "Code Donna", 30, 39.84));
            bestelling.VoegProductToe(new Parfum(0, "Georgio Armani", "Code Donna", 75, 76.00));
            bestelling.VoegProductToe(new Parfum(0, "Givency", "Absolutely Irresistible", 75, 75.42));
            bestelling.VoegProductToe(new Parfum(0, "Ted Lapidus", "Pour Elle", 50, 44.48));
            bestelling.VoegProductToe(new Parfum(0,"Cacharel","Anais",50,24.50));
            bestelling.VoegProductToe(new Parfum(0, "DKNY", "Be Delicious Woman", 100, 33.65));
            bestelling.VoegProductToe(new AfterShave(0, "Yves Saint Laurent", "Jazz", 50, 39.84, Soort.VAPO));
            bestelling.VoegProductToe(new AfterShave(0, "Yves Saint Laurent", "Jazz", 100, 57.76, Soort.VAPO));
            bestelling.SorteerBestellingen();
           

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All Products:");
            bestelling.ToonLijst();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nProducts voor Brand'Georgio Armani':");
            bestelling.ToonPerMerk("Georgio Armani");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nAll Perfumes:");
            bestelling.ToonParfums();
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Red;
            Product duursteProduct = bestelling.ZoekDuursteProduct();
            Console.WriteLine($"\nDuurste Product:");
            Console.WriteLine(duursteProduct.ToString());
            Console.ResetColor();

            Console.WriteLine($"\nTotal Price:{bestelling.TotalePrijs()}");

            SchrijfNaarBestand schrijfNaarBestand = new SchrijfNaarBestand();
            schrijfNaarBestand.SchrijfLijstNaarBestand(bestelling.Bestellingen);
            #endregion
        }
        static void WriteErrorToFile(Exception ex)
        {
            string fileEror = "error.Txt";
            using (StreamWriter writer = new StreamWriter(fileEror, true))
            {
                writer.WriteLine($"Date:{DateTime.Now}");
                writer.WriteLine($"Error Message: {ex.Message}");
                writer.WriteLine($"Stack Trace: {ex.StackTrace}");
                writer.WriteLine();
            }
        }

    }
}

