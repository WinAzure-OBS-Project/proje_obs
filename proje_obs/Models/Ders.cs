using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class Ders
    {
        [Key]
        public int DersId { get; set; }
        public String DersAdi { get; set; }
        public virtual ICollection<AcilanDers> AcilanDersler { get; set; }
        public virtual Donem AitOlduguDonem { get; set; }
    }
}