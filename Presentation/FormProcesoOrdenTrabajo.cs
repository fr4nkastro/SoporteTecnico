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
        FormTabla frmTabla; //Tabla genérica de donde siempre se tomaran los datos
        public DataGridViewRow clienteRow; //Tipos de row donde se cargaran los datos
        public DataGridViewRow servicioRow;
        public DataGridViewRow contratoRow;
        public DataGridViewRow tecnicoRow;
        private enum table //Enumeración para gestionar el tipo de tabla de la row sirve para llamar a formTabla(row, tbl)
        {
            cliente, contratos, detalleContratos, detalleFacturaServicios, detalleOrdenTrabajo, detallePaquete, disponibilidadTecnico, facturaServicio,
            ordenTrabajo, tecnicos, servicios
        }

        public FormProcesoOrdenTrabajo()
        {
            InitializeComponent();
            //Formtao de los pickers con hora
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            dateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm";
        }

        //Carga local de datos
        private void FormProcesoOrdenTrabajo_Load(object sender, EventArgs e)
        {
            using (var context = new DBEntities ())
            {
                var result = 
                dataGridView2.DataSource = context.Database.SqlQuery<viewDisponibilidadTecnicos>(@"SELECT * FROM viewDisponibilidadTecnico").ToList();
                dataGridView1.DataSource = context.Database.SqlQuery<viewOrdenTrabajo>(@"SELECT * FROM viewOrdenTrabajo").ToList();
                for (int c = 0; c < 4; c++)
                    dataGridView1.Columns[c].Visible = false;
            }


        }

        
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {


            //Delete this

        }


        //Metodo para obtener los datos requeridos de cliente en el form actual
        //Dependiendo el tipo de tabla que retorne el form tabla se efectua una acción
        //Para multiples rows de distintas tablas
        private void getData(DataGridViewRow row, int tbl)
        {

            switch (tbl)
            {
                case (int)table.cliente:
                    clienteRow = row;
                    textBox1.Text = clienteRow.Cells["nombre"].Value.ToString();
                    break;
                case (int)table.servicios:
                    servicioRow= row;
                    textBox2.Text = servicioRow.Cells["nombre"].Value.ToString();
                    break;
                case (int)table.contratos:
                    contratoRow= row;
                    textBox3.Text = contratoRow.Cells["ContratoID"].Value.ToString();
                    break;
                case (int)table.tecnicos:
                    tecnicoRow = row;
                    textBox4.Text = tecnicoRow.Cells["nombre"].Value.ToString();
                    break;
                default:
                    break;
            }
        }


        //Llamado a la tabla con doble click en textbox cliente
        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clienteRow = new DataGridViewRow();
            frmTabla = new FormTabla((int)table.cliente);
            frmTabla.eventGetRow += getData;
            frmTabla.Show();
            

            //Cargar la tabla flotante con los datos requeridos
            using (var context = new DBEntities())
            {

                frmTabla.dataGridViewTablaGenerica.DataSource = context.CLIENTE.ToList();
                //frmTabla.dataGridViewTablaGenerica.
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {//Añadir ORDEN DE TRABAJO
            //DETALLE ORDEN DE TRABAJO a partir de las row
        }


        //Llamado de la tabla con doble click sobre textbox servicio
        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clienteRow = new DataGridViewRow();
            frmTabla = new FormTabla((int)table.servicios);
            frmTabla.eventGetRow += getData;
            frmTabla.Show();


            //Cargar la tabla flotante con los datos requeridos
            using (var context = new DBEntities())
            {
                frmTabla.dataGridViewTablaGenerica.DataSource = context.SERVICIOS.ToList();   
            }
        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            contratoRow = new DataGridViewRow();
            frmTabla = new FormTabla(((int)table.contratos));
            frmTabla.eventGetRow += getData;
            frmTabla.Show();

            //Cargar la tabla flotante con los datos requeridos
            using (var context = new DBEntities())
            {
                frmTabla.dataGridViewTablaGenerica.DataSource = context.Database.SqlQuery<ViewContrato>(@" select * From viewContrato").ToList();
                for(int c=0;c<4; c++)
                    frmTabla.dataGridViewTablaGenerica.Columns[c].Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tecnicoRow = new DataGridViewRow();
            frmTabla = new FormTabla(((int)table.tecnicos));
            frmTabla.eventGetRow += getData;
            frmTabla.Show();

            //Cargar la tabla flotante con los datos requeridos
            using (var context = new DBEntities())
            {
                frmTabla.dataGridViewTablaGenerica.DataSource = context.TECNICOS.ToList();
                //for (int c = 0; c < 4; c++)
                //    frmTabla.dataGridViewTablaGenerica.Columns[c].Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ELiminar detalleOrdenDetrabajoS de orden detrabajo
            //Eliminar orden de trabajo

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Añadir función de carga de los datos desde la tabla a los textbox
            //Los ID se encuentran invisible en las primeras columnas de los datagridview revisar las view para comprender

        }
    }
}
