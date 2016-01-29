using System.Linq;
using System.Web.Mvc;

namespace Autocomplete_Widget.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public ActionResult Search(string term)
        {
            return Json(Models.Database.FindLanguage(LanguageName: term).Select(z => z.Name), JsonRequestBehavior.AllowGet);
        }
    }
}