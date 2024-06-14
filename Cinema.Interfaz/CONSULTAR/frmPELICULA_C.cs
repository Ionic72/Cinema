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
    public partial class frmPELICULA_C : Form
    {
        private PELICULALN PeliculaLN = PELICULALN.Instancia;

        public frmPELICULA_C()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                foreach (PELICULA Pelicula in PeliculaLN.Peliculas())
                {
                    string categoria = ($"{Pelicula.CategoriaPelicula.CategoriaID}, {Pelicula.CategoriaPelicula.NombreCategoria}, {Pelicula.CategoriaPelicula.Descripcion}");
                    PELICULADGV.Rows.Add(Pelicula.PeliculaID, Pelicula.Titulo, categoria, Pelicula.Lanzamiento, Pelicula.Idioma);
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
