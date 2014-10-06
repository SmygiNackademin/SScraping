

namespace Scraping.Lib.Service
{
    public class AllabolagScrapingClient : ScrapingClient
    {
        private readonly string _orgNr;

        public AllabolagScrapingClient(string orgNr)
        {
            _orgNr = orgNr;
        }

        public override string Site { get { return string.Format("http://www.allabolag.se/{0}", _orgNr); } }

        public override string Xpath { get { return @"id('printTitle')"; } }
    }
}