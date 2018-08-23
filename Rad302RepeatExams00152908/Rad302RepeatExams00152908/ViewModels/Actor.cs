using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rad302RepeatExams00152908.ViewModels
{
    public class Actor
    {
        [Key]
        public int ID { set; get; }     
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Second Name")]
        public string SecondName { get; set; }
    }
}