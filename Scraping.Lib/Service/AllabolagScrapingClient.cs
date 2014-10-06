using System.Net.Http;
using System.Threading.Tasks;
using Scraping.Lib.Interface;

namespace Scraping.Lib.Service
{
    public class AllabolagScrapingClient : IScrapingClient
    {
        public string Content { get; set; }
        private const string _site = "http://allabolag.se/";
        private readonly string _orgNr;
        private readonly HttpClient _client = new HttpClient();

        public AllabolagScrapingClient(string orgNr)
        {
            _orgNr = orgNr;
        }

        public async Task GetHtmlContentFromScraping()
        {
            var response = await _client.GetAsync(_site + _orgNr);
            Content = await response.Content.ReadAsStringAsync();
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