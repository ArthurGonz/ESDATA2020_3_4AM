using System;


namespace _002c_Cola_Practica8_5_2
{
    class ClaseNodo
    {
        private int noturno;
        private string nombre;
        private string tipomovimiento;
        private DateTime horallegada;
        // Propiedades
        public int NoTurno
        {
            get{ return noturno; }
            set{ noturno = value; }
        }
        public string Nombre
        {
            get{ return nombre; }
            set{ nombre = value; }
        }
        public string TipoMovimiento
        {
            get{ return tipomovimiento; }
            set{ tipomovimiento = value; }
        }
        public DateTime HoraLlegada
        {
            get{ return horallegada; }
            set{ horallegada = value; }
        }
    }
}

