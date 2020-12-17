namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartHospital1 : DbMigration
    {
        public override void Up()
        {
<<<<<<< Updated upstream
            AddColumn("dbo.AspNetUsers", "Rol", c => c.String());
=======
            AlterColumn("dbo.Hospitals", "Numero_Hospital", c => c.Int(nullable: false));
>>>>>>> Stashed changes
        }
        
        public override void Down()
        {
<<<<<<< Updated upstream
            DropColumn("dbo.AspNetUsers", "Rol");
=======
            AlterColumn("dbo.Hospitals", "Numero_Hospital", c => c.String(nullable: false));
>>>>>>> Stashed changes
        }
    }
}
