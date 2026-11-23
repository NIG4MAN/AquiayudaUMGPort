namespace PracticaExamen
{
    partial class FrmMenuPractica
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnBancos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.Text = "Menú principal · Práctica de examen";
            this.BackColor = System.Drawing.Color.FromArgb(244, 248, 242);
            this.lblTitulo.Text = "Embutidos de Calidad";
            this.lblTitulo.Location = new System.Drawing.Point(28, 28);
            this.lblTitulo.Size = new System.Drawing.Size(310, 40);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.Controls.Add(this.lblTitulo);
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Location = new System.Drawing.Point(28, 82);
            this.lblUsuario.Size = new System.Drawing.Size(310, 30);
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.Controls.Add(this.lblUsuario);
            this.btnSeguridad.Text = "Módulo de Seguridad";
            this.btnSeguridad.Location = new System.Drawing.Point(28, 140);
            this.btnSeguridad.Size = new System.Drawing.Size(304, 64);
            this.btnSeguridad.BackColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.btnSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Click += new System.EventHandler(this.AbrirSeguridad);
            this.Controls.Add(this.btnSeguridad);
            this.btnBancos.Text = "Bancos";
            this.btnBancos.Location = new System.Drawing.Point(28, 218);
            this.btnBancos.Size = new System.Drawing.Size(304, 64);
            this.btnBancos.BackColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.btnBancos.ForeColor = System.Drawing.Color.White;
            this.btnBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBancos.Click += new System.EventHandler(this.AbrirBancos);
            this.Controls.Add(this.btnBancos);
            this.btnSalir.Text = "Salir al Login";
            this.btnSalir.Location = new System.Drawing.Point(28, 350);
            this.btnSalir.Size = new System.Drawing.Size(304, 52);
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Click += new System.EventHandler(this.Salir);
            this.Controls.Add(this.btnSalir);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmMenuPractica";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnBancos;
        private System.Windows.Forms.Button btnSalir;
    }
}
