namespace AspNetIdentity.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioRelacionClinica : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CodigoClinica_CodigoClinica", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "CodigoClinica_CodigoClinica");
            AddForeignKey("dbo.AspNetUsers", "CodigoClinica_CodigoClinica", "dbo.Clinicas", "CodigoClinica");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "CodigoClinica_CodigoClinica", "dbo.Clinicas");
            DropIndex("dbo.AspNetUsers", new[] { "CodigoClinica_CodigoClinica" });
            DropColumn("dbo.AspNetUsers", "CodigoClinica_CodigoClinica");
        }
    }
}
