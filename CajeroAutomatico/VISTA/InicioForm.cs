using CajeroAutomatico.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            RegistrarForm registrarForm = new RegistrarForm();
            registrarForm.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            IngresoForm ingreso = new IngresoForm();
            ingreso.Show();
        }
    }
}
