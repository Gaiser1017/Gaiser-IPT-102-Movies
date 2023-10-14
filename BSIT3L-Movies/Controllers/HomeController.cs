using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
           new MovieViewModel { Id = 1, Name = "Iron Man", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.\r\n" },
           new MovieViewModel { Id = 2, Name = "Thor", Rating = "1", Image = "css/picture/pic2.jpg", Details = "" },
           new MovieViewModel { Id = 3, Name = "Captain America: The first Avenger", Rating = "1", Image = "css/picture/pic3.jpg", Details = "" },
           new MovieViewModel { Id = 4, Name = "The Avengers", Rating = "1", Image = "css/picture/pic4.jpg", Details = "" },
           new MovieViewModel { Id = 5, Name = "Thor the Dark World", Rating = "1", Image = "css/picture/pic5.jpg", Details = "" },
           new MovieViewModel { Id = 6, Name = "Captain America: Civil War", Rating = "1", Image = "css/picture/pic6.jpg", Details = "" },
           new MovieViewModel { Id = 7, Name = "Doctor Strange", Rating = "1", Image = "css/picture/pic7.jpg", Details = "" },
           new MovieViewModel { Id = 8, Name = "Spiderman Homecoming", Rating = "1", Image = "css/picture/pic8.jpg", Details = "" },
           new MovieViewModel { Id = 9, Name = "Black Panther", Rating = "1", Image = "css/picture/pic9.jpg", Details = "" },
           new MovieViewModel { Id = 10, Rating = "1", Image = "css/picture/pic10.jpg", Details = "" },
           new MovieViewModel { Id = 11,Rating = "1", Image = "css/picture/pic11.jpg", Details = "" },
           new MovieViewModel { Id = 12, Rating = "1", Image = "css/picture/pic12.jpg", Details = "" },
           new MovieViewModel { Id = 13, Rating = "1", Image = "css/picture/pic13.jpg", Details = "" },
           new MovieViewModel { Id = 14, Rating = "1", Image = "css/picture/pic14.jpg", Details = "" },
           new MovieViewModel { Id = 15, Rating = "1", Image = "css/picture/pic15.jpg", Details = "" },

        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}