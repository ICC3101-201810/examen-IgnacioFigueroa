using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public class Puntaje
    {
        public string jugador;
        public int puntaje;
        public string tiempo;

        public Puntaje(string jugador, int puntaje, string tiempo)
        {
            this.jugador = jugador;
            this.puntaje = puntaje;
            this.tiempo = tiempo;
        }
    }
}
