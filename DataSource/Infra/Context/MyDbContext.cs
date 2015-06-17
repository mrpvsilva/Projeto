

using System.Data.Entity;
using Dominio.Models;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataSource.Infra.Context
{
    public class MyDbContext : DbContext, IDisposable
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuarios { get; set; }

        public DbSet<OrdemServico> OrdemServicos { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        public MyDbContext()
            : base("MyDb")
        {

        }

        

    }
}
