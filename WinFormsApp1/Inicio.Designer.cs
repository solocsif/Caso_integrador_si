namespace WinFormsApp1
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            GestionDeInmuebles = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GestionDeInmuebles).BeginInit();
            SuspendLayout();
            // 
            // GestionDeInmuebles
            // 
            GestionDeInmuebles.ErrorImage = (Image)resources.GetObject("GestionDeInmuebles.ErrorImage");
            GestionDeInmuebles.Image = Properties.Resources.MicrosoftTeams_image;
            GestionDeInmuebles.InitialImage = (Image)resources.GetObject("GestionDeInmuebles.InitialImage");
            GestionDeInmuebles.Location = new Point(290, 77);
            GestionDeInmuebles.Name = "GestionDeInmuebles";
            GestionDeInmuebles.Size = new Size(211, 141);
            GestionDeInmuebles.SizeMode = PictureBoxSizeMode.Zoom;
            GestionDeInmuebles.TabIndex = 0;
            GestionDeInmuebles.TabStop = false;
            GestionDeInmuebles.Click += GestionDeInmuebles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 243);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 1;
            label1.Text = "Gestion De Inmuebles";
            label1.Click += label1_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(GestionDeInmuebles);
            Name = "Inicio";
            Text = "Form1";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)GestionDeInmuebles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox GestionDeInmuebles;
        private Label label1;
    }
}