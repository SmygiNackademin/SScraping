using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Scraping.Infrastructure;
using Scraping.Models;

namespace Scraping.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new IndexViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(string orgNr)
        {
            if (string.IsNullOrEmpty(orgNr))
                return View();
            var client = new Client(orgNr);
            await client.Start();
            var company = DissectHtmlPage.Dissect(client.Content);
            return View(new IndexViewModel { CompanyName = company });
        }
    }
}
