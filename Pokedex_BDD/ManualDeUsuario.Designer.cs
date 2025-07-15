namespace Pokedex
{
    partial class ManualDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualDeUsuario));
            pictureVista = new PictureBox();
            panel1 = new Panel();
            btSiguiente = new Button();
            btAtras = new Button();
            textDescrip = new TextBox();
            panel3 = new Panel();
            pcbPokedex = new PictureBox();
            btVolverAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureVista).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPokedex).BeginInit();
            SuspendLayout();
            // 
            // pictureVista
            // 
            pictureVista.Image = Properties.Resources.VistaOpciones;
            pictureVista.Location = new Point(120, 86);
            pictureVista.Name = "pictureVista";
            pictureVista.Size = new Size(879, 367);
            pictureVista.SizeMode = PictureBoxSizeMode.Zoom;
            pictureVista.TabIndex = 0;
            pictureVista.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 0, 0);
            panel1.Controls.Add(btSiguiente);
            panel1.Controls.Add(btAtras);
            panel1.Controls.Add(textDescrip);
            panel1.Controls.Add(pictureVista);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-3, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 704);
            panel1.TabIndex = 1;
            // 
            // btSiguiente
            // 
            btSiguiente.BackColor = Color.FromArgb(255, 222, 0);
            btSiguiente.FlatStyle = FlatStyle.Flat;
            btSiguiente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSiguiente.Location = new Point(1021, 630);
            btSiguiente.Name = "btSiguiente";
            btSiguiente.Size = new Size(57, 44);
            btSiguiente.TabIndex = 36;
            btSiguiente.Text = ">";
            btSiguiente.UseVisualStyleBackColor = false;
            btSiguiente.Click += btSiguiente_Click;
            // 
            // btAtras
            // 
            btAtras.BackColor = Color.FromArgb(255, 222, 0);
            btAtras.FlatStyle = FlatStyle.Flat;
            btAtras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAtras.Location = new Point(29, 630);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(57, 44);
            btAtras.TabIndex = 35;
            btAtras.Text = "<";
            btAtras.UseVisualStyleBackColor = false;
            btAtras.Click += btAtras_Click;
            // 
            // textDescrip
            // 
            textDescrip.BackColor = Color.Red;
            textDescrip.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDescrip.ForeColor = Color.White;
            textDescrip.Location = new Point(120, 477);
            textDescrip.Multiline = true;
            textDescrip.Name = "textDescrip";
            textDescrip.Size = new Size(879, 197);
            textDescrip.TabIndex = 8;
            textDescrip.Text = "Testeo de tipografia y color";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(pcbPokedex);
            panel3.Controls.Add(btVolverAtras);
            panel3.Location = new Point(-1, -28);
            panel3.Name = "panel3";
            panel3.Size = new Size(1107, 89);
            panel3.TabIndex = 7;
            // 
            // pcbPokedex
            // 
            pcbPokedex.Image = (Image)resources.GetObject("pcbPokedex.Image");
            pcbPokedex.Location = new Point(533, 36);
            pcbPokedex.Name = "pcbPokedex";
            pcbPokedex.Size = new Size(86, 42);
            pcbPokedex.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPokedex.TabIndex = 31;
            pcbPokedex.TabStop = false;
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
            // ManualDeUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 697);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ManualDeUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManualDeUsuario";
            Load += ManualDeUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureVista).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbPokedex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureVista;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pcbPokedex;
        private Button btVolverAtras;
        private TextBox textDescrip;
        private Button btSiguiente;
        private Button btAtras;
    }
}