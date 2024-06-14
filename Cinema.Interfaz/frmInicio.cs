using Cinema.Interfaz.REGISTRAR;
using Cinema.Interfaz.CONSULTAR;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 14/6/2024
 */

namespace Cinema.Interfaz
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            this.Padding = new Padding(5);
            this.IsMdiContainer = true;
        }

        //Submenus
        private void RegistrarBTN_Click(object sender, EventArgs e)
        {
            Consultar_menu.Visible = false;
            ShowSubMenu(Registrar_menu);
        }

        private void ConsultarBTN_Click(object sender, EventArgs e)
        {
            Registrar_menu.Visible = false;
            ShowSubMenu(Consultar_menu);
        }

        private void ShowSubMenu(Panel submenu)
        {
            submenu.Visible = (submenu.Visible == true) ? false : true;
        }

        //Ventanas de Registro
        private void Registrar_Categoria_Click(object sender, EventArgs e)
        {
            ShowForm(new frmCATEGORIA_PELICULA());
        }

        private void Registrar_Pelicula_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPELICULA());
        }

        private void Registrar_Encargado_Click(object sender, EventArgs e)
        {
            ShowForm(new frmENCARGADO());
        }

        private void Registrar_Sucursal_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSUCURSAL());
        }

        private void Registrar_PeliculaxSucursal_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPELICULAxSUCURSAL());
        }

        private void Registrar_Cliente_Click(object sender, EventArgs e)
        {
            ShowForm(new frmCLIENTE());
        }

        //Ventanas de Consulta
        private void Consultar_Categoria_Click(object sender, EventArgs e)
        {
            ShowForm(new frmCATEGORIA_PELICULA_C());
        }

        private void Consultar_Pelicula_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPELICULA_C());
        }

        private void Consultar_Encargado_Click(object sender, EventArgs e)
        {
            ShowForm(new frmENCARGADO_C());
        }

        private void Consultar_Sucusal_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSUCURSAL_C());
        }

        private void Consultar_PeliculaxSucursal_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPELICULAxSUCURSAL_C());
        }

        private void Consultar_Cliente_Click(object sender, EventArgs e)
        {
            ShowForm(new frmCLIENTE_C());
        }

        //VENTANAS
        private void ShowForm(Form frmHijo)
        {
            foreach (Form form in Ventana.Controls){form.Close();}
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            Ventana.Controls.Add(frmHijo);
            frmHijo.Show();
        }
    }
}
