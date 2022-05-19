using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Geometry_Dash
{
    public class B_Personalizado : Button  // hereda el boton personalizado en el boton de windows de forms.
    {
        // atributos.
        private int border_size = 0; // tamaño de borde
        private int border_radius = 48; // borde del radio
        private Color border_colour = Color.PaleVioletRed; // color de borde.
        private int lvl = 0;
        private Font fontName = new Font("Pusab", 25);

        // constructor
        public B_Personalizado()
        {
            Color newColor = new Color();
            newColor = Color.FromArgb(255, 0, 0, 64);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(400, 120);
            this.BackColor = newColor;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
            this.Text = "Press Start";
            this.Font = fontName;
           
        }

        // metodos.

        public void setLvl (int lvl)
        {
            this.lvl = lvl;
        }

        public int getlvl()
        {
            return lvl;
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (border_radius > this.Height)
                border_radius = this.Height;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -border_size, -border_size);
            int smoothSize = 2;
            if (border_size > 0)
                smoothSize = border_size;
            if (border_radius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, border_radius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, border_radius - border_size))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(border_colour, border_size))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (border_size >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (border_size >= 1)
                {
                    using (Pen penBorder = new Pen(border_colour, border_size))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }

}
