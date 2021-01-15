using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Distribuidora.Models
{
    public class Pedido
    {
        public Pedido(){}

        public Pedido(int pedidoId, DateTime dataPedido, int quantidadePedido, decimal valorUnitarioPedido, decimal valorTotalPedido)
        {
            PedidoId = pedidoId;
            DataPedido = dataPedido;
            QuantidadePedido = quantidadePedido;
            ValorUnitarioPedido = valorUnitarioPedido;
            ValorTotalPedido = valorTotalPedido;
        }

        public Pedido(int pedidoId, DateTime dataPedido, int quantidadePedido, decimal valorUnitarioPedido, decimal valorTotalPedido, ItensDoPedido itensDoPedido) : this(pedidoId, dataPedido, quantidadePedido, valorUnitarioPedido, valorTotalPedido)
        {
            this.itensDoPedido = itensDoPedido;
        }

        [Key]
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public int QuantidadePedido { get; set; }
        public decimal ValorUnitarioPedido { get; set; }
        public decimal ValorTotalPedido { get; set; }
        public ItensDoPedido itensDoPedido { get; set; }
    }
}