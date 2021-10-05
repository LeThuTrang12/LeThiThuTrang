namespace LeThiThuTrang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaLop);
            
            CreateTable(
                "dbo.Sinhvien",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 20, unicode: false),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sinhvien");
            DropTable("dbo.LopHoc");
        }
    }
}
