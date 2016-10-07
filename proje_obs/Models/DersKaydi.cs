using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class DersKaydi
    {
        [Key]
        public int DersKaydiId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public AcilanDers AcilanDers { get; set; }
    }
}