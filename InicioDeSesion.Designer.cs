namespace Pokedex
{
    partial class InicioDeSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSesion));
            label2 = new Label();
            label1 = new Label();
            linkRegistrate = new LinkLabel();
            btVerPass = new Button();
            tbPass = new TextBox();
            lbVerPass = new Label();
            tbNombre = new TextBox();
            btIniciarSesion = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(204, 0, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(652, 491);
            label2.Name = "label2";
            label2.Size = new Size(215, 20);
            label2.TabIndex = 3;
            label2.Text = "¿Todavia no tienes una cuenta?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(204, 0, 0);
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(717, 103);
            label1.Name = "label1";
            label1.Size = new Size(168, 36);
            label1.TabIndex = 2;
            label1.Text = "Inicio de sesión";
            // 
            // linkRegistrate
            // 
            linkRegistrate.AutoSize = true;
            linkRegistrate.BackColor = Color.FromArgb(204, 0, 0);
            linkRegistrate.ForeColor = Color.White;
            linkRegistrate.LinkColor = Color.White;
            linkRegistrate.Location = new Point(867, 491);
            linkRegistrate.Name = "linkRegistrate";
            linkRegistrate.Size = new Size(76, 20);
            linkRegistrate.TabIndex = 4;
            linkRegistrate.TabStop = true;
            linkRegistrate.Text = "Registrate";
            linkRegistrate.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btVerPass
            // 
            btVerPass.Location = new Point(37, 187);
            btVerPass.Name = "btVerPass";
            btVerPass.Size = new Size(16, 15);
            btVerPass.TabIndex = 24;
            btVerPass.UseVisualStyleBackColor = true;
            btVerPass.Click += btVerPass_Click;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(33, 142);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(302, 27);
            tbPass.TabIndex = 20;
            tbPass.UseSystemPasswordChar = true;
            // 
            // lbVerPass
            // 
            lbVerPass.AutoSize = true;
            lbVerPass.BackColor = Color.FromArgb(204, 0, 0);
            lbVerPass.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVerPass.ForeColor = Color.White;
            lbVerPass.Location = new Point(59, 186);
            lbVerPass.Name = "lbVerPass";
            lbVerPass.Size = new Size(95, 17);
            lbVerPass.TabIndex = 23;
            lbVerPass.Text = "Ver contraseña";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(34, 64);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(302, 27);
            tbNombre.TabIndex = 18;
            // 
            // btIniciarSesion
            // 
            btIniciarSesion.BackColor = Color.FromArgb(255, 222, 0);
            btIniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(255, 222, 0);
            btIniciarSesion.FlatAppearance.BorderSize = 5;
            btIniciarSesion.FlatStyle = FlatStyle.Flat;
            btIniciarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btIniciarSesion.ForeColor = Color.Black;
            btIniciarSesion.Location = new Point(37, 253);
            btIniciarSesion.Name = "btIniciarSesion";
            btIniciarSesion.Size = new Size(304, 57);
            btIniciarSesion.TabIndex = 22;
            btIniciarSesion.Text = "Iniciar Sesion";
            btIniciarSesion.UseVisualStyleBackColor = false;
            btIniciarSesion.Click += btIniciarSesion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(204, 0, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 33);
            label4.Name = "label4";
            label4.Size = new Size(204, 20);
            label4.TabIndex = 19;
            label4.Text = "Ingrese su nombre de usuario\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(204, 0, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 111);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 21;
            label5.Text = "Ingrese su contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 0, 0);
            panel1.Controls.Add(btVerPass);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btIniciarSesion);
            panel1.Controls.Add(lbVerPass);
            panel1.Location = new Point(614, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 322);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 0, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkRegistrate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(-3, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 703);
            panel2.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(105, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(430, 169);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Location = new Point(0, 588);
            panel4.Name = "panel4";
            panel4.Size = new Size(1082, 57);
            panel4.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 469);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(-3, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 57);
            panel3.TabIndex = 27;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 694);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "InicioDeSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioDesesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private LinkLabel linkRegistrate;
        private Button btVerPass;
        private TextBox tbPass;
        private Label lbVerPass;
        private TextBox tbNombre;
        private Button btIniciarSesion;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel4;
    }
}
