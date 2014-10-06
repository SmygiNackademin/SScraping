using System.Threading.Tasks;
using System.Web.Mvc;
using Scraping.Lib.Factory;
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
        public async Task<ActionResult> Index(string orgNr, string sida)
        {
            if (string.IsNullOrEmpty(orgNr) || string.IsNullOrEmpty(sida))
                return View();
            var client = ScrapingFactory.CreateScreenScraper(ValidateOrgNr(orgNr), sida);
            await client.GetHtmlContentFromScraping();
            var company = client.GetCompanyName();
            return View(new IndexViewModel { CompanyName = company });
        }

        private string ValidateOrgNr(string orgNr)
        {
            if (orgNr.Contains("-"))
                orgNr = orgNr.Replace("-", "");
            if (orgNr.Contains(" "))
                orgNr = orgNr.Replace(" ", "");
            return orgNr;
        }
    }
}
