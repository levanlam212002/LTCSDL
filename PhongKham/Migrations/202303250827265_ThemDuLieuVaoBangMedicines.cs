namespace hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDuLieuVaoBangMedicines : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicines", "Price", c => c.Single(nullable: false));
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'Megadual',N'Tuýt',653000,'2022/08/12','2027/05/19')");
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'Demarport',N'viên',800,'2022/08/12','2024/03/19')");
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'Paracetamol',N'chai',1200000,'2022/08/12','2026/12/19')");
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'Degital',N'viên',500,'2022/08/12','2028/09/19')");
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'Hewsou',N'chai',732000,'2022/08/12','2025/08/19')");
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'Dicerew',N'viên',400,'2022/08/12','2025/01/19')");
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'Magal',N'vỹ',20000,'2022/08/12','2026/02/27')");
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'C-hash',N'chai',458000,'2021/09/22','2024/02/19')");
            Sql("Insert Into Medicines([Name],[Unit],[Price],[AddedDate],[Expiry]) values(N'Klenzit',N'Tuýt',359000,'2022/04/15','2025/02/19')");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicines", "Price");
        }
    }
}
