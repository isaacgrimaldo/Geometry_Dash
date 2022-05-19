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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void hover_btn_start(object sonder, EventArgs e)
        {
            int btnWidth = btnStart.Width;
            int btnHeight = btnStart.Height;

            btnStart.Size = new Size( btnWidth + 10 , btnHeight +10) ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnStart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
