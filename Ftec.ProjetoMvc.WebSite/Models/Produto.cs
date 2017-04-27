using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftec.ProjetoMvc.WebSite.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public Categoria Categoria { get; set; }
     }
}