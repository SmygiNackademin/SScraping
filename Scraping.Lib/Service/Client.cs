using System.Net.Http;
using System.Threading.Tasks;
using Scraping.Lib.Interface;

namespace Scraping.Lib.Service
{
    public class Client : IClient
    {
        public string Content { get; set; }
        private readonly string _site;
        private readonly string _orgNr;
        private readonly HttpClient _client = new HttpClient();

        public Client(string orgNr, string site)
        {
            _orgNr = ValidateOrgNr(orgNr);
            _site = site;
        }

        private string ValidateOrgNr(string orgNr)
        {
            if (orgNr.Contains("-"))
                orgNr = orgNr.Replace("-", "");
            if (orgNr.Contains(" "))
                orgNr = orgNr.Replace(" ", "");
            return orgNr;
        }

        public async Task GetHtmlContentFromScraping()
        {
            var response = await _client.GetAsync(_site + _orgNr);
            Content = await response.Content.ReadAsStringAsync();
        }

        public string GetCompanyName()
        {
            return _site.ToLower().Contains("eniro") ? GetCompanyFromEniro() : GetCompanyFromAllabolag();
        }

        private string GetCompanyFromEniro()
        {
            var page = Content;
            page = page.Remove(0, page.IndexOf("\"hitTitle\":") + 12);
            var companyName = page.Substring(0, page.IndexOf("\"hitNumber") - 2);
            return companyName;
        }

        private string GetCompanyFromAllabolag()
        {
            var page = Content;
            page = page.Remove(0, page.IndexOf("<title>") + 7);
            var companyName = page.Substring(0, page.IndexOf("</title>") - 27);
            return companyName;
        }
    }
}