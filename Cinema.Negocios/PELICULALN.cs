using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Cinema.Entidades;
using Newtonsoft.Json.Linq;

namespace Cinema.Negocios
{
    public class PELICULALN
    {
        private const int CapacidadMaxima = 20;
        private CATEGORIA_PELICULALN categoria = CATEGORIA_PELICULALN.Instancia;
        private CATEGORIA_PELICULA[] CategoriaPelicula = new CATEGORIA_PELICULA[CapacidadMaxima]; //Array de las Categorías
        private PELICULA[] Pelicula = new PELICULA[CapacidadMaxima]; //Array de las películas
        private static PELICULALN instancia;
       
        public static PELICULALN Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new PELICULALN();
                }
                return instancia;
            }
        }

        public void AgregarPelicula(PELICULA newPelicula)
        {
            Verificar_Array(newPelicula);
            for(int i = 0; i < CapacidadMaxima; i++)
            {
                if (Pelicula[i] == null)
                {
                    Pelicula[i] = newPelicula;
                    return;
                }
            }
            throw new Exception("Capacidad máxima almacenada (20 Películas)"); //Si no hay más espacios vacíos, se ejecutará un error.
        }

        private void Verificar_Array(PELICULA newPelicula)
        {
            foreach (var pelicula in Pelicula)
            {
                if(pelicula == null) { return; }
                if(pelicula.PeliculaID == newPelicula.PeliculaID)
                {
                    throw new Exception("El ID de la película ya se encuentra almacenada");
                }
            }
        }

        public int ValidarAño(int year)
        {
            if(year < 1980 || year > 2028)
            {
                throw new Exception("El año no es válido, solo se permite entre (1980-2028");
            }
            return year;
        }

        public string ValidarIdioma(string idioma)
        {
            string rutaArchivo = Path.Combine("../../..", "Idiomas.json");
            string IdiomasText = File.ReadAllText(rutaArchivo);
            var json = JObject.Parse(IdiomasText);

            if (json["Idiomas"][idioma] == null) { throw new Exception("El idioma ingresado no es válido o es incoherente."); }
            return (string)json["Idiomas"][idioma];
        }

        public CATEGORIA_PELICULA ObtenerCategoria(string NombreCategoría)
        {
            CategoriaPelicula = categoria.ObtenerCategorias();
            foreach(var categorias in CategoriaPelicula)
            {
                if (categorias.NombreCategoria == NombreCategoría)
                {
                    return categorias;
                }
            }
            throw new Exception("La categoría ingresada no esta agregada!");
        }

        public int CantidadDisponible()
        {
            int cant = 0;
            for (int i = 0; i < CapacidadMaxima; i++)
            {
                if (Pelicula[i] == null)
                {
                    cant++;
                }
            }
            return cant;
        }
    }
}
