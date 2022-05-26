namespace WFP1AC14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonObtenerDatos = new System.Windows.Forms.Button();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.buttonCrearAlumno = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.parcial1 = new System.Windows.Forms.TextBox();
            this.parcial2 = new System.Windows.Forms.TextBox();
            this.parcial3 = new System.Windows.Forms.TextBox();
            this.borrar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObtenerDatos
            // 
            this.buttonObtenerDatos.Location = new System.Drawing.Point(560, 507);
            this.buttonObtenerDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonObtenerDatos.Name = "buttonObtenerDatos";
            this.buttonObtenerDatos.Size = new System.Drawing.Size(156, 22);
            this.buttonObtenerDatos.TabIndex = 0;
            this.buttonObtenerDatos.Text = "Obtener Datos";
            this.buttonObtenerDatos.UseVisualStyleBackColor = true;
            this.buttonObtenerDatos.Click += new System.EventHandler(this.buttonObtenerDatos_Click);
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(717, 0);
            this.dataGridViewAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowHeadersWidth = 51;
            this.dataGridViewAlumnos.RowTemplate.Height = 29;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(482, 540);
            this.dataGridViewAlumnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CARNET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(79, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(79, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(79, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(79, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seccion";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(177, 35);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(152, 23);
            this.textBoxCarnet.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(177, 80);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(409, 23);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(177, 127);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(409, 23);
            this.textBoxCorreo.TabIndex = 9;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "PROGRAMACIÓN I",
            "PROGRAMACIÓN 2",
            "PROGRAMACIÓN 3",
            "MATEMATICA"});
            this.comboBoxClase.Location = new System.Drawing.Point(177, 175);
            this.comboBoxClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(288, 23);
            this.comboBoxClase.TabIndex = 10;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonConsulta.Location = new System.Drawing.Point(355, 35);
            this.buttonConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(186, 33);
            this.buttonConsulta.TabIndex = 11;
            this.buttonConsulta.Text = "Consulta Carnet";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(177, 218);
            this.comboBoxSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(72, 23);
            this.comboBoxSeccion.TabIndex = 12;
            // 
            // buttonCrearAlumno
            // 
            this.buttonCrearAlumno.BackColor = System.Drawing.Color.Red;
            this.buttonCrearAlumno.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonCrearAlumno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCrearAlumno.Location = new System.Drawing.Point(12, 398);
            this.buttonCrearAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrearAlumno.Name = "buttonCrearAlumno";
            this.buttonCrearAlumno.Size = new System.Drawing.Size(189, 68);
            this.buttonCrearAlumno.TabIndex = 13;
            this.buttonCrearAlumno.Text = "CREAR ALUMNO";
            this.buttonCrearAlumno.UseVisualStyleBackColor = false;
            this.buttonCrearAlumno.Click += new System.EventHandler(this.buttonCrearAlumno_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Red;
            this.buttonActualizar.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonActualizar.Location = new System.Drawing.Point(223, 398);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(184, 68);
            this.buttonActualizar.TabIndex = 14;
            this.buttonActualizar.Text = "ACTUALIZAR";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.Location = new System.Drawing.Point(60, 507);
            this.buttonImportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(82, 22);
            this.buttonImportar.TabIndex = 15;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(194, 507);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(82, 22);
            this.buttonExportar.TabIndex = 16;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // parcial1
            // 
            this.parcial1.Location = new System.Drawing.Point(177, 257);
            this.parcial1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parcial1.Name = "parcial1";
            this.parcial1.Size = new System.Drawing.Size(112, 23);
            this.parcial1.TabIndex = 17;
            this.parcial1.Text = "0";
            // 
            // parcial2
            // 
            this.parcial2.Location = new System.Drawing.Point(177, 299);
            this.parcial2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parcial2.Name = "parcial2";
            this.parcial2.Size = new System.Drawing.Size(112, 23);
            this.parcial2.TabIndex = 18;
            this.parcial2.Text = "0";
            // 
            // parcial3
            // 
            this.parcial3.Location = new System.Drawing.Point(177, 338);
            this.parcial3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parcial3.Name = "parcial3";
            this.parcial3.Size = new System.Drawing.Size(112, 23);
            this.parcial3.TabIndex = 19;
            this.parcial3.Text = "0";
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.Red;
            this.borrar.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.borrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.borrar.Location = new System.Drawing.Point(426, 398);
            this.borrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(189, 68);
            this.borrar.TabIndex = 20;
            this.borrar.Text = "ELIMINAR ALUMNO";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Blue;
            this.limpiar.Location = new System.Drawing.Point(223, 470);
            this.limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(189, 22);
            this.limpiar.TabIndex = 21;
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(79, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "PARCIAL 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(79, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "PARCIAL 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(78, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "PARCIAL 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Engravers MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(212, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "\"BIENVENIDO\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 179);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1199, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.parcial3);
            this.Controls.Add(this.parcial2);
            this.Controls.Add(this.parcial1);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCrearAlumno);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.buttonObtenerDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
          
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonObtenerDatos;
        private DataGridView dataGridViewAlumnos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private ComboBox comboBoxClase;
        private Button buttonConsulta;
        private ComboBox comboBoxSeccion;
        private Button buttonCrearAlumno;
        private Button buttonActualizar;
        private Button buttonImportar;
        private Button buttonExportar;
        private TextBox parcial1;
        private TextBox parcial2;
        private TextBox parcial3;
        private Button borrar;
        private Button limpiar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
    }
}