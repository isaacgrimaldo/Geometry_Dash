using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Dash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2(); // se hace la llamada al formulario de inicio del juego.
            formulario.Show();             // inicio del juego.

            this.Hide();                  // se cierra el menu del juego y abre el incio del mismo.

        }
    }
}
