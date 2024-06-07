using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Cinema.Entidades
{
    public  class SUCURSAL
    {
        private int SucursalID { get; set; }
        private string Nombre { get; set; }
        private ENCARGADO Encargado { get; set; }
        private string Direccion { get; set; }
        private string Telefono { get; set; }
        private bool Activo { get; set; }
    }
}
