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
    public partial class FormDetalleContrato : Form
    {
        public FormDetalleContrato()
        {
            InitializeComponent();
            Read();
        }

        private void Read()
        {
            using (var context = new DBEntities())
            {

                dataGridViewCliente.DataSource = context.DETALLE_CONTRATO.ToList();
                dataGridViewCliente.Columns[5].Visible = false;
                dataGridViewCliente.Columns[6].Visible = false;
                
            }

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            Read();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var row = dataGridViewCliente.CurrentRow;
            if (row != null)
            {
                int Contrato = Int16.Parse( textBoxContratoID.Text);
                int Servicio = Int16.Parse(textBoxServicioID.Text);
                int cantidad = Int16.Parse(textBoxCantidad.Text);
                int Realizado = Int16.Parse(textBoxRealizado.Text);
                

                using (var context = new DBEntities())
                {
                    context.spAddDetalleContrato(Contrato, Servicio, cantidad, Realizado);
                }
            }
            Read();
        }

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewCliente.CurrentRow;
            if (row != null)
            {
                string Contrato = row.Cells[0].Value.ToString();
                string Servicio = dataGridViewCliente.CurrentRow.Cells[1].Value.ToString();
                string cantidad = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
                string Realizado = dataGridViewCliente.CurrentRow.Cells[4].Value.ToString();

                textBoxContratoID.Text = Contrato;
                textBoxServicioID.Text = Servicio;
                textBoxCantidad.Text = cantidad;
                textBoxRealizado.Text = Realizado;
            }
        }
    }
}
