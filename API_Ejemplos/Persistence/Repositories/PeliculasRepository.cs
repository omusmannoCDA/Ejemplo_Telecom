using API_Ejemplos.Domain.Repositories;
using API_Ejemplos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace API_Ejemplos.Data
{
    public class PeliculasRepository : IPeliculaRepository
    {
        //public PeliculasRepository(Database context) 
        //{

        //}

        public List<Pelicula> ListPeliculas()
        {
            return ObtenerPeliculas();
        }

        internal List<Pelicula> ObtenerPeliculas()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            Database database = new Database();
            SqlConnection conn = new SqlConnection(database.CadenaConexion());
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("prcGetPeliculas", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    peliculas.Add(new Pelicula(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), reader[4].ToString()));
                }

                int totalItems = peliculas.Count;

                return peliculas;
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        internal void BorrarPelicula()
        {

        }

        internal void ActualizarPelicula()
        {

        }

        internal void AgregarPelicula()
        {

        }
    }
}
