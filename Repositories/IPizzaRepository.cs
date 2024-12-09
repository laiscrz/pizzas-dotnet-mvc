using PizzasHub.Models;

namespace PizzasHub.Repositories;

public interface IPizzaRepository
{
    Task<IEnumerable<PizzaModel>> GetAllAsync();
    Task<PizzaModel> GetByIdAsync(int id);
    Task AddAsync(PizzaModel entity);
    Task UpdateAsync(PizzaModel entity);
    Task DeleteAsync(int id);
}