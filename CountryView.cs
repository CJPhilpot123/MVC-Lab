using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        private Country displaycountry;
        
        public Country DisplayCountry
        {
            set { displaycountry = value; }
            get { return displaycountry; }
        }

        public CountryView(Country _displaycountry)
        {
            displaycountry = _displaycountry;
        }

        public void Display()
        {
            Console.WriteLine($"{displaycountry.Name}");
        }


    }
}
