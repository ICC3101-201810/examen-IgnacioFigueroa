using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public class IniciarJuegoEventArgs : EventArgs
    {
        public string jugador;

        public IniciarJuegoEventArgs()
        {
            this.jugador = jugador;
        }
    }
}
