﻿using Cinema.Entidades;
using Newtonsoft.Json.Linq;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 14/6/2024
 */

namespace Cinema.Negocios
{
    public class PELICULALN
    {
        private const int CapacidadMaxima = 20;
        private CATEGORIA_PELICULALN categoria = CATEGORIA_PELICULALN.Instancia;
        private PELICULA[] Pelicula = new PELICULA[CapacidadMaxima]; //Array de las películas
        private static PELICULALN instancia;
       
        public static PELICULALN Instancia
        {
            get
            {
                if (instancia == null) { instancia = new PELICULALN(); }
                return instancia;
            }
        }

        public void AgregarPelicula(PELICULA newPelicula)
        {
            Verificar_Array(newPelicula);
            for(int i = 0; i < CapacidadMaxima; i++)
            {
                if (Pelicula[i] == null) { Pelicula[i] = newPelicula; return; }
            }
            throw new Exception("Capacidad máxima almacenada (20 Películas)"); //Si no hay más espacios vacíos, se ejecutará un error.
        }

        private void Verificar_Array(PELICULA newPelicula)
        {
            foreach (var pelicula in Pelicula)
            {
                if (pelicula == null) { return; }
                if (pelicula.PeliculaID == newPelicula.PeliculaID)
                {
                    throw new Exception("El ID de la película ya se encuentra almacenada");
                }
            }
        }

        public int ValidarAño(int year)
        {
            if (year < 1980 || year > 2024) {throw new Exception("El año no es válido, solo se permite entre (1980-2024)");}
            return year;
        }

        public string ValidarIdioma(string idioma)
        {
            string rutaArchivo = Path.Combine("../../..", "Idiomas.json");
            string IdiomasText = File.ReadAllText(rutaArchivo);
            var json = JObject.Parse(IdiomasText);

            if (json["Idiomas"][idioma] == null) {throw new Exception("El idioma ingresado no es válido o es incoherente.");}
            var acronym = json["Idiomas"][idioma];
            return acronym.ToString();
        }

        public CATEGORIA_PELICULA ObtenerCategoria(string NombreCategoría)
        {
            foreach (var categorias in categoria.Categorias())
            {
                if (categorias.NombreCategoria == NombreCategoría) { return categorias; }
            }
            throw new Exception("La categoría ingresada no esta agregada!");
        }

        public PELICULA[] Peliculas()
        {
            if (Pelicula.All(p => p == null)) { throw new Exception("No hay peliculas disponibles"); }
            return Pelicula.Where(p => p != null).ToArray();
        }
        
        public int CantidadDisponible()
        {
            return Pelicula.Count(p => p == null);
        }
    }
}
