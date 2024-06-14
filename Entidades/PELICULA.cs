/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 14/6/2024
 */

namespace Cinema.Entidades
{
    public class PELICULA
    {
        public int PeliculaID { get; set; }
        public string Titulo { get; set; }
        public CATEGORIA_PELICULA CategoriaPelicula { get; set; }
        public int Lanzamiento { get; set; }
        public string Idioma { get; set; }
    }
}
