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
        public void TestScreenScrapingAllabolagResult()
        {
            const string expected = "Mattias Asplund Aktiebolag";
            var client = ScrapingFactory.CreateScreenScraper("556599-5239", "Allabolag");
            var actual = client.GetHtmlContentFromScraping();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestScreenScrapingEniroResult()
        {
            const string expected = "Mattias Asplund AB";
            var client = ScrapingFactory.CreateScreenScraper("556599-5239", "Eniro");
            var actual = client.GetHtmlContentFromScraping();
            Assert.AreEqual(expected, actual);
        }
    }
}
