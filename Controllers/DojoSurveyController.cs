using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string location, string fav_lang, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.fav_lang = fav_lang;
            ViewBag.comment = comment;

            return View();
        }

        [HttpGet]
        [Route("result")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("index");
        }
    }
}