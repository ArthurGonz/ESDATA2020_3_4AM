using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001Practica5_3_5_3
{
    public partial class Form1 : Form
    {
        ClaseArregloOrdenadoDescendente ArregloOrdenadoDescendente = 
        new ClaseArregloOrdenadoDescendente(9);

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ushort Matricula;
            int calificacion;
            ClaseDatos estudiante = new ClaseDatos();
            bool verificarMat,verificarCalif;
            bool verificar = ArregloOrdenadoDescendente.EstaLleno();
            if (!verificar)
            {
                verificarMat = ushort.TryParse(NumMatriculaTb.Text, out Matricula);
                verificarCalif = int.TryParse(CalificacionTb.Text, out calificacion);
                if (verificarMat)
                {
                    if (verificarCalif)
                    {
                        estudiante.NumeroMatricula = Matricula;
                        estudiante.Nombre = NombreTb.Text;
                        estudiante.Calificacion = calificacion;

                        verificar = ArregloOrdenadoDescendente.Insertar(estudiante);
                        if (verificar)
                        {
                            LlenarDGV();
                            MessageBox.Show("Estudiante insertado en el arreglo:" +
                                "\n Num. Matricula: " + estudiante.NumeroMatricula +
                                "\n Nombre: " + estudiante.Nombre +
                                "\n Calificacion: " + estudiante.Calificacion);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El tipo de dato de calificacion no es correcto");
                    }
                }
                else
                {
                    MessageBox.Show("La matricula no puede ser registrada");
                }
            }
            else{
                MessageBox.Show("El arreglo esta Lleno");
            }

        }


        private void LlenarDGV()
        {
            ClaseDatos estudiante;
            DataTable Dt = new DataTable();
            Dt.Columns.Add("Matricula");
            Dt.Columns.Add("Nombre");
            Dt.Columns.Add("Calificacion");
            for(int i = 0; i < 9; i++)
            {
                estudiante = ArregloOrdenadoDescendente.Consultar(i);
                if (estudiante != null)
                    Dt.Rows.Add(new object[] {estudiante.NumeroMatricula, estudiante.Nombre,estudiante.Calificacion });
            }
            dataGridView1.DataSource = Dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ushort IndiceEliminar;
            bool valor = ushort.TryParse(NumMatriculaTb.Text, out IndiceEliminar);
            if (valor)
            {
                ArregloOrdenadoDescendente.Eliminar(IndiceEliminar);
            }
            else
            {
                try
                {
                    ushort IndiceEliminarDgv = (ushort)dataGridView1.SelectedRows[0].Cells[0].Value;
                    ArregloOrdenadoDescendente.Eliminar(IndiceEliminarDgv);
                }
                catch (Exception) {  }
            }
            LlenarDGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool verificar;
            verificar = ArregloOrdenadoDescendente.EstaVacio();
            if (!verificar)
            {
                double Promedio = ArregloOrdenadoDescendente.CalcularPromedio();
                MessageBox.Show("El Promedio es: " + Promedio);
            }
            else
            {
                MessageBox.Show("El arreglo esta vacio");
            }
            
        }
    }
}
