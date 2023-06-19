namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDLVaoBangBills : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Bills([Total],[ExaminationCardId]) values(100000,1)");
            Sql("Insert Into Bills([Total],[ExaminationCardId]) values(520000,2)");
            Sql("Insert Into Bills([Total],[ExaminationCardId]) values(325000,3)");
            Sql("Insert Into Bills([Total],[ExaminationCardId]) values(412000,4)");
            Sql("Insert Into Bills([Total],[ExaminationCardId]) values(250000,5)");
        }
        
        public override void Down()
        {
        }
    }
}
