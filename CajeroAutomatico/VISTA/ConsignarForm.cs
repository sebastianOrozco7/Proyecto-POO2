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
    public partial class ConsignarForm : Form
    {
        public ConsignarForm()
        {
            InitializeComponent();
        }
        ConsignarDAL consignarDAL = new ConsignarDAL();
        private void btnConsignar_Click(object sender, EventArgs e)
        {
            consignarDAL.Consignar(txbValorConsignacion);
        }
    }
}
