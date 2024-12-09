using Microsoft.EntityFrameworkCore;
using PizzasHub.Models;

namespace PizzasHub.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<PizzaModel> Pizzas { get; set;}

}