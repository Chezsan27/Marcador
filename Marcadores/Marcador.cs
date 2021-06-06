using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Marcadores
{
    public partial class Marcador : Form
    {
        #region Variables
        private Menu menu;
        private EscribirFichero escribir;
        Cronometro crono;
        Button[,] botonesMarcadorLocal = new Button[3,2];
        Button[,] botonesMarcadorVisitante = new Button[3,2];
        #endregion
        #region CONSTRUCTORES
        public Marcador(Menu menu, bool pilota)
        {
            InitializeComponent();
            escribir = new EscribirFichero();
            this.menu = menu;
            
            crono = new Cronometro(timer1, textBoxMinutos, textBoxSegundos);
            instanciaBotonesCronometro("minutos", 106);
            instanciaBotonesCronometro("segundos", 327);
            
            instanciaBotonesMarcador("local", 22, botonesMarcadorLocal);
            instanciaBotonesMarcador("visitante", 343, botonesMarcadorVisitante);
            ocultaBotonesSobrantes(botonesMarcadorLocal);
            ocultaBotonesSobrantes(botonesMarcadorVisitante);
            if (pilota)
            {
                iniciaValoresBotonesPilota();
                
            }
            iniciarValoresTextBox();
        }
        public Marcador(Menu menu, String minutos)
        {
            InitializeComponent();
            escribir = new EscribirFichero();
            this.menu = menu;
            textBoxMinutos.Text = minutos;

            crono = new Cronometro(timer1, textBoxMinutos, textBoxSegundos);
            checkBoxCuentAtras.Checked = true;
            instanciaBotonesCronometro("minutos", 106);
            instanciaBotonesCronometro("segundos", 327);
            instanciaBotonesMarcador("local", 22, botonesMarcadorLocal);
            instanciaBotonesMarcador("visitante", 343, botonesMarcadorVisitante);
            iniciarValoresTextBox();
        }
        #endregion
        #region INICIALIZA VALORES
        private void iniciarValoresTextBox()
        {
            iniciarValoresNombreEquipos();
            iniciaValoresMarcador();
            iniciaValoresJuegos();
            textBoxParte.Text = "1";
        }
        private void iniciarValoresNombreEquipos()
        {
           
            textBoxNombreEquipoLocal.Text = "LOC";
            textBoxNombreEquipoVisitante.Text = "VIS";
        }
        private void iniciaValoresMarcador()
        {
            txtBoxMarcadorLocal.Text = "0";
            txtBoxMarcadorVisitante.Text = "0";
        }
        private void iniciaValoresJuegos()
        {
            textBoxJuegosLocal.Text = "0";
            textBoxJuegosVisitante.Text = "0";
        }
        
        private void iniciaValoresBotonesPilota()
        {
            
            botonesMarcadorLocal[0, 0].Text = "+15";
            botonesMarcadorLocal[0, 1].Text = "-15";
            botonesMarcadorVisitante[0, 0].Text = "+15";
            botonesMarcadorVisitante[0, 1].Text = "-15";
            panelPilota.Visible = true;
        }
        #endregion
        #region BOTONES MARCADOR
        private void instanciaBotonesMarcador(String tag, int posicionX, Button[,] botonesMarcador)
        {
            String signo = "";
            int correccionPosicion = 0;
            int posicionY = 323;
            for (int x = 0; x < botonesMarcador.GetLength(0); x++)
            {
                for (int y = 0; y < botonesMarcador.GetLength(1); y++)
                {
                    if (y==1)
                    {
                        signo = "-";
                        correccionPosicion = 75;
                    }
                    else
                    {
                        signo = "+";
                        correccionPosicion = 0;
                    }
                    botonesMarcador[x, y] = new Button
                    {
                        Width = 75,
                        Height = 50,
                        Visible = true,
                        Tag = tag,
                        Text = signo + (x + 1),
                        Top = posicionY + (50 * x) + 10,
                        Left = posicionX + correccionPosicion,
                        BackColor = SystemColors.ControlLightLight
                };
                    Controls.Add(botonesMarcador[x, y]);
                    botonesMarcador[x, y].Click += new EventHandler(botonMarcadorPulsado);
                    
                }
                   
                
            }
        }
        private void ocultaBotonesSobrantes(Button[,] botonesMarcador)
        {
            for (int i = 1; i < botonesMarcador.GetLength(0); i++)
            {
                for (int y = 0; y < botonesMarcador.GetLength(1); y++)
                {
                    botonesMarcador[i, y].Visible = false;
                }
            }
        }
        private void botonMarcadorPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (boton.Tag.Equals("local"))
            {
                sumaRestaPunto(boton, txtBoxMarcadorLocal, txtBoxMarcadorVisitante, textBoxJuegosLocal);
            }
            else
            {
                sumaRestaPunto(boton, txtBoxMarcadorVisitante, txtBoxMarcadorLocal, textBoxJuegosVisitante);
            }
        }
        private void sumaRestaPunto(Button boton, TextBox marcadorLocal, TextBox marcadorVisitante, TextBox juegosLocal)
        {
            int valorBoton = Convert.ToInt32(boton.Text);
            if (marcadorLocal.Text.Equals("VAL"))
            {
                if (valorBoton > 0)
                {
                    marcadorLocal.Text = "0";
                    marcadorVisitante.Text = "0";
                    int numJuegosLocal = Convert.ToInt32(juegosLocal.Text) + 5;

                    juegosLocal.Text = "" + numJuegosLocal;
                }
                else
                {
                    marcadorLocal.Text = "30";
                }

            }
            else
            {
                try
                {
                    int numMarcadorLocal = Convert.ToInt32(marcadorLocal.Text);
                    int total = numMarcadorLocal + valorBoton;
                    if (panelPilota.Visible && total == 45)
                    {
                        marcadorLocal.Text = "VAL";
                    }
                    else
                    {
                        marcadorLocal.Text = "" + total;
                    }
                }
                catch (System.FormatException)
                {

                    MessageBox.Show("Valor no valido");
                }
                

                
            }
        }
        
        
       
        #endregion
        #region CONTROL CRONOMETRO
        private void instanciaBotonesCronometro(String tag, int posicionY)
        {
            String signo = "";          
            int posicionX = 47;
            
                for (int y = 0; y < 2; y++)
                {
                    if (y == 1)
                    {
                        signo = "-";
                        
                    }
                    else
                    {
                        signo = "+";
                       
                    }
                    Button boton = new Button
                    {
                        Width = 75,
                        Height = 23,
                        Visible = true,
                        Tag = tag,
                        Text = signo + "1",
                        Top = posicionX + (30 * y),
                        Left = posicionY,
                        BackColor = SystemColors.ControlLightLight
                    };
                    Controls.Add(boton);
                    boton.Click += new EventHandler(sumaRestaTiempo);

                }
        }

        private void sumaRestaTiempo(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int valorBoton = Convert.ToInt32(boton.Text);
            int segundos = Convert.ToInt32(textBoxSegundos.Text);
            int minutos = Convert.ToInt32(textBoxMinutos.Text);
            if (boton.Tag.Equals("minutos"))
            {
                crono.pintaTiempo(minutos + valorBoton, segundos);
            }
            else
            {
                crono.pintaTiempo(minutos, segundos + valorBoton);
            }
        }

        private void btnCrono_Click(object sender, EventArgs e)
        {
            if (crono.Activado)
            {
                crono.desactiva();
                btnCrono.Text = "START";               
            }
            else
            {
                crono.activa();
                btnCrono.Text = "PAUSA";                               
            } 
        }

        private void buttonResetCrono_Click(object sender, EventArgs e)
        {
            crono.desactiva();
            textBoxMinutos.Text = crono.pintaNumFormato(crono.ResetMinuto);
            textBoxSegundos.Text = crono.pintaNumFormato(crono.ResetSegundo);
            btnCrono.Text = "START";
            
        }

        private void checkBoxCuentAtras_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCuentAtras.Checked)
            {
                crono.CuentAtras = true;
            }
            else
            {
                crono.CuentAtras = false;
            }
        }

        #endregion
        #region Ficheros
        private void textBoxEscribeFichero_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            escribir.escribirFichero(textBox.Tag+".txt", textBox.Text);
        }

        private void pbRetroceder_Click(object sender, EventArgs e)
        {
            menu.oculto = false;
            menu.Show();
            this.Close();       
        }
       
        private void pbGuardarDirectorio_Click(object sender, EventArgs e)
        {
            string rutaDestino = "";
            string rutaOrigen = escribir.RutaGuardado;
            DialogResult resultado = folderBrowserDialog.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                
                rutaDestino = folderBrowserDialog.SelectedPath + @"\";
                moverFicheros(rutaOrigen, rutaDestino);
                establecerRutaGuardado(rutaDestino);
               
            }
        }
        private void moverFicheros(string rutaOrigen, string rutaDestino)
        {
            try
            {
                File.Move(rutaOrigen + "JuegosLocal.txt", rutaDestino + "JuegosLocal.txt");
                File.Move(rutaOrigen + "JuegosVisitante.txt", rutaDestino + "JuegosVisitante.txt");
                File.Move(rutaOrigen + "MarcadorLocal.txt", rutaDestino + "MarcadorLocal.txt");
                File.Move(rutaOrigen + "MarcadorVisitante.txt", rutaDestino + "MarcadorVisitante.txt");
                File.Move(rutaOrigen + "NombreLocal.txt", rutaDestino + "NombreLocal.txt");
                File.Move(rutaOrigen + "NombreVisitante.txt", rutaDestino + "NombreVisitante.txt");
                File.Move(rutaOrigen + "Tiempo.txt", rutaDestino + "Tiempo.txt");
                File.Move(rutaOrigen + "Parte.txt", rutaDestino + "Parte.txt");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("No se ha encontrado algun fichero al moverlo al nuevo directorio");
                MessageBox.Show("Introduce valores diferentes para volver a crearlos");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Los archivos ya existen el destino, pero se vuelve a establecer esta ruta como predeterminada");
            }  
        }
        private void establecerRutaGuardado(string rutaAbsoluta)
        {
            escribir.RutaGuardado = rutaAbsoluta;
            crono.Escribir.RutaGuardado = rutaAbsoluta;
            escribir.escribirCambioRuta(rutaAbsoluta);
        }
        #endregion
        private void Marcador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (menu.oculto)
            {
                Application.Exit();
            }
        }
    }
}