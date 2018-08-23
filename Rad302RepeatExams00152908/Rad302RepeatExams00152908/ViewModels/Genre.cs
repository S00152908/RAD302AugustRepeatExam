using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rad302RepeatExams00152908.ViewModels
{
    public class Genre
    {
        [Key]
        public int ID { set; get; }     //this is the primary key for this SupplierProduct table

        [Required]
        public string Name { set; get; }      

    }
}