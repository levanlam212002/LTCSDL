namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Patients", "address", c => c.String(nullable: false));
           
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "address");
            DropColumn("dbo.Bills", "Status");
        }
    }
}
