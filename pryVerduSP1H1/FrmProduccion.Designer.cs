namespace pryVerduSP1H1
{
    partial class FrmProduccion
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboNombreCultivo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboNombreLocalidad = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombreCultivo = new System.Windows.Forms.Label();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(188, 163);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(68, 31);
            this.btnCargar.TabIndex = 27;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(135, 137);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(121, 20);
            this.nudCantidad.TabIndex = 26;
            // 
            // cboNombreCultivo
            // 
            this.cboNombreCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreCultivo.FormattingEnabled = true;
            this.cboNombreCultivo.Location = new System.Drawing.Point(135, 97);
            this.cboNombreCultivo.Name = "cboNombreCultivo";
            this.cboNombreCultivo.Size = new System.Drawing.Size(121, 21);
            this.cboNombreCultivo.TabIndex = 25;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(135, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 24;
            this.dtpFecha.Value = new System.DateTime(2022, 9, 20, 12, 0, 0, 0);
            // 
            // cboNombreLocalidad
            // 
            this.cboNombreLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreLocalidad.FormattingEnabled = true;
            this.cboNombreLocalidad.Location = new System.Drawing.Point(137, 59);
            this.cboNombreLocalidad.Name = "cboNombreLocalidad";
            this.cboNombreLocalidad.Size = new System.Drawing.Size(119, 21);
            this.cboNombreLocalidad.TabIndex = 23;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(26, 137);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblNombreCultivo
            // 
            this.lblNombreCultivo.AutoSize = true;
            this.lblNombreCultivo.Location = new System.Drawing.Point(26, 97);
            this.lblNombreCultivo.Name = "lblNombreCultivo";
            this.lblNombreCultivo.Size = new System.Drawing.Size(78, 13);
            this.lblNombreCultivo.TabIndex = 21;
            this.lblNombreCultivo.Text = "Nombre cultivo";
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Location = new System.Drawing.Point(26, 62);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(89, 13);
            this.lblNombreLocalidad.TabIndex = 20;
            this.lblNombreLocalidad.Text = "Nombre localidad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(26, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // FrmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 203);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cboNombreCultivo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboNombreLocalidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreCultivo);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.lblFecha);
            this.Name = "FrmProduccion";
            this.Text = "FrmProduccion";
            this.Load += new System.EventHandler(this.FrmProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cboNombreCultivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboNombreLocalidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombreCultivo;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblFecha;
    }
}