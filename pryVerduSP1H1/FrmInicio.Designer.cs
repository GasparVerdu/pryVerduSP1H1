namespace pryVerduSP1H1
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCultivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaLocalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cultivosToolStripMenuItem,
            this.localidadToolStripMenuItem,
            this.produccionToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaCultivosToolStripMenuItem,
            this.consultaLocalidadToolStripMenuItem,
            this.consultaProduccionToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // cultivosToolStripMenuItem
            // 
            this.cultivosToolStripMenuItem.Name = "cultivosToolStripMenuItem";
            this.cultivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cultivosToolStripMenuItem.Text = "Cultivos";
            this.cultivosToolStripMenuItem.Click += new System.EventHandler(this.cultivosToolStripMenuItem_Click_1);
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localidadToolStripMenuItem.Text = "Localidad";
            this.localidadToolStripMenuItem.Click += new System.EventHandler(this.localidadToolStripMenuItem_Click_1);
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produccionToolStripMenuItem.Text = "Produccion";
            this.produccionToolStripMenuItem.Click += new System.EventHandler(this.produccionToolStripMenuItem_Click_1);
            // 
            // consultaCultivosToolStripMenuItem
            // 
            this.consultaCultivosToolStripMenuItem.Name = "consultaCultivosToolStripMenuItem";
            this.consultaCultivosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultaCultivosToolStripMenuItem.Text = "Consulta Cultivos";
            this.consultaCultivosToolStripMenuItem.Click += new System.EventHandler(this.consultaCultivosToolStripMenuItem_Click);
            // 
            // consultaLocalidadToolStripMenuItem
            // 
            this.consultaLocalidadToolStripMenuItem.Name = "consultaLocalidadToolStripMenuItem";
            this.consultaLocalidadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultaLocalidadToolStripMenuItem.Text = "Consulta Localidad";
            this.consultaLocalidadToolStripMenuItem.Click += new System.EventHandler(this.consultaLocalidadToolStripMenuItem_Click);
            // 
            // consultaProduccionToolStripMenuItem
            // 
            this.consultaProduccionToolStripMenuItem.Name = "consultaProduccionToolStripMenuItem";
            this.consultaProduccionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultaProduccionToolStripMenuItem.Text = "Consulta Produccion";
            this.consultaProduccionToolStripMenuItem.Click += new System.EventHandler(this.consultaProduccionToolStripMenuItem_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCultivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaLocalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

