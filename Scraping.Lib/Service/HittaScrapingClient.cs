
namespace Scraping.Lib.Service
{
    public class HittaScrapingClient : ScrapingClient
    {
        public override string Site { get { return "http://www.hitta.se/sök?vad="; } }

        public override string Xpath { get { return @"id('item-details')/div[1]/h1"; } }
    }
}
