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
    public partial class frmCLIENTE_C : Form
    {
        private CLIENTELN ClienteLN = CLIENTELN.Instancia;

        public frmCLIENTE_C()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                foreach (CLIENTE Cliente in ClienteLN.Clientes())
                {
                    CLIENTEDGV.Rows.Add(Cliente.ClienteID, Cliente.Identificacion, Cliente.Nombre, Cliente.P_Apellido, Cliente.S_Apellido, Cliente.F_Nacimiento, Cliente.F_Registro, Cliente.Activo);
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
