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
    public partial class FormCrudTablas : Form
    {
        public FormCrudTablas()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (var context = new DBEntities())
        //    {
        //        context.spAddCliente(textBoxNombre.Text, textBoxEstado.Text, textBoxRTN.Text, textBoxTelefono.Text, textBoxDireccion.Text);
        //    }

        //}

        //private void buttonRead_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    using(var context = new DBEntities())
        //    {
        //        context.spDeleteCliente(Int16.Parse(dataGridViewCliente.CurrentRow.Cells[0].Value.ToString()));
        //    }
        //}
    }
}
