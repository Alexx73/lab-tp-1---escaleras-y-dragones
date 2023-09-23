using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tp_1___escaleras_y_dragones
{
    class Jugador
    {
       public ArrayList jugadores = new ArrayList();
        public string Nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public int Posicion { get; set; }
        public int PosicionAnterior { get; set; }
        public int Avance { get; set; }
        public bool Ganador { get; set; }

        public Jugador(string nombre) 
        {
            Nombre = nombre;
        }

        public virtual void Avanzar()
        {

        }



    }
}
