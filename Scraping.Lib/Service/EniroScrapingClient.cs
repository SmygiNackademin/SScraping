using System.Net.Http;
using System.Threading.Tasks;
using Scraping.Lib.Interface;

namespace Scraping.Lib.Service
{
    public class EniroScrapingClient : IScrapingClient
    {
        public string Content { get; set; }
        private const string _site = "http://gulasidorna.eniro.se/hitta:";
        private readonly string _orgNr;
        private readonly HttpClient _client = new HttpClient();

        public EniroScrapingClient(string orgNr)
        {
            _orgNr = orgNr;
        }

        public async Task<string> GetHtmlContentFromScraping()
        {
            var response = await _client.GetAsync(_site + _orgNr);
            Content = await response.Content.ReadAsStringAsync();
            return "";
        }

        public string GetCompanyName()
        {
            var page = Content;
            page = page.Remove(0, page.IndexOf("\"hitTitle\":") + 12);
            var companyName = page.Substring(0, page.IndexOf("\"hitNumber") - 2);
            return companyName;
        }
    }
}
