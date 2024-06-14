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
    public partial class frmENCARGADO : Form
    {
        private readonly ENCARGADOLN EncargadoLN = ENCARGADOLN.Instancia;

        public frmENCARGADO()
        {
            InitializeComponent();
            CantidadDisponible();
        }

        private void CantidadDisponible()
        {
            int cant = EncargadoLN.CantidadDisponible();
            Cantidad.Text = $"Almacenamiento disponible: {cant}";
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Cedula.Text) || string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(P_Apellido.Text) || string.IsNullOrEmpty(S_Apellido.Text) || string.IsNullOrEmpty(F_Nacimiento.Text) || string.IsNullOrEmpty(F_Ingreso.Text)) { throw new Exception("Faltan datos por llenar"); }
                ENCARGADO newEncargado = new ENCARGADO
                {
                    EncargadoID = Convert.ToInt32(ID.Text),
                    Identificacion = Cedula.Text,
                    Nombre = Nombre.Text.ToUpper(),
                    P_Apellido = P_Apellido.Text.ToUpper(),
                    S_Apellido = S_Apellido.Text.ToUpper(),
                    F_Nacimiento = F_Nacimiento.Value,
                    F_Ingreso = F_Ingreso.Value
                };
                EncargadoLN.AgregarEncargado(newEncargado);
                CantidadDisponible();
                ID.Clear(); Cedula.Clear(); Nombre.Clear(); P_Apellido.Clear(); S_Apellido.Clear(); //Se limpian los textbox's
                MessageBox.Show("Exito al almacenar el Encargado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No fue posible almacenar el Encargado: {ex.Message}");
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) { e.Handled = true; }
        }

        //Situa el titulo y el boton dependiendo del tamaño de la pantalla
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Label_Titulo.Left = (Titulo.Width - Label_Titulo.Width) / 2;
            Enviar.Left = (this.ClientSize.Width - Enviar.Width) / 2;
        }
    }
}
