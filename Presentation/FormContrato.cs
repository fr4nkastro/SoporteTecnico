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
    public partial class FormFormContrato : Form
    {
        public FormFormContrato()
        {
            InitializeComponent();
            Read();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Read()
        {
            using (var context = new DBEntities())
            {

                dataGridViewCliente.DataSource = context.CONTRATOS.ToList();
                dataGridViewCliente.Columns[6].Visible = false;
                dataGridViewCliente.Columns[7].Visible = false;
                dataGridViewCliente.Columns[8].Visible = false;
                dataGridViewCliente.Columns[9].Visible = false;
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
                int clienteid = Int16.Parse( textBoxClienteID.Text);
                DateTime fechaInicio = Convert.ToDateTime( textBoxFechaInicio.Text);
                DateTime fechafinal = Convert.ToDateTime(textBoxFechaFinal.Text);
                int tecnicoid = Int16.Parse( textBoxTecnicoID.Text);
                int retasos = Int16.Parse (textBoxRetrasos.Text);

                using (var context = new DBEntities())
                {
                    context.spAddContrato(clienteid, fechaInicio, fechafinal, tecnicoid, retasos);
                }
            }
            Read();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var row = dataGridViewCliente.CurrentRow;
            if (row != null)
            {
                int id = Int16.Parse(row.Cells[0].Value.ToString());
                using (var context = new DBEntities())
                {
                    context.spDeleteContrato(id);
                }
            }
            Read();
        }

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewCliente.CurrentRow;
            if (row != null)
            {
                string clienteid = row.Cells[1].Value.ToString();
                string fechaInicio = dataGridViewCliente.CurrentRow.Cells[2].Value.ToString();
                string fechafinal = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
                string tecnicoid = dataGridViewCliente.CurrentRow.Cells[4].Value.ToString();
                string retasos = dataGridViewCliente.CurrentRow.Cells[5].Value.ToString();
                textBoxClienteID.Text = clienteid;
                textBoxFechaInicio.Text = fechaInicio;
                textBoxFechaFinal.Text = fechafinal;
                textBoxTecnicoID.Text = tecnicoid;
                textBoxRetrasos.Text = retasos;


                


            }
        }
    }
}
