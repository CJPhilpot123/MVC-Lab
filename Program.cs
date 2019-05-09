using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> Countries = new List<Country>();
            Country Wakanda = new Country("Wakanda", "Africa", new List<string>() { "black" });
            Country Venezuela = new Country("Venezuela", "Brazil", new List<string>() { "Yellow", "Blue", "Red" });
            Country Russia = new Country("Russia", "Asia", new List<string>() { "White", "Blue", "Red" });
            Country Japan = new Country("Japan", "Asia", new List<string>() { "White", "Red" });
            Country Canada = new Country("Canada", "North America", new List<string>() { "Red", "White" });
            CountryControlla countryController = new CountryControlla(Countries);
            countryController.WelcomeAction();
        }
    }
}
