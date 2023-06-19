namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThuTuc : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE PROC SP_GetAccountByUsername @userName nvarchar(100),@password nvarchar(100) AS BEGIN declare @kq int SELECT @kq = count(*) FROM dbo.Doctor WHERE userName = @userName and password = @password Select @kq as KQ END");
                

        }
        
        public override void Down()
        {
        }
    }
}
