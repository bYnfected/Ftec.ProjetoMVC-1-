using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RandomTestValues;
using Ftec.ProjetoMvc.WebSite.Models;

namespace Ftec.ProjetoMvc.WebSite.MockFactory
{
    public static class MockFactory
    {
        public static List<Produto> GerarListaProdutos(int numeroDeVezes)
        {
            List<Produto> produtos = new List<Produto>();

            for(int i = 0; i < numeroDeVezes; i++)
            {
                produtos.Add(new Produto()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Juliano",
                    Preco = 10,
                    Quantidade = 10
                });
            }

            return produtos;
        }

        public static List<Categoria> GerarListaCategorias(int numeroDeVezes)
        {
            List<Categoria> categoria = new List<Categoria>();

            for (int i = 0; i < numeroDeVezes; i++)
            {
                categoria.Add(new Categoria()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Juliano"
                });
            }

            return categoria;
        }
    }
}