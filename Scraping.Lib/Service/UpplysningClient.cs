
namespace Scraping.Lib.Service
{
    public class UpplysningScrapingClient : ScrapingClient
    {
        private readonly string _orgNr;

        public UpplysningScrapingClient(string orgNr)
        {
            _orgNr = orgNr;
        }

        public override string Site { get { return string.Format("http://www.upplysning.se:{0}", _orgNr); } }

        public override string Xpath { get { return @"id('dataheader')/x:b"; } }
    }
}