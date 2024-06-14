using Cinema.Entidades;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays.
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 14/6/2024
 */

namespace Cinema.Negocios
{
    public class CATEGORIA_PELICULALN
    {
        private const int CapacidadMaxima = 20;
        private CATEGORIA_PELICULA[] CategoriaPelicula = new CATEGORIA_PELICULA[CapacidadMaxima];
        private static CATEGORIA_PELICULALN instancia;

        public static CATEGORIA_PELICULALN Instancia
        {
            get
            {
                if (instancia == null) { instancia = new CATEGORIA_PELICULALN(); }
                return instancia;
            }
        }

        public void AgregarCategoria(CATEGORIA_PELICULA newCategoriaPelicula)
        {
            Verificar_Array(newCategoriaPelicula);
            for (int i = 0; i < CapacidadMaxima; i++)
            {
                if (CategoriaPelicula[i] == null) { CategoriaPelicula[i] = newCategoriaPelicula; return; }
            }
            throw new Exception("Capacidad máxima almacenada (20 Categorías)"); //Si no hay más espacios vacíos, se ejecutará un error.
        }

        //Este bloque de codigo verifica que no se ingrese otra vez la misma categoria dentro del array
        private void Verificar_Array(CATEGORIA_PELICULA newCategoriaPelicula)
        {
            for(int i = 0; i < CapacidadMaxima; i++)
            {
                if (CategoriaPelicula[i] == null) { return; }
                if (CategoriaPelicula[i].CategoriaID == newCategoriaPelicula.CategoriaID || CategoriaPelicula[i].NombreCategoria == newCategoriaPelicula.NombreCategoria)
                {
                    throw new Exception("El \"ID\" o el \"Nombre\" de la categoría ya se encontraba almacenada");
                }
            }
        }

        public CATEGORIA_PELICULA[] Categorias()
        {
            if (CategoriaPelicula.All(c => c == null)) {throw new Exception("No hay categorías disponibles.");}
            return CategoriaPelicula.Where(c => c != null).ToArray();
        }

        //Este bloque contabiliza la cantidad de espacios de memoria del array que estan disponibles para su uso.
        public int CantidadDisponible()
        {
            return CategoriaPelicula.Count(ct => ct == null);
        }
    }
}
