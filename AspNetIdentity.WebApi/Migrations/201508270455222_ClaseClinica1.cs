namespace AspNetIdentity.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClaseClinica1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinicas",
                c => new
                    {
                        CodigoClinica = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Telefono = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.CodigoClinica);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clinicas");
        }
    }
}
