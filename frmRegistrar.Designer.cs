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
            this.lblNum = new System.Windows.Forms.Label();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegPais
            // 
            this.btnRegPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegPais.Location = new System.Drawing.Point(299, 433);
            this.btnRegPais.Name = "btnRegPais";
            this.btnRegPais.Size = new System.Drawing.Size(111, 46);
            this.btnRegPais.TabIndex = 9;
            this.btnRegPais.Text = "&Registrar Nuevo Pais";
            this.btnRegPais.UseVisualStyleBackColor = false;
            this.btnRegPais.Click += new System.EventHandler(this.btnRegPais_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(314, 517);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBorrar.Location = new System.Drawing.Point(168, 433);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 46);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(25, 433);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 46);
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
            this.lblTitulo.Location = new System.Drawing.Point(95, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "El Club del Campeon";
            // 
            // mrcDatos
            // 
            this.mrcDatos.BackColor = System.Drawing.Color.Transparent;
            this.mrcDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.mrcDatos.Location = new System.Drawing.Point(25, 44);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4);
            this.mrcDatos.Size = new System.Drawing.Size(400, 381);
            this.mrcDatos.TabIndex = 5;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(153, 336);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(18, 20);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "$";
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Enabled = false;
            this.txtPuntaje.Location = new System.Drawing.Point(173, 285);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(152, 27);
            this.txtPuntaje.TabIndex = 7;
            this.txtPuntaje.TextChanged += new System.EventHandler(this.txtPuntaje_TextChanged);
            this.txtPuntaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntaje_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Puntaje:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Enabled = false;
            this.txtIngreso.Location = new System.Drawing.Point(173, 333);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(152, 27);
            this.txtIngreso.TabIndex = 6;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(38, 340);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(69, 20);
            this.lblIngreso.TabIndex = 11;
            this.lblIngreso.Text = "&Ingreso:";
            // 
            // optMujer
            // 
            this.optMujer.AutoSize = true;
            this.optMujer.Enabled = false;
            this.optMujer.Location = new System.Drawing.Point(274, 240);
            this.optMujer.Margin = new System.Windows.Forms.Padding(4);
            this.optMujer.Name = "optMujer";
            this.optMujer.Size = new System.Drawing.Size(72, 24);
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
            this.optHombre.Location = new System.Drawing.Point(164, 237);
            this.optHombre.Margin = new System.Windows.Forms.Padding(4);
            this.optHombre.Name = "optHombre";
            this.optHombre.Size = new System.Drawing.Size(90, 24);
            this.optHombre.TabIndex = 4;
            this.optHombre.TabStop = true;
            this.optHombre.Text = "Hombre";
            this.optHombre.UseVisualStyleBackColor = true;
            this.optHombre.CheckedChanged += new System.EventHandler(this.optHombre_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(38, 240);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(51, 20);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "&Sexo:";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(173, 190);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(152, 27);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(38, 190);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(52, 20);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "&Edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(173, 86);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(152, 27);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.Enabled = false;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(173, 137);
            this.cmbPais.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(152, 28);
            this.cmbPais.TabIndex = 2;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Lugar Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nombre:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(22, 303);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(107, 20);
            this.lblNum.TabIndex = 15;
            this.lblNum.Text = "(130 minimo)";
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArmaniniI_IEFI.Properties.Resources.WhatsApp_Image_2023_04_25_at_22_13_08;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 563);
            this.Controls.Add(this.btnRegPais);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mrcDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

