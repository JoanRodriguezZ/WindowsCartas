
namespace WindowsCartas
{
    partial class CartasWindow
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
            this.labelNumCartas = new System.Windows.Forms.Label();
            this.btnCrearBaraja = new System.Windows.Forms.Button();
            this.btnRobarCarta = new System.Windows.Forms.Button();
            this.btnBarajar = new System.Windows.Forms.Button();
            this.btnCogerCartaRandom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCartaEspecifica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCogerCarta = new System.Windows.Forms.Button();
            this.labelCarta = new System.Windows.Forms.Label();
            this.listBoxCartasBaraja = new System.Windows.Forms.ListBox();
            this.labelCartaElegida = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumCartas
            // 
            this.labelNumCartas.AutoSize = true;
            this.labelNumCartas.Location = new System.Drawing.Point(107, 100);
            this.labelNumCartas.Name = "labelNumCartas";
            this.labelNumCartas.Size = new System.Drawing.Size(175, 17);
            this.labelNumCartas.TabIndex = 0;
            this.labelNumCartas.Text = "No hay cartas en la baraja";
            this.labelNumCartas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCrearBaraja
            // 
            this.btnCrearBaraja.Location = new System.Drawing.Point(110, 12);
            this.btnCrearBaraja.Name = "btnCrearBaraja";
            this.btnCrearBaraja.Size = new System.Drawing.Size(172, 58);
            this.btnCrearBaraja.TabIndex = 1;
            this.btnCrearBaraja.Text = "Crear baraja";
            this.btnCrearBaraja.UseVisualStyleBackColor = true;
            this.btnCrearBaraja.Click += new System.EventHandler(this.btnCrearBaraja_Click);
            // 
            // btnRobarCarta
            // 
            this.btnRobarCarta.Location = new System.Drawing.Point(59, 236);
            this.btnRobarCarta.Name = "btnRobarCarta";
            this.btnRobarCarta.Size = new System.Drawing.Size(120, 44);
            this.btnRobarCarta.TabIndex = 2;
            this.btnRobarCarta.Text = "Robar 1a carta";
            this.btnRobarCarta.UseVisualStyleBackColor = true;
            this.btnRobarCarta.Click += new System.EventHandler(this.btnRobarCarta_Click);
            // 
            // btnBarajar
            // 
            this.btnBarajar.Location = new System.Drawing.Point(132, 150);
            this.btnBarajar.Name = "btnBarajar";
            this.btnBarajar.Size = new System.Drawing.Size(120, 42);
            this.btnBarajar.TabIndex = 3;
            this.btnBarajar.Text = "Barajar";
            this.btnBarajar.UseVisualStyleBackColor = true;
            this.btnBarajar.Click += new System.EventHandler(this.btnBarajar_Click);
            // 
            // btnCogerCartaRandom
            // 
            this.btnCogerCartaRandom.Location = new System.Drawing.Point(213, 236);
            this.btnCogerCartaRandom.Name = "btnCogerCartaRandom";
            this.btnCogerCartaRandom.Size = new System.Drawing.Size(127, 44);
            this.btnCogerCartaRandom.TabIndex = 4;
            this.btnCogerCartaRandom.Text = "Coger carta aleatoria";
            this.btnCogerCartaRandom.UseVisualStyleBackColor = true;
            this.btnCogerCartaRandom.Click += new System.EventHandler(this.btnCogerCartaRandom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCogerCarta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCartaEspecifica);
            this.groupBox1.Location = new System.Drawing.Point(41, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBoxCartaEspecifica
            // 
            this.textBoxCartaEspecifica.Location = new System.Drawing.Point(172, 17);
            this.textBoxCartaEspecifica.Name = "textBoxCartaEspecifica";
            this.textBoxCartaEspecifica.Size = new System.Drawing.Size(51, 22);
            this.textBoxCartaEspecifica.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posicion carta";
            // 
            // btnCogerCarta
            // 
            this.btnCogerCarta.Location = new System.Drawing.Point(91, 45);
            this.btnCogerCarta.Name = "btnCogerCarta";
            this.btnCogerCarta.Size = new System.Drawing.Size(120, 37);
            this.btnCogerCarta.TabIndex = 2;
            this.btnCogerCarta.Text = "Coger carta";
            this.btnCogerCarta.UseVisualStyleBackColor = true;
            this.btnCogerCarta.Click += new System.EventHandler(this.btnCogerCarta_Click);
            // 
            // labelCarta
            // 
            this.labelCarta.AutoSize = true;
            this.labelCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelCarta.Location = new System.Drawing.Point(90, 451);
            this.labelCarta.Name = "labelCarta";
            this.labelCarta.Size = new System.Drawing.Size(58, 24);
            this.labelCarta.TabIndex = 6;
            this.labelCarta.Text = "Carta:";
            // 
            // listBoxCartasBaraja
            // 
            this.listBoxCartasBaraja.FormattingEnabled = true;
            this.listBoxCartasBaraja.ItemHeight = 16;
            this.listBoxCartasBaraja.Location = new System.Drawing.Point(384, 24);
            this.listBoxCartasBaraja.Name = "listBoxCartasBaraja";
            this.listBoxCartasBaraja.Size = new System.Drawing.Size(254, 436);
            this.listBoxCartasBaraja.TabIndex = 7;
            // 
            // labelCartaElegida
            // 
            this.labelCartaElegida.AutoSize = true;
            this.labelCartaElegida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelCartaElegida.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelCartaElegida.Location = new System.Drawing.Point(147, 451);
            this.labelCartaElegida.Name = "labelCartaElegida";
            this.labelCartaElegida.Size = new System.Drawing.Size(0, 24);
            this.labelCartaElegida.TabIndex = 8;
            // 
            // CartasWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 531);
            this.Controls.Add(this.labelCartaElegida);
            this.Controls.Add(this.listBoxCartasBaraja);
            this.Controls.Add(this.labelCarta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCogerCartaRandom);
            this.Controls.Add(this.btnBarajar);
            this.Controls.Add(this.btnRobarCarta);
            this.Controls.Add(this.btnCrearBaraja);
            this.Controls.Add(this.labelNumCartas);
            this.Name = "CartasWindow";
            this.Text = "Cartas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumCartas;
        private System.Windows.Forms.Button btnCrearBaraja;
        private System.Windows.Forms.Button btnRobarCarta;
        private System.Windows.Forms.Button btnBarajar;
        private System.Windows.Forms.Button btnCogerCartaRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCartaEspecifica;
        private System.Windows.Forms.Button btnCogerCarta;
        private System.Windows.Forms.Label labelCarta;
        private System.Windows.Forms.ListBox listBoxCartasBaraja;
        private System.Windows.Forms.Label labelCartaElegida;
    }
}

