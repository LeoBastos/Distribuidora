using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Distribuidora.Models
{
    public class Cliente
    {
        public Cliente(){}

        public Cliente(int clienteId, string nomeCliente, string email, string cpf, string celular, DateTime dataDeCadastro)
        {
            ClienteId = clienteId;
            NomeCliente = nomeCliente;
            Email = email;
            Cpf = cpf;
            Celular = celular;
            DataDeCadastro = dataDeCadastro;
        }

        public Cliente(int clienteId, string nomeCliente, string email, string cpf, string celular, DateTime dataDeCadastro, Pedido pedidoCliente) : this(clienteId, nomeCliente, email, cpf, celular, dataDeCadastro)
        {
            PedidoCliente = pedidoCliente;
        }

        [Key]
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public DateTime DataDeCadastro { get; set; }        
        public Pedido PedidoCliente { get; set; }
    }
}