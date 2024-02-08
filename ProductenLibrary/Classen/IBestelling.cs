using System.Collections.Generic;

namespace ProductenLibrary.Classen
{
    public interface IBestelling
    {
        List<Product> Bestellingen { get; set; }

        void SorteerBestellingen();
        void ToonLijst();
        void ToonParfums();
        void ToonPerMerk(string merk);
        double TotalePrijs();
        void VoegProductToe(Product product);
        Product ZoekDuursteProduct();
    }
}