
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie=new Movie() { Name="Deepak!" };
           // ViewData["Movie"] = movie;
             return View(movie);
          //  return new ViewResult();
        }
    }
}