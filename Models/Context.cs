using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Produção.Models;

namespace Produção.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base (options)
        {
            InicializaBD.Initialize(this);
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produção.Models.Produto> Produto { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

    }

     
}
