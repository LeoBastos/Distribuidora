using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Distribuidora.Models
{
    public class Produto
    {
        public Produto(){}

        public Produto(int produtoId, string nomeProduto, int quantidade, decimal valorUnitario, decimal precoVenda, string unidade)
        {
            ProdutoId = produtoId;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            PrecoVenda = precoVenda;
            Unidade = unidade;
        }

        public Produto(int produtoId, string nomeProduto, int quantidade, decimal valorUnitario, decimal precoVenda, string unidade, Produto itensDoProduto) : this(produtoId, nomeProduto, quantidade, valorUnitario, precoVenda, unidade)
        {
            ItensDoProduto = itensDoProduto;
        }

        [Key]
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal PrecoVenda { get; set; }        
        public string Unidade { get; set; }
        public Produto ItensDoProduto { get; set; }

    }
}