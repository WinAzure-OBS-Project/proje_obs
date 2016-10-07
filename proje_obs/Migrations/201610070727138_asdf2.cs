namespace proje_obs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdf2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DersKaydis", "AcilanDers_AcilanDersId", c => c.Int());
            AddColumn("dbo.DersKaydis", "Ogrenci_OgrenciId", c => c.Int());
            AddColumn("dbo.idaris", "Ad", c => c.String());
            AddColumn("dbo.idaris", "Gorev", c => c.String());
            AddColumn("dbo.idaris", "Sifre", c => c.String());
            AddColumn("dbo.idaris", "Bolum_BolumId", c => c.Int());
            AddColumn("dbo.Nots", "Vize", c => c.Single(nullable: false));
            AddColumn("dbo.Nots", "Final", c => c.Single(nullable: false));
            AddColumn("dbo.Nots", "Ortalama", c => c.Single(nullable: false));
            CreateIndex("dbo.DersKaydis", "AcilanDers_AcilanDersId");
            CreateIndex("dbo.DersKaydis", "Ogrenci_OgrenciId");
            CreateIndex("dbo.idaris", "Bolum_BolumId");
            AddForeignKey("dbo.DersKaydis", "AcilanDers_AcilanDersId", "dbo.AcilanDers", "AcilanDersId");
            AddForeignKey("dbo.DersKaydis", "Ogrenci_OgrenciId", "dbo.Ogrencis", "OgrenciId");
            AddForeignKey("dbo.idaris", "Bolum_BolumId", "dbo.Bolums", "BolumId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.idaris", "Bolum_BolumId", "dbo.Bolums");
            DropForeignKey("dbo.DersKaydis", "Ogrenci_OgrenciId", "dbo.Ogrencis");
            DropForeignKey("dbo.DersKaydis", "AcilanDers_AcilanDersId", "dbo.AcilanDers");
            DropIndex("dbo.idaris", new[] { "Bolum_BolumId" });
            DropIndex("dbo.DersKaydis", new[] { "Ogrenci_OgrenciId" });
            DropIndex("dbo.DersKaydis", new[] { "AcilanDers_AcilanDersId" });
            DropColumn("dbo.Nots", "Ortalama");
            DropColumn("dbo.Nots", "Final");
            DropColumn("dbo.Nots", "Vize");
            DropColumn("dbo.idaris", "Bolum_BolumId");
            DropColumn("dbo.idaris", "Sifre");
            DropColumn("dbo.idaris", "Gorev");
            DropColumn("dbo.idaris", "Ad");
            DropColumn("dbo.DersKaydis", "Ogrenci_OgrenciId");
            DropColumn("dbo.DersKaydis", "AcilanDers_AcilanDersId");
        }
    }
}
