using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class idari
    {
        [Key]
        public int idariId { get; set; }
        public String Ad { get; set; }
        public String Gorev { get; set; }
        public String Sifre { get; set; }
        public virtual Bolum Bolum { get; set; }
    }
}