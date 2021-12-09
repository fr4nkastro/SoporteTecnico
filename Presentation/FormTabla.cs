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
    public partial class FormTabla : Form
    {
        public  DataGridViewRow currentRow;
        public delegate void getRow(DataGridViewRow row, int tbl);
        public event getRow eventGetRow;
        int currentTbl;
        //public enum table
        //{
        //    cliente, contratos, detalleContratos, detalleFacturaServicios, detalleOrdenTrabajo, detallePaquete, disponibilidadTecnico, facturaServicio,
        //    ordenTrabajo, tecnicos
        //}
        public FormTabla(int tbl)
        {
            InitializeComponent();
            currentTbl = tbl;
        }

        private void dataGridViewTablaGenerica_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = dataGridViewTablaGenerica.CurrentRow;
            this.Visible = false;
            this.Enabled = false;
           
        }



       
         
        private void FormTabla_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void FormTabla_Leave(object sender, EventArgs e)
        {
 
        }

        private void FormTabla_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormTabla_Deactivate(object sender, EventArgs e)
        {
     
        }

        private void FormTabla_EnabledChanged(object sender, EventArgs e)
        {
            var eventRow = eventGetRow;
            if (eventRow != null)
            {
                eventGetRow(dataGridViewTablaGenerica.CurrentRow, currentTbl );

            }
        }
    }
}
