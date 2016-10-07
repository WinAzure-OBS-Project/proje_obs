using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje_obs.Models
{
    public class EgitimPlani
    {
        [Key]
        public int EgitimPlaniId { get; set; }
    }
}