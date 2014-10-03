using System.Net.Http;
using System.Threading.Tasks;

namespace Scraping.Lib
{
    public class Client
    {
        public string Content { get; set; }
        private string address = "http://allabolag.se/";
        private readonly HttpClient _client = new HttpClient();

        public Client(string orgNr)
        {
            address += orgNr;
        }

        public async Task Start()
        {
            var response = await _client.GetAsync(address);
            Content = await response.Content.ReadAsStringAsync();
        }

        public string Dissect()
        {
            return DissectHtmlPage.Dissect(Content);
        }
    }
}