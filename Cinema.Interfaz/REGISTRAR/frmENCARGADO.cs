﻿using System;
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
using Entidades;
using Microsoft.VisualBasic;

/*
 * UNED II Cuatrimestre
 * Proyecto 01: Proyecto que se encarga de registrar y mostrar información implementando Clases, Arrays. 
 * Estudiante: Andrew Jeshua Telles Calderón
 * Fecha 16/6/2024
 */

namespace Cinema.Interfaz.REGISTRAR
{
    public partial class frmENCARGADO : Form
    {
        private ENCARGADOLN EncargadoLN = ENCARGADOLN.Instancia;
        private ENCARGADO newEncargado = new ENCARGADO();
        private int cant;

        public frmENCARGADO()
        {
            InitializeComponent();
            CantidadDisponible();
        }

        private void CantidadDisponible()
        {
            cant = EncargadoLN.CantidadDisponible();
            Cantidad.Text = $"Almacenamiento disponible: {cant}";
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Cedula.Text) || string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(P_Apellido.Text) || string.IsNullOrEmpty(S_Apellido.Text) || string.IsNullOrEmpty(F_Nacimiento.Text) || string.IsNullOrEmpty(F_Ingreso.Text)){throw new Exception("Faltan datos por llenar");}
                newEncargado.EncargadoID = Convert.ToInt32(ID.Text);
                newEncargado.Identificacion = Cedula.Text;
                newEncargado.Nombre = Nombre.Text.ToUpper();
                newEncargado.P_Apellido = P_Apellido.Text.ToUpper();
                newEncargado.S_Apellido = S_Apellido.Text.ToUpper();
                newEncargado.F_Nacimiento = F_Nacimiento.Value;
                newEncargado.F_Ingreso = F_Ingreso.Value;
                EncargadoLN.AgregarEncargado(newEncargado);
                cant--;  Cantidad.Text = $"Almacenamiento disponible: {cant}";
                ID.Clear(); Cedula.Clear(); Nombre.Clear(); P_Apellido.Clear(); S_Apellido.Clear(); //Se limpian los textbox's
                MessageBox.Show("Exito al almacenar el Encargado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No fue posible almacenar el Encargado: {ex.Message}");
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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
