using Cinema.Entidades;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 14/6/2024
 */

namespace Cinema.Negocios
{
    public class SUCURSALLN
    {
        private const int CapacidadMaxima = 5;
        private ENCARGADOLN EncargadoLN = ENCARGADOLN.Instancia;
        private SUCURSAL[] Sucursal = new SUCURSAL[CapacidadMaxima];
        private static SUCURSALLN instancia;

        public static SUCURSALLN Instancia
        {
            get
            {
                if (instancia == null) { instancia = new SUCURSALLN(); }
                return instancia;
            }
        }

        public void AgregarSucursal(SUCURSAL newSucursal)
        {
            Verificar_Array(newSucursal);
            for (int i=0; i<CapacidadMaxima; i++)
            {
                if (Sucursal[i] == null) { Sucursal[i] = newSucursal; return; }
            }
            throw new Exception("Capacidad máxima almacenada (5 Sucursales)");
        }

        private void Verificar_Array(SUCURSAL newSucursal)
        {
            for (int i = 0; i < CapacidadMaxima; i++)
            {
                if (Sucursal[i] == null) { return; }
                if (Sucursal[i].SucursalID == newSucursal.SucursalID || Sucursal[i].Encargado.Identificacion == newSucursal.Encargado.Identificacion || Sucursal[i].Telefono == newSucursal.Telefono) {throw new Exception("El \"ID\", el \"Encargado\" o el \"Teléfono\" de la Sucursal ya se encuentran registrados.");}
            }
        }

        public SUCURSAL[] Sucursales()
        {
            if (Sucursal.All(s => s == null)) { throw new Exception("No hay sucursales disponibles"); }
            return Sucursal.Where(s => s != null).ToArray();
        }

        public ENCARGADO ObtenerEncargado(int ID)
        {
            foreach(var encargados in EncargadoLN.Encargados())
            {
                if (encargados.EncargadoID == ID) { return encargados; }
            }
            throw new Exception("El empleado ingresado no esta agregado!");
        }

        public int CantidadDisponible()
        {
            return Sucursal.Count(s => s == null);
        }
    }
}
