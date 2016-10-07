using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public String Ad { get; set; }
        public String Sifre { get; set; }
        public virtual Bolum bolum { get; set; }
    }
}