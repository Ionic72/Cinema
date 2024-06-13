using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 16/6/2024
 */

namespace Cinema.Entidades
{
    public class ENCARGADO
    {
        public int EncargadoID { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string P_Apellido { get; set; }
        public string S_Apellido { get; set; }
        public DateTime F_Nacimiento { get; set; }
        public DateTime F_Ingreso { get; set; }
    }
}
