
namespace Scraping.Lib.Service
{
    public class HittaScrapingClient : ScrapingClient
    {
        private readonly string _orgNr;

        public HittaScrapingClient(string orgNr)
        {
            _orgNr = orgNr;
        }

        public override string Site { get { return string.Format("http://www.hitta.se/sök?vad={0}", _orgNr); } }

        public override string Xpath { get { return @"id('item-details')/div[1]/h1"; } }
    }
}
