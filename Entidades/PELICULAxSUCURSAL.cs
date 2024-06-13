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

namespace Cinema.Entidades
{
    public class PELICULAxSUCURSAL
    {
        public SUCURSAL Sucursal { get; set; }
        public PELICULA Pelicula { get; set; }
        public int Cantidad { get; set; }
    }
}