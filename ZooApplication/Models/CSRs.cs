using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ZooApplication.Models
{
    public class CSRs
    {

        [Key]
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string Status { get; set; }


    }
}
