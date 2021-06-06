
namespace Marcadores
{
    partial class Marcador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCrono = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxMinutos = new System.Windows.Forms.TextBox();
            this.separador = new System.Windows.Forms.TextBox();
            this.textBoxSegundos = new System.Windows.Forms.TextBox();
            this.buttonResetCrono = new System.Windows.Forms.Button();
            this.checkBoxCuentAtras = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreEquipoLocal = new System.Windows.Forms.TextBox();
            this.textBoxNombreEquipoVisitante = new System.Windows.Forms.TextBox();
            this.txtBoxMarcadorLocal = new System.Windows.Forms.TextBox();
            this.txtBoxMarcadorVisitante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPilota = new System.Windows.Forms.Panel();
            this.textBoxJuegosVisitante = new System.Windows.Forms.TextBox();
            this.textBoxJuegosLocal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbRetroceder = new System.Windows.Forms.PictureBox();
            this.pbGuardarDirectorio = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxParte = new System.Windows.Forms.TextBox();
            this.panelPilota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetroceder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarDirectorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrono
            // 
            this.btnCrono.Location = new System.Drawing.Point(178, 115);
            this.btnCrono.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrono.Name = "btnCrono";
            this.btnCrono.Size = new System.Drawing.Size(70, 43);
            this.btnCrono.TabIndex = 1;
            this.btnCrono.Text = "START";
            this.btnCrono.UseVisualStyleBackColor = true;
            this.btnCrono.Click += new System.EventHandler(this.btnCrono_Click);
            // 
            // textBoxMinutos
            // 
            this.textBoxMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinutos.Location = new System.Drawing.Point(187, 47);
            this.textBoxMinutos.Name = "textBoxMinutos";
            this.textBoxMinutos.Size = new System.Drawing.Size(49, 53);
            this.textBoxMinutos.TabIndex = 2;
            this.textBoxMinutos.Tag = "Minutos";
            this.textBoxMinutos.Text = "00";
            this.textBoxMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // separador
            // 
            this.separador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separador.Location = new System.Drawing.Point(242, 47);
            this.separador.Name = "separador";
            this.separador.ReadOnly = true;
            this.separador.Size = new System.Drawing.Size(20, 53);
            this.separador.TabIndex = 3;
            this.separador.Text = ":";
            this.separador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSegundos
            // 
            this.textBoxSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSegundos.Location = new System.Drawing.Point(268, 47);
            this.textBoxSegundos.Name = "textBoxSegundos";
            this.textBoxSegundos.Size = new System.Drawing.Size(53, 53);
            this.textBoxSegundos.TabIndex = 4;
            this.textBoxSegundos.Tag = "Segundos";
            this.textBoxSegundos.Text = "00";
            // 
            // buttonResetCrono
            // 
            this.buttonResetCrono.Location = new System.Drawing.Point(253, 115);
            this.buttonResetCrono.Name = "buttonResetCrono";
            this.buttonResetCrono.Size = new System.Drawing.Size(75, 43);
            this.buttonResetCrono.TabIndex = 5;
            this.buttonResetCrono.Text = "RESET";
            this.buttonResetCrono.UseVisualStyleBackColor = true;
            this.buttonResetCrono.Click += new System.EventHandler(this.buttonResetCrono_Click);
            // 
            // checkBoxCuentAtras
            // 
            this.checkBoxCuentAtras.AutoSize = true;
            this.checkBoxCuentAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCuentAtras.Location = new System.Drawing.Point(178, 164);
            this.checkBoxCuentAtras.Name = "checkBoxCuentAtras";
            this.checkBoxCuentAtras.Size = new System.Drawing.Size(146, 29);
            this.checkBoxCuentAtras.TabIndex = 6;
            this.checkBoxCuentAtras.Text = "Cuenta Atrás";
            this.checkBoxCuentAtras.UseVisualStyleBackColor = true;
            this.checkBoxCuentAtras.CheckedChanged += new System.EventHandler(this.checkBoxCuentAtras_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Equipo Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Equipo Visitante";
            // 
            // textBoxNombreEquipoLocal
            // 
            this.textBoxNombreEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreEquipoLocal.Location = new System.Drawing.Point(187, 230);
            this.textBoxNombreEquipoLocal.Name = "textBoxNombreEquipoLocal";
            this.textBoxNombreEquipoLocal.Size = new System.Drawing.Size(53, 30);
            this.textBoxNombreEquipoLocal.TabIndex = 13;
            this.textBoxNombreEquipoLocal.Tag = "NombreLocal";
            this.textBoxNombreEquipoLocal.TextChanged += new System.EventHandler(this.textBoxEscribeFichero_TextChanged);
            // 
            // textBoxNombreEquipoVisitante
            // 
            this.textBoxNombreEquipoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreEquipoVisitante.Location = new System.Drawing.Point(268, 230);
            this.textBoxNombreEquipoVisitante.Name = "textBoxNombreEquipoVisitante";
            this.textBoxNombreEquipoVisitante.Size = new System.Drawing.Size(53, 30);
            this.textBoxNombreEquipoVisitante.TabIndex = 14;
            this.textBoxNombreEquipoVisitante.Tag = "NombreVisitante";
            this.textBoxNombreEquipoVisitante.TextChanged += new System.EventHandler(this.textBoxEscribeFichero_TextChanged);
            // 
            // txtBoxMarcadorLocal
            // 
            this.txtBoxMarcadorLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMarcadorLocal.Location = new System.Drawing.Point(184, 318);
            this.txtBoxMarcadorLocal.Name = "txtBoxMarcadorLocal";
            this.txtBoxMarcadorLocal.Size = new System.Drawing.Size(52, 38);
            this.txtBoxMarcadorLocal.TabIndex = 15;
            this.txtBoxMarcadorLocal.Tag = "MarcadorLocal";
            this.txtBoxMarcadorLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMarcadorLocal.TextChanged += new System.EventHandler(this.textBoxEscribeFichero_TextChanged);
            // 
            // txtBoxMarcadorVisitante
            // 
            this.txtBoxMarcadorVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMarcadorVisitante.Location = new System.Drawing.Point(272, 318);
            this.txtBoxMarcadorVisitante.Name = "txtBoxMarcadorVisitante";
            this.txtBoxMarcadorVisitante.Size = new System.Drawing.Size(52, 38);
            this.txtBoxMarcadorVisitante.TabIndex = 16;
            this.txtBoxMarcadorVisitante.Tag = "MarcadorVisitante";
            this.txtBoxMarcadorVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMarcadorVisitante.TextChanged += new System.EventHandler(this.textBoxEscribeFichero_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "MARCADOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "-";
            // 
            // panelPilota
            // 
            this.panelPilota.Controls.Add(this.textBoxJuegosVisitante);
            this.panelPilota.Controls.Add(this.textBoxJuegosLocal);
            this.panelPilota.Controls.Add(this.label5);
            this.panelPilota.Controls.Add(this.label6);
            this.panelPilota.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPilota.Location = new System.Drawing.Point(0, 429);
            this.panelPilota.Name = "panelPilota";
            this.panelPilota.Size = new System.Drawing.Size(509, 116);
            this.panelPilota.TabIndex = 19;
            this.panelPilota.Visible = false;
            // 
            // textBoxJuegosVisitante
            // 
            this.textBoxJuegosVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJuegosVisitante.Location = new System.Drawing.Point(272, 36);
            this.textBoxJuegosVisitante.Name = "textBoxJuegosVisitante";
            this.textBoxJuegosVisitante.Size = new System.Drawing.Size(52, 38);
            this.textBoxJuegosVisitante.TabIndex = 21;
            this.textBoxJuegosVisitante.Tag = "JuegosVisitante";
            this.textBoxJuegosVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJuegosVisitante.TextChanged += new System.EventHandler(this.textBoxEscribeFichero_TextChanged);
            // 
            // textBoxJuegosLocal
            // 
            this.textBoxJuegosLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJuegosLocal.Location = new System.Drawing.Point(184, 36);
            this.textBoxJuegosLocal.Name = "textBoxJuegosLocal";
            this.textBoxJuegosLocal.Size = new System.Drawing.Size(52, 38);
            this.textBoxJuegosLocal.TabIndex = 20;
            this.textBoxJuegosLocal.Tag = "JuegosLocal";
            this.textBoxJuegosLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJuegosLocal.TextChanged += new System.EventHandler(this.textBoxEscribeFichero_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "JUEGOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "-";
            // 
            // pbRetroceder
            // 
            this.pbRetroceder.Image = global::Marcadores.Properties.Resources.back;
            this.pbRetroceder.Location = new System.Drawing.Point(13, 13);
            this.pbRetroceder.Name = "pbRetroceder";
            this.pbRetroceder.Size = new System.Drawing.Size(37, 33);
            this.pbRetroceder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRetroceder.TabIndex = 20;
            this.pbRetroceder.TabStop = false;
            this.pbRetroceder.Click += new System.EventHandler(this.pbRetroceder_Click);
            // 
            // pbGuardarDirectorio
            // 
            this.pbGuardarDirectorio.Image = global::Marcadores.Properties.Resources.save;
            this.pbGuardarDirectorio.Location = new System.Drawing.Point(56, 13);
            this.pbGuardarDirectorio.Name = "pbGuardarDirectorio";
            this.pbGuardarDirectorio.Size = new System.Drawing.Size(37, 33);
            this.pbGuardarDirectorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardarDirectorio.TabIndex = 23;
            this.pbGuardarDirectorio.TabStop = false;
            this.pbGuardarDirectorio.Click += new System.EventHandler(this.pbGuardarDirectorio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Parte";
            // 
            // textBoxParte
            // 
            this.textBoxParte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParte.Location = new System.Drawing.Point(235, 388);
            this.textBoxParte.Name = "textBoxParte";
            this.textBoxParte.Size = new System.Drawing.Size(38, 35);
            this.textBoxParte.TabIndex = 25;
            this.textBoxParte.Tag = "Parte";
            this.textBoxParte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxParte.TextChanged += new System.EventHandler(this.textBoxEscribeFichero_TextChanged);
            // 
            // Marcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(509, 545);
            this.Controls.Add(this.textBoxParte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbGuardarDirectorio);
            this.Controls.Add(this.pbRetroceder);
            this.Controls.Add(this.panelPilota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxMarcadorVisitante);
            this.Controls.Add(this.txtBoxMarcadorLocal);
            this.Controls.Add(this.textBoxNombreEquipoVisitante);
            this.Controls.Add(this.textBoxNombreEquipoLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxCuentAtras);
            this.Controls.Add(this.buttonResetCrono);
            this.Controls.Add(this.textBoxSegundos);
            this.Controls.Add(this.separador);
            this.Controls.Add(this.textBoxMinutos);
            this.Controls.Add(this.btnCrono);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(525, 584);
            this.MinimumSize = new System.Drawing.Size(525, 584);
            this.Name = "Marcador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Marcador_FormClosing);
            this.panelPilota.ResumeLayout(false);
            this.panelPilota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetroceder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarDirectorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrono;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxMinutos;
        private System.Windows.Forms.TextBox separador;
        private System.Windows.Forms.TextBox textBoxSegundos;
        private System.Windows.Forms.Button buttonResetCrono;
        private System.Windows.Forms.CheckBox checkBoxCuentAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreEquipoLocal;
        private System.Windows.Forms.TextBox textBoxNombreEquipoVisitante;
        private System.Windows.Forms.TextBox txtBoxMarcadorLocal;
        private System.Windows.Forms.TextBox txtBoxMarcadorVisitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelPilota;
        private System.Windows.Forms.TextBox textBoxJuegosVisitante;
        private System.Windows.Forms.TextBox textBoxJuegosLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbRetroceder;
        private System.Windows.Forms.PictureBox pbGuardarDirectorio;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxParte;
    }
}

