using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ShowTracker.Models;

namespace ShowTracker.Controllers;

public class HomeController : Controller
{
    private ShowTrackerContext _db;

    public HomeController(ShowTrackerContext context)
    {
        _db = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    // Very unfinished, just didn't want to leave it with errors.
    [HttpGet("/dashboard")]
    public IActionResult Dashboard()
    {
        if (!_IsUserLoggedIn)
        {
            return RedirectToAction("Index");
        }

        return View("Dashboard");
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

    private bool _IsUserLoggedIn { get => HttpContext.Session.GetInt32("UserId") != null; }
}
