using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{




    public partial class Miprimeraplicacion : Form
    {
        public Miprimeraplicacion()
        {
            InitializeComponent();
        }

        private void Miprimeraplicacion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a c#");
        }

        private void Miprimeraplicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau...Chauu");
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola soy Microsoft..");
            //this.BackColor = Color.Blue;
            //MouseEventArgs click = (MouseEventArgs)e;

            //if (click.Button == MouseButtons.Left)
            //{
              //  MessageBox.Show("Presiono el boton Izquierdo.");
            //}else if (click.Button == MouseButtons.Right)
            //{
              //  MessageBox.Show("Presiono el boton Derecho.");
            //}else if(click.Button== MouseButtons.Middle)
            //{
              //  MessageBox.Show("Presiono el boton del medio.");
            //}
            if(Texto.Text == "")
            {
                Texto.BackColor = Color.Red;
            }
            else
            {
                Texto.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void etiqueta1_MouseMove(object sender, MouseEventArgs e)
        {
            etiqueta1.BackColor = Color.Cyan;
            etiqueta1.Cursor = Cursors.Hand;
        }

        private void etiqueta1_MouseLeave(object sender, EventArgs e)
        {
            etiqueta1.BackColor = System.Drawing.SystemColors.Control;
            etiqueta1.Cursor = Cursors.Arrow;

        }

        private void Texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar >59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Texto2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + Texto2.Text.Length + " Caracteres");
        }
    }
}
