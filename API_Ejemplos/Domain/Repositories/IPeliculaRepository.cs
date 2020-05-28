using API_Ejemplos.Domain.Models;
using System.Collections.Generic;

namespace API_Ejemplos.Domain.Repositories
{
    public interface IPeliculaRepository
    {
        List<Pelicula> ListPeliculas();
    }
}
