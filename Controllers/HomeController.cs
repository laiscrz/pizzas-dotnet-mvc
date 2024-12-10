using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PizzasHub.Models;

namespace PizzasHub.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var statusCode = HttpContext.Response.StatusCode;
        var errorMessage = "Ocorreu um erro inesperado.";

        return View(new ErrorViewModel
        {
            StatusCode = statusCode,
            ErrorMessage = errorMessage,
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            Timestamp = DateTime.Now
        });
    }



}
