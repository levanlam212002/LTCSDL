namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDLVaoBangExaminationCards : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId]) values(N'Có dấu hiệu sốt nhẹ',1,2)");
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId]) values(N'Đau họng cấp tính',2,2)");
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId]) values(N'Bị mụn trứng cá',3,4)");
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId]) values(N'Sâu răng cấp 4',1,3)");
            Sql("Insert Into ExaminationCards([Diagnostic],[PatientId],[DoctorId]) values(N'Sốt xuất huyết',2,2)");
        }
        
        public override void Down()
        {
        }
    }
}
