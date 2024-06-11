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
    public partial class frmCATEGORIA_PELICULA : Form
    {
        private CATEGORIA_PELICULALN CategoriaPeliculaLN = CATEGORIA_PELICULALN.Instancia;
        private CATEGORIA_PELICULA newCategoriaPelicula = new CATEGORIA_PELICULA();
        private int cant;
        public frmCATEGORIA_PELICULA()
        {
            InitializeComponent();
            CantidadDisponible();
        }

        private void CantidadDisponible()
        {
            cant = CategoriaPeliculaLN.CantidadDisponible();
            Cantidad.Text = $"Almacenamiento disponible: {cant}";
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Descripcion.Text)) { throw new Exception("Faltan datos por llenar"); }
                newCategoriaPelicula.CategoriaID = Convert.ToInt32(ID.Text);
                newCategoriaPelicula.NombreCategoria = Nombre.Text.ToUpper();
                newCategoriaPelicula.Descripcion = Descripcion.Text;
                CategoriaPeliculaLN.AgregarCategoria(newCategoriaPelicula);
                cant--; Cantidad.Text = $"Almacenamiento disponible: {cant}";
                Nombre.Clear(); ID.Clear(); Descripcion.Clear(); //Se limpian los textbox's
                MessageBox.Show("Exito al almacenar la Categoría!");
            } catch(Exception ex)
            {
                MessageBox.Show($"No fue posible almacenar la Categoría: {ex.Message}");
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

        //Bloquear el ingreso de carácteres 
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
