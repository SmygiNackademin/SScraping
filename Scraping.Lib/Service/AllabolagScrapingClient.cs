using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Scraping.Lib.Interface;


namespace Scraping.Lib.Service
{
    public class AllabolagScrapingClient : IScrapingClient
    {
        public string Content { get; set; }
        private const string _site = "http://www.allabolag.se/";
        private readonly string _orgNr;
        private readonly HttpClient _client = new HttpClient();

        public AllabolagScrapingClient(string orgNr)
        {
            _orgNr = orgNr;
        }

        public async Task<string> GetHtmlContentFromScraping()
        {
            var webClient = new WebClient();
            var htmlCLient = new HtmlAgilityPack.HtmlDocument();
            htmlCLient.Load(webClient.OpenRead(_site + _orgNr), Encoding.Default);

            string str = "";
            var name = htmlCLient.DocumentNode.SelectSingleNode("id('printTitle')").InnerText;
            return name;
        }

        public string GetCompanyName()
        {
            var page = Content;
            page = page.Remove(0, page.IndexOf("<title>") + 7);
            var companyName = page.Substring(0, page.IndexOf("</title>") - 27);
            return companyName;


        }
    }
}