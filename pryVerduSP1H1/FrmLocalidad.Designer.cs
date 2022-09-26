namespace pryVerduSP1H1
{
    partial class FrmLocalidad
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
            this.MaskTxtIdentificador = new System.Windows.Forms.MaskedTextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblNombreLoc = new System.Windows.Forms.Label();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MaskTxtIdentificador
            // 
            this.MaskTxtIdentificador.Location = new System.Drawing.Point(119, 17);
            this.MaskTxtIdentificador.Mask = "0000";
            this.MaskTxtIdentificador.Name = "MaskTxtIdentificador";
            this.MaskTxtIdentificador.Size = new System.Drawing.Size(100, 20);
            this.MaskTxtIdentificador.TabIndex = 9;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(24, 17);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(65, 13);
            this.lblIdentificador.TabIndex = 8;
            this.lblIdentificador.Text = "Identificador";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(144, 92);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblNombreLoc
            // 
            this.lblNombreLoc.AutoSize = true;
            this.lblNombreLoc.Location = new System.Drawing.Point(24, 50);
            this.lblNombreLoc.Name = "lblNombreLoc";
            this.lblNombreLoc.Size = new System.Drawing.Size(89, 13);
            this.lblNombreLoc.TabIndex = 6;
            this.lblNombreLoc.Text = "Nombre localidad";
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(119, 50);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLocalidad.TabIndex = 5;
            // 
            // FrmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 130);
            this.Controls.Add(this.MaskTxtIdentificador);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblNombreLoc);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Name = "FrmLocalidad";
            this.Text = "FrmLocalidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MaskTxtIdentificador;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblNombreLoc;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
    }
}