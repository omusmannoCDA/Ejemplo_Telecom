
namespace API_Ejemplos.Domain.Models
{
    public class Pelicula
    {
        public Pelicula() { }

        public Pelicula(int _id, string _nombre, int _anio, string _director, string _clasificacion)
        {
            id = _id;
            nombre = _nombre;
            anio = _anio;
            director = _director;
            clasificacion = _clasificacion;
        }
        public int id { get; set; }
        public string nombre { get; set; }
        public int anio { get; set; }
        public string director { get; set; }
        public string clasificacion { get; set; }
    }
}
