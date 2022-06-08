namespace Cedula_de_Identidad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gbCedula = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.buttF = new System.Windows.Forms.RadioButton();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.buttM = new System.Windows.Forms.RadioButton();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textExpiracion = new System.Windows.Forms.TextBox();
            this.Expiracion = new System.Windows.Forms.Label();
            this.EstadoCivil = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.Label();
            this.textOcupacion = new System.Windows.Forms.TextBox();
            this.Ocupacion = new System.Windows.Forms.Label();
            this.textSangre = new System.Windows.Forms.TextBox();
            this.Sangre = new System.Windows.Forms.Label();
            this.textNacionalidad = new System.Windows.Forms.TextBox();
            this.Naconalidad = new System.Windows.Forms.Label();
            this.textLugar = new System.Windows.Forms.TextBox();
            this.PoB = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.boxFoto = new System.Windows.Forms.PictureBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.gbCedula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula de Identidad";
            // 
            // gbCedula
            // 
            this.gbCedula.Controls.Add(this.comboEstado);
            this.gbCedula.Controls.Add(this.buttF);
            this.gbCedula.Controls.Add(this.dtNacimiento);
            this.gbCedula.Controls.Add(this.buttM);
            this.gbCedula.Controls.Add(this.buttonIngresar);
            this.gbCedula.Controls.Add(this.textID);
            this.gbCedula.Controls.Add(this.label9);
            this.gbCedula.Controls.Add(this.textExpiracion);
            this.gbCedula.Controls.Add(this.Expiracion);
            this.gbCedula.Controls.Add(this.EstadoCivil);
            this.gbCedula.Controls.Add(this.Sexo);
            this.gbCedula.Controls.Add(this.DoB);
            this.gbCedula.Controls.Add(this.textOcupacion);
            this.gbCedula.Controls.Add(this.Ocupacion);
            this.gbCedula.Controls.Add(this.textSangre);
            this.gbCedula.Controls.Add(this.Sangre);
            this.gbCedula.Controls.Add(this.textNacionalidad);
            this.gbCedula.Controls.Add(this.Naconalidad);
            this.gbCedula.Controls.Add(this.textLugar);
            this.gbCedula.Controls.Add(this.PoB);
            this.gbCedula.Controls.Add(this.textNombre);
            this.gbCedula.Controls.Add(this.Nombre);
            this.gbCedula.Controls.Add(this.boxFoto);
            this.gbCedula.Enabled = false;
            this.gbCedula.Location = new System.Drawing.Point(12, 54);
            this.gbCedula.Name = "gbCedula";
            this.gbCedula.Size = new System.Drawing.Size(487, 274);
            this.gbCedula.TabIndex = 1;
            this.gbCedula.TabStop = false;
            this.gbCedula.Text = "Cédula de Identidad";
            this.gbCedula.Enter += new System.EventHandler(this.gbCedula_Enter);
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.comboEstado.Location = new System.Drawing.Point(318, 173);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(163, 21);
            this.comboEstado.TabIndex = 25;
            // 
            // buttF
            // 
            this.buttF.AutoSize = true;
            this.buttF.Location = new System.Drawing.Point(401, 132);
            this.buttF.Name = "buttF";
            this.buttF.Size = new System.Drawing.Size(80, 17);
            this.buttF.TabIndex = 24;
            this.buttF.TabStop = true;
            this.buttF.Text = "Femenino";
            this.buttF.UseVisualStyleBackColor = true;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNacimiento.Location = new System.Drawing.Point(317, 92);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(164, 21);
            this.dtNacimiento.TabIndex = 23;
            // 
            // buttM
            // 
            this.buttM.AutoSize = true;
            this.buttM.Location = new System.Drawing.Point(317, 133);
            this.buttM.Name = "buttM";
            this.buttM.Size = new System.Drawing.Size(80, 17);
            this.buttM.TabIndex = 21;
            this.buttM.TabStop = true;
            this.buttM.Text = "Masculino";
            this.buttM.UseVisualStyleBackColor = true;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(6, 179);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(132, 23);
            this.buttonIngresar.TabIndex = 22;
            this.buttonIngresar.Text = "Ingresar Foto";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(147, 51);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(334, 21);
            this.textID.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID";
            // 
            // textExpiracion
            // 
            this.textExpiracion.Enabled = false;
            this.textExpiracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExpiracion.Location = new System.Drawing.Point(317, 214);
            this.textExpiracion.Name = "textExpiracion";
            this.textExpiracion.Size = new System.Drawing.Size(164, 21);
            this.textExpiracion.TabIndex = 18;
            // 
            // Expiracion
            // 
            this.Expiracion.AutoSize = true;
            this.Expiracion.Location = new System.Drawing.Point(314, 198);
            this.Expiracion.Name = "Expiracion";
            this.Expiracion.Size = new System.Drawing.Size(121, 13);
            this.Expiracion.TabIndex = 17;
            this.Expiracion.Text = "Fecha de Expiración";
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.AutoSize = true;
            this.EstadoCivil.Location = new System.Drawing.Point(314, 157);
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Size = new System.Drawing.Size(74, 13);
            this.EstadoCivil.TabIndex = 15;
            this.EstadoCivil.Text = "Estado Civil";
            this.EstadoCivil.Click += new System.EventHandler(this.label7_Click);
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(314, 116);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(36, 13);
            this.Sexo.TabIndex = 13;
            this.Sexo.Text = "Sexo";
            // 
            // DoB
            // 
            this.DoB.AutoSize = true;
            this.DoB.Location = new System.Drawing.Point(314, 75);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(125, 13);
            this.DoB.TabIndex = 11;
            this.DoB.Text = "Fecha de Nacimiento";
            // 
            // textOcupacion
            // 
            this.textOcupacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOcupacion.Location = new System.Drawing.Point(147, 214);
            this.textOcupacion.Name = "textOcupacion";
            this.textOcupacion.Size = new System.Drawing.Size(164, 21);
            this.textOcupacion.TabIndex = 10;
            // 
            // Ocupacion
            // 
            this.Ocupacion.AutoSize = true;
            this.Ocupacion.Location = new System.Drawing.Point(144, 198);
            this.Ocupacion.Name = "Ocupacion";
            this.Ocupacion.Size = new System.Drawing.Size(66, 13);
            this.Ocupacion.TabIndex = 9;
            this.Ocupacion.Text = "Ocupación";
            // 
            // textSangre
            // 
            this.textSangre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSangre.Location = new System.Drawing.Point(147, 173);
            this.textSangre.Name = "textSangre";
            this.textSangre.Size = new System.Drawing.Size(164, 21);
            this.textSangre.TabIndex = 8;
            // 
            // Sangre
            // 
            this.Sangre.AutoSize = true;
            this.Sangre.Location = new System.Drawing.Point(144, 157);
            this.Sangre.Name = "Sangre";
            this.Sangre.Size = new System.Drawing.Size(48, 13);
            this.Sangre.TabIndex = 7;
            this.Sangre.Text = "Sangre";
            // 
            // textNacionalidad
            // 
            this.textNacionalidad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNacionalidad.Location = new System.Drawing.Point(147, 132);
            this.textNacionalidad.Name = "textNacionalidad";
            this.textNacionalidad.Size = new System.Drawing.Size(164, 21);
            this.textNacionalidad.TabIndex = 6;
            // 
            // Naconalidad
            // 
            this.Naconalidad.AutoSize = true;
            this.Naconalidad.Location = new System.Drawing.Point(144, 116);
            this.Naconalidad.Name = "Naconalidad";
            this.Naconalidad.Size = new System.Drawing.Size(79, 13);
            this.Naconalidad.TabIndex = 5;
            this.Naconalidad.Text = "Nacionalidad";
            // 
            // textLugar
            // 
            this.textLugar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLugar.Location = new System.Drawing.Point(147, 91);
            this.textLugar.Name = "textLugar";
            this.textLugar.Size = new System.Drawing.Size(164, 21);
            this.textLugar.TabIndex = 4;
            // 
            // PoB
            // 
            this.PoB.AutoSize = true;
            this.PoB.Location = new System.Drawing.Point(144, 75);
            this.PoB.Name = "PoB";
            this.PoB.Size = new System.Drawing.Size(124, 13);
            this.PoB.TabIndex = 3;
            this.PoB.Text = "Lugar de Nacimiento";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(6, 219);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(134, 32);
            this.textNombre.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(3, 203);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(52, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // boxFoto
            // 
            this.boxFoto.Location = new System.Drawing.Point(6, 20);
            this.boxFoto.Name = "boxFoto";
            this.boxFoto.Size = new System.Drawing.Size(134, 153);
            this.boxFoto.TabIndex = 0;
            this.boxFoto.TabStop = false;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(505, 63);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(339, 326);
            this.dgvUsuario.TabIndex = 2;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCrear.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(12, 334);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(140, 55);
            this.buttonCrear.TabIndex = 3;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonGuardar.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(183, 334);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(140, 55);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(353, 334);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(140, 55);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(855, 430);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.gbCedula);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Cédula de Identidad";
            this.gbCedula.ResumeLayout(false);
            this.gbCedula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCedula;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textExpiracion;
        private System.Windows.Forms.Label Expiracion;
        private System.Windows.Forms.Label EstadoCivil;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.TextBox textOcupacion;
        private System.Windows.Forms.Label Ocupacion;
        private System.Windows.Forms.TextBox textSangre;
        private System.Windows.Forms.Label Sangre;
        private System.Windows.Forms.TextBox textNacionalidad;
        private System.Windows.Forms.Label Naconalidad;
        private System.Windows.Forms.TextBox textLugar;
        private System.Windows.Forms.Label PoB;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.PictureBox boxFoto;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.RadioButton buttM;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.RadioButton buttF;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}

