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
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movimentacao",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FuncionarioID = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioID, cascadeDelete: true)
                .Index(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.FuncionarioDepartamento",
                c => new
                    {
                        Funcionario_ID = c.Int(nullable: false),
                        Departamento_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Funcionario_ID, t.Departamento_ID })
                .ForeignKey("dbo.Funcionario", t => t.Funcionario_ID, cascadeDelete: true)
                .ForeignKey("dbo.Departamento", t => t.Departamento_ID, cascadeDelete: true)
                .Index(t => t.Funcionario_ID)
                .Index(t => t.Departamento_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movimentacao", "FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.FuncionarioDepartamento", "Departamento_ID", "dbo.Departamento");
            DropForeignKey("dbo.FuncionarioDepartamento", "Funcionario_ID", "dbo.Funcionario");
            DropIndex("dbo.FuncionarioDepartamento", new[] { "Departamento_ID" });
            DropIndex("dbo.FuncionarioDepartamento", new[] { "Funcionario_ID" });
            DropIndex("dbo.Movimentacao", new[] { "FuncionarioID" });
            DropTable("dbo.FuncionarioDepartamento");
            DropTable("dbo.Movimentacao");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Departamento");
        }
    }
}
