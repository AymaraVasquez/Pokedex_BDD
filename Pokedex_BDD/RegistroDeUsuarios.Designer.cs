namespace Pokedex
{
    partial class RegistroDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeUsuarios));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            tbRecuperacion = new TextBox();
            checkContrasena = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            pbFotoUsu = new PictureBox();
            label2 = new Label();
            tbNombre = new TextBox();
            label4 = new Label();
            tbPass = new TextBox();
            label3 = new Label();
            tbUsu = new TextBox();
            btCrearUsu = new Button();
            panel3 = new Panel();
            btAtras = new Button();
            btManual = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoUsu).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.collage;
            pictureBox1.Location = new Point(-104, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 837);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(204, 0, 0);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 33);
            label1.Name = "label1";
            label1.Size = new Size(326, 62);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido!!\r\nComienza creando tu usuario\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 0, 0);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btCrearUsu);
            panel2.Location = new Point(228, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 724);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(204, 0, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(57, 448);
            label6.Name = "label6";
            label6.Size = new Size(187, 20);
            label6.TabIndex = 13;
            label6.Text = "Escoge tu icono de usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 0, 0);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbRecuperacion);
            panel1.Controls.Add(checkContrasena);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(pbFotoUsu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbUsu);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(20, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 478);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(204, 0, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 263);
            label5.Name = "label5";
            label5.Size = new Size(222, 20);
            label5.TabIndex = 28;
            label5.Text = "Ingrese su frase de recuperación";
            // 
            // tbRecuperacion
            // 
            tbRecuperacion.Location = new Point(39, 294);
            tbRecuperacion.Name = "tbRecuperacion";
            tbRecuperacion.Size = new Size(302, 27);
            tbRecuperacion.TabIndex = 27;
            tbRecuperacion.KeyPress += tbRecuperacion_KeyPress;
            // 
            // checkContrasena
            // 
            checkContrasena.AutoSize = true;
            checkContrasena.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkContrasena.ForeColor = Color.White;
            checkContrasena.Location = new Point(40, 228);
            checkContrasena.Name = "checkContrasena";
            checkContrasena.Size = new Size(117, 21);
            checkContrasena.TabIndex = 26;
            checkContrasena.Text = "Ver contraseña";
            checkContrasena.UseVisualStyleBackColor = true;
            checkContrasena.CheckedChanged += checkContrasena_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(158, 400);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(21, 27);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pbFotoUsu
            // 
            pbFotoUsu.Image = Properties.Resources.ashicon_removebg_preview;
            pbFotoUsu.Location = new Point(30, 367);
            pbFotoUsu.Name = "pbFotoUsu";
            pbFotoUsu.Size = new Size(115, 95);
            pbFotoUsu.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoUsu.TabIndex = 5;
            pbFotoUsu.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(204, 0, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 12);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 12;
            label2.Text = "Ingrese su nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(39, 43);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(302, 27);
            tbNombre.TabIndex = 11;
            tbNombre.KeyPress += tbNombre_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(204, 0, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 163);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 7;
            label4.Text = "Ingrese su contraseña";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(37, 193);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(304, 27);
            tbPass.TabIndex = 6;
            tbPass.UseSystemPasswordChar = true;
            tbPass.KeyPress += tbPass_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(204, 0, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 85);
            label3.Name = "label3";
            label3.Size = new Size(204, 20);
            label3.TabIndex = 5;
            label3.Text = "Ingrese su nombre de usuario\r\n";
            // 
            // tbUsu
            // 
            tbUsu.Location = new Point(39, 116);
            tbUsu.Name = "tbUsu";
            tbUsu.Size = new Size(302, 27);
            tbUsu.TabIndex = 0;
            tbUsu.KeyPress += tbUsu_KeyPress;
            // 
            // btCrearUsu
            // 
            btCrearUsu.BackColor = Color.Red;
            btCrearUsu.FlatAppearance.BorderColor = Color.White;
            btCrearUsu.FlatStyle = FlatStyle.Flat;
            btCrearUsu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCrearUsu.ForeColor = Color.White;
            btCrearUsu.Location = new Point(57, 606);
            btCrearUsu.Name = "btCrearUsu";
            btCrearUsu.Size = new Size(304, 57);
            btCrearUsu.TabIndex = 8;
            btCrearUsu.Text = "Crear usuario";
            btCrearUsu.UseVisualStyleBackColor = false;
            btCrearUsu.Click += btCrearUsu_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(btAtras);
            panel3.Controls.Add(btManual);
            panel3.Location = new Point(-2, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 64);
            panel3.TabIndex = 29;
            // 
            // btAtras
            // 
            btAtras.BackColor = Color.FromArgb(255, 222, 0);
            btAtras.FlatStyle = FlatStyle.Flat;
            btAtras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAtras.Location = new Point(14, 9);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(57, 47);
            btAtras.TabIndex = 34;
            btAtras.Text = "<<";
            btAtras.UseVisualStyleBackColor = false;
            btAtras.Click += btAtras_Click;
            // 
            // btManual
            // 
            btManual.BackColor = Color.FromArgb(255, 222, 0);
            btManual.FlatStyle = FlatStyle.Flat;
            btManual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btManual.Location = new Point(1039, 14);
            btManual.Name = "btManual";
            btManual.Size = new Size(38, 36);
            btManual.TabIndex = 30;
            btManual.Text = "?";
            btManual.UseVisualStyleBackColor = false;
            // 
            // RegistroDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 694);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistroDeUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RegistroDeUsuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoUsu).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button btCrearUsu;
        private Label label4;
        private TextBox tbPass;
        private Label label3;
        private TextBox tbUsu;
        private Label label2;
        private TextBox tbNombre;
        private Label label6;
        private PictureBox pbFotoUsu;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private TextBox tbRecuperacion;
        private CheckBox checkContrasena;
        private Panel panel3;
        private Button btManual;
        private Button btAtras;
        private ToolTip toolTip1;
    }
}