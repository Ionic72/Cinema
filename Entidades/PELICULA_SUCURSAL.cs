using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entidades
{
    public class PELICULA_SUCURSAL
    {
        private SUCURSAL Sucursal { get; set; }
        private PELICULA Pelicula { get; set; }
        private int Cantidad { get; set; }
    }
}
