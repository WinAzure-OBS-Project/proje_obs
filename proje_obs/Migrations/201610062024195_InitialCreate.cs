namespace proje_obs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcilanDers",
                c => new
                    {
                        AcilanDersId = c.Int(nullable: false, identity: true),
                        Ders_DersId = c.Int(),
                    })
                .PrimaryKey(t => t.AcilanDersId)
                .ForeignKey("dbo.Ders", t => t.Ders_DersId)
                .Index(t => t.Ders_DersId);
            
            CreateTable(
                "dbo.Bolums",
                c => new
                    {
                        BolumId = c.Int(nullable: false, identity: true),
                        BolumAdi = c.String(),
                        Fakulte_FakulteId = c.Int(),
                    })
                .PrimaryKey(t => t.BolumId)
                .ForeignKey("dbo.Fakultes", t => t.Fakulte_FakulteId)
                .Index(t => t.Fakulte_FakulteId);
            
            CreateTable(
                "dbo.EgitimPlanis",
                c => new
                    {
                        EgitimPlaniId = c.Int(nullable: false, identity: true),
                        Bolum_BolumId = c.Int(),
                    })
                .PrimaryKey(t => t.EgitimPlaniId)
                .ForeignKey("dbo.Bolums", t => t.Bolum_BolumId)
                .Index(t => t.Bolum_BolumId);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        OgrenciId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        bolum_BolumId = c.Int(),
                        OgretimElemani_OgretimElemaniId = c.Int(),
                    })
                .PrimaryKey(t => t.OgrenciId)
                .ForeignKey("dbo.Bolums", t => t.bolum_BolumId)
                .ForeignKey("dbo.OgretimElemanis", t => t.OgretimElemani_OgretimElemaniId)
                .Index(t => t.bolum_BolumId)
                .Index(t => t.OgretimElemani_OgretimElemaniId);
            
            CreateTable(
                "dbo.OgretimElemanis",
                c => new
                    {
                        OgretimElemaniId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Unvan = c.String(),
                        Bolum_BolumId = c.Int(),
                    })
                .PrimaryKey(t => t.OgretimElemaniId)
                .ForeignKey("dbo.Bolums", t => t.Bolum_BolumId)
                .Index(t => t.Bolum_BolumId);
            
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        DersId = c.Int(nullable: false, identity: true),
                        DersAdi = c.String(),
                        AitOlduguDonem_DonemId = c.Int(),
                        OgretimElemani_OgretimElemaniId = c.Int(),
                    })
                .PrimaryKey(t => t.DersId)
                .ForeignKey("dbo.Donems", t => t.AitOlduguDonem_DonemId)
                .ForeignKey("dbo.OgretimElemanis", t => t.OgretimElemani_OgretimElemaniId)
                .Index(t => t.AitOlduguDonem_DonemId)
                .Index(t => t.OgretimElemani_OgretimElemaniId);
            
            CreateTable(
                "dbo.Donems",
                c => new
                    {
                        DonemId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DonemId);
            
            CreateTable(
                "dbo.DersKaydis",
                c => new
                    {
                        DersKaydiId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DersKaydiId);
            
            CreateTable(
                "dbo.Fakultes",
                c => new
                    {
                        FakulteId = c.Int(nullable: false, identity: true),
                        FakulteAdi = c.String(),
                    })
                .PrimaryKey(t => t.FakulteId);
            
            CreateTable(
                "dbo.idaris",
                c => new
                    {
                        idariId = c.Int(nullable: false, identity: true),
                        Fakulte_FakulteId = c.Int(),
                    })
                .PrimaryKey(t => t.idariId)
                .ForeignKey("dbo.Fakultes", t => t.Fakulte_FakulteId)
                .Index(t => t.Fakulte_FakulteId);
            
            CreateTable(
                "dbo.Nots",
                c => new
                    {
                        NotId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.NotId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.idaris", "Fakulte_FakulteId", "dbo.Fakultes");
            DropForeignKey("dbo.Bolums", "Fakulte_FakulteId", "dbo.Fakultes");
            DropForeignKey("dbo.OgretimElemanis", "Bolum_BolumId", "dbo.Bolums");
            DropForeignKey("dbo.Ders", "OgretimElemani_OgretimElemaniId", "dbo.OgretimElemanis");
            DropForeignKey("dbo.Ders", "AitOlduguDonem_DonemId", "dbo.Donems");
            DropForeignKey("dbo.AcilanDers", "Ders_DersId", "dbo.Ders");
            DropForeignKey("dbo.Ogrencis", "OgretimElemani_OgretimElemaniId", "dbo.OgretimElemanis");
            DropForeignKey("dbo.Ogrencis", "bolum_BolumId", "dbo.Bolums");
            DropForeignKey("dbo.EgitimPlanis", "Bolum_BolumId", "dbo.Bolums");
            DropIndex("dbo.idaris", new[] { "Fakulte_FakulteId" });
            DropIndex("dbo.Ders", new[] { "OgretimElemani_OgretimElemaniId" });
            DropIndex("dbo.Ders", new[] { "AitOlduguDonem_DonemId" });
            DropIndex("dbo.OgretimElemanis", new[] { "Bolum_BolumId" });
            DropIndex("dbo.Ogrencis", new[] { "OgretimElemani_OgretimElemaniId" });
            DropIndex("dbo.Ogrencis", new[] { "bolum_BolumId" });
            DropIndex("dbo.EgitimPlanis", new[] { "Bolum_BolumId" });
            DropIndex("dbo.Bolums", new[] { "Fakulte_FakulteId" });
            DropIndex("dbo.AcilanDers", new[] { "Ders_DersId" });
            DropTable("dbo.Nots");
            DropTable("dbo.idaris");
            DropTable("dbo.Fakultes");
            DropTable("dbo.DersKaydis");
            DropTable("dbo.Donems");
            DropTable("dbo.Ders");
            DropTable("dbo.OgretimElemanis");
            DropTable("dbo.Ogrencis");
            DropTable("dbo.EgitimPlanis");
            DropTable("dbo.Bolums");
            DropTable("dbo.AcilanDers");
        }
    }
}
