using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class Donem
    {
        [Key]
        public int DonemId { get; set; }
        public virtual ICollection<Ders> Dersler { get; set; }

    }
}