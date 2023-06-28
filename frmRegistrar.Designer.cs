namespace pryArmaniniI_IEFI
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.btnRegPais = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.optMujer = new System.Windows.Forms.RadioButton();
            this.optHombre = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegPais
            // 
            this.btnRegPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegPais.Location = new System.Drawing.Point(224, 352);
            this.btnRegPais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegPais.Name = "btnRegPais";
            this.btnRegPais.Size = new System.Drawing.Size(83, 37);
            this.btnRegPais.TabIndex = 9;
            this.btnRegPais.Text = "&Registrar Nuevo Pais";
            this.btnRegPais.UseVisualStyleBackColor = false;
            this.btnRegPais.Click += new System.EventHandler(this.btnRegPais_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(236, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 26);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBorrar.Location = new System.Drawing.Point(126, 352);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(83, 37);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(19, 352);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(83, 37);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "&Registrar Nuevo Cliente";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(71, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "El Club del Campion";
            // 
            // mrcDatos
            // 
            this.mrcDatos.BackColor = System.Drawing.Color.Transparent;
            this.mrcDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mrcDatos.Controls.Add(this.label5);
            this.mrcDatos.Controls.Add(this.lblNum);
            this.mrcDatos.Controls.Add(this.lblPeso);
            this.mrcDatos.Controls.Add(this.txtPuntaje);
            this.mrcDatos.Controls.Add(this.label4);
            this.mrcDatos.Controls.Add(this.txtIngreso);
            this.mrcDatos.Controls.Add(this.lblIngreso);
            this.mrcDatos.Controls.Add(this.optMujer);
            this.mrcDatos.Controls.Add(this.optHombre);
            this.mrcDatos.Controls.Add(this.lblSexo);
            this.mrcDatos.Controls.Add(this.txtEdad);
            this.mrcDatos.Controls.Add(this.lblEdad);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.cmbPais);
            this.mrcDatos.Controls.Add(this.label3);
            this.mrcDatos.Controls.Add(this.label2);
            this.mrcDatos.Controls.Add(this.label1);
            this.mrcDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mrcDatos.Location = new System.Drawing.Point(19, 36);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(300, 310);
            this.mrcDatos.TabIndex = 5;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(16, 246);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(90, 17);
            this.lblNum.TabIndex = 15;
            this.lblNum.Text = "(130 minimo)";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(115, 273);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(16, 17);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "$";
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Enabled = false;
            this.txtPuntaje.Location = new System.Drawing.Point(130, 232);
            this.txtPuntaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(115, 23);
            this.txtPuntaje.TabIndex = 7;
            this.txtPuntaje.TextChanged += new System.EventHandler(this.txtPuntaje_TextChanged);
            this.txtPuntaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntaje_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Puntaje:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Enabled = false;
            this.txtIngreso.Location = new System.Drawing.Point(130, 271);
            this.txtIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(115, 23);
            this.txtIngreso.TabIndex = 6;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(28, 276);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(59, 17);
            this.lblIngreso.TabIndex = 11;
            this.lblIngreso.Text = "&Ingreso:";
            // 
            // optMujer
            // 
            this.optMujer.AutoSize = true;
            this.optMujer.Enabled = false;
            this.optMujer.Location = new System.Drawing.Point(206, 195);
            this.optMujer.Name = "optMujer";
            this.optMujer.Size = new System.Drawing.Size(61, 21);
            this.optMujer.TabIndex = 5;
            this.optMujer.TabStop = true;
            this.optMujer.Text = "Mujer";
            this.optMujer.UseVisualStyleBackColor = true;
            this.optMujer.CheckedChanged += new System.EventHandler(this.optMujer_CheckedChanged);
            // 
            // optHombre
            // 
            this.optHombre.AutoSize = true;
            this.optHombre.Enabled = false;
            this.optHombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optHombre.Location = new System.Drawing.Point(123, 193);
            this.optHombre.Name = "optHombre";
            this.optHombre.Size = new System.Drawing.Size(76, 21);
            this.optHombre.TabIndex = 4;
            this.optHombre.TabStop = true;
            this.optHombre.Text = "Hombre";
            this.optHombre.UseVisualStyleBackColor = true;
            this.optHombre.CheckedChanged += new System.EventHandler(this.optHombre_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(28, 195);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(43, 17);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "&Sexo:";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(130, 154);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(115, 23);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(28, 154);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(45, 17);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "&Edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(115, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(130, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(115, 23);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.Enabled = false;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(130, 111);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(115, 25);
            this.cmbPais.TabIndex = 2;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Lugar Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "(50 minimo)";
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArmaniniI_IEFI.Properties.Resources.WhatsApp_Image_2023_04_25_at_22_13_08;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 457);
            this.Controls.Add(this.btnRegPais);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mrcDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El Club del Campeon - Registrar Clientes";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegPais;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.RadioButton optMujer;
        private System.Windows.Forms.RadioButton optHombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label5;
    }
}

