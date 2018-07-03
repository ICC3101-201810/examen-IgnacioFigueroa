using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PacMan
{
    public class BienvenidaController
    {
        BienvenidaForm bienvenidaForm;

        public BienvenidaController(BienvenidaForm bienvenidaForm)
        {
            this.bienvenidaForm = bienvenidaForm;
            bienvenidaForm.OnIniciarJuego += VistasBienvenida_OnIniciarJuego;
        }

        public void VistasBienvenida_OnIniciarJuego(object sender, IniciarJuegoEventArgs e)
        {
            JuegoForm juegoForm = new JuegoForm();
            JuegoController juegoController = new JuegoController(juegoForm);
            juegoForm.jugador = e.jugador;
            juegoForm.Show();
            
            
        }
    }
}
