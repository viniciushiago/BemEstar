using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BemEstar.Domain.Entities
{
    public class Alimento
    {
        public int IdAlimento { get; set; }
        public String NomeAlimento  { get; set; }
        public int Calorias { get; set; }
        public int IdRefeicao { get; set; }
        public Refeicao Refeicao { get; set; }
    }
}
