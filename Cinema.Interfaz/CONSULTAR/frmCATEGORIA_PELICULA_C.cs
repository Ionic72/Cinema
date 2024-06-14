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
    public partial class frmCATEGORIA_PELICULA_C : Form
    {
        private CATEGORIA_PELICULALN CategoriaPeliculaLN = CATEGORIA_PELICULALN.Instancia;

        public frmCATEGORIA_PELICULA_C()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                foreach (CATEGORIA_PELICULA CategoriaPelicula in CategoriaPeliculaLN.Categorias())
                {
                    CATEGORIA_PELICULADGV.Rows.Add(CategoriaPelicula.CategoriaID, CategoriaPelicula.NombreCategoria, CategoriaPelicula.Descripcion);
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
