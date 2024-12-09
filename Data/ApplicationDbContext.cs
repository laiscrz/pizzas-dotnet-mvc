using Microsoft.EntityFrameworkCore;

namespace PizzasHub.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


}