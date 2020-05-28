using API_Ejemplos.Domain.Models;
using System.Collections.Generic;

namespace API_Ejemplos.Domain.Services
{
    public interface IPeliculaService
    {
        List<Pelicula> ListPeliculas();
    }
}
