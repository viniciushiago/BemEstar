using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BemEstar.Domain.Entities;

namespace BemEstar.Infrastructure.Interface
{
    public interface IAlimentoRepository
    {
        List<Alimento> GetAlimentos();
    }
}