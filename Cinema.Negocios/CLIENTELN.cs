using Cinema.Entidades;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 14/6/2024
 */

namespace Cinema.Negocios
{
    public class CLIENTELN
    {
        private const int CapacidadMaxima = 20;
        private CLIENTE[] Cliente = new CLIENTE[CapacidadMaxima];
        private static CLIENTELN instancia;

        public static CLIENTELN Instancia{
            get
            { 
                if (instancia == null) { instancia = new CLIENTELN(); }
                return instancia;
            }
        }

        public void AgregarCliente(CLIENTE newCliente)
        {
            Verificar_Array(newCliente);
            for (int i = 0; i < CapacidadMaxima; i++)
            {
                if (Cliente[i] == null) { Cliente[i] = newCliente; return; }
            }
            throw new Exception("Capacidad máxima almacenada (20 Clientes)"); //Si no hay más espacios vacíos, se ejecutará un error.
        }

        private void Verificar_Array(CLIENTE newCliente)
        {
            for(int i=0; i<CapacidadMaxima; i++)
            {
                if(Cliente[i] == null) {return;}
                if(Cliente[i].ClienteID == newCliente.ClienteID || Cliente[i].Identificacion == newCliente.Identificacion)
                {
                    throw new Exception("El \"ID\" o la \"Cédula\" del cliente ya se encuentra almacenada");
                }
            }
        }

        public CLIENTE[] Clientes()
        {
            if (Cliente.All(c => c == null)) { throw new Exception("No hay clientes disponibles"); }
            return Cliente.Where(c => c != null).ToArray();
        }

        public int CantidadDisponible()
        {
            return Cliente.Count(c => c == null);
        }
    }
}
