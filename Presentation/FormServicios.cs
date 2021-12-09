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
    public partial class FormServicios : Form
    {
        public FormServicios()
        {
            InitializeComponent();
            Read();
        }

        private void Read()
        {
            using (var context = new DBEntities())
            {

                dataGridViewCliente.DataSource = context.SERVICIOS.ToList();
        
            }

        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            Read();
        }
    }
}
