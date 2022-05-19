namespace Geometry_Dash
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lvlBack = new System.Windows.Forms.PictureBox();
            this.nextLvl = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.bntExit = new System.Windows.Forms.PictureBox();
            this.selectLvl = new System.Windows.Forms.Panel();
            this.sayLvl = new System.Windows.Forms.Label();
            this.btnLvls = new Geometry_Dash.B_Personalizado();
            this.lvlImgs = new System.Windows.Forms.ImageList(this.components);
            this.imgLvl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvlBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextLvl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntExit)).BeginInit();
            this.selectLvl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(119, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(690, 91);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblLvl
            // 
            this.lblLvl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLvl.AutoSize = true;
            this.lblLvl.Font = new System.Drawing.Font("Pusab", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl.ForeColor = System.Drawing.Color.White;
            this.lblLvl.Location = new System.Drawing.Point(3, 0);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(132, 37);
            this.lblLvl.TabIndex = 6;
            this.lblLvl.Text = "label1";
            this.lblLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvlBack
            // 
            this.lvlBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvlBack.Image = ((System.Drawing.Image)(resources.GetObject("lvlBack.Image")));
            this.lvlBack.Location = new System.Drawing.Point(78, 360);
            this.lvlBack.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lvlBack.Name = "lvlBack";
            this.lvlBack.Size = new System.Drawing.Size(100, 100);
            this.lvlBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvlBack.TabIndex = 7;
            this.lvlBack.TabStop = false;
            this.lvlBack.Click += new System.EventHandler(this.lvlBack_Click);
            // 
            // nextLvl
            // 
            this.nextLvl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextLvl.Image = ((System.Drawing.Image)(resources.GetObject("nextLvl.Image")));
            this.nextLvl.Location = new System.Drawing.Point(801, 360);
            this.nextLvl.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.nextLvl.Name = "nextLvl";
            this.nextLvl.Size = new System.Drawing.Size(100, 100);
            this.nextLvl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nextLvl.TabIndex = 8;
            this.nextLvl.TabStop = false;
            this.nextLvl.Click += new System.EventHandler(this.nextLvl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(33)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.bntExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 40);
            this.panel1.TabIndex = 9;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(850, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 40);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMin.TabIndex = 10;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // bntExit
            // 
            this.bntExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bntExit.Image = ((System.Drawing.Image)(resources.GetObject("bntExit.Image")));
            this.bntExit.Location = new System.Drawing.Point(899, 0);
            this.bntExit.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(40, 40);
            this.bntExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bntExit.TabIndex = 10;
            this.bntExit.TabStop = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // selectLvl
            // 
            this.selectLvl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectLvl.Controls.Add(this.imgLvl);
            this.selectLvl.Controls.Add(this.btnLvls);
            this.selectLvl.Controls.Add(this.lblLvl);
            this.selectLvl.ForeColor = System.Drawing.Color.Transparent;
            this.selectLvl.Location = new System.Drawing.Point(233, 277);
            this.selectLvl.Name = "selectLvl";
            this.selectLvl.Size = new System.Drawing.Size(520, 183);
            this.selectLvl.TabIndex = 10;
            // 
            // sayLvl
            // 
            this.sayLvl.AutoSize = true;
            this.sayLvl.Font = new System.Drawing.Font("Pusab", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayLvl.ForeColor = System.Drawing.Color.White;
            this.sayLvl.Location = new System.Drawing.Point(154, 669);
            this.sayLvl.Name = "sayLvl";
            this.sayLvl.Size = new System.Drawing.Size(132, 37);
            this.sayLvl.TabIndex = 11;
            this.sayLvl.Text = "label1";
            // 
            // btnLvls
            // 
            this.btnLvls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLvls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLvls.FlatAppearance.BorderSize = 0;
            this.btnLvls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLvls.Font = new System.Drawing.Font("Pusab", 25F);
            this.btnLvls.ForeColor = System.Drawing.Color.White;
            this.btnLvls.Location = new System.Drawing.Point(30, 57);
            this.btnLvls.Name = "btnLvls";
            this.btnLvls.Size = new System.Drawing.Size(456, 123);
            this.btnLvls.TabIndex = 7;
            this.btnLvls.Text = "Press Start";
            this.btnLvls.UseVisualStyleBackColor = false;
            this.btnLvls.Click += new System.EventHandler(this.btnLvls_Click);
            // 
            // lvlImgs
            // 
            this.lvlImgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lvlImgs.ImageStream")));
            this.lvlImgs.TransparentColor = System.Drawing.Color.Transparent;
            this.lvlImgs.Images.SetKeyName(0, "Carita.png");
            this.lvlImgs.Images.SetKeyName(1, "lvl2.jpg");
            this.lvlImgs.Images.SetKeyName(2, "lvl3.jpg");
            // 
            // imgLvl
            // 
            this.imgLvl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLvl.BackColor = System.Drawing.Color.Transparent;
            this.imgLvl.ImageIndex = 0;
            this.imgLvl.ImageList = this.lvlImgs;
            this.imgLvl.Location = new System.Drawing.Point(55, 83);
            this.imgLvl.Name = "imgLvl";
            this.imgLvl.Size = new System.Drawing.Size(80, 80);
            this.imgLvl.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(939, 788);
            this.Controls.Add(this.sayLvl);
            this.Controls.Add(this.selectLvl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nextLvl);
            this.Controls.Add(this.lvlBack);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvlBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextLvl)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntExit)).EndInit();
            this.selectLvl.ResumeLayout(false);
            this.selectLvl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.PictureBox lvlBack;
        private System.Windows.Forms.PictureBox nextLvl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bntExit;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.Panel selectLvl;
        private System.Windows.Forms.Label sayLvl;
        private B_Personalizado btnLvls;
        private System.Windows.Forms.Label imgLvl;
        private System.Windows.Forms.ImageList lvlImgs;
    }
}