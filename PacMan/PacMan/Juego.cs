using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace PacMan
{
    [Serializable()]
    public class Juego
    {
        public bool arriba;
        public bool abajo;
        public bool izquierda;
        public bool derecha;
        public bool derrota;
        public int puntos;
        public Rectangle pacMan;
        public Rectangle fantasma1;
        public Rectangle fantasma2;
        public Rectangle fruta1;
        public Rectangle fruta2;
        List<Puntaje> puntajes;

        public Juego()
        {
            derrota = false;
            puntos = 0;
            Random random = new Random();
            this.arriba = false;
            this.abajo = false;
            this.izquierda = false;
            this.derecha = false;
            pacMan = new Rectangle(350, 300, 45, 45);
            fantasma1 = new Rectangle(random.Next(0, 700), random.Next(0,600), 45, 45);
            fantasma2 = new Rectangle(random.Next(0, 700), random.Next(0,600), 45, 45);
            fruta1 = new Rectangle(0, 0, 45, 45);
            fruta2 = new Rectangle(0, 0, 45, 45);

        }

        public bool revisarDerrota(Rectangle pacman,Rectangle fantasma)
        {
            if (pacMan.IntersectsWith(fantasma))
            {
                derrota = true;
                return true;
            }
            return false;
        }
        public bool revisarFrutaComida(Rectangle pacMan, Rectangle fruta)
        {
            if (pacMan.IntersectsWith(fruta))
            {
                puntos += 10; // Todas las frutas valen lo mismo
                return true;
            }
            return false;
        }

        public void moverPacMan()
        {
            if (arriba)
            {
                this.pacMan.Y -= 2;
            }
            else if (abajo)
            {
                this.pacMan.Y += 2;
            }
            else if (izquierda)
            {
                this.pacMan.X -= 2;
            }
            else if (derecha)
            {
                this.pacMan.X += 2;
            }
        }
        
        public void AnadirPuntaje(string jugador, int puntaje, string tiempo)
        {
            puntajes.Add(new Puntaje(jugador, puntaje, tiempo));
        }

        public void MostrarPuntajes()
        {
            List<Puntaje> puntajesOrdenados = new List<Puntaje>();
            try
            {
                puntajesOrdenados = puntajes.OrderBy(x => x.puntaje).ToList();
            }
            catch { }
            string mostrar = "Puntajes: \n";
            foreach(Puntaje p in puntajesOrdenados)
            {
                mostrar += p.jugador + p.puntaje.ToString() + p.tiempo + "\n";
            }
            System.Windows.Forms.MessageBox.Show(mostrar);

        }

        public void SerializeAll()
        {
            try
            {
                using (Stream stream = File.Open("puntajesData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter usuariosData = new BinaryFormatter();
                    usuariosData.Serialize(stream, puntajes);
                }
            }
            catch (IOException) { }

        }



    }
}
