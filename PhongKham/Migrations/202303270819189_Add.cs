namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Male", c => c.Boolean(nullable: false));
            DropColumn("dbo.Patients", "Sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "Sex", c => c.Boolean(nullable: false));
            DropColumn("dbo.Patients", "Male");
        }
    }
}
