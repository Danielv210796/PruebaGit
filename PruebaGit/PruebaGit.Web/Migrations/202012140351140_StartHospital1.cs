namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartHospital1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hospitals", "Numero_Hospital", c => c.String(nullable: false));
            AlterColumn("dbo.Actividads", "ActividadId", c => c.String(nullable: false));
            DropColumn("dbo.Hospitals", "NomHospital");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hospitals", "NomHospital", c => c.Int(nullable: false));
            AlterColumn("dbo.Actividads", "ActividadId", c => c.Int(nullable: false));
            DropColumn("dbo.Hospitals", "Numero_Hospital");
        }
    }
}
