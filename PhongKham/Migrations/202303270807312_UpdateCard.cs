namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCard : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExaminationCards", "Forecast", c => c.String(nullable: false));
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId],[Forecast]) values(N'Có dấu hiệu sốt nhẹ',1,9,N'Bệnh cảm mạo')");
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId],[Forecast]) values(N'Đau họng cấp tính',2,9,N'viêm họng')");
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId],[Forecast]) values(N'Bị mụn trứng cá',3,11,N'mụn trứng cá')");
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId],[Forecast]) values(N'Sâu răng cấp 4',1,10,N'Bị sâu răng')");
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId],[Forecast]) values(N'Sốt xuất huyết',2,9,N'Sốt xuất huyết')");
           
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExaminationCards", "Forecast");
        }
    }
}
