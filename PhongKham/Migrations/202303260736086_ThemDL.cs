namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDL : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Doctors([Name],[Birthday],[specialize],[position],[userName],[password]) values(N'Phan Thị Yến Vi','2002/10/29',N'chăm sóc bệnh nhân',N'Y tá','yenvi','123')");
            Sql("Insert Into Doctors([Name],[Birthday],[specialize],[position],[userName],[password]) values(N'Nguyễn Thị Thanh','2002/11/02',N'Đa khoa',N'Bác sĩ','thanh123','abc')");
            Sql("Insert Into Doctors([Name],[Birthday],[specialize],[position],[userName],[password]) values(N'Thái Tân Phát','2002/04/07',N'Răng hàm mặt',N'Bác sĩ','tanphat11','1111')");
            Sql("Insert Into Doctors([Name],[Birthday],[specialize],[position],[userName],[password]) values(N'Nguyễn Thị Ngọc Yến','2002/08/23',N'Da liễu',N'Bác sĩ','yen','1')");
        }
        
        public override void Down()
        {
        }
    }
}
