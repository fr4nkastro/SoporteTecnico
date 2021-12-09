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
using DataAccess.DTO;
namespace Presentation
{
    public partial class FormProcesoOrdenTrabajo : Form
    {
        FormTabla frmTabla;
        public FormProcesoOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void FormProcesoOrdenTrabajo_Load(object sender, EventArgs e)
        {
            using (var context = new DBEntities ())
            {
                var result = 
                dataGridView2.DataSource = context.Database.SqlQuery<viewDisponibilidadTecnicos>(@"SELECT * FROM viewDisponibilidadTecnico").ToList();
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            frmTabla= new FormTabla();
            frmTabla.Show();

            
            
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = frmTabla.currentRow.Cells[0].ToString();
            frmTabla.Close();
            using (var context = new DBEntities())
            {
                var result =
                dataGridView2.DataSource = context.Database.SqlQuery<viewDisponibilidadTecnicos>(@"SELECT * FROM CLIENTES").ToList();
            }
        }
    }
}
