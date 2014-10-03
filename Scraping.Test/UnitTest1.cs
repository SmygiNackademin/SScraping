using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scraping.Lib;

namespace Scraping.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestScreenScrapingAllabolagResult()
        {
            const string excepted = "Mattias Asplund Aktiebolag";
            var client = new Client("556599-5239");
            await client.Start();
            var actual = client.Dissect();
            Assert.AreEqual(excepted, actual);
        }
    }
}
