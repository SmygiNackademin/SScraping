using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scraping.Models
{
    public class IndexViewModel
    {
        public string CompanyName { get; set; }
        public SelectList SiteList { get; set; }

        public IndexViewModel()
        {
            var siteList = new Dictionary<string, string>();
            siteList.Add("Allabolag", "http://allabolag.se/");
            siteList.Add("Eniro", "http://gulasidorna.eniro.se/hitta:");
            SiteList = new SelectList(siteList, "Value", "Key");
        }
    }
}