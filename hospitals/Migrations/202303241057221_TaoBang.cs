namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoBang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Single(nullable: false),
                        ExaminationCardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExaminationCards", t => t.ExaminationCardId, cascadeDelete: true)
                .Index(t => t.ExaminationCardId);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Unit = c.String(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        Expiry = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrescriptionDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        PrescriptionId = c.Int(nullable: false),
                        MedicineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicines", t => t.MedicineId, cascadeDelete: true)
                .ForeignKey("dbo.Prescriptions", t => t.PrescriptionId, cascadeDelete: true)
                .Index(t => t.PrescriptionId)
                .Index(t => t.MedicineId);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ExaminationCardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExaminationCards", t => t.ExaminationCardId, cascadeDelete: true)
                .Index(t => t.ExaminationCardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrescriptionDetails", "PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Prescriptions", "ExaminationCardId", "dbo.ExaminationCards");
            DropForeignKey("dbo.PrescriptionDetails", "MedicineId", "dbo.Medicines");
            DropForeignKey("dbo.Bills", "ExaminationCardId", "dbo.ExaminationCards");
            DropIndex("dbo.Prescriptions", new[] { "ExaminationCardId" });
            DropIndex("dbo.PrescriptionDetails", new[] { "MedicineId" });
            DropIndex("dbo.PrescriptionDetails", new[] { "PrescriptionId" });
            DropIndex("dbo.Bills", new[] { "ExaminationCardId" });
            DropTable("dbo.Prescriptions");
            DropTable("dbo.PrescriptionDetails");
            DropTable("dbo.Medicines");
            DropTable("dbo.Bills");
        }
    }
}
