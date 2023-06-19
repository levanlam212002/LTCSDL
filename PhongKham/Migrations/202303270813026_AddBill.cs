namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBill : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Bills([Total],[ExaminationCardId],[Status]) values(100000,6,'true')");
            Sql("Insert Into Bills([Total],[ExaminationCardId],[Status]) values(520000,7,'false')");
            Sql("Insert Into Bills([Total],[ExaminationCardId],[Status]) values(325000,8,'false')");
            Sql("Insert Into Bills([Total],[ExaminationCardId],[Status]) values(412000,9,'false')");
            Sql("Insert Into Bills([Total],[ExaminationCardId],[Status]) values(250000,10,'false')");
        }
        
        public override void Down()
        {
        }
    }
}
