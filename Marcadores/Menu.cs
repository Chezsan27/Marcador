using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcadores
{
    public partial class Menu : Form
    {
        public bool oculto;
        public Menu()
        {
            InitializeComponent();
            oculto = false;
        }

        private void buttonFutbol_Click(object sender, EventArgs e)
        {
            Marcador mFutbol = new Marcador(this, false);
            mFutbol.Show();
            this.Hide();
            oculto = true;
        }
        private void buttonBaloncesto_Click(object sender, EventArgs e)
        {
            Marcador mBaloncesto = new Marcador(this, "10");
            mBaloncesto.Show();
            this.Hide();
            oculto = true;
        }
        private void buttonPilota_Click(object sender, EventArgs e)
        {
            Marcador mPilota = new Marcador(this, true);
            
            mPilota.Show();
            this.Hide();
            oculto = true;
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        
    }
}
