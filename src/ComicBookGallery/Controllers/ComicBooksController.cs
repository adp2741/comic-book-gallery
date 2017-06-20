using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Something neat</p>";
            ViewBag.Artists = new string[] { "Scripts: Dan Slott", "Pencils: Humberto Ramos" };

            return View();
        }
    }
}

