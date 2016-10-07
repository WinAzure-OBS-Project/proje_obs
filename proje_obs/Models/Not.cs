using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class Not
    {
        [Key]
        public int NotId { get; set; }
        public float Vize { get; set; }
        public float Final { get; set; }
        public float Ortalama { get; set; }
    }
}