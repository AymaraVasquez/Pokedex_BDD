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
            pictureBox3 = new PictureBox();
            domainUpDown1 = new DomainUpDown();
            label2 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel2.Controls.Add(button1);
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
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(domainUpDown1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(20, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 478);
            panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ashicon_removebg_preview;
            pictureBox3.Location = new Point(36, 317);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 133);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // domainUpDown1
            // 
            domainUpDown1.BackColor = Color.White;
            domainUpDown1.Location = new Point(191, 373);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(23, 27);
            domainUpDown1.TabIndex = 0;
            domainUpDown1.Text = "domainUpDown1";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
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
            // textBox3
            // 
            textBox3.Location = new Point(39, 43);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 27);
            textBox3.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(44, 239);
            button2.Name = "button2";
            button2.Size = new Size(16, 15);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(204, 0, 0);
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(66, 238);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 9;
            label5.Text = "Ver contraseña";
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
            // textBox2
            // 
            textBox2.Location = new Point(37, 193);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(302, 27);
            textBox2.TabIndex = 6;
            textBox2.UseSystemPasswordChar = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(41, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 606);
            button1.Name = "button1";
            button1.Size = new Size(304, 57);
            button1.TabIndex = 8;
            button1.Text = "Crear usuario";
            button1.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private Label label5;
        private Button button1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label6;
        private DomainUpDown domainUpDown1;
        private PictureBox pictureBox3;
    }
}