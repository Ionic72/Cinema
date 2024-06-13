﻿using System;
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
    public class SUCURSALLN
    {
        private const int CapacidadMaxima = 5;
        private ENCARGADOLN EncargadoLN = ENCARGADOLN.Instancia;
        private ENCARGADO[] Encargado = new ENCARGADO[20];
        private SUCURSAL[] Sucursal = new SUCURSAL[CapacidadMaxima];
        private static SUCURSALLN instancia;

        public static SUCURSALLN Instancia
        {
            get
            {
                if(instancia == null) {instancia = new SUCURSALLN();}
                return instancia;
            }
        }

        public void AgregarSucursal(SUCURSAL newSucursal)
        {
            Verificar_Array(newSucursal);
            for(int i=0; i<CapacidadMaxima; i++)
            {
                if(Sucursal[i] == null) {Sucursal[i] = newSucursal; return;}
            }
            throw new Exception("Capacidad máxima almacenada (5 Sucursales)");
        }

        private void Verificar_Array(SUCURSAL newSucursal)
        {
            for(int i = 0; i<CapacidadMaxima; i++)
            {
                if(Sucursal[i] == null) {return;}
                if(Sucursal[i].SucursalID == newSucursal.SucursalID) {throw new Exception("El ID de la Sucursal ya se encuentra almacenada");}
            }
        }

        public ENCARGADO ObtenerEncargado(int ID)
        {
            Encargado = EncargadoLN.Encargados();
            foreach(var encargados in Encargado)
            {
                if(encargados.EncargadoID == ID) {return encargados;}
            }
            throw new Exception("El empleado ingresado no esta agregado!");
        }

        public int CantidadDisponible()
        {
            return Sucursal.Count(s => s == null);
        }
    }
}
