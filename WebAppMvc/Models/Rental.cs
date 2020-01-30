using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMvc.Models
{
    public class Rental
    {   
      
        public byte Id { get; set; }


        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }  

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }
      


    }
}