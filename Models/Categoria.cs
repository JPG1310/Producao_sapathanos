using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Produção.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="A descrição precisa ser preenchida")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
        public ICollection<Estoque> Estoques { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }

    }
}
