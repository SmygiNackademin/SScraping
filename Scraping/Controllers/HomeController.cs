using System.Threading.Tasks;
using System.Web.Mvc;
using Scraping.Infrastructure;
using Scraping.Lib;
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
            var client = new Client(ValidateOrgnr(orgNr));
            await client.Start();
            var company = client.Dissect();
            return View(new IndexViewModel { CompanyName = company });
        }

        private string ValidateOrgnr(string orgNr)
        {
            if (orgNr.Contains("-"))
                orgNr = orgNr.Replace("-", "");
            if (orgNr.Contains(" "))
                orgNr = orgNr.Replace(" ", "");
            return orgNr;
        }
    }
}
