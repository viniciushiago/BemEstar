using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BemEstar.Domain.Entities;

namespace BemEstar.Application.Interface
{
    public interface IAlimentoService
    {
        List<Alimento> GetAlimentos();
    }
}