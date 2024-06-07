using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entidades
{
    public class PELICULA
    {
        private int PeliculaID { get; set; }
        private string Titulo { get; set; }
        private CATEGORIA_PELICULA CategoriaPelicula { get; set; }
        private int Lanzamiento { get; set; }
        private string Idioma { get; set; }
    }
}
