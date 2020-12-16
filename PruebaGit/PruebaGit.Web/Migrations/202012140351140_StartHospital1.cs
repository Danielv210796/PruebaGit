namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartHospital1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Rol", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Rol");
        }
    }
}
