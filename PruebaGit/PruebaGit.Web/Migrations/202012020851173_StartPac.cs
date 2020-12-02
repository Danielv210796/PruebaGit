namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartPac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "NoPaciente", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "Nombres", c => c.String());
            DropColumn("dbo.Pacientes", "Id_Paciente");
            DropColumn("dbo.Pacientes", "Nombre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pacientes", "Nombre", c => c.String());
            AddColumn("dbo.Pacientes", "Id_Paciente", c => c.Int(nullable: false));
            DropColumn("dbo.Pacientes", "Nombres");
            DropColumn("dbo.Pacientes", "NoPaciente");
        }
    }
}
