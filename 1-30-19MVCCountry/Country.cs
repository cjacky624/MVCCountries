using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_30_19MVCCountry
{
    class Country
    {
        public string Name;
        public string Lang;
        public string Hello;
        public string[] Colors;

        public Country(string Name, string Lang, string Hello, string[] Colors)
        {
            this.Name = Name;
            this.Lang = Lang;
            this.Hello = Hello;
            this.Colors = Colors;
        }

        //private string name;
        //private string lang;
        //private string hello;
        //private string[] colors;

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}
        //public string Lang
        //{
        //    get
        //    {
        //        return lang;
        //    }
        //    set
        //    {
        //        lang = value;
        //    }
        //}
        //public string Hello
        //{
        //    get
        //    {
        //        return hello;
        //    }
        //    set
        //    {
        //        hello = value;
        //    }
        //}
        //public string[] Colors
        //{
        //    get
        //    {
        //        return colors;
        //    }
        //    set
        //    {
        //        colors = value;
        //    }
        //}

    }
}
