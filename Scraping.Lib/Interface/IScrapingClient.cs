using System.Threading.Tasks;

namespace Scraping.Lib.Interface
{
    public interface IScrapingClient
    {
        Task GetHtmlContentFromScraping();
        string GetCompanyName();
    }
}
