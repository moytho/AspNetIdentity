namespace AspNetIdentity.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClinicaLogo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clinicas", "Logo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clinicas", "Logo");
        }
    }
}
