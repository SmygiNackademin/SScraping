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
            var webClient = new WebClient();
            var htmlCLient = new HtmlDocument();
            htmlCLient.Load(webClient.OpenRead(Site), Encoding.Default);
            return htmlCLient.DocumentNode.SelectSingleNode(Xpath).InnerText;
        }
    }
}
