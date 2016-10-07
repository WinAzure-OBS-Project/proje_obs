using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class OgretimElemani
    {
        [Key]
        public int OgretimElemaniId { get; set; }
        public String Ad { get; set; }
        public String Sifre { get; set; }
        public String Unvan { get; set; }
        public virtual ICollection<Ders> Dersler { get; set; }
        public virtual ICollection<Ogrenci> DanismaniOlduguOgrenciler { get; set; }
        

    }
}