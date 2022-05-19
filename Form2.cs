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
    public partial class Form2 : Form
    {
        private int lvl = 0;
        B_Personalizado newLvl = new B_Personalizado();

        public Form2()
        {
            InitializeComponent();
           // WindowState = FormWindowState.Maximized;  // Abre el juego en pantalla completa.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //inicializacion del form
            WindowState = FormWindowState.Maximized;
            string lvlMessage = "Level " + Convert.ToString(lvl + 1);
            lblLvl.Text = lvlMessage;
            lvlBack.Visible = false;

        }

        private void lvlBack_Click(object sender, EventArgs e)
        {
            //va al nivel anterior
            lvl--;
            string lvlMessage = "Level " + Convert.ToString(lvl + 1);
            lblLvl.Text = lvlMessage;//muestra el nivel
            if (lvl <= 0) lvlBack.Visible = false;
            if (lvl <= 2) nextLvl.Visible = true;
            newLvl.setLvl(lvl) ; // cambia el nivel del boton
            imgLvl.ImageIndex = lvl; // cambia la imagen del nivel
        }

        private void nextLvl_Click(object sender, EventArgs e)
        {
            // va al siguiente nivel
            lvl++;
            string lvlMessage = "Level " + Convert.ToString(lvl + 1);
           
            lblLvl.Text = lvlMessage; // muestra el nviel
            if (lvl >= 2) nextLvl.Visible = false;
            if (lvl > 0) lvlBack.Visible = true;
            newLvl.setLvl(lvl); // cambia el nivel del boton
            imgLvl.ImageIndex = lvl; //cambia la imagende del nivel
            
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ShowLvl(int lvl)
        {    
            // llevara al usuario a los niveles creados
            switch (lvl)
            {
                case 0 :
                    sayLvl.Text = "usted fue al lvl" + lvl;

                    break;
                case 1:
                    sayLvl.Text = "usted fue al lvl" + lvl;

                    break;
                case 2:
                    sayLvl.Text = "usted fue al lvl" + lvl;

                    break;
                default: throw new ArgumentException("Nivel del juego aun no creado");
            }
        }

        //disprara el evento para correr el nivel
        private void btnLvls_Click(object sender, EventArgs e)
        {
            ShowLvl(lvl);
        }
    }
}
