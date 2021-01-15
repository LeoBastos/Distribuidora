using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Distribuidora.Models
{
    public class Estoque
    {
        public Estoque(){}

        public Estoque(int estoqueId, int quantidadeEstoque, decimal valorUnitario)
        {
            EstoqueId = estoqueId;
            QuantidadeEstoque = quantidadeEstoque;
            ValorUnitario = valorUnitario;
        }

        public Estoque(int estoqueId, int quantidadeEstoque, decimal valorUnitario, Produto produtoEstoque) : this(estoqueId, quantidadeEstoque, valorUnitario)
        {
            ProdutoEstoque = produtoEstoque;
        }

        [Key]
        public int EstoqueId { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal ValorUnitario { get; set; }
        public Produto ProdutoEstoque { get; set; }
    }
}