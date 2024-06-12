using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Entidades;
using Entidades;

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
                if(instancia == null) { instancia = new SUCURSALLN(); }
                return instancia;
            }
        }

        public void AgregarSucursal(SUCURSAL newSucursal)
        {
            Verificar_Array(newSucursal);
            for(int i = 0; i < CapacidadMaxima; i++)
            {
                if (Sucursal[i] == null) { Sucursal[i] = newSucursal; return; }
            }
            throw new Exception("Capacidad máxima almacenada (5 Sucursales)");
        }

        private void Verificar_Array(SUCURSAL newSucursal)
        {
            foreach (var sucursal in Sucursal)
            {
                if (sucursal == null) { return; }
                if (sucursal.SucursalID == newSucursal.SucursalID)
                {
                    throw new Exception("El ID de la Sucursal ya se encuentra almacenada");
                }
            }
        }

        public ENCARGADO ObtenerEncargado(int ID)
        {
            Encargado = EncargadoLN.ObtenerEncargados();
            foreach(var encargados in Encargado)
            {
                if (encargados.EncargadoID == ID) {
                    return encargados;
                }
            }
            throw new Exception("El empleado ingresado no esta agregado!");
        }

        public int CantidadDisponible()
        {
            int cant = 0;
            for (int i = 0; i < CapacidadMaxima; i++)
            {
                if (Sucursal[i] == null)
                {
                    cant++;
                }
            }
            return cant;
        }
    }
}
