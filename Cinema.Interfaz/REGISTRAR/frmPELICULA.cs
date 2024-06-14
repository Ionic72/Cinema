using Cinema.Entidades;
using Cinema.Negocios;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 14/6/2024
 */

namespace Cinema.Interfaz.REGISTRAR
{
    public partial class frmPELICULA : Form
    {
        private PELICULALN PeliculaLN = PELICULALN.Instancia;

        public frmPELICULA()
        {
            InitializeComponent();
            CantidadDisponible();
        }

        private void CantidadDisponible()
        {
            int cant = PeliculaLN.CantidadDisponible();
            Cantidad.Text = $"Almacenamiento disponible: {cant}";
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Title.Text) || string.IsNullOrEmpty(Category.Text) || string.IsNullOrEmpty(Year.Text) || string.IsNullOrEmpty(Language.Text)){throw new Exception("Faltan datos por llenar");}
                PELICULA newPelicula = new PELICULA
                {
                    PeliculaID = Convert.ToInt32(ID.Text),
                    Titulo = Title.Text.ToUpper(),
                    CategoriaPelicula = PeliculaLN.ObtenerCategoria(Category.Text.ToUpper()),
                    Lanzamiento = PeliculaLN.ValidarAño(Convert.ToInt32(Year.Text)),
                    Idioma = PeliculaLN.ValidarIdioma(Language.Text.ToLower())
                };
                PeliculaLN.AgregarPelicula(newPelicula);
                CantidadDisponible();
                ID.Clear(); Title.Clear(); Category.Clear(); Year.Clear(); Language.Clear(); //Se limpian los textbox's
                MessageBox.Show("Exito al almacenar la Película!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No fue posible almacenar la Película: {ex.Message}");
            }
        }

        //Bloquar el ingreso de carácteres alphanúmericos
        private void NUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        //Bloquear el ingreso de carácteres númericos
        private void Char_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }
        }

        //Situa el titulo y el boton dependiendo del tamaño de la pantalla
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Label_Titulo.Left = (Titulo.Width - Label_Titulo.Width) / 2;
            Enviar.Left = (this.ClientSize.Width - Enviar.Width) / 2;
        }
    }
}
