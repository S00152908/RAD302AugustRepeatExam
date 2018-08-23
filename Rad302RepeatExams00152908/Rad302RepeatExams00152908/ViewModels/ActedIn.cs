using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rad302RepeatExams00152908.ViewModels
{
    public class ActedIn
    {
        [Key]
        public int ID { set; get; }

        [Required] 
        public Movie MovieID { set; get; }    

        [Required]
        public Actor ActorID { set; get; }
    }
}