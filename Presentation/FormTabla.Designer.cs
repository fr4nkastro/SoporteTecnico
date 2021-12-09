namespace Presentation
{
    partial class FormTabla
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
            this.dataGridViewTablaGenerica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaGenerica)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTablaGenerica
            // 
            this.dataGridViewTablaGenerica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablaGenerica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTablaGenerica.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTablaGenerica.Name = "dataGridViewTablaGenerica";
            this.dataGridViewTablaGenerica.RowHeadersWidth = 51;
            this.dataGridViewTablaGenerica.RowTemplate.Height = 24;
            this.dataGridViewTablaGenerica.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewTablaGenerica.TabIndex = 0;
            this.dataGridViewTablaGenerica.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTablaGenerica_CellMouseDoubleClick);
            // 
            // FormTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTablaGenerica);
            this.Name = "FormTabla";
            this.Text = "FormTabla";
            this.Deactivate += new System.EventHandler(this.FormTabla_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTabla_FormClosing);
            this.EnabledChanged += new System.EventHandler(this.FormTabla_EnabledChanged);
            this.VisibleChanged += new System.EventHandler(this.FormTabla_VisibleChanged);
            this.Leave += new System.EventHandler(this.FormTabla_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaGenerica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewTablaGenerica;
    }
}