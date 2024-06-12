using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Entidades;
using Entidades;

namespace Cinema.Negocios
{
    public class ENCARGADOLN
    {
        private const int CapacidadMaxima = 20;
        private ENCARGADO[] Encargado = new ENCARGADO[CapacidadMaxima];
        private static ENCARGADOLN instancia;

        public static ENCARGADOLN Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ENCARGADOLN();
                }
                return instancia;
            }
        }

        public void AgregarEncargado(ENCARGADO newEncargado)
        {
            Verificar_Array(newEncargado);
            for(int i = 0; i < CapacidadMaxima; i++)
            {
                if (Encargado[i] == null)
                {
                    Encargado[i] = newEncargado;
                    return;
                }
            }
            throw new Exception("Capacidad máxima almacenada (20 Encargados)"); //Si no hay más espacios vacíos, se ejecutará un error.
        }

        private void Verificar_Array(ENCARGADO newEncargado)
        {
            foreach (var encargado in Encargado)
            {
                if (encargado == null) { return; }
                if (encargado.EncargadoID == newEncargado.EncargadoID || encargado.Identificacion == encargado.Identificacion)
                {
                    throw new Exception("El \"ID\" o la \"Cédula\" del encargadi ya se encuentra almacenada");
                }
            }
        }

        public ENCARGADO[] ObtenerEncargados()
        {
            if (Encargado.All(c => c == null))
            {
                throw new Exception("No hay encargados disponibles");
            }
            return Encargado.Where(c => c != null).ToArray();
        }

        //Este bloque contabiliza la cantidad de espacios de memoria del array que estan disponibles para su uso.
        public int CantidadDisponible()
        {
            int cant = 0;
            for (int i = 0; i < CapacidadMaxima; i++)
            {
                if (Encargado[i] == null)
                {
                    cant++;
                }
            }
            return cant;
        }
    }
}
