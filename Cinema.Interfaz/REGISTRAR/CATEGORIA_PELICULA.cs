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

namespace Cinema.Interfaz.REGISTRAR
{
    public partial class CATEGORIA_PELICULA : Form
    {
        CATEGORIA_PELICULA_NG NegocioCategoria_Pelicula = new CATEGORIA_PELICULA_NG();
        private string identificacion, name, descripcion;
        private bool Confirmar;
        public CATEGORIA_PELICULA()
        {
            InitializeComponent();
        }

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Label_Titulo.Left = (Titulo.Width - Label_Titulo.Width) / 2;
            Enviar.Left = (this.ClientSize.Width - Enviar.Width) / 2;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            name = Nombre.Text;
            identificacion = ID.Text;
            descripcion = Descripcion.Text;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(identificacion) && !string.IsNullOrEmpty(descripcion))
            {
                Confirmar = NegocioCategoria_Pelicula.AgregarCategoria(identificacion, name, descripcion);
            }
        }

        //Bloquar el acceso de caracteres alphanúmericos
        private void NUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
