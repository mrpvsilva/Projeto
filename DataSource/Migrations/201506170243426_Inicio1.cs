namespace DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculos", "TipoServico", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculos", "TipoServico");
        }
    }
}
