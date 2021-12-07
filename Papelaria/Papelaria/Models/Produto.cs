using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Papelaria.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public long? CategoriaId { get; set; }

        public long? FornecedorId { get; set; }

        public Categoria categoria { get; set; }

        public Fornecedor fornecedor { get; set; }

    }
}