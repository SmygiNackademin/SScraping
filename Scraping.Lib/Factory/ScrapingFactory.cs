using System.Net;
using HtmlAgilityPack;
using Scraping.Lib.Interface;
using Scraping.Lib.Service;

namespace Scraping.Lib.Factory
{
    public class ScrapingFactory
    {
        public static IScrapingClient CreateScreenScraper(string orgNr, string site)
        {
            if (site.ToLower().Contains("eniro"))
                return new EniroScrapingClient(orgNr);
            else if (site.ToLower().Contains("hitta"))
                return null;
            else if (site.ToLower().Contains("upplysning"))
                return new UpplysningScrapingClient(orgNr);
            else
                return new AllabolagScrapingClient(orgNr);
        }
    }
}
