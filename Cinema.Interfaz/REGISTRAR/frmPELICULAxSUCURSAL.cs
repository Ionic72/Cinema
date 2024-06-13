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
    public partial class frmPELICULAxSUCURSAL : Form
    {
        private PELICULAxSUCURSALLN PeliculaxSucursalLN = PELICULAxSUCURSALLN.Instancia;

        public frmPELICULAxSUCURSAL()
        {
            InitializeComponent();
            CantidadDisponible();
            LoadDataGridView();
        }

        private void CantidadDisponible()
        {
            int cant = PeliculaxSucursalLN.CantidadDisponible();
            Cantidad.Text = $"Almacenamiento disponible: {cant}";
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(Hotel.Text)){throw new Exception("Faltan datos por llenar");}
                PELICULAxSUCURSAL newPeliculaxSucursal = new PELICULAxSUCURSAL
                {
                     = Convert.ToInt32(ID.Text),
                    Titulo = Title.Text.ToUpper(),
                    CategoriaPelicula = PeliculaLN.ObtenerCategoria(Category.Text),
                    Lanzamiento = PeliculaLN.ValidarAño(Convert.ToInt32(Year.Text)),
                    Idioma = PeliculaLN.ValidarIdioma(Language.Text)
                };
                newPeliculaxSucursal.AgregarPelicula(newPelicula);
                CantidadDisponible();
                Cifras.Clear(); //Se limpian los textbox's
                MessageBox.Show("Exito al almacenar la Película en la Sucursal!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No fue posible almacenar la Película en la Sucursal: {ex.Message}");
            }
        }

        private void LoadDataGridView()
        {
            PELICULA[] peliculas = PeliculaxSucursalLN.ObtenerPeliculas();
            foreach (var pelicula in peliculas)
            {
                PELICULADGV.Rows.Add(pelicula.PeliculaID, pelicula.Titulo, pelicula.CategoriaPelicula, pelicula.Lanzamiento, pelicula.Idioma);
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

        //Bloquea el acceso de cualquier tecla
        private void BLOCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Situa el titulo y el boton dependiendo del tamaño de la pantalla
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Label_Titulo.Left = (Titulo.Width - Label_Titulo.Width) / 2;
            Enviar.Left = (this.ClientSize.Width - Enviar.Width) / 2;
        }
    }
}
