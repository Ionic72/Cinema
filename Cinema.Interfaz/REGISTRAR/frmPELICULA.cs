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
    public partial class frmPELICULA : Form
    {
        private PELICULALN PeliculaLN = PELICULALN.Instancia;
        private PELICULA newPelicula = new PELICULA();
        private int cant;

        public frmPELICULA()
        {
            InitializeComponent();
            CantidadDisponible();
        }

        private void CantidadDisponible()
        {
            cant = PeliculaLN.CantidadDisponible();
            Cantidad.Text = $"Almacenamiento disponible: {cant}";
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Title.Text) || string.IsNullOrEmpty(Category.Text) || string.IsNullOrEmpty(Year.Text) || string.IsNullOrEmpty(Language.Text)){throw new Exception("Faltan datos por llenar");}
                newPelicula.PeliculaID = Convert.ToInt32(ID.Text);
                newPelicula.Titulo = Title.Text.ToUpper();
                newPelicula.CategoriaPelicula = PeliculaLN.ObtenerCategoria(Category.Text);
                newPelicula.Lanzamiento = PeliculaLN.ValidarAño(Convert.ToInt32(Year.Text));
                newPelicula.Idioma = PeliculaLN.ValidarIdioma(Language.Text);
                PeliculaLN.AgregarPelicula(newPelicula);
                cant--;  Cantidad.Text = $"Almacenamiento disponible: {cant}";
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
