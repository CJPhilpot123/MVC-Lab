using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryControlla
    {
        private List<Country> countriesdb;

        public List<Country> CountriesDB
        {
            set { countriesdb = value; }
            get { return countriesdb; }
        }

        public CountryControlla(List<Country> _countriesdb)
        {
            countriesdb = _countriesdb;
        }

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            Console.WriteLine($"Which Country would you like to learn more about?");
            
        }

    }
}
