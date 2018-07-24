using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment1CPW213.Models
{
    public class Information
    {
        [Key] 
        public int SourceID { get; set; }

        [Required]
        [StringLength(40)]
        public string SiteName { get; set; }

        [Required]
        [StringLength(40)]
        public string URL { get; set; }
    }
}