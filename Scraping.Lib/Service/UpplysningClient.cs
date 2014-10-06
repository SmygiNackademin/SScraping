
namespace Scraping.Lib.Service
{
    public class UpplysningScrapingClient : ScrapingClient
    {
        public override string Site { get { return "http://www.upplysning.se/"; } }

        public override string Xpath { get { return @"id('dataheader')/b"; } }
    }
}