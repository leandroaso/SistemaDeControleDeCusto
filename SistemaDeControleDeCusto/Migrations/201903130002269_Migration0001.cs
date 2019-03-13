namespace SistemaDeControleDeCusto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departamento");
        }
    }
}
