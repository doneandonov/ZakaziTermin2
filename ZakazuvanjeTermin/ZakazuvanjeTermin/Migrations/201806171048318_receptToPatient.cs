namespace ZakazuvanjeTermin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class receptToPatient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Receptas", "Doctor_Id", c => c.Int());
            CreateIndex("dbo.Receptas", "Doctor_Id");
            AddForeignKey("dbo.Receptas", "Doctor_Id", "dbo.Doctors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receptas", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.Receptas", new[] { "Doctor_Id" });
            DropColumn("dbo.Receptas", "Doctor_Id");
        }
    }
}
