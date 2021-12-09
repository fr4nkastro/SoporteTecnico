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

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewCliente.CurrentRow;
            if (row != null)
            {
                string Factura = row.Cells[1].Value.ToString();
                string precio = dataGridViewCliente.CurrentRow.Cells[2].Value.ToString();
                string isv = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
                string cantidad = dataGridViewCliente.CurrentRow.Cells[4].Value.ToString();
                string total = dataGridViewCliente.CurrentRow.Cells[5].Value.ToString();
                //string servicio = dataGridViewCliente.CurrentRow.Cells[6].Value.ToString();
                textBoxFacturaID.Text = Factura;
                textBoxPrecio.Text = precio;
                textBoxCantidad.Text = cantidad;
                textBoxIsv.Text = isv;
                textBoxTotal.Text = total;
                //textBoxServicioID.Text = servicio;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
        //    var row = dataGridViewCliente.CurrentRow;
        //    if (row != null)
        //    {
        //        int Factura = Int16.Parse( textBoxFacturaID.Text) ;
        //        float precio = (float)Convert.ToDecimal( textBoxPrecio.Text);
        //        float isv = (float)Convert.ToDecimal(textBoxIsv.Text);
        //        int cantidad = Int16.Parse(textBoxCantidad.Text);
        //        float total = (float)Convert.ToDecimal(textBoxTotal.Text);

        //        using (var context = new DBEntities())
        //        {
        //            context.spAddDetalleFactura(Factura, precio, isv, cantidad, total);
        //        }
        //    }
            Read();
        }

        private void FormDetalleFacturaServicio_Load(object sender, EventArgs e)
        {
            using (var context = new DBEntities())
            {
                dataGridViewCliente.DataSource = context.DETALLE_FACTURA_SERVICIO.ToList();

            }
        }
    }
}
