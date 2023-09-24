
namespace lab_tp_1___escaleras_y_dragones
{
    partial class Form1
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
            this.panelTablero = new System.Windows.Forms.Panel();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pBCaballeroVerde = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBCaballeroVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTablero
            // 
            this.panelTablero.Location = new System.Drawing.Point(2, 12);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.Size = new System.Drawing.Size(750, 346);
            this.panelTablero.TabIndex = 0;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(767, 149);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(100, 42);
            this.btnAvanzar.TabIndex = 1;
            this.btnAvanzar.Text = "Rojo";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pBCaballeroVerde
            // 
            this.pBCaballeroVerde.Image = global::lab_tp_1___escaleras_y_dragones.Properties.Resources.caballero_verde_45px___bg;
            this.pBCaballeroVerde.Location = new System.Drawing.Point(767, 1);
            this.pBCaballeroVerde.Name = "pBCaballeroVerde";
            this.pBCaballeroVerde.Size = new System.Drawing.Size(59, 52);
            this.pBCaballeroVerde.TabIndex = 2;
            this.pBCaballeroVerde.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab_tp_1___escaleras_y_dragones.Properties.Resources.caballero_rojo___60_px__bg;
            this.pictureBox1.Location = new System.Drawing.Point(767, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pBCaballeroVerde);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTablero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBCaballeroVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.PictureBox pBCaballeroVerde;
        private System.Windows.Forms.Button button1;
    }
}

