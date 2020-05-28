using System.Collections.Generic;
using API_Ejemplos.Domain.Services;
using API_Ejemplos.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Ejemplos.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaService _peliculaService;

        public PeliculaController(IPeliculaService peliculaService)
        {
            _peliculaService = peliculaService;
        }

        [HttpGet]
        public List<Pelicula> ListPeliculas()
        {
            var peliculas = _peliculaService.ListPeliculas();
            return peliculas;
        }
    }
}