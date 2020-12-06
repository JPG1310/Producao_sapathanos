using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produção.Models
{
    public class InicializaBD
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();
            
            if(context.Categorias.Any())
            {
                return;
            }

            var categorias = new Categoria[]
            {
                new Categoria{Descricao="Funcionarios"},
                new Categoria{Descricao="Modelos"},
                new Categoria{Descricao="Informatica"},
                new Categoria{Descricao="Informatica"},
                new Categoria{Descricao="Informatica"},
                new Categoria{Descricao="Informatica"},
                new Categoria{Descricao="Informatica"},

            };
            foreach (var item in categorias)
            {
                context.Categorias.Add(item);
            }
            context.SaveChanges();

            var Estoques = new Estoque[]
           {
                 new Estoque{Descricao="Couro", CategoriaId=2},

           };
            foreach (var item in Estoques)
            {
                context.Estoques.Add(item);
            }
            context.SaveChanges();

            var Funcionarios = new Funcionario[]
         {
                 

         };
            foreach (var item in Funcionarios)
            {
                context.Funcionarios.Add(item);
            }
            context.SaveChanges();

        }
    }
}
