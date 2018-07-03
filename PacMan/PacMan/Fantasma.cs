using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class Fantasma
    {
        public int posX;
        public int posY;
        int ancho;
        int largo;

        public Fantasma(int posX, int posY)
        {
            ancho = 46;
            largo = 46;
            this.posX = posX;
            this.posY = posY;
        }
    }
}
