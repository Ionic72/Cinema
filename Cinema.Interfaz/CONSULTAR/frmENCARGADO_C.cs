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
    public partial class frmENCARGADO_C : Form
    {
        private ENCARGADOLN EncargadoLN = ENCARGADOLN.Instancia;

        public frmENCARGADO_C()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                foreach (ENCARGADO Encargado in EncargadoLN.Encargados())
                {
                    PELICULADGV.Rows.Add(Encargado.EncargadoID, Encargado.Identificacion, Encargado.Nombre, Encargado.P_Apellido, Encargado.S_Apellido, Encargado.F_Nacimiento, Encargado.F_Ingreso);
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
