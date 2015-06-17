

using System.Data.Entity;
using Dominio.Models;
using System;
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

        public override void OnModelCreating(DbModelBuilder builder)
        {
            
        } 

    }
}
