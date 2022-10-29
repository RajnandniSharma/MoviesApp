using Microsoft.AspNetCore.Mvc;
using MoviesApp.Models;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
      
            public IActionResult Index()
        {
            IMemory Im=new IMemory();
            return View(Im.getAllMovies());
        }
    }
}
