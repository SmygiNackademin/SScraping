using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scraping.Lib.Factory;
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
            var client = ScrapingFactory.CreateScreenScraper("556599-5239", "Allabolag");
            await client.GetHtmlContentFromScraping();
            var actual = client.GetCompanyName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task TestScreenScrapingEniroResult()
        {
            const string expected = "Mattias Asplund AB";
            var client = ScrapingFactory.CreateScreenScraper("556599-5239", "Eniro");
            await client.GetHtmlContentFromScraping();
            var actual = client.GetCompanyName();
            Assert.AreEqual(expected, actual);
        }
    }
}
