using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Presentation
{
    public partial class FormProcesoGestionCliente : Form
    {
        public FormProcesoGestionCliente()
        {
            InitializeComponent();
            Read();
        }


        private void Read()
        {
            using (var context = new DBEntities())
            {

                dataGridViewCliente.DataSource = context.CLIENTE.ToList();
                dataGridViewCliente.Columns[6].Visible = false;
                dataGridViewCliente.Columns[7].Visible = false;
                dataGridViewCliente.Columns[8].Visible = false;
            }

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            //using (var context= new DBEntities())
            //{

            //    dataGridViewCliente.DataSource= context.CLIENTE.ToList();
            //    dataGridViewCliente.Columns[6].Visible = false;
            //    dataGridViewCliente.Columns[7].Visible = false;
            //    dataGridViewCliente.Columns[8].Visible = false;
            //}
            Read();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var row = dataGridViewCliente.CurrentRow;
            if (row != null)
            {
                string nombre = textBoxNombre.Text; ;
                string estado = textBoxEstado.Text;
                string rtn = textBoxRTN.Text;
                string telefono = textBoxTelefono.Text;
                string dirección = textBoxDireccion.Text;

                using (var context = new DBEntities())
                {
                    context.spAddCliente(nombre, estado, rtn, telefono, dirección);
                }
            }
            Read();
        }

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewCliente.CurrentRow;
            if (row != null)
            {
                string nombre = row.Cells[1].Value.ToString();
                string estado = dataGridViewCliente.CurrentRow.Cells[2].Value.ToString();
                string rtn = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
                string telefono = dataGridViewCliente.CurrentRow.Cells[4].Value.ToString();
                string dirección = dataGridViewCliente.CurrentRow.Cells[5].Value.ToString();
                textBoxNombre.Text = nombre;
                textBoxDireccion.Text = dirección;
                textBoxEstado.Text = estado;   
                textBoxRTN.Text = rtn;
                textBoxTelefono.Text = telefono;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var row = dataGridViewCliente.CurrentRow;
            if (row != null)
            {
                int id = Int16.Parse(row.Cells[0].Value.ToString());
                string nombre = textBoxNombre.Text; ;
                string estado = textBoxEstado.Text;
                string rtn = textBoxRTN.Text;
                string telefono = textBoxTelefono.Text;
                string dirección = textBoxDireccion.Text;

                using (var context = new DBEntities())
                {
                    context.spUpdateCliente(id,nombre, estado, rtn, telefono, dirección);
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
                    context.spDeleteCliente(id);
                }
            }
            Read();
        }
    }
}
