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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new DBEntities())
            {

            }

        }
    }
}
