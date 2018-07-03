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

    public partial class BienvenidaForm : Form
    {
        public event EventHandler<IniciarJuegoEventArgs> OnIniciarJuego;
        public BienvenidaForm()
        {
            InitializeComponent();
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            IniciarJuegoEventArgs iniciarJuegoEventArgs = new IniciarJuegoEventArgs();
            if (NombreTB.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario");
                return;
            }

            iniciarJuegoEventArgs.jugador = NombreTB.Text;
            OnIniciarJuego(this, iniciarJuegoEventArgs);
            Hide();
        }
    }
}
