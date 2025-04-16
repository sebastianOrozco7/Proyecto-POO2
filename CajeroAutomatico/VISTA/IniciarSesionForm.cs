using CajeroAutomatico.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CajeroAutomatico.VISTA
{
    public partial class IniciarSesionForm : Form
    {
        public IniciarSesionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSesionDAL iniciarSesion = new IniciarSesionDAL();
            iniciarSesion.InicioSesion(txbUsuario, txbContraseña);
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txbUsuario.Clear();
            txbContraseña.Clear();
        }
    }
}
