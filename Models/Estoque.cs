using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Produção.Models
{
    public class Estoque
    {
        public int EstoqueId { get; set; }

        [DisplayName("Descrição")]

        public string Descricao { get; set; }

        public string Quantidade { get; set; }

        [DisplayName("Categoria")]

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
