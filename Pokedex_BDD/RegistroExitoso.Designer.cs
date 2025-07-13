namespace Pokedex
{
    partial class RegistroExitoso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroExitoso));
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btIniciarSesion = new Button();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 57);
            panel3.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pikagif;
            pictureBox1.Location = new Point(255, 231);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btIniciarSesion
            // 
            btIniciarSesion.BackColor = Color.FromArgb(255, 222, 0);
            btIniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(255, 222, 0);
            btIniciarSesion.FlatAppearance.BorderSize = 5;
            btIniciarSesion.FlatStyle = FlatStyle.Flat;
            btIniciarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btIniciarSesion.ForeColor = Color.Black;
            btIniciarSesion.Location = new Point(255, 546);
            btIniciarSesion.Name = "btIniciarSesion";
            btIniciarSesion.Size = new Size(369, 57);
            btIniciarSesion.TabIndex = 31;
            btIniciarSesion.Text = "Volver al inicio de sesión";
            btIniciarSesion.UseVisualStyleBackColor = false;
            btIniciarSesion.Click += btIniciarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(204, 0, 0);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(255, 101);
            label1.Name = "label1";
            label1.Size = new Size(204, 31);
            label1.TabIndex = 32;
            label1.Text = "Registro Exitoso!!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(204, 0, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(255, 145);
            label4.Name = "label4";
            label4.Size = new Size(331, 40);
            label4.TabIndex = 33;
            label4.Text = "No olvides tu frase de recuperación. Te servirá si \r\nen algun momento olvidas tu contraseña.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(0, 641);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 57);
            panel1.TabIndex = 29;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.collage;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(-106, -59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(332, 837);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // RegistroExitoso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 0, 0);
            ClientSize = new Size(649, 694);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btIniciarSesion);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistroExitoso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroExitoso";
            FormClosed += RegistroExitoso_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btIniciarSesion;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}