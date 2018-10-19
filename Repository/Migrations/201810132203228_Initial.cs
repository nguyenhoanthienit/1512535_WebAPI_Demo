namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatPhongs",
                c => new
                    {
                        MaDatPhong = c.Int(nullable: false, identity: true),
                        MaKH = c.Int(nullable: false),
                        MaPhong = c.Int(nullable: false),
                        NgayDat = c.DateTime(nullable: false),
                        NgayNhan = c.DateTime(nullable: false),
                        NgayTra = c.DateTime(nullable: false),
                        SoNguoiLon = c.Int(nullable: false),
                        SoTreEm = c.Int(nullable: false),
                        SoPhong = c.Int(nullable: false),
                        TongTien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaDatPhong);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        CMND = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        MaPhong = c.Int(nullable: false, identity: true),
                        DonGia = c.Int(nullable: false),
                        TenPhong = c.String(),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phongs");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DatPhongs");
        }
    }
}
