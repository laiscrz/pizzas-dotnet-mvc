using Microsoft.AspNetCore.Mvc;
using PizzasHub.DTOs;
using PizzasHub.Models;
using PizzasHub.Services;

namespace PizzasHub.Controllers;
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

    [HttpGet]
    public IActionResult Register()
    {
        var model = new PizzaDTO();
        return View(model);
    }


    [HttpPost]
    [HttpPost]
    public async Task<IActionResult> Register(PizzaDTO pizzaDto)
    {
        if (ModelState.IsValid)
        {
            var pizza = new PizzaModel
            {
                Sabor = pizzaDto.Sabor,
                UrlCapa = pizzaDto.UrlCapa,
                Descricao = pizzaDto.Descricao,
                Valor = pizzaDto.Valor
            };

            await _pizzaService.AddPizzaAsync(pizza);
            return RedirectToAction("Index", "Pizza");
        }
        else
        {
            return View(pizzaDto);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Remove(int id)
    {
        await _pizzaService.DeletePizzaAsync(id); 

        TempData["Success"] = "Pizza removida com sucesso!";

        return RedirectToAction("Index", "Pizza");
    }



}
