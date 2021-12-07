using Papelaria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Papelaria.Contexts
{
    public class EFContexts
    {
        public class EFContexts : DbContext
        {
            public EFContexts() : base("db_Papelaria") 
            {
            }
            
            public  DbSet<Categoria> Categorias { get; set; }

            public DbSet<Fornecedor> Fornecedores { get; set; }

            public DbSet<Produto> Produtos { get; set; }
            
        }
    }
}