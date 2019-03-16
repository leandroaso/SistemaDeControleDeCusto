namespace SistemaDeControleDeCusto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movimentacao", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movimentacao", "Valor");
        }
    }
}
