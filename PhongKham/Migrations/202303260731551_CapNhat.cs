namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CapNhat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "userName", c => c.String(nullable: false));
            AddColumn("dbo.Doctors", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "password");
            DropColumn("dbo.Doctors", "userName");
        }
    }
}
