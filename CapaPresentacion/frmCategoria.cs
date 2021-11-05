﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarBuscarDatos(txtBuscar.Text);
            Componentes(false);
        }


        #region Metodos

        public void MostrarBuscarDatos(string buscar)
        {
            N_CATEGORIA categoria = new N_CATEGORIA();
            tablaCategoria.DataSource = categoria.MostrarCategoria(buscar);
            AccionTabla();

        }

        void AccionTabla()
        {
            tablaCategoria.Columns[0].Visible = false;
            tablaCategoria.ClearSelection();
            tablaCategoria.Columns[1].Width = 60;
            tablaCategoria.Columns[2].Width = 170;
        }

        public void InsertarDatos()
        {
            E_CATEGORIA EntidadCategoria = new E_CATEGORIA();
            N_CATEGORIA NegocioCategoria = new N_CATEGORIA();
            
           
                EntidadCategoria.Nombre = txtNombre.Text.ToUpper();
                EntidadCategoria.Descripcion = txtDescripcion.Text.ToUpper();

                NegocioCategoria.InsertarCategoria(EntidadCategoria);                 
                
        }

        public void ActualizarDatos()
        {
            E_CATEGORIA EntidadCategoria = new E_CATEGORIA();
            N_CATEGORIA NegocioCategoria = new N_CATEGORIA();

            EntidadCategoria.Idcategoria = Convert.ToInt32(txtCodigo.Text.Substring(2).Trim());
            EntidadCategoria.Nombre = txtNombre.Text.ToUpper();
            EntidadCategoria.Descripcion = txtDescripcion.Text.ToUpper();

            NegocioCategoria.EditarCategoria(EntidadCategoria);
        }

        public void Componentes(bool estado)
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = estado;
            txtDescripcion.Enabled = estado;
            btnGuardar.Enabled = estado;
        }

        public void LimpiarComponentes()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarDatos(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Componentes(true);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if(tablaCategoria.SelectedRows.Count > 0)
            {
                txtCodigo.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = tablaCategoria.CurrentRow.Cells[3].Value.ToString();

                Componentes(true);
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una categoria.");
            }
            


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MostrarBuscarDatos(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != string.Empty)
                {
                    if (txtCodigo.Text != string.Empty)
                        ActualizarDatos();
                    else
                        InsertarDatos();

                    LimpiarComponentes();
                    Componentes(false);
                    MostrarBuscarDatos(txtBuscar.Text);
                    frmAlerta alerta = new frmAlerta("Datos insertados satisfactoriamente!", frmAlerta.Alerta.Exitoso);
                    alerta.ShowDialog();
                }
                else
                {
                    frmAlerta alerta = new frmAlerta("Nombre debe ser insertado", frmAlerta.Alerta.Información);
                    alerta.ShowDialog();
                }
            }
            catch (Exception)
            {

                frmAlerta alerta = new frmAlerta("Error al tratar de insertar los datos", frmAlerta.Alerta.Error);
                alerta.ShowDialog();
            }            

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
