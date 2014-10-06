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
            siteList.Add("Allabolag", "Allabolag");
            siteList.Add("Eniro", "Eniro");
            siteList.Add("Hitta.se", "Hitta");
            siteList.Add("Upplysning.se", "Upplysning");
            SiteList = new SelectList(siteList, "Value", "Key");
        }
    }
}