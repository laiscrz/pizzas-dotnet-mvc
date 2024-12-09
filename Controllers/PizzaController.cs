using Microsoft.AspNetCore.Mvc;
using PizzasHub.Models;
using PizzasHub.Services;

namespace PizzasHub.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pizzas = await _pizzaService.GetAllPizzasAsync();

            return View(pizzas);
        }
    }
}
