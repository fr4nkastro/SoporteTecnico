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
//using DataAccess.DTO;


namespace Presentation
{
    public partial class FormProcesoServicios : Form
    {
        public FormProcesoServicios()
        {
            InitializeComponent();
            ReadAll();
        }

        private void Read()
        {
            using (var context = new DBEntities())
            {

                dataGridView3.DataSource = context.SERVICIOS.ToList();
                dataGridView3.Columns[4].Visible = false;
                dataGridView3.Columns[5].Visible = false;
                dataGridView3.Columns[6].Visible = false;
                dataGridView3.Columns[7].Visible = false;
                dataGridView3.Columns[8].Visible = false;
            }

        }

        private void ReadAll()
        {
            Read();
            ReadPaquete();

        }

        private void ReadPaquete()
        {

            using (var context = new DBEntities())
            {

                dataGridView1.DataSource = context.viewPaquetes.ToList();
            }
             
        }


     

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView3.CurrentRow;
            if (row != null)
            {
                string nombre = row.Cells[1].Value.ToString();
                float precio = float.Parse( row.Cells[2].Value.ToString());
                string tipo = row.Cells[3].Value.ToString();

                textBox1.Text = nombre;
                textBox2.Text = Convert.ToString(precio);
                textBox3.Text = tipo;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            float precio = float.Parse(textBox2.Text);
            string tipo = textBox3.Text;


                using (var context = new DBEntities())
            {

                dataGridView3.DataSource = context.spAddServicioFull(nombre, precio, tipo);
              
            }

            ReadAll();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var row = dataGridView3.CurrentRow;
            if (row != null)
            {
           
                int id = Int16.Parse(row.Cells[0].Value.ToString());



                using (var context = new DBEntities())
                {

                    dataGridView3.DataSource = context.spDeleteServiciosFull(id);

                }


            }
            ReadAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = dataGridView3.CurrentRow;
            int id = Int16.Parse(row.Cells[0].Value.ToString());

            string nombre = textBox1.Text;
            float precio = float.Parse(textBox2.Text);
            string tipo = textBox3.Text;


            using (var context = new DBEntities())
            {

                dataGridView3.DataSource = context.spUpdateServicios(id, nombre, precio, tipo);

            }

            ReadAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            int id = Int16.Parse(row.Cells[0].Value.ToString());

            using (var context = new DBEntities())
            {

                dataGridView2.DataSource = context.fServiciosEnPaquetes(id).ToList();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            var row = dataGridView1.CurrentRow;
            int id = Int16.Parse(row.Cells[0].Value.ToString());

            var row2 = dataGridView3.CurrentRow;
            int id2 = Int16.Parse(row2.Cells[0].Value.ToString());

            var row3 = dataGridView1.CurrentRow;
            int id3 = Int16.Parse(row3.Cells[0].Value.ToString());

            using (var context = new DBEntities())
            {

                context.spAddDetallePaquete(id2, id);

                dataGridView2.DataSource = context.fServiciosEnPaquetes(id3).ToList();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var row2 = dataGridView1.CurrentRow;
            int id2 = Int16.Parse(row2.Cells[0].Value.ToString());

            var row = dataGridView2.CurrentRow;
            int id= Int16.Parse(row.Cells[2].Value.ToString());



            using (var context = new DBEntities())
            {

                dataGridView2.DataSource = context.spDeleteDetallePaquete(id);
                dataGridView2.DataSource = context.fServiciosEnPaquetes(id2).ToList();


            }


        }
    }

       
    }

