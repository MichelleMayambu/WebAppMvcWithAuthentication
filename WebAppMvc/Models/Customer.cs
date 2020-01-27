using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppMvc.Models;

namespace WebAppMvc.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "please enter customer name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Min18YearsMember]
        public DateTime? BirthDate { get; set; }

        public string Gender { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        //Navigattion property associate customer class with MembershipType class 
        public MembershipType MembershipType { get; set; }

        //entity framework recoginzes this Id convention and treats property as foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }


    }
}