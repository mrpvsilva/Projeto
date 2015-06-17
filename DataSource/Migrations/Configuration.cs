using Dominio.Models;

namespace DataSource.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataSource.Infra.Context.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataSource.Infra.Context.MyDbContext context)
        {
            context.GrupoUsuarios.AddOrUpdate(new GrupoUsuario[]
            {
                new GrupoUsuario { Descricao = "Administrador" },
                new GrupoUsuario{Descricao = "Gerente"},
                new GrupoUsuario{Descricao = "Funcionario"},
                new GrupoUsuario{Descricao = "Cliente"}
            });

            context.Usuarios.AddOrUpdate(new Usuario[]
            {
                new Usuario { Nome = "Admin", Senha = "123456", Login = "admin", IdGrupoUsuario = 1 },
                new Usuario { Nome = "Gerente", Senha = "123456", Login = "gerente", IdGrupoUsuario = 2 },
                new Usuario { Nome = "Funcionario", Senha = "123456", Login = "funcionario", IdGrupoUsuario = 3 },
                new Usuario { Nome = "Cliente", Senha = "123456", Login = "cliente", IdGrupoUsuario = 4 },
                
            });


        }
    }
}
