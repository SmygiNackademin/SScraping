
namespace Scraping.Lib.Service
{
    public class EniroScrapingClient : ScrapingClient
    {
        public override string Site { get { return "http://gulasidorna.eniro.se/hitta:"; } }

        public override string Xpath { get { return @"id('hit-list')/li/article/header/div[2]/h2/span/a"; } }
    }
}
