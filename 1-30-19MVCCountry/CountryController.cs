using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_30_19MVCCountry
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();
        }

        public void CountryMenu()
        {
            Console.WriteLine("What continent would you like to learn about (North America/Asia)?");
            string input = Console.ReadLine();
            List<Country> countries;    //look at this

            if (input.ToLower() == "north america")
            {
                NorthAmericaDB nadb = new NorthAmericaDB();
                countries = nadb.Countries;     //look at this

            }
        }
    }
}
