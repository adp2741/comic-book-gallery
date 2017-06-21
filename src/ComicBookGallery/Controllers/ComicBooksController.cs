using ComicBookGallery.Models;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>A comic book about a man and spiders.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Scripts" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" }
                }
            };

            return View(comicBook);
        }
    }
}

