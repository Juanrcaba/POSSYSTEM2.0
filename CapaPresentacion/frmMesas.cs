﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            PagePrincipal form = new PagePrincipal();
            form.Show();
            this.Hide();
        }
        void pantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            pantallaOK();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            frmCaja form = new frmCaja();
            form.Show();
            this.Hide();
        }

        private void btnmesa1_Click(object sender, EventArgs e)
        {
            frmComanda form = new frmComanda();
            form.Show();
            this.Hide();
        }
    }
}