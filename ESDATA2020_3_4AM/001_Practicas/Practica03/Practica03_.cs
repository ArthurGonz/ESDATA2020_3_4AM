using _001_Practicas.Practica03;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace _001_Practicas
{
    public partial class Practica03_ : Form
    {
        ClaseArregloDesordenado EquipoDeBeisbol = new ClaseArregloDesordenado(9);
        public Practica03_()
        {
            InitializeComponent();

        }

        private void Practica03__Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseDatos jugador = new ClaseDatos();
            bool verificar = EquipoDeBeisbol.EstaLleno();
            if (!verificar)
            {               
                jugador.Uniforme = Convert.ToUInt16(Uniforme.Text);
                jugador.Nombre = Nombre.Text;
                jugador.Porcentaje = Convert.ToDouble(PorcentajeBateo.Text);
                verificar = EquipoDeBeisbol.Insertar(jugador);
                if (verificar)
                {
                    LlenarDataGridView();
                    MessageBox.Show("jugador insertado en el arreglo:\n " +
                        "Num jugador: " + jugador.Uniforme + 
                        "\n Nombre: " + jugador.Nombre + 
                        "\n % de Bateo: " + jugador.Porcentaje);   
                }
                else
                {
                    MessageBox.Show("Error al insertar datos"); 
                }
            }
            else
            {

                MessageBox.Show("El arreglo esta lleno");
            }
        }

        private void Uniforme_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClaseDatos jugador = EquipoDeBeisbol.Mayor();
            MessageBox.Show("El mejor bateador es:\n Num. Uniforme: " + jugador.Uniforme + 
                "\nNombre: " + jugador.Nombre + 
                "\nPromedio Bateo: " + jugador.Porcentaje);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ushort IndiceEliminar;
            bool valor = ushort.TryParse(Uniforme.Text, out IndiceEliminar);
            if (valor)
            {
                EquipoDeBeisbol.Eliminar(IndiceEliminar);
            }
            else 
            {
                try
                {
                    ushort IndiceEliminarDgv = (ushort)dataGridView1.SelectedRows[0].Cells[0].Value;
                    EquipoDeBeisbol.Eliminar(IndiceEliminarDgv);
                }
                catch (Exception) { }
            }
             LlenarDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EquipoDeBeisbol.Ordenar();
            LlenarDataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
        {     
           MessageBox.Show("Fin de la aplicacion");   
           Application.Exit(); 
        }

        private void LlenarDataGridView()
        {
            ClaseDatos jugador;
            DataTable dt = new DataTable();
            dt.Columns.Add("Uniforme");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Bateo");
            for(int i = 0; i < 9; i++)
            {
                jugador = EquipoDeBeisbol.Consultar(i);

                if(jugador != null)
                dt.Rows.Add(new object[] { jugador.Uniforme, jugador.Nombre, jugador.Porcentaje });
            }

            dataGridView1.DataSource = dt; 
        }
    }
}
