namespace Geometry_Dash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.bntExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntExit)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 150);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(286, 206);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(250, 250);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 3;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.b_start_Click);
            this.btnStart.MouseLeave += new System.EventHandler(this.moveout_btn_start);
            this.btnStart.MouseHover += new System.EventHandler(this.hover_btn_start);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(33)))), ((int)(((byte)(226)))));
            this.title.Controls.Add(this.btnMin);
            this.title.Controls.Add(this.bntExit);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(807, 40);
            this.title.TabIndex = 4;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(723, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 40);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bntExit
            // 
            this.bntExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bntExit.Image = ((System.Drawing.Image)(resources.GetObject("bntExit.Image")));
            this.bntExit.Location = new System.Drawing.Point(772, 0);
            this.bntExit.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(40, 40);
            this.bntExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bntExit.TabIndex = 0;
            this.bntExit.TabStop = false;
            this.bntExit.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 461);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox bntExit;
    }
}

