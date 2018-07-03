using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PacMan
{
    class PacMan 
    {
        bool Estado;
        public int posX;
        public int posY;
        int ancho;
        int largo;

        public PacMan()
        {
            Estado = true;
            ancho = 46;
            largo = 46;
            posX = 500-ancho/2 ;
            posY = 1000 - largo / 2;
        }
    }
}
