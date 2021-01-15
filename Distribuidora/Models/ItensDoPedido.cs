using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Distribuidora.Models
{
    public class ItensDoPedido
    {
        public ItensDoPedido() { }

        public ItensDoPedido(int itensDoPedidoId, int quantidadeItens, decimal preco, decimal valorTotal)
        {
            ItensDoPedidoId = itensDoPedidoId;
            QuantidadeItens = quantidadeItens;
            Preco = preco;
            ValorTotal = valorTotal;
        }

        [Key]
        public int ItensDoPedidoId { get; set; }
        public int QuantidadeItens { get; set; }
        public decimal Preco { get; set; }
        public decimal ValorTotal { get; set; }
    }
}