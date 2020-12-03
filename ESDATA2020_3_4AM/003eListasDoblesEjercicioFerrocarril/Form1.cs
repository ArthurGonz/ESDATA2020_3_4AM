using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003eListasDoblesEjercicioFerrocarril
{
    public partial class Form1 : Form
    {
        static ClaseListaDobleDesordenada<ClaseNodoListaDoble> ferrocarril = 
            new ClaseListaDobleDesordenada<ClaseNodoListaDoble>();
        static ClaseNodoListaDoble nodo = new ClaseNodoListaDoble();
        public Form1()
        {
            //Pagina 290
            InitializeComponent();
            TB_otro.Enabled = false;
            Image vagones = Image.FromFile("Vagon.jpg");
            PB_vagon.Image = vagones;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void MostrarDGVDesdeInicio()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Matricula");
            dt.Columns.Add("Propietario");
            dt.Columns.Add("Tipo");
            foreach (var DGV in ferrocarril.DesdeNodoInicial)
            {
                nodo = ferrocarril.Buscar(DGV);
                if (nodo != null)
                    dt.Rows.Add(new object[] {nodo.Matricula, nodo.Propietario,nodo.Tipo});
            }
            DGV.DataSource = dt;
        }

        public void MostrarDGVDesdeFinal()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Matricula");
            dt.Columns.Add("Propietario");
            dt.Columns.Add("Tipo");
            foreach (var DGV in ferrocarril.DesdeNodoFinal)
            {
                nodo = ferrocarril.Buscar(DGV);
                if (nodo != null)
                    dt.Rows.Add(new object[] { nodo.Matricula, nodo.Propietario, nodo.Tipo });
            }
            DGV.DataSource = dt;
        }

        private void B_agregar_Click(object sender, EventArgs e)
        {
            nodo = new ClaseNodoListaDoble();
            nodo.Matricula = TB_matricula.Text;
            nodo.Propietario = TB_propietario.Text;
            Tipo();
            ferrocarril.Insertar(nodo);
            MostrarDGVDesdeInicio();
        }

        public void Tipo()
        {
            if (RB_locomotora.Checked == true)
            {
                //usando 2 lineas para insertar imagen
                nodo.Tipo = RB_locomotora.Text;
                Image locomotora = Image.FromFile("Locomotora.jpg");
                PB_vagon.Image = locomotora;
                nodo.ArchivoImagen = "Locomotora.jpg";
            }
                

            if (RB_pasajeros.Checked == true)
            {
                nodo.Tipo = RB_pasajeros.Text;
                PB_vagon.Image = Image.FromFile("Pasajeros.jpg");
                nodo.ArchivoImagen = "Pasajeros.jpg";

            }

            if (RB_portaAutos.Checked == true)
            {
                nodo.Tipo = RB_portaAutos.Text;
                PB_vagon.Image = Image.FromFile("portaAutos.jpg");
                nodo.ArchivoImagen = "portaAutos.jpg";
            }

            if (RB_vagonCerrado.Checked == true)
            {
                nodo.Tipo = RB_vagonCerrado.Text;
                PB_vagon.Image = Image.FromFile("Cerrado.jpg");
                nodo.ArchivoImagen = "Cerrado.jpg";
            }

            if (RB_tolva.Checked == true)
            {
                nodo.Tipo = RB_tolva.Text;
                PB_vagon.Image = Image.FromFile("Tolva.jpg");
                nodo.ArchivoImagen = "Tolva.jpg";
            }

            if (RB_plataforma.Checked == true)
            {
                nodo.Tipo = RB_tolva.Text;
                PB_vagon.Image = Image.FromFile("Plataforma.jpg");
                nodo.ArchivoImagen = "Plataforma.jpg";
            }


            if (RB_jaula.Checked == true)
            {
                nodo.Tipo = RB_jaula.Text;
                PB_vagon.Image = Image.FromFile("Jaula.jpg");
                nodo.ArchivoImagen = "Jaula.jpg";
            }

            if(RB_otro.Checked == true)
            {
                nodo.Tipo = TB_otro.Text;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();
                string image = openFileDialog1.FileName;
                PB_vagon.Image = Image.FromFile(image);
                nodo.ArchivoImagen = image;
            }
               
        }

        private void B_principio_Click(object sender, EventArgs e)
        {
            MostrarDGVDesdeInicio();
        }

        private void B_final_Click(object sender, EventArgs e)
        {
            MostrarDGVDesdeFinal();
        }

        private void RB_otro_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_otro.Checked == true)
                TB_otro.Enabled = true;
            else
            {
                TB_otro.Enabled = false;
                TB_otro.Text = "";
            }
                
        }

        private void B_eliminar_Click(object sender, EventArgs e)
        {
            if (!ferrocarril.EstaVacia())
            {
                nodo = new ClaseNodoListaDoble();
                nodo.Matricula = TB_matricula.Text;
                var resultado = MessageBox.Show("Seguro que deseas eliminar el vagon con num. Matricula "
                         + nodo.Matricula + "?", "Confirme operacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ferrocarril.Eliminar(nodo);
                    MostrarDGVDesdeInicio();
                    MessageBox.Show("Vagon Eliminado");
                }
            }
            MessageBox.Show("No hay valores"); 
        }

        private void B_salir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void B_buscar_Click(object sender, EventArgs e)
        {
            nodo = new ClaseNodoListaDoble();
            nodo.Matricula = TB_matricula.Text;
            nodo = ferrocarril.Buscar(nodo);
            PB_vagon.Image = Image.FromFile(nodo.ArchivoImagen);
            MessageBox.Show("Matricula: " + nodo.Matricula 
                + "\nPropietario:" + nodo.Propietario
                + "\nTipo:" + nodo.Tipo);
        }
    }
}
