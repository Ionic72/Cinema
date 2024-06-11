﻿using System;
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

namespace Entidades
{
    public class ENCARGADO
    {
        private int EncargadoID { get; set; }
        private string Identificacion { get; set; }
        private string Nombre { get; set; }
        private string P_Apellido { get; set; }
        private string S_Apellido { get; set; }
        private DateTime F_Nacimiento { get; set; }
        private DateTime F_Ingreso { get; set; }
    }
}
