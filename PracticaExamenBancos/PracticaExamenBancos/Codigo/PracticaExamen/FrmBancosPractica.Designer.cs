namespace PracticaExamen
{
    partial class FrmBancosPractica
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.menuCatalogos = new System.Windows.Forms.MenuStrip();
            this.itemCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.Text = "Bancos · Catálogos de práctica";
            this.BackColor = System.Drawing.Color.FromArgb(244, 248, 242);
            this.menuCatalogos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.itemCatalogos });
            this.itemCatalogos.Text = "Catálogos";
            this.itemCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.itemPacientes });
            this.itemPacientes.Text = "Pacientes";
            this.itemPacientes.Click += new System.EventHandler(this.AbrirPacientes);
            this.Controls.Add(this.menuCatalogos);
            this.MainMenuStrip = this.menuCatalogos;
            this.lblTitulo.Text = "Bancos";
            this.lblTitulo.Location = new System.Drawing.Point(40, 74);
            this.lblTitulo.Size = new System.Drawing.Size(750, 60);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.Controls.Add(this.lblTitulo);
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Location = new System.Drawing.Point(42, 147);
            this.lblUsuario.Size = new System.Drawing.Size(750, 32);
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.Controls.Add(this.lblUsuario);
            this.lblIndicacion.Text = "Catálogos · Mantenimiento de pacientes";
            this.lblIndicacion.Location = new System.Drawing.Point(42, 220);
            this.lblIndicacion.Size = new System.Drawing.Size(850, 36);
            this.lblIndicacion.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblIndicacion.ForeColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.Controls.Add(this.lblIndicacion);
            this.btnPacientes.Text = "Abrir Pacientes";
            this.btnPacientes.Location = new System.Drawing.Point(42, 280);
            this.btnPacientes.Size = new System.Drawing.Size(270, 64);
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Click += new System.EventHandler(this.AbrirPacientes);
            this.Controls.Add(this.btnPacientes);
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.Location = new System.Drawing.Point(740, 510);
            this.btnVolver.Size = new System.Drawing.Size(210, 48);
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(24, 73, 52);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Click += new System.EventHandler(this.Volver);
            this.Controls.Add(this.btnVolver);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmBancosPractica";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.MenuStrip menuCatalogos;
        private System.Windows.Forms.ToolStripMenuItem itemCatalogos;
        private System.Windows.Forms.ToolStripMenuItem itemPacientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnVolver;
    }
}
