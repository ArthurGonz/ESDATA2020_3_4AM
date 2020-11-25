using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003Practica9_6_7_6_2
{
    public partial class Form1 : Form
    {
        ClaseListaSimpleOrdenada<ClaseDatosEstudiante<int>> ListaEstudiantes = 
            new ClaseListaSimpleOrdenada<ClaseDatosEstudiante<int>>();

        ClaseListaSimpleOrdenada<ClaseDatosLibro<string>> ListaLibros = 
            new ClaseListaSimpleOrdenada<ClaseDatosLibro<string>>();
        public Form1()
        {
            InitializeComponent();
            MostrarDGV1();
            MostrarDGV2();
        }

        private void BT_AgregarEstudiante_Click(object sender, EventArgs e)
        {
            ClaseDatosEstudiante<int> Estudiante = new ClaseDatosEstudiante<int>();
            try
            {
                Estudiante.NumeroMatricula = int.Parse(TB_Matricula.Text);
                Estudiante.Nombre = TB_Nombre.Text;
                Estudiante.Promedio = double.Parse(TB_Promedio.Text);
                try
                {
                    ListaEstudiantes.Insertar(Estudiante);
                    MessageBox.Show("Num Matricula: " + Estudiante.NumeroMatricula +
                    "\nNombre: " + Estudiante.Nombre +
                    "\nPromedio: " + Estudiante.Promedio);
                }
                catch (Exception) { MessageBox.Show("Elemento repetido"); }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos");
            }
            
            MostrarDGV1();
        }

        private DataTable CrearDGV1()
        {
            DataTable Dt1 = new DataTable();
            Dt1.Columns.Add("Num.\nMatricula");
            Dt1.Columns.Add("Nombre");
            Dt1.Columns.Add("Promedio");
            return Dt1;
        }

        private void MostrarDGV1()
        {
            DataTable Dt1 = CrearDGV1();
            ClaseDatosEstudiante<int> Estudiantes = new ClaseDatosEstudiante<int>();
            foreach (var DGVestudiantes in ListaEstudiantes)
            {

                Estudiantes = ListaEstudiantes.Buscar(DGVestudiantes);
                if (Estudiantes != null)
                    Dt1.Rows.Add(new object[] {Estudiantes.NumeroMatricula, Estudiantes.Nombre, Estudiantes.Promedio });     
            }
            DGV_Estudiante.DataSource = Dt1;
        }

        private DataTable CrearDGV2()
        {
            DataTable Dt2 = new DataTable();
            Dt2.Columns.Add("ISBN");
            Dt2.Columns.Add("Titulo");
            Dt2.Columns.Add("Autor");
            return Dt2;
        }

        private void MostrarDGV2()
        {
            DataTable Dt2 = CrearDGV2();
            ClaseDatosLibro<string> Libro = new ClaseDatosLibro<string>();
            foreach (var DGVLibros in ListaLibros)
            {

                Libro = ListaLibros.Buscar(DGVLibros);
                if (Libro != null)
                    Dt2.Rows.Add(new object[] {Libro.ISBN, Libro.Titulo, Libro.Autor});
            }
            DGV_Libros.DataSource = Dt2;
        }

        private void BT_AgregarLibro_Click(object sender, EventArgs e)
        {
            ClaseDatosLibro<string> Libro = new ClaseDatosLibro<string>();
            try
            {
                Libro.ISBN = TB_ISBN.Text;
                Libro.Autor = TB_Autor.Text;
                Libro.Titulo = TB_Titulo.Text;
                try
                {
                    ListaLibros.Insertar(Libro);
                }
                catch (Exception)
                { MessageBox.Show("Elemento repetido"); }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos");
            }
           
            
            MessageBox.Show("ISBN: " + Libro.ISBN +
                "\nTitulo: " + Libro.Titulo +
                "\nAutor: " + Libro.Autor) ;

            MostrarDGV2();
        }

        private void BT_BorrarEstudiante_Click(object sender, EventArgs e)
        {
            bool verificar;       
            ClaseDatosEstudiante<int> Estudiante = new ClaseDatosEstudiante<int>();

            verificar = ListaEstudiantes.EstaVacia();
            if (!verificar)
            {
                try
                {
                    Estudiante.NumeroMatricula = int.Parse(TB_Matricula.Text);
                    var resultado = MessageBox.Show("Seguro que deseas eliminar el estudiante con num. Matricula "
                        + Estudiante.NumeroMatricula + "?","Confirme operacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ListaEstudiantes.Eliminar(Estudiante);
                        MostrarDGV1();
                        MessageBox.Show("Estudiante Eliminado");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar el estudiante");
                }
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
        }

        private void Tb_BorrarLibro_Click(object sender, EventArgs e)
        {
            bool verificar;
            ClaseDatosLibro<string> libro = new ClaseDatosLibro<string>();

            verificar = ListaLibros.EstaVacia();
            if (!verificar)
            {
                try
                {
                    libro.ISBN = TB_ISBN.Text;
                    var resultado = MessageBox.Show("Seguro que deseas eliminar el libro con el ISBN  "
                        + libro.ISBN + "?", "Confirme operacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ListaLibros.Eliminar(libro);
                        MostrarDGV2();
                        MessageBox.Show("Libro Eliminado");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar el Libro");
                } 
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
        }

        private void BT_Salir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Seguro que desea salir?","Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
   
        }
    }
}
