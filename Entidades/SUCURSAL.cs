using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays.
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 16/6/2024
 */

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
