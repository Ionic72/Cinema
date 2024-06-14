using Cinema.Entidades;
using Cinema.Negocios;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 14/6/2024
 */

namespace Cinema.Interfaz.CONSULTAR
{
    public partial class frmPELICULAxSUCURSAL_C : Form
    {
        private PELICULAxSUCURSALLN PeliculaxSucursalLN = PELICULAxSUCURSALLN.Instancia;

        public frmPELICULAxSUCURSAL_C()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                foreach (PELICULAxSUCURSAL PeliculaxSucursal in PeliculaxSucursalLN.PeliculasxSucursal())
                {
                    string sucursal = $"{PeliculaxSucursal.Sucursal.SucursalID}, {PeliculaxSucursal.Sucursal.Nombre}, {PeliculaxSucursal.Sucursal.Encargado.EncargadoID}, {PeliculaxSucursal.Sucursal.Direccion}, {PeliculaxSucursal.Sucursal.Telefono}";
                    string pelicula = $"{PeliculaxSucursal.Pelicula.PeliculaID}, {PeliculaxSucursal.Pelicula.Titulo}, {PeliculaxSucursal.Pelicula.CategoriaPelicula.NombreCategoria}, {PeliculaxSucursal.Pelicula.Lanzamiento}, {PeliculaxSucursal.Pelicula.Idioma}";
                    PELICULAxSUCURSALDGV.Rows.Add(sucursal, pelicula, PeliculaxSucursal.Cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Situa el titulo dependiendo del tamaño de la pantalla
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Label_Titulo.Left = (Titulo.Width - Label_Titulo.Width) / 2;
        }
    }
}
