using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scraping.Lib.Factory;

namespace Scraping.Test
{
    [TestClass]
    public class ScrapingTests
    {
        [TestMethod]
        public async Task TestShizzle()
        {
            var sw = new Stopwatch();
            sw.Start();
            await Allabolag();
            sw.Stop();
            var allabolagTime = sw.ElapsedTicks;
            sw.Restart();
            await Eniro();
            sw.Stop();
            var eniroTime = sw.ElapsedTicks;
            sw.Restart();
            await Hitta();
            sw.Stop();
            var hittaTime = sw.ElapsedTicks;
            sw.Restart();
            await Upplysning();
            sw.Stop();
            var upplysningTime = sw.ElapsedTicks;
        }

        public Task Allabolag()
        {
            var client = ScrapingFactory.CreateScreenScraper("Allabolag");
            return Task.Run(() => client.GetCompanyNameByOrgNr("5565995239"));
        }

        public Task Eniro()
        {
            var client = ScrapingFactory.CreateScreenScraper("Eniro");
            return Task.Run(() => client.GetCompanyNameByOrgNr("5565995239"));
        }

        public Task Hitta()
        {
            var client = ScrapingFactory.CreateScreenScraper("Hitta");
            return Task.Run(() => client.GetCompanyNameByOrgNr("5565995239"));
        }

        public Task Upplysning()
        {
            var client = ScrapingFactory.CreateScreenScraper("Upplysning");
            return Task.Run(() => client.GetCompanyNameByOrgNr("5565995239"));
        }

        [TestMethod]
        public void TestScreenScrapingAllabolagResult()
        {
            const string expected = "Mattias Asplund Aktiebolag";
            var client = ScrapingFactory.CreateScreenScraper("Allabolag");
            var actual = client.GetCompanyNameByOrgNr("5565995239");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestScreenScrapingEniroResult()
        {
            const string expected = "Mattias Asplund AB\n";
            var client = ScrapingFactory.CreateScreenScraper("Eniro");
            var actual = client.GetCompanyNameByOrgNr("5565995239");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestScreenScrapingHittaResult()
        {
            const string expected = "Asplund Software";
            var client = ScrapingFactory.CreateScreenScraper("Hitta");
            var actual = client.GetCompanyNameByOrgNr("5565995239");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestScreenScrapingUpplysningResult()
        {
            const string expected = "Mattias Asplund Aktiebolag";
            var client = ScrapingFactory.CreateScreenScraper("Upplysning");
            var actual = client.GetCompanyNameByOrgNr("5565995239");
            Assert.AreEqual(expected, actual);
        }
    }
}
