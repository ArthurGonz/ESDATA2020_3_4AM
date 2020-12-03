namespace _003eListasDoblesEjercicioFerrocarril
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_otro = new System.Windows.Forms.TextBox();
            this.RB_otro = new System.Windows.Forms.RadioButton();
            this.RB_model = new System.Windows.Forms.RadioButton();
            this.RB_jaula = new System.Windows.Forms.RadioButton();
            this.RB_plataforma = new System.Windows.Forms.RadioButton();
            this.RB_tolva = new System.Windows.Forms.RadioButton();
            this.RB_vagonCerrado = new System.Windows.Forms.RadioButton();
            this.RB_portaAutos = new System.Windows.Forms.RadioButton();
            this.RB_pasajeros = new System.Windows.Forms.RadioButton();
            this.RB_locomotora = new System.Windows.Forms.RadioButton();
            this.TB_propietario = new System.Windows.Forms.TextBox();
            this.TB_matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_agregar = new System.Windows.Forms.Button();
            this.B_eliminar = new System.Windows.Forms.Button();
            this.B_principio = new System.Windows.Forms.Button();
            this.B_final = new System.Windows.Forms.Button();
            this.B_buscar = new System.Windows.Forms.Button();
            this.B_salir = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.PB_vagon = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_vagon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TB_propietario);
            this.groupBox1.Controls.Add(this.TB_matricula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(469, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de vagones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_otro);
            this.groupBox2.Controls.Add(this.RB_otro);
            this.groupBox2.Controls.Add(this.RB_model);
            this.groupBox2.Controls.Add(this.RB_jaula);
            this.groupBox2.Controls.Add(this.RB_plataforma);
            this.groupBox2.Controls.Add(this.RB_tolva);
            this.groupBox2.Controls.Add(this.RB_vagonCerrado);
            this.groupBox2.Controls.Add(this.RB_portaAutos);
            this.groupBox2.Controls.Add(this.RB_pasajeros);
            this.groupBox2.Controls.Add(this.RB_locomotora);
            this.groupBox2.Location = new System.Drawing.Point(16, 127);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(439, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // TB_otro
            // 
            this.TB_otro.Location = new System.Drawing.Point(317, 74);
            this.TB_otro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_otro.Name = "TB_otro";
            this.TB_otro.Size = new System.Drawing.Size(112, 22);
            this.TB_otro.TabIndex = 9;
            // 
            // RB_otro
            // 
            this.RB_otro.AutoSize = true;
            this.RB_otro.Location = new System.Drawing.Point(253, 76);
            this.RB_otro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_otro.Name = "RB_otro";
            this.RB_otro.Size = new System.Drawing.Size(57, 21);
            this.RB_otro.TabIndex = 8;
            this.RB_otro.TabStop = true;
            this.RB_otro.Text = "Otro";
            this.RB_otro.UseVisualStyleBackColor = true;
            this.RB_otro.CheckedChanged += new System.EventHandler(this.RB_otro_CheckedChanged);
            // 
            // RB_model
            // 
            this.RB_model.AutoSize = true;
            this.RB_model.Location = new System.Drawing.Point(253, 49);
            this.RB_model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_model.Name = "RB_model";
            this.RB_model.Size = new System.Drawing.Size(67, 21);
            this.RB_model.TabIndex = 7;
            this.RB_model.TabStop = true;
            this.RB_model.Text = "Model";
            this.RB_model.UseVisualStyleBackColor = true;
            // 
            // RB_jaula
            // 
            this.RB_jaula.AutoSize = true;
            this.RB_jaula.Location = new System.Drawing.Point(253, 23);
            this.RB_jaula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_jaula.Name = "RB_jaula";
            this.RB_jaula.Size = new System.Drawing.Size(63, 21);
            this.RB_jaula.TabIndex = 6;
            this.RB_jaula.TabStop = true;
            this.RB_jaula.Text = "Jaula";
            this.RB_jaula.UseVisualStyleBackColor = true;
            // 
            // RB_plataforma
            // 
            this.RB_plataforma.AutoSize = true;
            this.RB_plataforma.Location = new System.Drawing.Point(123, 76);
            this.RB_plataforma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_plataforma.Name = "RB_plataforma";
            this.RB_plataforma.Size = new System.Drawing.Size(97, 21);
            this.RB_plataforma.TabIndex = 5;
            this.RB_plataforma.TabStop = true;
            this.RB_plataforma.Text = "Plataforma";
            this.RB_plataforma.UseVisualStyleBackColor = true;
            // 
            // RB_tolva
            // 
            this.RB_tolva.AutoSize = true;
            this.RB_tolva.Location = new System.Drawing.Point(123, 49);
            this.RB_tolva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_tolva.Name = "RB_tolva";
            this.RB_tolva.Size = new System.Drawing.Size(64, 21);
            this.RB_tolva.TabIndex = 4;
            this.RB_tolva.TabStop = true;
            this.RB_tolva.Text = "Tolva";
            this.RB_tolva.UseVisualStyleBackColor = true;
            // 
            // RB_vagonCerrado
            // 
            this.RB_vagonCerrado.AutoSize = true;
            this.RB_vagonCerrado.Location = new System.Drawing.Point(123, 23);
            this.RB_vagonCerrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_vagonCerrado.Name = "RB_vagonCerrado";
            this.RB_vagonCerrado.Size = new System.Drawing.Size(125, 21);
            this.RB_vagonCerrado.TabIndex = 3;
            this.RB_vagonCerrado.TabStop = true;
            this.RB_vagonCerrado.Text = "Vagon Cerrado";
            this.RB_vagonCerrado.UseVisualStyleBackColor = true;
            // 
            // RB_portaAutos
            // 
            this.RB_portaAutos.AutoSize = true;
            this.RB_portaAutos.Location = new System.Drawing.Point(7, 75);
            this.RB_portaAutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_portaAutos.Name = "RB_portaAutos";
            this.RB_portaAutos.Size = new System.Drawing.Size(92, 21);
            this.RB_portaAutos.TabIndex = 2;
            this.RB_portaAutos.TabStop = true;
            this.RB_portaAutos.Text = "PortaAuto";
            this.RB_portaAutos.UseVisualStyleBackColor = true;
            // 
            // RB_pasajeros
            // 
            this.RB_pasajeros.AutoSize = true;
            this.RB_pasajeros.Location = new System.Drawing.Point(7, 48);
            this.RB_pasajeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_pasajeros.Name = "RB_pasajeros";
            this.RB_pasajeros.Size = new System.Drawing.Size(92, 21);
            this.RB_pasajeros.TabIndex = 1;
            this.RB_pasajeros.TabStop = true;
            this.RB_pasajeros.Text = "Pasajeros";
            this.RB_pasajeros.UseVisualStyleBackColor = true;
            // 
            // RB_locomotora
            // 
            this.RB_locomotora.AutoSize = true;
            this.RB_locomotora.Location = new System.Drawing.Point(7, 22);
            this.RB_locomotora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_locomotora.Name = "RB_locomotora";
            this.RB_locomotora.Size = new System.Drawing.Size(104, 21);
            this.RB_locomotora.TabIndex = 0;
            this.RB_locomotora.TabStop = true;
            this.RB_locomotora.Text = "Locomotora";
            this.RB_locomotora.UseVisualStyleBackColor = true;
            // 
            // TB_propietario
            // 
            this.TB_propietario.Location = new System.Drawing.Point(97, 86);
            this.TB_propietario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_propietario.Name = "TB_propietario";
            this.TB_propietario.Size = new System.Drawing.Size(283, 22);
            this.TB_propietario.TabIndex = 3;
            // 
            // TB_matricula
            // 
            this.TB_matricula.Location = new System.Drawing.Point(97, 41);
            this.TB_matricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_matricula.Name = "TB_matricula";
            this.TB_matricula.Size = new System.Drawing.Size(167, 22);
            this.TB_matricula.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propietario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // B_agregar
            // 
            this.B_agregar.Location = new System.Drawing.Point(511, 12);
            this.B_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_agregar.Name = "B_agregar";
            this.B_agregar.Size = new System.Drawing.Size(87, 25);
            this.B_agregar.TabIndex = 1;
            this.B_agregar.Text = "Agregar";
            this.B_agregar.UseVisualStyleBackColor = true;
            this.B_agregar.Click += new System.EventHandler(this.B_agregar_Click);
            // 
            // B_eliminar
            // 
            this.B_eliminar.Location = new System.Drawing.Point(511, 43);
            this.B_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_eliminar.Name = "B_eliminar";
            this.B_eliminar.Size = new System.Drawing.Size(87, 25);
            this.B_eliminar.TabIndex = 2;
            this.B_eliminar.Text = "Eliminar";
            this.B_eliminar.UseVisualStyleBackColor = true;
            this.B_eliminar.Click += new System.EventHandler(this.B_eliminar_Click);
            // 
            // B_principio
            // 
            this.B_principio.Location = new System.Drawing.Point(511, 74);
            this.B_principio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_principio.Name = "B_principio";
            this.B_principio.Size = new System.Drawing.Size(87, 59);
            this.B_principio.TabIndex = 3;
            this.B_principio.Text = "Mostrar desde principio";
            this.B_principio.UseVisualStyleBackColor = true;
            this.B_principio.Click += new System.EventHandler(this.B_principio_Click);
            // 
            // B_final
            // 
            this.B_final.Location = new System.Drawing.Point(511, 139);
            this.B_final.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_final.Name = "B_final";
            this.B_final.Size = new System.Drawing.Size(87, 46);
            this.B_final.TabIndex = 4;
            this.B_final.Text = "Mostrar Final";
            this.B_final.UseVisualStyleBackColor = true;
            this.B_final.Click += new System.EventHandler(this.B_final_Click);
            // 
            // B_buscar
            // 
            this.B_buscar.Location = new System.Drawing.Point(511, 191);
            this.B_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_buscar.Name = "B_buscar";
            this.B_buscar.Size = new System.Drawing.Size(87, 46);
            this.B_buscar.TabIndex = 5;
            this.B_buscar.Text = "Buscar vagon";
            this.B_buscar.UseVisualStyleBackColor = true;
            this.B_buscar.Click += new System.EventHandler(this.B_buscar_Click);
            // 
            // B_salir
            // 
            this.B_salir.Location = new System.Drawing.Point(511, 242);
            this.B_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_salir.Name = "B_salir";
            this.B_salir.Size = new System.Drawing.Size(87, 23);
            this.B_salir.TabIndex = 6;
            this.B_salir.Text = "Salir";
            this.B_salir.UseVisualStyleBackColor = true;
            this.B_salir.Click += new System.EventHandler(this.B_salir_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(27, 288);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(399, 150);
            this.DGV.TabIndex = 7;
            // 
            // PB_vagon
            // 
            this.PB_vagon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PB_vagon.InitialImage = null;
            this.PB_vagon.Location = new System.Drawing.Point(431, 288);
            this.PB_vagon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_vagon.Name = "PB_vagon";
            this.PB_vagon.Size = new System.Drawing.Size(168, 150);
            this.PB_vagon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_vagon.TabIndex = 9;
            this.PB_vagon.TabStop = false;
            this.PB_vagon.WaitOnLoad = true;
            this.PB_vagon.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.PB_vagon);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.B_salir);
            this.Controls.Add(this.B_buscar);
            this.Controls.Add(this.B_final);
            this.Controls.Add(this.B_principio);
            this.Controls.Add(this.B_eliminar);
            this.Controls.Add(this.B_agregar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_vagon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_otro;
        private System.Windows.Forms.RadioButton RB_otro;
        private System.Windows.Forms.RadioButton RB_model;
        private System.Windows.Forms.RadioButton RB_jaula;
        private System.Windows.Forms.RadioButton RB_plataforma;
        private System.Windows.Forms.RadioButton RB_tolva;
        private System.Windows.Forms.RadioButton RB_vagonCerrado;
        private System.Windows.Forms.RadioButton RB_portaAutos;
        private System.Windows.Forms.RadioButton RB_pasajeros;
        private System.Windows.Forms.RadioButton RB_locomotora;
        private System.Windows.Forms.TextBox TB_propietario;
        private System.Windows.Forms.TextBox TB_matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_agregar;
        private System.Windows.Forms.Button B_eliminar;
        private System.Windows.Forms.Button B_principio;
        private System.Windows.Forms.Button B_final;
        private System.Windows.Forms.Button B_buscar;
        private System.Windows.Forms.Button B_salir;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.PictureBox PB_vagon;
    }
}

