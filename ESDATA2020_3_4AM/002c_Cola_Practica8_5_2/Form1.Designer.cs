namespace _002c_Cola_Practica8_5_2
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
            this.CB_Movimiento = new System.Windows.Forms.ComboBox();
            this.TB_Cliente = new System.Windows.Forms.TextBox();
            this.TB_Turno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Turno = new System.Windows.Forms.Label();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.BT_Atender = new System.Windows.Forms.Button();
            this.BT_Salida = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Frente = new System.Windows.Forms.TextBox();
            this.TB_Final = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Movimiento);
            this.groupBox1.Controls.Add(this.TB_Cliente);
            this.groupBox1.Controls.Add(this.TB_Turno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Turno);
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CB_Movimiento
            // 
            this.CB_Movimiento.FormattingEnabled = true;
            this.CB_Movimiento.Items.AddRange(new object[] {
            "Pago de servicios",
            "Deposito",
            "Retiro",
            "Compra de tiempo aire o consulta de saldo"});
            this.CB_Movimiento.Location = new System.Drawing.Point(103, 130);
            this.CB_Movimiento.Name = "CB_Movimiento";
            this.CB_Movimiento.Size = new System.Drawing.Size(290, 24);
            this.CB_Movimiento.TabIndex = 5;
            // 
            // TB_Cliente
            // 
            this.TB_Cliente.Location = new System.Drawing.Point(103, 81);
            this.TB_Cliente.Name = "TB_Cliente";
            this.TB_Cliente.Size = new System.Drawing.Size(229, 22);
            this.TB_Cliente.TabIndex = 4;
            // 
            // TB_Turno
            // 
            this.TB_Turno.Location = new System.Drawing.Point(103, 38);
            this.TB_Turno.Name = "TB_Turno";
            this.TB_Turno.Size = new System.Drawing.Size(229, 22);
            this.TB_Turno.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // Turno
            // 
            this.Turno.AutoSize = true;
            this.Turno.Location = new System.Drawing.Point(18, 38);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(46, 17);
            this.Turno.TabIndex = 0;
            this.Turno.Text = "Turno";
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.Location = new System.Drawing.Point(534, 39);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(90, 42);
            this.BT_Agregar.TabIndex = 1;
            this.BT_Agregar.Text = "Agregar ";
            this.BT_Agregar.UseVisualStyleBackColor = true;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // BT_Atender
            // 
            this.BT_Atender.Location = new System.Drawing.Point(534, 95);
            this.BT_Atender.Name = "BT_Atender";
            this.BT_Atender.Size = new System.Drawing.Size(90, 46);
            this.BT_Atender.TabIndex = 2;
            this.BT_Atender.Text = "Atender";
            this.BT_Atender.UseVisualStyleBackColor = true;
            this.BT_Atender.Click += new System.EventHandler(this.BT_Atender_Click);
            // 
            // BT_Salida
            // 
            this.BT_Salida.Location = new System.Drawing.Point(534, 155);
            this.BT_Salida.Name = "BT_Salida";
            this.BT_Salida.Size = new System.Drawing.Size(90, 48);
            this.BT_Salida.TabIndex = 3;
            this.BT_Salida.Text = "Salir";
            this.BT_Salida.UseVisualStyleBackColor = true;
            this.BT_Salida.Click += new System.EventHandler(this.BT_Salida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Frente";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Final";
            // 
            // TB_Frente
            // 
            this.TB_Frente.Enabled = false;
            this.TB_Frente.Location = new System.Drawing.Point(109, 222);
            this.TB_Frente.Name = "TB_Frente";
            this.TB_Frente.Size = new System.Drawing.Size(100, 22);
            this.TB_Frente.TabIndex = 6;
            // 
            // TB_Final
            // 
            this.TB_Final.Enabled = false;
            this.TB_Final.Location = new System.Drawing.Point(109, 262);
            this.TB_Final.Name = "TB_Final";
            this.TB_Final.Size = new System.Drawing.Size(100, 22);
            this.TB_Final.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 191);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TB_Final);
            this.Controls.Add(this.TB_Frente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_Salida);
            this.Controls.Add(this.BT_Atender);
            this.Controls.Add(this.BT_Agregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_Movimiento;
        private System.Windows.Forms.TextBox TB_Cliente;
        private System.Windows.Forms.TextBox TB_Turno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Turno;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.Button BT_Atender;
        private System.Windows.Forms.Button BT_Salida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Frente;
        private System.Windows.Forms.TextBox TB_Final;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

