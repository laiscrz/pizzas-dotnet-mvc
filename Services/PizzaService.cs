using PizzasHub.Models;
using PizzasHub.Repositories;

namespace PizzasHub.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _repository;

        public PizzaService(IPizzaRepository repository)
        {
            _repository = repository;
        }

        // Adicionar Pizza (Validação de negócio antes de persistir)
        public async Task AddPizzaAsync(PizzaModel pizza)
        {
            if (string.IsNullOrEmpty(pizza.Sabor))
                throw new ArgumentException("O sabor da pizza é obrigatório.");

            if (pizza.Valor <= 0)
                throw new ArgumentException("O preço da pizza deve ser maior que zero.");

            await _repository.AddAsync(pizza);
        }

        // Obter todas as pizzas
        public async Task<IEnumerable<PizzaModel>> GetAllPizzasAsync()
        {
            return await _repository.GetAllAsync();
        }

        // Obter uma pizza pelo ID
        public async Task<PizzaModel> GetPizzaByIdAsync(int id)
        {
            var pizza = await _repository.GetByIdAsync(id);
            if (pizza == null)
                throw new KeyNotFoundException("Pizza não encontrada.");

            return pizza;
        }

        // Atualizar uma pizza
        public async Task UpdatePizzaAsync(PizzaModel pizza)
        {
            if (pizza.Id == 0)
                throw new ArgumentException("O ID da pizza é obrigatório para atualização.");

            await _repository.UpdateAsync(pizza);
        }

        // Remover pizza
        public async Task DeletePizzaAsync(int id)
        {
            var pizza = await _repository.GetByIdAsync(id);
            if (pizza == null)
                throw new KeyNotFoundException("Pizza não encontrada para exclusão.");

            await _repository.DeleteAsync(id);
        }
    }
}
