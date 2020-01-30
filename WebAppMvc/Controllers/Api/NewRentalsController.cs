using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebAppMvc.Dtos;
using WebAppMvc.Models;

namespace WebAppMvc.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;//access database

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public IHttpActionResult NewRental(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id));

            foreach ( var movie in movies)
            {
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now

                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
         
        }
    }
}
