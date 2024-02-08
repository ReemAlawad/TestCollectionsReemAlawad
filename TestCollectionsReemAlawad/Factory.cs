using ProductenLibrary;
using ProductenLibrary.Classen;
using ProductenLibrary.Enumetion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollectionsReemAlawad
{
    public static class Factory
    {
       public static IBestelling GetBestelling()
        {
            return new Bestelling();
        }
    }
}
