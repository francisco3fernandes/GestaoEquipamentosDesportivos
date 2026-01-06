using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosDesportivos.Models
{
    public class EquipamentoModel
    {
        public int IdEquipamento { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public DateTime DataAquisicao { get; set; }
    }
}
