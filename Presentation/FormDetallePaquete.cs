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
    public partial class FormDetallePaquete : Form
    {
        public FormDetallePaquete()
        {
            InitializeComponent();
            Read();
        }

        private void Read()
        {
            using (var context = new DBEntities())
            {

                dataGridViewCliente.DataSource = context.DETALLE_PAQUETE.ToList();
                dataGridViewCliente.Columns[3].Visible = false;
                dataGridViewCliente.Columns[4].Visible = false;
           
            }

        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            Read();
        }
    }
}
