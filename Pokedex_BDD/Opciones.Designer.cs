namespace Pokedex
{
    partial class Opciones
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btPokedex = new Button();
            btCrear = new Button();
            btVerPerfil = new Button();
            panel3 = new Panel();
            btVolverAtras = new Button();
            btManual = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            pcbPokedex = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPokedex).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 0, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btPokedex);
            panel1.Controls.Add(btCrear);
            panel1.Controls.Add(btVerPerfil);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 568);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pikachuu;
            pictureBox1.Location = new Point(393, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 319);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btPokedex
            // 
            btPokedex.BackColor = Color.FromArgb(255, 222, 0);
            btPokedex.FlatAppearance.BorderColor = Color.FromArgb(255, 222, 0);
            btPokedex.FlatAppearance.BorderSize = 5;
            btPokedex.FlatStyle = FlatStyle.Flat;
            btPokedex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPokedex.ForeColor = Color.Black;
            btPokedex.Location = new Point(50, 364);
            btPokedex.Name = "btPokedex";
            btPokedex.Size = new Size(304, 57);
            btPokedex.TabIndex = 25;
            btPokedex.Text = "Ver Pokedex";
            btPokedex.UseVisualStyleBackColor = false;
            btPokedex.Click += btPokedex_Click;
            // 
            // btCrear
            // 
            btCrear.BackColor = Color.FromArgb(255, 222, 0);
            btCrear.FlatAppearance.BorderColor = Color.FromArgb(255, 222, 0);
            btCrear.FlatAppearance.BorderSize = 5;
            btCrear.FlatStyle = FlatStyle.Flat;
            btCrear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCrear.ForeColor = Color.Black;
            btCrear.Location = new Point(50, 278);
            btCrear.Name = "btCrear";
            btCrear.Size = new Size(304, 57);
            btCrear.TabIndex = 24;
            btCrear.Text = "Crear equipo pokemon";
            btCrear.UseVisualStyleBackColor = false;
            btCrear.Click += btCrear_Click;
            // 
            // btVerPerfil
            // 
            btVerPerfil.BackColor = Color.FromArgb(255, 222, 0);
            btVerPerfil.FlatAppearance.BorderColor = Color.FromArgb(255, 222, 0);
            btVerPerfil.FlatAppearance.BorderSize = 5;
            btVerPerfil.FlatStyle = FlatStyle.Flat;
            btVerPerfil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btVerPerfil.ForeColor = Color.Black;
            btVerPerfil.Location = new Point(50, 192);
            btVerPerfil.Name = "btVerPerfil";
            btVerPerfil.Size = new Size(304, 57);
            btVerPerfil.TabIndex = 23;
            btVerPerfil.Text = "Ver Perfil";
            btVerPerfil.UseVisualStyleBackColor = false;
            btVerPerfil.Click += btVerPerfil_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(pcbPokedex);
            panel3.Controls.Add(btVolverAtras);
            panel3.Controls.Add(btManual);
            panel3.Location = new Point(-1, -28);
            panel3.Name = "panel3";
            panel3.Size = new Size(804, 89);
            panel3.TabIndex = 7;
            // 
            // btVolverAtras
            // 
            btVolverAtras.BackColor = Color.FromArgb(255, 222, 0);
            btVolverAtras.FlatStyle = FlatStyle.Flat;
            btVolverAtras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btVolverAtras.Location = new Point(14, 42);
            btVolverAtras.Name = "btVolverAtras";
            btVolverAtras.Size = new Size(55, 36);
            btVolverAtras.TabIndex = 36;
            btVolverAtras.Text = "<<";
            btVolverAtras.UseVisualStyleBackColor = false;
            btVolverAtras.Click += btVolverAtras_Click;
            // 
            // btManual
            // 
            btManual.BackColor = Color.FromArgb(255, 222, 0);
            btManual.FlatStyle = FlatStyle.Flat;
            btManual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btManual.Location = new Point(755, 42);
            btManual.Name = "btManual";
            btManual.Size = new Size(38, 36);
            btManual.TabIndex = 0;
            btManual.Text = "?";
            btManual.UseVisualStyleBackColor = false;
            btManual.Click += btManual_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(204, 0, 0);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 91);
            label1.Name = "label1";
            label1.Size = new Size(317, 62);
            label1.TabIndex = 4;
            label1.Text = "Ahora escoge\r\n¿Qué quieres hacer primero?";
            // 
            // pcbPokedex
            // 
            pcbPokedex.Image = (Image)resources.GetObject("pcbPokedex.Image");
            pcbPokedex.Location = new Point(365, 40);
            pcbPokedex.Name = "pcbPokedex";
            pcbPokedex.Size = new Size(86, 42);
            pcbPokedex.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPokedex.TabIndex = 31;
            pcbPokedex.TabStop = false;
            // 
            // Opciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Opciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Opciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbPokedex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button btPokedex;
        private Button btCrear;
        private Button btVerPerfil;
        private Button btManual;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Button btVolverAtras;
        private PictureBox pcbPokedex;
    }
}