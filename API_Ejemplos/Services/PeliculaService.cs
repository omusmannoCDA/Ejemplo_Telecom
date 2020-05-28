using API_Ejemplos.Domain.Repositories;
using API_Ejemplos.Domain.Services;
using API_Ejemplos.Domain.Models;
using System.Collections.Generic;

namespace API_Ejemplos.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculaRepository _peliculaRepository;

        public PeliculaService(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }

        public List<Pelicula> ListPeliculas()
        {
            return _peliculaRepository.ListPeliculas();
        }
    }
}
    