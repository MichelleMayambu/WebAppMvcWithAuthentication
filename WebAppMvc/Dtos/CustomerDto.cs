using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppMvc.Models;

namespace WebAppMvc.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please enter customer name")]
        [StringLength(255)]
        public string Name { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        /*IMPORTANT NOTE
         * temporarily commenting out the 'Min18YearsMember' attribute because we are casting the propertys to the model, 
         * meaning we have to end points; one from the Mvc actiions and one from the API, to solve this
          will mean that we have to  delete the Mvc actions and modifying our forms to match our Api functions
          which is beyond the scope of this mvc respository app for now so we will stick to keeping the app as is for now*/
        //[Min18YearsMember]
        public DateTime? BirthDate { get; set; }

        public string Gender { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        //removed reference objects and models to create DTo's for them

    }
}