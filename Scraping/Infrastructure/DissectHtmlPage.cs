using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scraping.Infrastructure
{
    public static class DissectHtmlPage
    {
        public static string Dissect(string page)
        {
            page = page.Remove(0, page.IndexOf("<title>") + 7);
            var companyName = page.Substring(0, page.IndexOf("</title>") - 27);
            return companyName;
        }
    }
}