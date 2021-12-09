namespace Presentation
{
    partial class FormFormContrato
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRetrasos = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTecnicoID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFechaFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClienteID = new System.Windows.Forms.TextBox();
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
            this.dataGridViewCliente.Location = new System.Drawing.Point(0, 226);
            this.dataGridViewCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.RowHeadersWidth = 51;
            this.dataGridViewCliente.RowTemplate.Height = 24;
            this.dataGridViewCliente.Size = new System.Drawing.Size(600, 140);
            this.dataGridViewCliente.TabIndex = 23;
            this.dataGridViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.buttonRead);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxRetrasos);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxTecnicoID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxFechaFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxFechaInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxClienteID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 226);
            this.panel1.TabIndex = 22;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(324, 143);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(56, 19);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(264, 143);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 19);
            this.button9.TabIndex = 25;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(384, 143);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(56, 19);
            this.buttonRead.TabIndex = 24;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Retrasos";
            // 
            // textBoxRetrasos
            // 
            this.textBoxRetrasos.Location = new System.Drawing.Point(195, 119);
            this.textBoxRetrasos.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRetrasos.Name = "textBoxRetrasos";
            this.textBoxRetrasos.Size = new System.Drawing.Size(262, 20);
            this.textBoxRetrasos.TabIndex = 22;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(204, 143);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 19);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "TecnicoID";
            // 
            // textBoxTecnicoID
            // 
            this.textBoxTecnicoID.Location = new System.Drawing.Point(195, 97);
            this.textBoxTecnicoID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTecnicoID.Name = "textBoxTecnicoID";
            this.textBoxTecnicoID.Size = new System.Drawing.Size(262, 20);
            this.textBoxTecnicoID.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha Final";
            // 
            // textBoxFechaFinal
            // 
            this.textBoxFechaFinal.Location = new System.Drawing.Point(195, 74);
            this.textBoxFechaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFechaFinal.Name = "textBoxFechaFinal";
            this.textBoxFechaFinal.Size = new System.Drawing.Size(262, 20);
            this.textBoxFechaFinal.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(126, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha Inicio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(195, 51);
            this.textBoxFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(262, 20);
            this.textBoxFechaInicio.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ClienteID";
            // 
            // textBoxClienteID
            // 
            this.textBoxClienteID.Location = new System.Drawing.Point(195, 28);
            this.textBoxClienteID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClienteID.Name = "textBoxClienteID";
            this.textBoxClienteID.Size = new System.Drawing.Size(262, 20);
            this.textBoxClienteID.TabIndex = 13;
            // 
            // FormFormContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFormContrato";
            this.Text = "FormContrato";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRetrasos;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTecnicoID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClienteID;
    }
}