using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BemEstar.Domain.Entities
{
    public class Refeicao
    {
        public int IdRefeicao { get; set; }
        public string NomeRefeicao  { get; set; }
        public List<Alimento> Alimentos { get; set; }
    }
}