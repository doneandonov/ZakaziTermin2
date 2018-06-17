namespace ZakazuvanjeTermin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Receptas", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.Receptas", new[] { "Doctor_Id" });
            AddColumn("dbo.Receptas", "Pacient_Id", c => c.Int());
            CreateIndex("dbo.Receptas", "Pacient_Id");
            AddForeignKey("dbo.Receptas", "Pacient_Id", "dbo.Pacients", "Id");
            DropColumn("dbo.Receptas", "Doctor_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Receptas", "Doctor_Id", c => c.Int());
            DropForeignKey("dbo.Receptas", "Pacient_Id", "dbo.Pacients");
            DropIndex("dbo.Receptas", new[] { "Pacient_Id" });
            DropColumn("dbo.Receptas", "Pacient_Id");
            CreateIndex("dbo.Receptas", "Doctor_Id");
            AddForeignKey("dbo.Receptas", "Doctor_Id", "dbo.Doctors", "Id");
        }
    }
}
