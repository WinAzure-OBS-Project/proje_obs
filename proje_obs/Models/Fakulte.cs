using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class Fakulte
    {
        [Key]
        public int FakulteId { get; set; }
        public String FakulteAdi { get; set; }
        public virtual ICollection<Bolum> Bolumler { get; set; }
        public virtual ICollection<idari> idari { get; set; }
    }
}