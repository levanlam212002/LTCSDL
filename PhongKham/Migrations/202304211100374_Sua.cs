namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sua : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "PayDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bills", "PayDate");
        }
    }
}
