
using System.Linq;

namespace Scraping.Lib
{
    public static class DissectHtmlPage
    {
        public static string Dissect(string page)
        {
            page = page.Remove(0, page.IndexOf("<title>") + 7);
            var companyName = page.Substring(0, page.IndexOf("</title>") - 27);
            return companyName;
        }
    }
}