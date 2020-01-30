using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebAppMvc.Dtos;

namespace WebAppMvc.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult NewRental(NewRentalDto newRental)
        {

            throw new NotImplementedException();
        }
    }
}
