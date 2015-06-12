namespace DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.GrupoUsuarios",
                c => new
                    {
                        IdGrupoUsuario = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.IdGrupoUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "IdGrupoUsuario", "dbo.GrupoUsuarios");
            DropIndex("dbo.Usuarios", new[] { "IdGrupoUsuario" });
            DropTable("dbo.GrupoUsuarios");
            DropTable("dbo.Usuarios");
        }
    }
}
