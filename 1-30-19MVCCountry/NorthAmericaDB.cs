using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_30_19MVCCountry
{
    class NorthAmericaDB
    { 

        public List<Country> Countries;

        public NorthAmericaDB()
        {
            string[] USColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("USA", "English", "Hello World!", USColors));

            string[] MexicoColors = { "Red", "White", "Green" };
            Countries.Add(new Country("Mexico", "Spanish", "Hola Mundo!", MexicoColors));

            string[] CanadaColors = { "Red", "White" };
            Countries.Add(new Country("Canada", "English & French", "Bonjour le Monde", CanadaColors));

            string[] CubaColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("Cuba", "Spanish", "Hola Mundo!", CubaColors));

            string[] GreenlandColors = { "Red", "White" };
            Countries.Add(new Country("Greenland", "Danish & English", "Hej Verden", GreenlandColors));
        }

    }
}
