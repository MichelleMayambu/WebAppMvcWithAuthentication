using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppMvc.Models;


namespace WebAppMvc.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}