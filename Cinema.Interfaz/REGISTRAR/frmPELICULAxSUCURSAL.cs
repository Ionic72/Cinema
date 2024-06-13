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
        private PELICULA[] peliculas = new PELICULA[20];
        private SUCURSAL[] sucursales = new SUCURSAL[5];
        private PELICULA[] selectedmovies = new PELICULA[20];

        public frmPELICULAxSUCURSAL()
        {
            InitializeComponent();
            CantidadDisponible();
            LoadComboBox();
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
                if (SucursalCBox.SelectedIndex == -1 || string.IsNullOrEmpty(Cifras.Text) || selectedmovies.All(p => p == null)) {throw new Exception("Faltan datos por llenar");}
                foreach (PELICULA pelicula in selectedmovies)
                {
                    if (pelicula == null) { break; }
                    PELICULAxSUCURSAL newPeliculaxSucursal = new PELICULAxSUCURSAL
                    {
                        Sucursal = (SUCURSAL) SucursalCBox.SelectedItem,
                        Pelicula = pelicula,
                        Cantidad = Convert.ToInt32(Cifras.Text)
                    };
                    PeliculaxSucursalLN.AgregarPeliculaxSucursal(newPeliculaxSucursal);
                }
                CantidadDisponible();
                Recarga(); //Se limpia todo
                MessageBox.Show("Exito al almacenar la(s) Película(s) en la Sucursal!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No fue posible almacenar la Película en la Sucursal: {ex.Message}");
            }
        }

        private void LoadComboBox()
        {
            try
            {
                sucursales = PeliculaxSucursalLN.ObtenerSucursales();
                SucursalCBox.DisplayMember = "Nombre";
                SucursalCBox.ValueMember = "SucursalID";

                foreach (SUCURSAL sucursal in sucursales)
                {
                    if (sucursal.Activo)
                    {
                        SucursalCBox.Items.Add(sucursal);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadDataGridView()
        {
            try
            {
                peliculas = PeliculaxSucursalLN.ObtenerPeliculas();
                foreach (var pelicula in peliculas)
                {
                    PELICULADGV.Rows.Add(pelicula.PeliculaID, pelicula.Titulo, pelicula.CategoriaPelicula.NombreCategoria, pelicula.Lanzamiento, pelicula.Idioma);
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PELICULADGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < PELICULADGV.Rows.Count)
            {
                int IDPeliculaSeleccionada = Convert.ToInt32(PELICULADGV.Rows[e.RowIndex].Cells["ID"].Value);

                if (selectedmovies.Any(p => p != null && p.PeliculaID == IDPeliculaSeleccionada)) {return;}
                
                PELICULA data = peliculas.FirstOrDefault(p => p.PeliculaID == IDPeliculaSeleccionada);

                for(int i=0; i<20; i++)
                {
                    if (selectedmovies[i] == null) {selectedmovies[i] = data; PELICULADGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGoldenrod; return;}
                }
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

        private void Recarga()
        {
            SucursalCBox.SelectedIndex = 0;
            selectedmovies = new PELICULA[20]; //Creo un nuevo array vacío
            Cifras.Text = null;
            foreach(DataGridViewRow row in PELICULADGV.Rows) { row.DefaultCellStyle.BackColor = Color.FromArgb(27, 30, 35); }
        }

        //Situa el titulo y el boton dependiendo del tamaño de la pantalla
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Label_Titulo.Left = (Titulo.Width - Label_Titulo.Width) / 2;
            Enviar.Left = (this.ClientSize.Width - Enviar.Width) / 2;
        }
    }
}
