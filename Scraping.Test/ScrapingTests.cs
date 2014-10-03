using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scraping.Lib.Service;

namespace Scraping.Test
{
    [TestClass]
    public class ScrapingTests
    {
        [TestMethod]
        public async Task TestScreenScrapingAllabolagResult()
        {
            const string expected = "Mattias Asplund Aktiebolag";
            var client = new ScrapingClient("556599-5239", "http://allabolag.se/");
            await client.GetHtmlContentFromScraping();
            var actual = client.GetCompanyName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task TestScreenScrapingEniro()
        {
            const string expected = "Mattias Asplund AB";
            var client = new ScrapingClient("556599-5239", "http://gulasidorna.eniro.se/hitta:");
            await client.GetHtmlContentFromScraping();
            var actual = client.GetCompanyName();
            Assert.AreEqual(expected, actual);
        }
    }
}
