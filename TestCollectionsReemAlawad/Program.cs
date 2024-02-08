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
 
            UnityContainer countainer = (UnityContainer)new UnityContainer().AddExtension(new Diagnostic());
            var bestelling = countainer.Resolve<Bestelling>();
            // IBestelling bestelling = Factory.GetBestelling();
            // Bestelling bestelling = new Bestelling();
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

