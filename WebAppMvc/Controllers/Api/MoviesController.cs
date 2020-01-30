using AutoMapper;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebAppMvc.Dtos;
using WebAppMvc.Models;

namespace WebApplication2.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private  ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/movies
        public IHttpActionResult GetMovies()
        {
            var moviesDtos = _context.Movies
               .Include(c => c.GenreType)
               .ToList()
               .Select(Mapper.Map<Movie, MovieDto>);


            return Ok(moviesDtos);


        }
        //GET /api/movies/1
        public IEnumerable<MovieDto> GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies
                .Include(m => m.GenreType).Include(m => m.GenreType)
                .Where(m => m.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query));
            return moviesQuery
                .ToList().ToList()
                .Select(Mapper.Map<Movie, MovieDto>);	       
        }
        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();


            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            //use 
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }
        // PUT /api/customers/1
        [HttpPut]
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();
        }
        //DELETE api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

        }
    }

}
