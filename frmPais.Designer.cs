namespace pryArmaniniI_IEFI
{
    partial class frmPais
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.mrcCompletar = new System.Windows.Forms.GroupBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mrcCompletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVolver.Location = new System.Drawing.Point(54, 271);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 59);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrar.Location = new System.Drawing.Point(218, 271);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 59);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // mrcCompletar
            // 
            this.mrcCompletar.BackColor = System.Drawing.Color.Transparent;
            this.mrcCompletar.Controls.Add(this.txtPais);
            this.mrcCompletar.Controls.Add(this.txtCodigo);
            this.mrcCompletar.Controls.Add(this.lblNombre);
            this.mrcCompletar.Controls.Add(this.lblCodigo);
            this.mrcCompletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mrcCompletar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mrcCompletar.Location = new System.Drawing.Point(8, 97);
            this.mrcCompletar.Name = "mrcCompletar";
            this.mrcCompletar.Size = new System.Drawing.Size(338, 152);
            this.mrcCompletar.TabIndex = 5;
            this.mrcCompletar.TabStop = false;
            this.mrcCompletar.Text = "Completar los Datos:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(167, 102);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(154, 23);
            this.txtPais.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(167, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(154, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "&Nombre de Pais:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(31, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(107, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "&Codigo de Pais:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar Nuevo Pais";
            // 
            // frmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArmaniniI_IEFI.Properties.Resources.WhatsApp_Image_2023_04_25_at_22_13_08;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 349);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcCompletar);
            this.Controls.Add(this.label1);
            this.Name = "frmPais";
            this.Text = "Registrar Pais";
            this.mrcCompletar.ResumeLayout(false);
            this.mrcCompletar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox mrcCompletar;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
    }
}