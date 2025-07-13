namespace Pokedex
{
    partial class RecuperarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContrasena));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            checkVer2 = new CheckBox();
            label3 = new Label();
            tbConfirmacion = new TextBox();
            checkContrasena = new CheckBox();
            label2 = new Label();
            tbFraseRecup = new TextBox();
            label4 = new Label();
            tbPass = new TextBox();
            label1 = new Label();
            btCambiarCont = new Button();
            panel3 = new Panel();
            btAtras = new Button();
            btManual = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.collage;
            pictureBox1.Location = new Point(-103, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 837);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 0, 0);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btCambiarCont);
            panel2.Location = new Point(229, -11);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 724);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 0, 0);
            panel1.Controls.Add(checkVer2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbConfirmacion);
            panel1.Controls.Add(checkContrasena);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbFraseRecup);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbPass);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(20, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 440);
            panel1.TabIndex = 4;
            // 
            // checkVer2
            // 
            checkVer2.AutoSize = true;
            checkVer2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkVer2.ForeColor = Color.White;
            checkVer2.Location = new Point(38, 272);
            checkVer2.Name = "checkVer2";
            checkVer2.Size = new Size(117, 21);
            checkVer2.TabIndex = 29;
            checkVer2.Text = "Ver contraseña";
            checkVer2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(204, 0, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 207);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 28;
            label3.Text = "Confirme su nueva contraseña";
            // 
            // tbConfirmacion
            // 
            tbConfirmacion.Enabled = false;
            tbConfirmacion.Location = new Point(35, 237);
            tbConfirmacion.Name = "tbConfirmacion";
            tbConfirmacion.PasswordChar = '*';
            tbConfirmacion.Size = new Size(304, 27);
            tbConfirmacion.TabIndex = 27;
            tbConfirmacion.UseSystemPasswordChar = true;
            // 
            // checkContrasena
            // 
            checkContrasena.AutoSize = true;
            checkContrasena.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkContrasena.ForeColor = Color.White;
            checkContrasena.Location = new Point(40, 172);
            checkContrasena.Name = "checkContrasena";
            checkContrasena.Size = new Size(117, 21);
            checkContrasena.TabIndex = 26;
            checkContrasena.Text = "Ver contraseña";
            checkContrasena.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(204, 0, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 29);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 12;
            label2.Text = "Ingrese su frase de recuperación";
            // 
            // tbFraseRecup
            // 
            tbFraseRecup.Location = new Point(39, 60);
            tbFraseRecup.Name = "tbFraseRecup";
            tbFraseRecup.Size = new Size(302, 27);
            tbFraseRecup.TabIndex = 11;
            tbFraseRecup.KeyPress += tbFraseRecup_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(204, 0, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 107);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 7;
            label4.Text = "Ingrese su nueva contraseña";
            // 
            // tbPass
            // 
            tbPass.Enabled = false;
            tbPass.Location = new Point(37, 137);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(304, 27);
            tbPass.TabIndex = 6;
            tbPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(204, 0, 0);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(338, 124);
            label1.TabIndex = 3;
            label1.Text = "Hola de nuevo!!\r\nRellena los campos requeridos\r\npara recuperar tu cuenta\r\n\r\n";
            // 
            // btCambiarCont
            // 
            btCambiarCont.BackColor = Color.Red;
            btCambiarCont.FlatAppearance.BorderColor = Color.White;
            btCambiarCont.FlatStyle = FlatStyle.Flat;
            btCambiarCont.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCambiarCont.ForeColor = Color.White;
            btCambiarCont.Location = new Point(57, 606);
            btCambiarCont.Name = "btCambiarCont";
            btCambiarCont.Size = new Size(304, 57);
            btCambiarCont.TabIndex = 8;
            btCambiarCont.Text = "Cambiar contraseña";
            btCambiarCont.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(btAtras);
            panel3.Controls.Add(btManual);
            panel3.Location = new Point(-1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 64);
            panel3.TabIndex = 30;
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
            // RecuperarContrasena
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
            Name = "RecuperarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecuperarContrasena";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private CheckBox checkContrasena;
        private Label label2;
        private TextBox tbFraseRecup;
        private Label label4;
        private TextBox tbPass;
        private Label label1;
        private Button btCambiarCont;
        private CheckBox checkVer2;
        private Label label3;
        private TextBox tbConfirmacion;
        private Panel panel3;
        private Button btAtras;
        private Button btManual;
        private ToolTip toolTip1;
    }
}