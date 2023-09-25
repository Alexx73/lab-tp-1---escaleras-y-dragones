
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
            this.pbDragonRojo = new System.Windows.Forms.PictureBox();
            this.pBCaballeroVerde = new System.Windows.Forms.PictureBox();
            this.pbCaballeroRojo = new System.Windows.Forms.PictureBox();
            this.pbDragonVerde = new System.Windows.Forms.PictureBox();
            this.pbDragonVerde2 = new System.Windows.Forms.PictureBox();
            this.pbDragonRojo2 = new System.Windows.Forms.PictureBox();
            this.panelTablero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragonRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCaballeroVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragonVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragonVerde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragonRojo2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTablero
            // 
            this.panelTablero.Controls.Add(this.pbDragonRojo2);
            this.panelTablero.Controls.Add(this.pbDragonVerde2);
            this.panelTablero.Controls.Add(this.pbDragonVerde);
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
            // pbDragonRojo
            // 
            this.pbDragonRojo.Image = global::lab_tp_1___escaleras_y_dragones.Properties.Resources.dragon_rojo_60x60_bg;
            this.pbDragonRojo.Location = new System.Drawing.Point(767, 308);
            this.pbDragonRojo.Name = "pbDragonRojo";
            this.pbDragonRojo.Size = new System.Drawing.Size(50, 50);
            this.pbDragonRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDragonRojo.TabIndex = 4;
            this.pbDragonRojo.TabStop = false;
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
            // pbCaballeroRojo
            // 
            this.pbCaballeroRojo.Image = global::lab_tp_1___escaleras_y_dragones.Properties.Resources.caballero_rojo___60_px__bg;
            this.pbCaballeroRojo.Location = new System.Drawing.Point(767, 59);
            this.pbCaballeroRojo.Name = "pbCaballeroRojo";
            this.pbCaballeroRojo.Size = new System.Drawing.Size(59, 50);
            this.pbCaballeroRojo.TabIndex = 0;
            this.pbCaballeroRojo.TabStop = false;
            // 
            // pbDragonVerde
            // 
            this.pbDragonVerde.Image = global::lab_tp_1___escaleras_y_dragones.Properties.Resources.dragon_verde_60x60_bg;
            this.pbDragonVerde.Location = new System.Drawing.Point(580, 201);
            this.pbDragonVerde.Name = "pbDragonVerde";
            this.pbDragonVerde.Size = new System.Drawing.Size(50, 50);
            this.pbDragonVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDragonVerde.TabIndex = 5;
            this.pbDragonVerde.TabStop = false;
            // 
            // pbDragonVerde2
            // 
            this.pbDragonVerde2.Image = global::lab_tp_1___escaleras_y_dragones.Properties.Resources.dragon_verde_60x60_bg;
            this.pbDragonVerde2.Location = new System.Drawing.Point(611, 3);
            this.pbDragonVerde2.Name = "pbDragonVerde2";
            this.pbDragonVerde2.Size = new System.Drawing.Size(50, 50);
            this.pbDragonVerde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDragonVerde2.TabIndex = 6;
            this.pbDragonVerde2.TabStop = false;
            // 
            // pbDragonRojo2
            // 
            this.pbDragonRojo2.Image = global::lab_tp_1___escaleras_y_dragones.Properties.Resources.dragon_rojo_60x60_bg;
            this.pbDragonRojo2.Location = new System.Drawing.Point(337, 64);
            this.pbDragonRojo2.Name = "pbDragonRojo2";
            this.pbDragonRojo2.Size = new System.Drawing.Size(50, 50);
            this.pbDragonRojo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDragonRojo2.TabIndex = 7;
            this.pbDragonRojo2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 461);
            this.Controls.Add(this.pbDragonRojo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pBCaballeroVerde);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.pbCaballeroRojo);
            this.Controls.Add(this.panelTablero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTablero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDragonRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCaballeroVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragonVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragonVerde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragonRojo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.PictureBox pbCaballeroRojo;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.PictureBox pBCaballeroVerde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbDragonRojo;
        private System.Windows.Forms.PictureBox pbDragonVerde;
        private System.Windows.Forms.PictureBox pbDragonRojo2;
        private System.Windows.Forms.PictureBox pbDragonVerde2;
    }
}

