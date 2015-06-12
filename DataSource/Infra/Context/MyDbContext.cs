

using System.Data.Entity;
using Dominio.Models;
using System;
namespace DataSource.Infra.Context
{
    public class MyDbContext : DbContext, IDisposable
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuarios { get; set; }

        public MyDbContext()
            : base("MyDb")
        {

        }

    }
}
