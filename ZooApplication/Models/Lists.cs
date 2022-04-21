using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ZooApplication.Models
{
    public class Lists
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }

    }
}
