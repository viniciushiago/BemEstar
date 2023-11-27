using BemEstar.Domain.Entities;
using BemEstar.Infrastructure.Data;
using BemEstar.Infrastructure.Interface;

namespace BemEstar.Infrastructure.Repositories
{
    public class AlimentoRepository : IAlimentoRepository
    {
        private readonly BemEstarDbContext _context;

        public AlimentoRepository(BemEstarDbContext context)
        {
            _context = context;
        }
        public List<Alimento> GetAlimentos()
        {
            return _context.Alimentos.ToList();
        }
    }
}