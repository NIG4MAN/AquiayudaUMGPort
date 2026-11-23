namespace PracticaExamen
{
    partial class FrmPacientes
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
            this.navegadorPacientes = new CapaVista_Navegador.Navegador();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.Text = "8990 · Pacientes";
            this.BackColor = System.Drawing.Color.FromArgb(244, 248, 242);
            this.lblTitulo.Text = "Pacientes";
            this.lblTitulo.Location = new System.Drawing.Point(24, 20);
            this.lblTitulo.Size = new System.Drawing.Size(700, 48);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.Controls.Add(this.lblTitulo);
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Location = new System.Drawing.Point(830, 28);
            this.lblUsuario.Size = new System.Drawing.Size(320, 32);
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.Controls.Add(this.lblUsuario);
            this.navegadorPacientes.Location = new System.Drawing.Point(18, 98);
            this.navegadorPacientes.Size = new System.Drawing.Size(1144, 92);
            this.navegadorPacientes.Name = "navegadorPacientes";
            this.Controls.Add(this.navegadorPacientes);
            this.lblEjercicio.Text = "Práctica: ingresa 3 pacientes, modifica uno y elimina otro. Revisa las operaciones en Seguridad.";
            this.lblEjercicio.Location = new System.Drawing.Point(24, 587);
            this.lblEjercicio.Size = new System.Drawing.Size(870, 58);
            this.lblEjercicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblEjercicio.ForeColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.Controls.Add(this.lblEjercicio);
            this.btnVolver.Text = "Volver";
            this.btnVolver.Location = new System.Drawing.Point(1000, 610);
            this.btnVolver.Size = new System.Drawing.Size(150, 42);
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Click += new System.EventHandler(this.Volver);
            this.Controls.Add(this.btnVolver);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmPacientes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private CapaVista_Navegador.Navegador navegadorPacientes;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.Button btnVolver;
    }
}
