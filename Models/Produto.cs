using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Produção.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [DisplayName("Descrição")]

        public string Descricao { get; set; }

        [DisplayName("Categoria")]

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

    }
}
