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
    public partial class FormOrdenTrabajo : Form
    {
        public FormOrdenTrabajo()
        {
            InitializeComponent();
            Read();
        }

        private void Read()
        {
            using (var context = new DBEntities())
            {

                dataGridViewCliente.DataSource = context.ORDEN_TRABAJO.ToList();
               
            }

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            Read();
        }
    }
}
