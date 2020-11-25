using System;

namespace _003Practica9_6_7_6_2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Estudiante = new System.Windows.Forms.DataGridView();
            this.BT_BorrarEstudiante = new System.Windows.Forms.Button();
            this.BT_AgregarEstudiante = new System.Windows.Forms.Button();
            this.TB_Promedio = new System.Windows.Forms.TextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Matricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_Libros = new System.Windows.Forms.DataGridView();
            this.Tb_BorrarLibro = new System.Windows.Forms.Button();
            this.BT_AgregarLibro = new System.Windows.Forms.Button();
            this.TB_Autor = new System.Windows.Forms.TextBox();
            this.TB_Titulo = new System.Windows.Forms.TextBox();
            this.TB_ISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_Salir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estudiante)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(467, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Estudiante);
            this.groupBox1.Controls.Add(this.BT_BorrarEstudiante);
            this.groupBox1.Controls.Add(this.BT_AgregarEstudiante);
            this.groupBox1.Controls.Add(this.TB_Promedio);
            this.groupBox1.Controls.Add(this.TB_Nombre);
            this.groupBox1.Controls.Add(this.TB_Matricula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DGV_Estudiante
            // 
            this.DGV_Estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Estudiante.Location = new System.Drawing.Point(26, 149);
            this.DGV_Estudiante.Name = "DGV_Estudiante";
            this.DGV_Estudiante.RowHeadersWidth = 51;
            this.DGV_Estudiante.RowTemplate.Height = 24;
            this.DGV_Estudiante.Size = new System.Drawing.Size(382, 131);
            this.DGV_Estudiante.TabIndex = 8;
            this.DGV_Estudiante.UseWaitCursor = true;
            // 
            // BT_BorrarEstudiante
            // 
            this.BT_BorrarEstudiante.Location = new System.Drawing.Point(325, 77);
            this.BT_BorrarEstudiante.Name = "BT_BorrarEstudiante";
            this.BT_BorrarEstudiante.Size = new System.Drawing.Size(83, 48);
            this.BT_BorrarEstudiante.TabIndex = 7;
            this.BT_BorrarEstudiante.Text = "Borrar";
            this.BT_BorrarEstudiante.UseVisualStyleBackColor = true;
            this.BT_BorrarEstudiante.Click += new System.EventHandler(this.BT_BorrarEstudiante_Click);
            // 
            // BT_AgregarEstudiante
            // 
            this.BT_AgregarEstudiante.Location = new System.Drawing.Point(325, 21);
            this.BT_AgregarEstudiante.Name = "BT_AgregarEstudiante";
            this.BT_AgregarEstudiante.Size = new System.Drawing.Size(83, 50);
            this.BT_AgregarEstudiante.TabIndex = 6;
            this.BT_AgregarEstudiante.Text = "Agregar a la cola";
            this.BT_AgregarEstudiante.UseVisualStyleBackColor = true;
            this.BT_AgregarEstudiante.Click += new System.EventHandler(this.BT_AgregarEstudiante_Click);
            // 
            // TB_Promedio
            // 
            this.TB_Promedio.Location = new System.Drawing.Point(116, 89);
            this.TB_Promedio.Name = "TB_Promedio";
            this.TB_Promedio.Size = new System.Drawing.Size(50, 22);
            this.TB_Promedio.TabIndex = 5;
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(116, 59);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(153, 22);
            this.TB_Nombre.TabIndex = 4;
            // 
            // TB_Matricula
            // 
            this.TB_Matricula.Location = new System.Drawing.Point(116, 31);
            this.TB_Matricula.Name = "TB_Matricula";
            this.TB_Matricula.Size = new System.Drawing.Size(97, 22);
            this.TB_Matricula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Promedio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num Matricula";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_Libros);
            this.groupBox2.Controls.Add(this.Tb_BorrarLibro);
            this.groupBox2.Controls.Add(this.BT_AgregarLibro);
            this.groupBox2.Controls.Add(this.TB_Autor);
            this.groupBox2.Controls.Add(this.TB_Titulo);
            this.groupBox2.Controls.Add(this.TB_ISBN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(18, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libros";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DGV_Libros
            // 
            this.DGV_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Libros.Location = new System.Drawing.Point(31, 149);
            this.DGV_Libros.Name = "DGV_Libros";
            this.DGV_Libros.RowHeadersWidth = 51;
            this.DGV_Libros.RowTemplate.Height = 24;
            this.DGV_Libros.Size = new System.Drawing.Size(377, 131);
            this.DGV_Libros.TabIndex = 8;
            // 
            // Tb_BorrarLibro
            // 
            this.Tb_BorrarLibro.Location = new System.Drawing.Point(325, 77);
            this.Tb_BorrarLibro.Name = "Tb_BorrarLibro";
            this.Tb_BorrarLibro.Size = new System.Drawing.Size(83, 48);
            this.Tb_BorrarLibro.TabIndex = 7;
            this.Tb_BorrarLibro.Text = "Borrar";
            this.Tb_BorrarLibro.UseVisualStyleBackColor = true;
            this.Tb_BorrarLibro.Click += new System.EventHandler(this.Tb_BorrarLibro_Click);
            // 
            // BT_AgregarLibro
            // 
            this.BT_AgregarLibro.Location = new System.Drawing.Point(325, 21);
            this.BT_AgregarLibro.Name = "BT_AgregarLibro";
            this.BT_AgregarLibro.Size = new System.Drawing.Size(83, 50);
            this.BT_AgregarLibro.TabIndex = 6;
            this.BT_AgregarLibro.Text = "Agregar a la cola";
            this.BT_AgregarLibro.UseVisualStyleBackColor = true;
            this.BT_AgregarLibro.Click += new System.EventHandler(this.BT_AgregarLibro_Click);
            // 
            // TB_Autor
            // 
            this.TB_Autor.Location = new System.Drawing.Point(77, 90);
            this.TB_Autor.Name = "TB_Autor";
            this.TB_Autor.Size = new System.Drawing.Size(165, 22);
            this.TB_Autor.TabIndex = 5;
            // 
            // TB_Titulo
            // 
            this.TB_Titulo.Location = new System.Drawing.Point(77, 59);
            this.TB_Titulo.Name = "TB_Titulo";
            this.TB_Titulo.Size = new System.Drawing.Size(228, 22);
            this.TB_Titulo.TabIndex = 4;
            // 
            // TB_ISBN
            // 
            this.TB_ISBN.Location = new System.Drawing.Point(77, 31);
            this.TB_ISBN.Name = "TB_ISBN";
            this.TB_ISBN.Size = new System.Drawing.Size(97, 22);
            this.TB_ISBN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "ISBN";
            // 
            // BT_Salir
            // 
            this.BT_Salir.Location = new System.Drawing.Point(419, 389);
            this.BT_Salir.Name = "BT_Salir";
            this.BT_Salir.Size = new System.Drawing.Size(76, 39);
            this.BT_Salir.TabIndex = 1;
            this.BT_Salir.Text = "Salir";
            this.BT_Salir.UseVisualStyleBackColor = true;
            this.BT_Salir.Click += new System.EventHandler(this.BT_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 431);
            this.Controls.Add(this.BT_Salir);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estudiante)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Libros)).EndInit();
            this.ResumeLayout(false);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Estudiante;
        private System.Windows.Forms.Button BT_BorrarEstudiante;
        private System.Windows.Forms.Button BT_AgregarEstudiante;
        private System.Windows.Forms.TextBox TB_Promedio;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Matricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Salir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_Libros;
        private System.Windows.Forms.Button Tb_BorrarLibro;
        private System.Windows.Forms.Button BT_AgregarLibro;
        private System.Windows.Forms.TextBox TB_Autor;
        private System.Windows.Forms.TextBox TB_Titulo;
        private System.Windows.Forms.TextBox TB_ISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

