using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_30_19MVCCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] colors = { "Red", "White", "Blue" };

            //Country c = new Country("Stankonia", "Stankonese", "Hello World!", colors);
            //cc.CountryDetails(c);

            bool run = true;
            while (run == true)
            {
                CountryController cc = new CountryController();
                cc.CountryMenu();
                //CountryDetails(c);
                //cc.CountryDetails

                //run = Continue();
            }

        }
        public static bool Continue()
        {
            Console.WriteLine("Do you wish to continue? y/n");
            string continueInput = Console.ReadLine();
            continueInput = continueInput.ToLower();
            bool goOn;
            if(continueInput == "y")
            {
                goOn = true;
            }
            else if (continueInput == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, please try again.");
                goOn = Continue();
            }
            return goOn;
        }
    }
}
