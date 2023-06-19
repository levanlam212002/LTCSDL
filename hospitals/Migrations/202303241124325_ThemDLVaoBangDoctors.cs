namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDLVaoBangDoctors : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Doctors([Name],[Birthday],[specialize],[position]) values(N'Phan Thị Yến Vi','2002/10/29',N'chăm sóc bệnh nhân',N'Y tá')");
            Sql("Insert Into Doctors([Name],[Birthday],[specialize],[position]) values(N'Nguyễn Thị Thanh','2002/11/02',N'Đa khoa',N'Bác sĩ')");
            Sql("Insert Into Doctors([Name],[Birthday],[specialize],[position]) values(N'Thái Tân Phát','2002/04/07',N'Răng hàm mặt',N'Bác sĩ')");
            Sql("Insert Into Doctors([Name],[Birthday],[specialize],[position]) values(N'Nguyễn Thị Ngọc Yến','2002/08/23',N'Da liễu',N'Bác sĩ')");
        }
        
        public override void Down()
        {
        }
    }
}
