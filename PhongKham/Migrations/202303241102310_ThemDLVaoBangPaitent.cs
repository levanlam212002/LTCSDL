namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDLVaoBangPaitent : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Patients([Name],[Sex],[Birthday],[email],[cccd],[phoneNumber]) values(N'Lê Văn Lâm',1,'2002/01/02','levanlam@gmail.com',2912823,'0966287704')");
            Sql("Insert Into Patients([Name],[Sex],[Birthday],[email],[cccd],[phoneNumber]) values(N'Huỳnh Minh Hoàng',1,'2002/09/23','hmh@gmail.com',2938323,'0955207704')");
            Sql("Insert Into Patients([Name],[Sex],[Birthday],[email],[cccd],[phoneNumber]) values(N'Nguyễn Toàn Mỹ',0,'2002/11/23','my@gmail.com',29212823,'09662834404')");
        }
        
        public override void Down()
        {
        }
    }
}
