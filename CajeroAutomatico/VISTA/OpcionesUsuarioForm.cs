using CajeroAutomatico.CONTROLADOR;
using CajeroAutomatico.MODELO;
using Consignacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CajeroAutomatico.VISTA
{
    public partial class OpcionesUsuarioForm : Form
    {
        public OpcionesUsuarioForm()
        {
            InitializeComponent();
        }

        ConsultaDal consultaDal = new ConsultaDal();
        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            //IniciarSesionDAL iniciarSesionDAL = new IniciarSesionDAL();
            string saldo = consultaDal.ConsultarSaldo(110546039);
            LblSaldoDisponible.Text = saldo;
        }

       

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            RetirarForm retirarform = new RetirarForm();
            retirarform.Show();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            ConsignarForm consignarform = new ConsignarForm();
            consignarform.Show();
        }

        private void LblSaldoDisponible_Click(object sender, EventArgs e)
        {

        }
    }
}
