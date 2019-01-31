using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_30_19MVCCountry
{
    class AsiaDB
    {
        public List<Country> Countries;


        public AsiaDB()
        {
            string[] ChinaColors = { "Gold", "Red" };
            Countries.Add(new Country("China", "Mandarin", "你好，世界", ChinaColors));

            string[] VietnamColors = {"Gold", "Red"};
            Countries.Add(new Country("Vietnam", "Vietnamese", "Chào thế giới", VietnamColors));

            string[] JapanColors = { "Red", "White" };
            Countries.Add(new Country("Japan", "Japanese", "Kon'nichiwa sekai", JapanColors));

            string[] SouthKoreaColors = { "Black", "Red", "Blue", "White" };
            Countries.Add(new Country("South Korea", "Korean", "annyeonghaseyo segye", SouthKoreaColors));

            string[] SingaporeColors = { "Red", "White" };
            Countries.Add(new Country("Singapore", "English, Chinese, Malay", "Hello World!", SingaporeColors));



        }
    }
}
