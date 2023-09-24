using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_tp_1___escaleras_y_dragones
{
    public partial class Form1 : Form
    {
        int cabVerdeX = 5;
        int cabVerdeY = 8;

        public Form1()
        {
            InitializeComponent();

            // posicionar picturebox inicial

            // Calcula la nueva posición del PictureBox
            int nuevaX = 3;
            int nuevaY = 5;

           

            // Establece la nueva posición
            pictureBox1.Location = new Point(nuevaX, nuevaY);
            pictureBox1.BackColor = Color.Transparent;

            pBCaballeroVerde.Location = new Point(cabVerdeX, cabVerdeY);
            pBCaballeroVerde.BackColor = Color.Transparent;

            // Tamaño de cada cuadrícula
            int gridSize = 50;

            // Cambia el color de fondo del Panel a rojo
           // panelTablero.BackColor = Color.Red;
            

            // Número de cuadrículas por fila y columna
            int numCols = 10;
            int numRows = 5;

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    // Crear una nueva cuadrícula como un control Panel
                    Panel cuadricula = new Panel
                    {
                        Size = new Size(gridSize, gridSize),
                        Location = new Point(col * gridSize, row * gridSize),
                        BorderStyle = BorderStyle.FixedSingle // Agregar un borde
                    };

                    // Puedes personalizar la apariencia de cada cuadrícula aquí

                    // Agregar la cuadrícula al panel del tablero
                    panelTablero.Controls.Add(cuadricula);
                }
            } // fin Cuadricula

           




        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            // Este metodo mueve al caballero horizontalmente, sumandole 50 a nuevaX

            // Calcula la nueva posición del PictureBox
            int nuevaX = pictureBox1.Left + (50);
            int nuevaY = pictureBox1.Top;

            if (nuevaX >= 450) nuevaX = 450;

            // Establece la nueva posición
            pictureBox1.Location = new Point(nuevaX, nuevaY);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Este metodo mueve al caballero horizontalmente, sumandole 50 a nuevaX

            // Calcula la nueva posición del PictureBox
            cabVerdeX = pBCaballeroVerde.Left + (50);
           

            if (cabVerdeX >= 450) cabVerdeX = 450;

            // Establece la nueva posición
            pBCaballeroVerde.Location = new Point(cabVerdeX,cabVerdeY );

        }
    }
    }

