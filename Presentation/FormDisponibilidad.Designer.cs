﻿namespace Presentation
{
    partial class FormDisponibilidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTecnico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesde = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCliente.Location = new System.Drawing.Point(0, 189);
            this.dataGridViewCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.RowHeadersWidth = 51;
            this.dataGridViewCliente.RowTemplate.Height = 24;
            this.dataGridViewCliente.Size = new System.Drawing.Size(800, 261);
            this.dataGridViewCliente.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.buttonRead);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxTecnico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxHasta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxDesde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 189);
            this.panel1.TabIndex = 22;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(320, 98);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 19);
            this.button8.TabIndex = 26;
            this.button8.Text = "Update";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(260, 99);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 19);
            this.button9.TabIndex = 25;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(380, 98);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(56, 19);
            this.buttonRead.TabIndex = 24;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(200, 98);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 19);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "TecnicoID";
            // 
            // textBoxTecnico
            // 
            this.textBoxTecnico.Location = new System.Drawing.Point(195, 74);
            this.textBoxTecnico.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTecnico.Name = "textBoxTecnico";
            this.textBoxTecnico.Size = new System.Drawing.Size(262, 20);
            this.textBoxTecnico.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hasta";
            // 
            // textBoxHasta
            // 
            this.textBoxHasta.Location = new System.Drawing.Point(195, 51);
            this.textBoxHasta.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHasta.Name = "textBoxHasta";
            this.textBoxHasta.Size = new System.Drawing.Size(262, 20);
            this.textBoxHasta.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Desde";
            // 
            // textBoxDesde
            // 
            this.textBoxDesde.Location = new System.Drawing.Point(195, 28);
            this.textBoxDesde.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDesde.Name = "textBoxDesde";
            this.textBoxDesde.Size = new System.Drawing.Size(262, 20);
            this.textBoxDesde.TabIndex = 13;
            // 
            // FormDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.panel1);
            this.Name = "FormDisponibilidad";
            this.Text = "Disponibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTecnico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDesde;
    }
}