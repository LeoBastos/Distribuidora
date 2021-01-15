using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Distribuidora.Models.ViewModel
{
    public class EstoqueViewModel
    {
        public EstoqueViewModel(){}

        public EstoqueViewModel(Cliente dadosDoCliente, Produto dadosDoProduto, Estoque dadosDoEstoque, Pedido dadosDoPedido, ItensDoPedido dadosItensPedido)
        {
            DadosDoCliente = dadosDoCliente;
            DadosDoProduto = dadosDoProduto;
            DadosDoEstoque = dadosDoEstoque;
            DadosDoPedido = dadosDoPedido;
            DadosItensPedido = dadosItensPedido;
        }

        public Cliente DadosDoCliente { get; set; }
        public Produto DadosDoProduto { get; set; }
        public Estoque DadosDoEstoque { get; set; }
        public Pedido DadosDoPedido { get; set; }
        public ItensDoPedido DadosItensPedido { get; set; }
    }
}