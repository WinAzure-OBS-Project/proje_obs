using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class Bolum
    {
        [Key]
        public int BolumId { get; set; }
        public String BolumAdi { get; set; }
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
        public virtual ICollection<OgretimElemani> OgretimElemanlari { get; set; }
        public virtual ICollection<EgitimPlani> EgitimPlanlari { get; set; }
    }
}