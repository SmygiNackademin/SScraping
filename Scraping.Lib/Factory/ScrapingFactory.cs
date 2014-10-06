using System.Net;
using HtmlAgilityPack;
using Scraping.Lib.Interface;
using Scraping.Lib.Service;

namespace Scraping.Lib.Factory
{
    public class ScrapingFactory
    {
        public static IScrapingClient CreateScreenScraper(string site)
        {
            if (site.ToLower().Contains("eniro"))
                return new EniroScrapingClient();
            else if (site.ToLower().Contains("hitta"))
                return new HittaScrapingClient();
            else if (site.ToLower().Contains("upplysning"))
                return new UpplysningScrapingClient();
            else
                return new AllabolagScrapingClient();
        }
    }
}
