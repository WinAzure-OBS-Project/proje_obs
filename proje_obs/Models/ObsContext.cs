using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proje_obs.Models
{
    public class ObsContext : DbContext
    {
        public ObsContext() : base("Default")
        {

        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<ObsContext>(null);
        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<AcilanDers> AcilanDersler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<DersKaydi> DersKayitlari { get; set; }
        public DbSet<Donem> Donemler { get; set; }
        public DbSet<EgitimPlani> EgitimPlanlari { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<idari> idariler { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgretimElemani> OgretimElemanlari { get; set; }

    }
}