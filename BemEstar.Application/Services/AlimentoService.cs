using BemEstar.Application.Interface;
using BemEstar.Domain.Entities;
using BemEstar.Infrastructure.Interface;

namespace BemEstar.Application.Services
{
    public class AlimentoService : IAlimentoService
    {
        private readonly IAlimentoRepository _respository;

        public AlimentoService(IAlimentoRepository repository){
            _respository = repository;
        }

        public List<Alimento> GetAlimentos(){
            return _respository.GetAlimentos();
        }
    }
}