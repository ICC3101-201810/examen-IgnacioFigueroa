using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class JuegoForm : Form
    {
        public string jugador;
        public Image pacman;
        public Image fantasmaRosado;
        public Image fantasmaRojo;
        public Image fruta1;
        public Image fruta2;
        public Graphics pacmanGraf;
        public Graphics fantasmaRosadoGraf;
        public Graphics fantasmaRojoGraf;
        public event EventHandler OnDibujar;
        public event EventHandler OnMoverArriba;
        public event EventHandler OnMoverAbajo;
        public event EventHandler OnMoverIzquierda;
        public event EventHandler OnMoverDerecha;
        public event EventHandler OnInterseccion;
        public JuegoForm()
        {
            KeyDown += new KeyEventHandler(JuegoForm_KeyDown);
            InitializeComponent();
            pacman = Properties.Resources.pacman_right;
            fantasmaRosado = Properties.Resources.pink_left1;
            fantasmaRojo = Properties.Resources.red_left1;
            fruta1 = Properties.Resources.cherry;
            fruta2 = Properties.Resources.tile114;
            pacmanGraf = CreateGraphics();
            fantasmaRojoGraf = CreateGraphics();
            fantasmaRojoGraf = CreateGraphics();
        }

        private void JuegoForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void JuegoForm_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void JuegoForm_Paint(object sender, PaintEventArgs e)
        {
            OnDibujar(this, EventArgs.Empty);
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void JuegoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                OnMoverDerecha(this, EventArgs.Empty);
                pacmanGraf.Clear(Color.White);
                OnDibujar(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Left)
            {
                OnMoverIzquierda(this, EventArgs.Empty);
                pacmanGraf.Clear(Color.White);
                OnDibujar(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Up)
            {
                OnMoverArriba(this, EventArgs.Empty);
                pacmanGraf.Clear(Color.White);
                OnDibujar(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Down)
            {
                OnMoverAbajo(this, EventArgs.Empty);
                pacmanGraf.Clear(Color.White);
                OnDibujar(this, EventArgs.Empty);
            }
            OnInterseccion(this, EventArgs.Empty);
        }

        private void JuegoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
