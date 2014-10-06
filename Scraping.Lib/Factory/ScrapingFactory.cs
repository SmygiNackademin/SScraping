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
            {
                return new EniroScrapingClient(orgNr);
            }
            return new AllabolagScrapingClient(orgNr);
        }
    }
}
