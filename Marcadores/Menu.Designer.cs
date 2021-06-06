
namespace Marcadores
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonFutbol = new System.Windows.Forms.Button();
            this.buttonBaloncesto = new System.Windows.Forms.Button();
            this.buttonPilota = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFutbol
            // 
            this.buttonFutbol.Location = new System.Drawing.Point(332, 48);
            this.buttonFutbol.Name = "buttonFutbol";
            this.buttonFutbol.Size = new System.Drawing.Size(92, 65);
            this.buttonFutbol.TabIndex = 0;
            this.buttonFutbol.Text = "FUTBOL";
            this.buttonFutbol.UseVisualStyleBackColor = true;
            this.buttonFutbol.Click += new System.EventHandler(this.buttonFutbol_Click);
            // 
            // buttonBaloncesto
            // 
            this.buttonBaloncesto.Location = new System.Drawing.Point(332, 165);
            this.buttonBaloncesto.Name = "buttonBaloncesto";
            this.buttonBaloncesto.Size = new System.Drawing.Size(92, 65);
            this.buttonBaloncesto.TabIndex = 1;
            this.buttonBaloncesto.Text = "BALONCESTO";
            this.buttonBaloncesto.UseVisualStyleBackColor = true;
            this.buttonBaloncesto.Click += new System.EventHandler(this.buttonBaloncesto_Click);
            // 
            // buttonPilota
            // 
            this.buttonPilota.Location = new System.Drawing.Point(332, 278);
            this.buttonPilota.Name = "buttonPilota";
            this.buttonPilota.Size = new System.Drawing.Size(92, 65);
            this.buttonPilota.TabIndex = 2;
            this.buttonPilota.Text = "PILOTA";
            this.buttonPilota.UseVisualStyleBackColor = true;
            this.buttonPilota.Click += new System.EventHandler(this.buttonPilota_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Marcadores.Properties.Resources.cronoMetrop;
            this.pictureBox1.Location = new System.Drawing.Point(353, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 375);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPilota);
            this.Controls.Add(this.buttonBaloncesto);
            this.Controls.Add(this.buttonFutbol);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFutbol;
        private System.Windows.Forms.Button buttonBaloncesto;
        private System.Windows.Forms.Button buttonPilota;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}