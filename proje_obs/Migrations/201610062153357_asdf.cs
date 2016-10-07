namespace proje_obs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ogrencis", "Sifre", c => c.String());
            AddColumn("dbo.OgretimElemanis", "Sifre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OgretimElemanis", "Sifre");
            DropColumn("dbo.Ogrencis", "Sifre");
        }
    }
}
