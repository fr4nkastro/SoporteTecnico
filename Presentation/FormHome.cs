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
    public partial class FormHome : Form
    {
        //Objeto menu y formulario padre
        
        private bool clickMemReport;

        public Form FormActual { get; set; }
        public Form FormActualMenu { get; set; }
        private int flagCurrentTable;
        private enum table
        {
            cliente, contratos, detalleContratos, detalleFacturaServicios, detalleOrdenTrabajo, detallePaquete, disponibilidadTecnico, facturaServicio,
            ordenTrabajo, tecnicos
        }
        public FormHome()
        {
            InitializeComponent();
            clickMemReport = false;
            flagCurrentTable = 0;
        }


        private void buttonReportes_Click(object sender, EventArgs e)
        {
            
            //if (clickMemReport)
            //{
            //    panelCategoriaReportes.Enabled = false;
            //    panelCategoriaReportes.Visible = false;
            //    clickMemReport = false;
            //}
            //else
            //{
            //    panelCategoriaReportes.Enabled = true;
            //    panelCategoriaReportes.Visible = true;
            //    clickMemReport = true;
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OpenForm(new FrmConfiguracionUsuarios(FormActualMenu));
            //OpenFormMenu(new FrmMenuConfiguracionUsuarios(FormActual));

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //var frmCrudTablas = new FormCrudTablas();
            //OpenForm(frmCrudTablas);
        }

        private void panelMainFrm_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            //if (clickMemReport)
            //{
            //    panel1.Enabled = false;
            //    panel1.Visible = false;
            //    clickMemReport = false;
            //}
            //else
            //{
            //    panel1.Enabled = true;
            //    panel1.Visible = true;
            //    clickMemReport = true;
            //}
        }

        private void OpenForm(Form formParent)
        {
            if (FormActual != null)
            {
                //Mantener un solo form
                FormActual.Close();
            }
            FormActual = formParent;
            formParent.TopLevel = false;
            formParent.FormBorderStyle = FormBorderStyle.None;
            formParent.Dock = DockStyle.Fill;
            panelMainFrm.Controls.Add(formParent);
            panelMainFrm.Tag = formParent;
            formParent.BringToFront();
            formParent.Show();
            
        }

            private void OpenFormMenu(Form FormHijo1)
        {
            if (FormActualMenu != null)
            {
                //Mantener un solo form
                FormActualMenu.Close();
            }
            FormActualMenu = FormHijo1;
            FormHijo1.TopLevel = false;
            FormHijo1.FormBorderStyle = FormBorderStyle.None;
            FormHijo1.Dock = DockStyle.Fill;
            //panelToolBar.Controls.Add(FormHijo1);
            //panelToolBar.Tag = FormHijo1;
            FormHijo1.BringToFront();
            FormHijo1.Show();
          

        }
        private void buttonInventario_Click(object sender, EventArgs e)
        {
            //FrmInventario formInventario = new FrmInventario(this);
            //FrmMenuInventario formMenuInventario = new FrmMenuInventario(formInventario);
            //formInventario.frmMenu = formMenuInventario;

            //OpenForm(formInventario);
            //OpenFormMenu(formMenuInventario);

        }

        private void buttonReportesInventario_Click(object sender, EventArgs e)
        {
            //OpenForm(new FrmReportes());
            //OpenFormMenu(new FrmMenuReporteAveria());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAverias_Click(object sender, EventArgs e)
        {
            //FrmAverias formAverias = new FrmAverias(this);
            //FrmMenuAveria formMenuAveria = new FrmMenuAveria(formAverias);
            //formAverias.frmMenu = formMenuAveria;

            //OpenForm(formAverias);
            //OpenFormMenu(formMenuAveria);
        }

        private void buttonMantenimiento_Click(object sender, EventArgs e)
        {

            //FrmMantenimientoDetallado formMantenimiento = new FrmMantenimientoDetallado();
            //FrmMenuMantenimiento formMenuMante = new FrmMenuMantenimiento();
            //formMantenimiento.frmMenu = formMenuMante;
            //formMenuMante.frmParent=formMantenimiento;


            //OpenForm(formMantenimiento);
            //OpenFormMenu(formMenuMante);
        }

        private void buttonReportesAverias_Click(object sender, EventArgs e)
        {
            //OpenForm(new FrmReportes());
            //OpenFormMenu(new FrmMenuReporteAveria());
        }

        private void buttonReportesMantenimiento_Click(object sender, EventArgs e)
        {
            //OpenForm(new FrmReportes());
            //OpenFormMenu(new FrmMenuReporteMantenimiento());
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            //Agregamos funcion volve a home directamente con clic al logo

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            //if (clickMemReport)
            //{
            //    cs.Enabled = false;
            //    cs.Visible = false;
            //    clickMemReport = false;
            //}
            //else
            //{
            //    cs.Enabled = true;
            //    cs.Visible = true;
            //    clickMemReport = true;
            //}
            //Agregamos funcion mostrar informacion de usuario y cerrar sesion con menu desplegable donde da info
            //confi de usuario y salir sesion
        }

        private void panelMainFrm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormLogin v1 = new FormLogin();
            //v1.Show();
            //this.Close();
        }

        private void panelCategoriaReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //new FormLogin().Show();
            //this.Dispose();
        }

        private void buttonSoporte_Click(object sender, EventArgs e)
        {
            //flagCurrentTable = (int)table.cliente;
            ////dataGridViewCliente.AllowUserToAddRows = false;
            //using (var context = new DBEntities())
            //{
            //    bindingSource1.DataSource= context.CLIENTE.ToList();
            //    dataGridViewCliente.DataSource = bindingSource1;
            //    dataGridViewCliente.Columns[6].Visible = false;
            //    dataGridViewCliente.Columns[7].Visible = false;
            //    dataGridViewCliente.Columns[8].Visible = false;
            //}
            var frmOrdenesTrabajo = new FormProcesoOrdenTrabajo();
            OpenForm(frmOrdenesTrabajo);
        }
        private void createCliente()
        {
            //int nRowIndex = dataGridViewCliente.Rows.Count - 1;
            //dataGridViewCliente.Rows[nRowIndex].
            //var row = dataGridViewCliente.CurrentRow;
            //if ( row != null)
            //{
            //    string nombre = row.Cells[1].Value.ToString();
            //    string estado = dataGridViewCliente.CurrentRow.Cells[2].Value.ToString();
            //    string rtn = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
            //    string telefono = dataGridViewCliente.CurrentRow.Cells[4].Value.ToString();
            //    string dirección = dataGridViewCliente.CurrentRow.Cells[5].Value.ToString();

            //    using (var context = new DBEntities())
            //    {
            //        context.spAddCliente(nombre, estado, rtn, telefono, dirección);
            //    }
            //}
            
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            switch (flagCurrentTable)
            {
                case (int)table.cliente:
                     createCliente();
                    break;
                default:
                    break;
            }
        }

        //private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    Console.WriteLine(dataGridViewCliente.CurrentRow.Index);
        //}

        //private void dataGridViewCliente_Click(object sender, EventArgs e)
        //{
        //    dataGridViewCliente.AllowUserToAddRows = false;
        //}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //using (var context = new DBEntities())
            //{
            //    context.spAddCliente(textBoxNombre.Text, textBoxEstado.Text, textBoxRTN.Text, textBoxTelefono.Text, textBoxDireccion.Text);
            //}
            //MessageBox.Show("Añadido");
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            flagCurrentTable = (int)table.cliente;
            //dataGridViewCliente.AllowUserToAddRows = false;
            //using (var context = new DBEntities())OPE
            //{
            //    bindingSource1.DataSource = context.CLIENTE.ToList();
            //    dataGridViewCliente.DataSource = bindingSource1;
            //    dataGridViewCliente.Columns[6].Visible = false;
            //    dataGridViewCliente.Columns[7].Visible = false;
            //    dataGridViewCliente.Columns[8].Visible = false;
            //}
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //using (var context = new DBEntities())
            //{
            //    context.spDeleteCliente(Int16.Parse(dataGridViewCliente.CurrentRow.Cells[0].Value.ToString()));
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //var row = dataGridViewCliente.CurrentRow;
            //if (row != null)
            //{
            //    int id= Int16.Parse(row.Cells[0].Value.ToString());
            //    string nombre = row.Cells[1].Value.ToString();
            //    string estado = row.Cells[2].Value.ToString();
            //    string rtn = row.Cells[3].Value.ToString();
            //    string telefono = row.Cells[4].Value.ToString();
            //    string dirección = row.Cells[5].Value.ToString();

            //    using (var context = new DBEntities())
            //    {
            //        context.spUpdateCliente(id,nombre,estado,rtn,telefono,dirección);
            //    }
            //}
        }

        private void dataGridViewCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFacturacion_Click(object sender, EventArgs e)
        {
            var frmContratacion = new FormProcesoContratacion();
            OpenForm(frmContratacion);
        }

        private void buttonContratacion_Click(object sender, EventArgs e)
        {
            var frmFacturacion = new FormProcesoFacturacion();
            OpenForm(frmFacturacion);
        }

        private void buttonConfiguracion_Click_1(object sender, EventArgs e)
        {
            var frmGestionServicios = new FormProcesoServicios();
            OpenForm(frmGestionServicios);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var frmTabla = new FormDetalleOrdenTrabajo();
            OpenForm(frmTabla);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmTabla = new FormDetallePaquete();
            OpenForm(frmTabla);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var frmTabla = new FormDisponibilidad();
            OpenForm(frmTabla);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frmTabla = new FormFacturaServicio();
            OpenForm(frmTabla);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frmTabla = new FormOrdenTrabajo();
            OpenForm(frmTabla);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frmTabla = new FormServicios();
            OpenForm(frmTabla);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var frmTabla = new FormTecnicos();
            OpenForm(frmTabla);
        }

        private void buttonGestionClientes_Click(object sender, EventArgs e)
        {
            var frmGestionClientes = new FormProcesoGestionCliente();
            OpenForm(frmGestionClientes);
        }
    }
}
