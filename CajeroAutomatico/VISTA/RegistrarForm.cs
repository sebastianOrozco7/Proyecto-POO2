using CajeroAutomatico.CONTROLADOR;
using CajeroAutomatico.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.VISTA
{
    public partial class RegistrarForm : Form
    {
        public RegistrarForm()
        {
            InitializeComponent();
        }
        RegistroDal usuario = new RegistroDal();
       
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txbTipoCuenta.Clear();
            txbContraseña.Clear();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            usuario.RegistrarNuevoUsuario(txtNombre, txtApellido, txtCorreo, txtTelefono, txtNumeroDocumento, txbContraseña, txbTipoCuenta, cmbTipoDocumento);
            LimpiarCampos();
        }
    }
}
