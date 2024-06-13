using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Entidades;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays.
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 16/6/2024
 */

namespace Cinema.Negocios
{
    public class PELICULAxSUCURSALLN
    {
        private const int CapacidadMaxima = 100;
        private PELICULALN Pelicula = PELICULALN.Instancia;
        private PELICULAxSUCURSAL[] PeliculaxSucursal = new PELICULAxSUCURSAL[CapacidadMaxima];
        private static PELICULAxSUCURSALLN instancia;

        public static PELICULAxSUCURSALLN Instancia
        {
            get
            {
                if(instancia == null) {instancia = new PELICULAxSUCURSALLN();}
                return instancia;
            }
        }





        public PELICULA[] ObtenerPeliculas()
        {
            return Pelicula.Peliculas();
        }

        public int CantidadDisponible()
        {
            return PeliculaxSucursal.Count(ps => ps == null);
        }
    }
}
