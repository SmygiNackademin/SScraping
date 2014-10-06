using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scraping.Lib.Factory;

namespace Scraping.Test
{
    [TestClass]
    public class ScrapingTests
    {
        [TestMethod]
        public void TestScreenScrapingAllabolagResult()
        {
            const string expected = "Mattias Asplund Aktiebolag";
            var client = ScrapingFactory.CreateScreenScraper("Allabolag");
            var actual = client.GetCompanyNameByOrgNr("556599-5239");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestScreenScrapingEniroResult()
        {
            const string expected = "Mattias Asplund AB";
            var client = ScrapingFactory.CreateScreenScraper("Eniro");
            var actual = client.GetCompanyNameByOrgNr("556599-5239");
            Assert.AreEqual(expected, actual);
        }
    }
}
