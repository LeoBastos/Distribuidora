using Distribuidora.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Distribuidora.Context
{
    public class DistribuidoraContext : DbContext
    {
        public DistribuidoraContext()
            : base("DistribuidoraContext")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItensDoPedido> itensDoPedido { get; set; }
    }
}