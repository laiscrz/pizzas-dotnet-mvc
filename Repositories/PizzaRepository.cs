using PizzasHub.Data;
using PizzasHub.Models;
using Microsoft.EntityFrameworkCore;

namespace PizzasHub.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<PizzaModel> _dbSet;

        public PizzaRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<PizzaModel>();
        }

        // Create (Adicionar uma nova Pizza)
        public async Task AddAsync(PizzaModel pizza)
        {
            await _dbSet.AddAsync(pizza);
            await _context.SaveChangesAsync();
        }

        // Read (Obter todas as Pizzas)
        public async Task<IEnumerable<PizzaModel>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        // Read (Obter uma Pizza por ID)
        public async Task<PizzaModel> GetByIdAsync(int id)
        {
            var pizza = await _dbSet.FindAsync(id) ?? throw new KeyNotFoundException("Pizza não encontrada.");
            return pizza;
        }

        // Update (Atualizar uma Pizza)
        public async Task UpdateAsync(PizzaModel pizza)
        {
            _dbSet.Update(pizza);
            await _context.SaveChangesAsync();
        }

        // Delete (Remover uma Pizza)
        public async Task DeleteAsync(int id)
        {
            var pizza = await GetByIdAsync(id);
            if (pizza != null)
            {
                _dbSet.Remove(pizza);
                await _context.SaveChangesAsync();
            }
        }
    }
}
