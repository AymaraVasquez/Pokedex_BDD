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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            pcbPokedex = new PictureBox();
            btVolverAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPokedex).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 0, 0);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-3, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 568);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(pcbPokedex);
            panel3.Controls.Add(btVolverAtras);
            panel3.Location = new Point(-1, -28);
            panel3.Name = "panel3";
            panel3.Size = new Size(804, 89);
            panel3.TabIndex = 7;
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
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ManualDeUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManualDeUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbPokedex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pcbPokedex;
        private Button btVolverAtras;
    }
}