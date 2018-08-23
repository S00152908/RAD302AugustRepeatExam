using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rad302RepeatExams00152908.ViewModels
{
    public class Movie
    {
        [Key]
        public int ID { set; get; }     //this is the primary key for this SupplierProduct table
        [Required]
        [DisplayName("Release Date")]
        public int ReleaseDate { set; get; }     

        [Required]
        public Genre GenreID { set; get; }    

       
    }
}