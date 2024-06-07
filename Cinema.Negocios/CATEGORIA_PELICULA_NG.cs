using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Cinema.Negocios
{
    public class CATEGORIA_PELICULA_NG
    {
        public void AgregarCategoria(string ID, string Nombre, string Descripcion)
        {
            CATEGORIA_PELICULA newCategoria = new CATEGORIA_PELICULA(ID, Nombre, Descripcion);

        }
    }
}
