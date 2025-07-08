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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeUsuarios));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            pbFotoUsu = new PictureBox();
            dUpDoIcono = new DomainUpDown();
            label2 = new Label();
            tbNombre = new TextBox();
            btVerPass = new Button();
            lbVerPass = new Label();
            label4 = new Label();
            tbPass = new TextBox();
            label3 = new Label();
            tbUsu = new TextBox();
            btCrearUsu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoUsu).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.collage;
            pictureBox1.Location = new Point(-104, -60);
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
            label6.Location = new Point(60, 402);
            label6.Name = "label6";
            label6.Size = new Size(187, 20);
            label6.TabIndex = 13;
            label6.Text = "Escoge tu icono de usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 0, 0);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(pbFotoUsu);
            panel1.Controls.Add(dUpDoIcono);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(btVerPass);
            panel1.Controls.Add(lbVerPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbUsu);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(20, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 478);
            panel1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(193, 406);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(21, 27);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pbFotoUsu
            // 
            pbFotoUsu.Image = Properties.Resources.ashicon_removebg_preview;
            pbFotoUsu.Location = new Point(36, 317);
            pbFotoUsu.Name = "pbFotoUsu";
            pbFotoUsu.Size = new Size(142, 133);
            pbFotoUsu.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoUsu.TabIndex = 5;
            pbFotoUsu.TabStop = false;
            // 
            // dUpDoIcono
            // 
            dUpDoIcono.BackColor = Color.White;
            dUpDoIcono.Location = new Point(191, 373);
            dUpDoIcono.Name = "dUpDoIcono";
            dUpDoIcono.Size = new Size(23, 27);
            dUpDoIcono.TabIndex = 0;
            dUpDoIcono.Text = "domainUpDown1";
            dUpDoIcono.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
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
            // 
            // btVerPass
            // 
            btVerPass.Location = new Point(44, 239);
            btVerPass.Name = "btVerPass";
            btVerPass.Size = new Size(16, 15);
            btVerPass.TabIndex = 10;
            btVerPass.UseVisualStyleBackColor = true;
            btVerPass.Click += btVerPass_Click;
            // 
            // lbVerPass
            // 
            lbVerPass.AutoSize = true;
            lbVerPass.BackColor = Color.FromArgb(204, 0, 0);
            lbVerPass.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVerPass.ForeColor = Color.White;
            lbVerPass.Location = new Point(66, 238);
            lbVerPass.Name = "lbVerPass";
            lbVerPass.Size = new Size(95, 17);
            lbVerPass.TabIndex = 9;
            lbVerPass.Text = "Ver contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(204, 0, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 163);
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
            tbPass.Size = new Size(302, 27);
            tbPass.TabIndex = 6;
            tbPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(204, 0, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 85);
            label3.Name = "label3";
            label3.Size = new Size(204, 20);
            label3.TabIndex = 5;
            label3.Text = "Ingrese su nombre de usuario\r\n";
            // 
            // tbUsu
            // 
            tbUsu.Location = new Point(41, 116);
            tbUsu.Name = "tbUsu";
            tbUsu.Size = new Size(302, 27);
            tbUsu.TabIndex = 0;
            // 
            // btCrearUsu
            // 
            btCrearUsu.BackColor = Color.Red;
            btCrearUsu.FlatAppearance.BorderColor = Color.Red;
            btCrearUsu.FlatAppearance.BorderSize = 3;
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
            // RegistroDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 694);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistroDeUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RegistroDeUsuarios";
            Load += RegistroDeUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoUsu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button btVerPass;
        private Label lbVerPass;
        private Button btCrearUsu;
        private Label label4;
        private TextBox tbPass;
        private Label label3;
        private TextBox tbUsu;
        private Label label2;
        private TextBox tbNombre;
        private Label label6;
        private DomainUpDown dUpDoIcono;
        private PictureBox pbFotoUsu;
        private NumericUpDown numericUpDown1;
    }
}