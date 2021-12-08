using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormDetalleFacturaServicio : Form
    {
        public FormDetalleFacturaServicio()
        {
            InitializeComponent();
            Read();
        }

        private void Read()
        {
            using (var context = new DBEntities())
            {

                dataGridViewCliente.DataSource = context.DETALLE_FACTURA_SERVICIO.ToList();
                dataGridViewCliente.Columns[7].Visible = false;
                dataGridViewCliente.Columns[8].Visible = false;
   
            }

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            Read();
        }
    }
}
