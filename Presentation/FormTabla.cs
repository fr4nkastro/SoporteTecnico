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
        public DataGridViewRow currentRow;
        public FormTabla()
        {
            InitializeComponent();
        }

        private void dataGridViewTablaGenerica_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = dataGridViewTablaGenerica.CurrentRow;
           
        }
    }
}
