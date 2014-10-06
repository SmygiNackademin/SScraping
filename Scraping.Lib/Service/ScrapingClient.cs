using System.Net;
using System.Text;
using HtmlAgilityPack;
using Scraping.Lib.Interface;

namespace Scraping.Lib.Service
{
    public abstract class ScrapingClient : IScrapingClient
    {
        public abstract string Site { get; }
        public abstract string Xpath { get; }

        public string GetHtmlContentFromScraping()
        {
            var webClient = new HtmlWeb();
            var htmlCLient = new HtmlDocument();
            htmlCLient = webClient.Load(Site);
            return htmlCLient.DocumentNode.SelectSingleNode(Xpath).InnerText;
        }
    }
}
