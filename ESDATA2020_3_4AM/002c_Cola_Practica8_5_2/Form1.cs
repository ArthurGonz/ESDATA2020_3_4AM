using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace _002c_Cola_Practica8_5_2
{
    public partial class Form1 : Form
    {

        ClaseCola Cola = new ClaseCola(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            bool validar;
            ClaseNodo Nodo = new ClaseNodo();
            validar = Cola.EstaLlena();
            if (!validar)
            {
                Nodo.NoTurno = int.Parse(TB_Turno.Text);
                Nodo.Nombre = TB_Cliente.Text;
                Nodo.TipoMovimiento = CB_Movimiento.Text;
                Nodo.HoraLlegada = DateTime.Now;

                validar = Cola.Encolar(Nodo);
                if (validar)
                {
                    TB_Frente.Text = Cola.Frente.ToString();
                    TB_Final.Text = Cola.Final.ToString();
                    MessageBox.Show("No. Turno: " + Nodo.NoTurno +
                        "\nCliente: " + Nodo.Nombre +
                        "\nTipo de movimiento: " + Nodo.TipoMovimiento +
                        "\nHora de entrada: " + Nodo.HoraLlegada);
                }
            }
            else
                MessageBox.Show("El arreglo esta lleno");
            MostrarDataGridView();
        }

        private void MostrarDataGridView()
        {
            ClaseNodo Nodo;
            DataTable Dt = new DataTable();
            Dt.Columns.Add("No. Turno");
            Dt.Columns.Add("Cliente");
            Dt.Columns.Add("Tipo Movimiento");
            Dt.Columns.Add("Hora llegada");
            for (int i = 0; i < 10; i++)
            {
                Nodo = Cola.Consultar(i);
                if (Nodo != null)
                    Dt.Rows.Add(new object[] { Nodo.NoTurno, Nodo.Nombre, Nodo.TipoMovimiento, Nodo.HoraLlegada });
            }
            dataGridView1.DataSource = Dt;
        }

        private void BT_Atender_Click(object sender, EventArgs e)
        {
            bool validar;
            ClaseNodo Nodo = new ClaseNodo();
            validar = Cola.EstaVacia();
            if (!validar)
            {
                Nodo.HoraLlegada = DateTime.Now;
                Nodo = Cola.Desencolar();
                TB_Frente.Text = Cola.Frente.ToString();
                TB_Final.Text = Cola.Final.ToString();
                MessageBox.Show("No. Turno: " + Nodo.NoTurno +
                       "\nCliente: " + Nodo.Nombre +
                       "\nTipo de movimiento: " + Nodo.TipoMovimiento +
                       "\nHora de Salida: " + Nodo.HoraLlegada);
            }

            MostrarDataGridView();
        }

        private void BT_Salida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fin de la aplicacion, vuelva pronto");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
