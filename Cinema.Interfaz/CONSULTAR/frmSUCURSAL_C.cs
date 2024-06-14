using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Entidades;
using Cinema.Negocios;
using Microsoft.VisualBasic;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 16/6/2024
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
                    SUCURSALDGV.Rows.Add(Sucursal.SucursalID, Sucursal.Nombre, Sucursal.Encargado.Nombre, Sucursal.Direccion, Sucursal.Telefono, Sucursal.Activo);
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
