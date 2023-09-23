using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tp_1___escaleras_y_dragones
{
    class Partida
    {


        public readonly string Ganador;
        

        public  readonly int  Ganadas;
        
       public Partida(string Ganador, int Ganadas)
        {
            this.Ganador = Ganador;
            this.Ganadas = Ganadas;
        }
    }
}
