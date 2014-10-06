﻿
namespace Scraping.Lib.Service
{
    public class HittaScrapingClient : ScrapingClient
    {
        private readonly string _orgNr;

        public HittaScrapingClient(string orgNr)
        {
            _orgNr = orgNr;
        }

        public override string Site { get { return string.Format("http://gulasidorna.eniro.se/hitta:{0}", _orgNr); } }

        public override string Xpath { get { return @"id('hit-list')/li/article/header/div[2]/h2/span/a"; } }
    }
}