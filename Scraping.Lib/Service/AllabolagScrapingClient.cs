

namespace Scraping.Lib.Service
{
    public class AllabolagScrapingClient : ScrapingClient
    {
        public override string Site { get { return "http://www.allabolag.se/"; } }

        public override string Xpath { get { return @"id('printTitle')"; } }
    }
}