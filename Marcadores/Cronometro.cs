using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcadores
{
    class Cronometro
    {
        private int minutos;
        private int segundos;
        private Timer temporizador;
        private TextBox textBoxMinutos;
        private TextBox textBoxSegundos;
        private bool cuentAtras;
        private int resetMinuto;
        private int resetSegundo;
        private EscribirFichero escribir;
        public bool CuentAtras { get => cuentAtras; set => cuentAtras = value; }
        public bool Activado { get => temporizador.Enabled;}
        public int ResetMinuto { get => resetMinuto; }
        public int ResetSegundo { get => resetSegundo; }
        internal EscribirFichero Escribir { get => escribir;}
        #region CONSTRUCTOR
        public Cronometro(Timer temporizador, TextBox textBoxMinutos, TextBox textBoxSegundos)
        {
            this.temporizador = temporizador;
            this.textBoxMinutos = textBoxMinutos;
            this.textBoxSegundos = textBoxSegundos;
            estableceEventos(temporizador, textBoxMinutos, textBoxSegundos);

            this.cuentAtras = false;

            this.minutos = Convert.ToInt32(textBoxMinutos.Text);
            this.segundos = Convert.ToInt32(textBoxSegundos.Text);
            this.resetMinuto = minutos;
            this.resetSegundo = segundos;

            escribir = new EscribirFichero();
            escribir.escribirFichero("Tiempo.txt", formatoCompletoTiempo());
        }
        #endregion
        #region EVENTOS
        private void estableceEventos(Timer temporizador, TextBox textBoxMinutos, TextBox textBoxSegundos)
        {
            temporizador.Tick += temporizador_Tick;
            textBoxMinutos.TextChanged += textBoxMinutos_TextChanged;
            textBoxSegundos.TextChanged += textBoxSegundos_TextChanged;
        }
        private void textBoxMinutos_TextChanged(object sender, EventArgs e)
        {
            if (!this.Activado)
            {
                try
                {
                    minutos = Convert.ToInt32(textBoxMinutos.Text);
                    resetMinuto = minutos;
                    escribir.escribirFichero("Tiempo.txt", formatoCompletoTiempo());

                }
                catch (FormatException)
                {
                    MessageBox.Show("Introduce un numero valido");
                }


            }
            else
            {
                minutos = Convert.ToInt32(textBoxMinutos.Text);
            }
        }

        private void textBoxSegundos_TextChanged(object sender, EventArgs e)
        {
            if (!this.Activado)
            {
                try
                {
                    segundos = Convert.ToInt32(textBoxSegundos.Text);
                    resetSegundo = segundos;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Introduce un numero valido");
                }
            }
            else
            {
                segundos = Convert.ToInt32(textBoxSegundos.Text);
            }
            escribir.escribirFichero("Tiempo.txt", formatoCompletoTiempo());
        }
        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (cuentAtras)
            {
                restaSegundo(1);
                if (minutos < 0)
                {
                    //pintaTiempo(resetMinuto, resetSegundo);
                    minutos = resetMinuto;
                    segundos = resetSegundo;
                    desactiva();
                   
                }
            }
            else
            {
                sumaSegundo(1);
            }
            
            pintaTiempo(minutos, segundos);
        }

        #endregion
        #region GESTION SEGUNDOS
        private void restaSegundo(int cantidad)
        {
            segundos -= cantidad;
            if (segundos < 0)
            {
                minutos -= cantidad;
                segundos = 59;
            }
        }
        private void sumaSegundo(int cantidad)
        {
            segundos += cantidad;
            if (segundos >= 60)
            {
                minutos += cantidad;
                segundos = 0;
            }
        }
        #endregion
        #region AVTIVA / DESACTIVA
        public void activa()
        {
            temporizador.Interval = 1000;
            temporizador.Enabled = true;
        }
        public void desactiva()
        {
            temporizador.Enabled = false;
        }
        #endregion
        #region FORMATEOS
        public void pintaTiempo(int numMinutos, int numSegundos)
        {
            textBoxMinutos.Text = pintaNumFormato(numMinutos);
            textBoxSegundos.Text = pintaNumFormato(numSegundos);
        }
        public string pintaNumFormato(int num)
        {
            return num < 10 ? "0" + num : "" + num;
        }
    
        private string formatoCompletoTiempo()
        {
            return pintaNumFormato(minutos) + ":" + pintaNumFormato(segundos);
        }
        #endregion
    }
}
