using PizzasHub.Models;

namespace PizzasHub.Services
{
    public interface IPizzaService
    {
        
        Task AddPizzaAsync(PizzaModel pizza);

        Task<IEnumerable<PizzaModel>> GetAllPizzasAsync();
     
        Task<PizzaModel> GetPizzaByIdAsync(int id);

        Task UpdatePizzaAsync(PizzaModel pizza);

        Task DeletePizzaAsync(int id);
    }
}
