using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        private SUCURSALLN Sucursal = SUCURSALLN.Instancia;
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

        public void AgregarPeliculaxSucursal(PELICULAxSUCURSAL newPeliculaxSucursal)
        {
            bool error = false;
            Verificar_Array(newPeliculaxSucursal, ref error);
            if (error) {return;} //Se devuelve al frm por lo que se ignora el caso donde la sucursal y la pelicula ya estabam registrados y continua con los siguiente
            for (int i=0; i<CapacidadMaxima; i++)
            {
                if(PeliculaxSucursal[i] == null) {PeliculaxSucursal[i] = newPeliculaxSucursal; return;}
            }
            throw new Exception("Capacidad máxima almacenada (100 PeliculasxSucursal)"); //Si no hay más espacios vacíos, se ejecutará un error.
        }

        private void Verificar_Array(PELICULAxSUCURSAL newPeliculaxSucursal, ref bool error)
        {
            for (int i = 0; i < CapacidadMaxima; i++)
            {
                if(PeliculaxSucursal[i] == null) {return;}
                if(PeliculaxSucursal[i].Sucursal == newPeliculaxSucursal.Sucursal && PeliculaxSucursal[i].Pelicula == newPeliculaxSucursal.Pelicula)
                {
                    error = true;
                }
            }
        }
        
        public PELICULAxSUCURSAL[] PeliculasxSucursal()
        {
            if (PeliculaxSucursal.All(s => s == null)) { throw new Exception("No hay películas asociadas a alguna sucursal"); }
            return PeliculaxSucursal.Where(s => s != null).ToArray();
        }

        public SUCURSAL[] ObtenerSucursales()
        {
            SUCURSAL[] sucursales = Sucursal.Sucursales();
            if(sucursales.All(s => !s.Activo)) {throw new Exception("No se encontrarón Sucursales Activas");}
            return sucursales;
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
