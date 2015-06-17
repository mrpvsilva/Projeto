namespace DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoUsuarios",
                c => new
                    {
                        IdGrupoUsuario = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.IdGrupoUsuario);
            
            CreateTable(
                "dbo.OrdemServicos",
                c => new
                    {
                        IdOrdemServico = c.Int(nullable: false, identity: true),
                        DataEntrada = c.DateTime(nullable: false),
                        Descricao = c.String(),
                        DataSaida = c.DateTime(),
                        IdVeiculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOrdemServico)
                .ForeignKey("dbo.Veiculos", t => t.IdVeiculo, cascadeDelete: true)
                .Index(t => t.IdVeiculo);
            
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        IdVeiculo = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        Modelo = c.String(),
                        Ano = c.Int(nullable: false),
                        Marca = c.String(),
                        Placa = c.String(),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdVeiculo)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario, cascadeDelete: true)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Telefone = c.String(),
                        DataNascimento = c.DateTime(),
                        Endereco = c.String(),
                        Numero = c.String(),
                        Cep = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                        IdGrupoUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.GrupoUsuarios", t => t.IdGrupoUsuario, cascadeDelete: true)
                .Index(t => t.IdGrupoUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrdemServicos", "IdVeiculo", "dbo.Veiculos");
            DropForeignKey("dbo.Veiculos", "IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "IdGrupoUsuario", "dbo.GrupoUsuarios");
            DropIndex("dbo.Usuarios", new[] { "IdGrupoUsuario" });
            DropIndex("dbo.Veiculos", new[] { "IdUsuario" });
            DropIndex("dbo.OrdemServicos", new[] { "IdVeiculo" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Veiculos");
            DropTable("dbo.OrdemServicos");
            DropTable("dbo.GrupoUsuarios");
        }
    }
}
