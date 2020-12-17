namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Foto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administradors", "Foto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Administradors", "Foto");
        }
    }
}
