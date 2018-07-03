using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PacMan
{
    public class JuegoController
    {
        JuegoForm juegoForm;
        Juego juego;

        public JuegoController(JuegoForm juegoForm)
        {
            this.juegoForm = juegoForm;
            juego = new Juego();
            juegoForm.OnDibujar += VistasJuego_OnDibujar;
            juegoForm.OnMoverArriba += VistasJuego_OnMoverArriba;
            juegoForm.OnMoverAbajo += VistasJuego_OnMoverAbajo;
            juegoForm.OnMoverDerecha += VistasJuego_OnMoverDerecha;
            juegoForm.OnMoverIzquierda += VistasJuego_OnMoverIzquierda;
            juegoForm.OnInterseccion += Vistas_Juego_OnInterseccion;
        }

        public void VistasJuego_OnDibujar(object sender, EventArgs e )
        {
            juegoForm.pacmanGraf.DrawImage(juegoForm.pacman, juego.pacMan);
            juegoForm.fantasmaRojoGraf.DrawImage(juegoForm.fantasmaRojo, juego.fantasma1);

        }

        public void VistasJuego_OnMoverArriba(object sender, EventArgs e)
        {
            juego.arriba = true;
            juego.abajo = false;
            juego.derecha = false;
            juego.izquierda = false;
            juego.moverPacMan();
        }

        public void VistasJuego_OnMoverAbajo(object sender, EventArgs e)
        {
            juego.arriba = false;
            juego.abajo = true;
            juego.derecha = false;
            juego.izquierda = false;
            juego.moverPacMan();
        }
        
        public void VistasJuego_OnMoverIzquierda(object sender, EventArgs e)
        {
            juego.arriba = false;
            juego.abajo = false;
            juego.derecha = false;
            juego.izquierda = true;
            juego.moverPacMan();
        }
        public void VistasJuego_OnMoverDerecha(object sender, EventArgs e)
        {
            juego.arriba = false;
            juego.abajo = false;
            juego.derecha = true;
            juego.izquierda = false;
            juego.moverPacMan();
        }
        public void Vistas_Juego_OnInterseccion(object sender, EventArgs e)
        {
            juego.revisarDerrota(juego.pacMan, juego.fantasma1);
            juego.revisarDerrota(juego.pacMan, juego.fantasma2);
            if (juego.derrota == true)
            {
                MessageBox.Show("Perdiste");
                juego.MostrarPuntajes();
            }
        }

        

    }
}
