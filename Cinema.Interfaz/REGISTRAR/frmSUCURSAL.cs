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

namespace Cinema.Interfaz.REGISTRAR
{
    public partial class frmSUCURSAL : Form
    {
        private SUCURSALLN SucursalLN = SUCURSALLN.Instancia;

        public frmSUCURSAL()
        {
            InitializeComponent();
            CantidadDisponible();
            Activo.Items.Add("No");
            Activo.Items.Add("Si");
            Activo.SelectedIndex = 0;
        }

        private void CantidadDisponible()
        {
            int cant = SucursalLN.CantidadDisponible();
            Cantidad.Text = $"Almacenamiento disponible: {cant}";
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Encargado.Text) || string.IsNullOrEmpty(Direccion.Text) || string.IsNullOrEmpty(Telefono.Text)) { throw new Exception("Faltan datos por llenar"); }
                SUCURSAL newSucursal = new SUCURSAL {
                    SucursalID = Convert.ToInt32(ID.Text),
                    Nombre = Nombre.Text.ToUpper(),
                    Encargado = SucursalLN.ObtenerEncargado(Convert.ToInt32(Encargado.Text)),
                    Direccion = Direccion.Text.ToLower(),
                    Telefono = Telefono.Text,
                    Activo = Activo.SelectedIndex == 1 //Si el index no es un Si (Index 1), almacenara false
                };
                SucursalLN.AgregarSucursal(newSucursal);
                CantidadDisponible();
                ID.Clear(); Nombre.Clear(); Encargado.Clear(); Direccion.Clear(); Telefono.Clear(); //Se limpian los textbox's
                MessageBox.Show("Exito al almacenar la Sucursal!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No fue posible almacenar la Sucursal: {ex.Message}");
            }
        }

        //Bloquar el ingreso de carácteres alphanúmericos
        private void NUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Bloquear el ingreso de carácteres númericos
        private void Char_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Situa el titulo y el boton dependiendo del tamaño de la pantalla
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Label_Titulo.Left = (Titulo.Width - Label_Titulo.Width) / 2;
            Enviar.Left = (this.ClientSize.Width - Enviar.Width) / 2;
        }
    }
}
