using HtmlAgilityPack;
using Scraping.Lib.Interface;

namespace Scraping.Lib.Service
{
    public abstract class ScrapingClient : IScrapingClient
    {
        public abstract string Site { get; }
        public abstract string Xpath { get; }

        public string GetCompanyNameByOrgNr(string orgNr)
        {
            var webClient = new HtmlWeb();
            var htmlCLient = webClient.Load(Site + orgNr);
            return htmlCLient.DocumentNode.SelectSingleNode(Xpath).InnerText;
        }
    }
}
