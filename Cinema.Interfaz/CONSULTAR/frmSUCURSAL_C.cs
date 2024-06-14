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
    public partial class frmSUCURSAL_C : Form
    {
        private SUCURSALLN SucursalLN = SUCURSALLN.Instancia;

        public frmSUCURSAL_C()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                foreach (SUCURSAL Sucursal in SucursalLN.Sucursales())
                {
                    string encargado = $"{Sucursal.Encargado.EncargadoID}, {Sucursal.Encargado.Identificacion}, {Sucursal.Encargado.Nombre} {Sucursal.Encargado.P_Apellido} {Sucursal.Encargado.S_Apellido}, {Sucursal.Encargado.F_Nacimiento}, {Sucursal.Encargado.F_Ingreso}";
                    SUCURSALDGV.Rows.Add(Sucursal.SucursalID, Sucursal.Nombre, encargado, Sucursal.Direccion, Sucursal.Telefono, Sucursal.Activo);
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
