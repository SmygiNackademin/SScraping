using System.Threading.Tasks;

namespace Scraping.Lib.Interface
{
    public interface IClient
    {
        Task GetHtmlContentFromScraping();
        string GetCompanyName();
    }
}
