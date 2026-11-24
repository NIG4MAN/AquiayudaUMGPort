namespace CapaVista_Bancos.Formularios
{
    partial class FrmPacientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
            this.BancosBtnVolver = new System.Windows.Forms.Button();
            this.BancosNavPacientes = new CapaVista_Navegador.Navegador();
            this.SuspendLayout();
            // 
            // BancosBtnVolver
            // 
            this.BancosBtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BancosBtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosBtnVolver.FlatAppearance.BorderSize = 0;
            this.BancosBtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BancosBtnVolver.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BancosBtnVolver.ForeColor = System.Drawing.Color.White;
            this.BancosBtnVolver.Location = new System.Drawing.Point(12, 667);
            this.BancosBtnVolver.Name = "BancosBtnVolver";
            this.BancosBtnVolver.Size = new System.Drawing.Size(110, 32);
            this.BancosBtnVolver.TabIndex = 1;
            this.BancosBtnVolver.Text = "Volver";
            this.BancosBtnVolver.UseVisualStyleBackColor = false;
            this.BancosBtnVolver.Click += new System.EventHandler(this.BancosBtnVolver_Click);
            // 
            // BancosNavPacientes
            // 
            this.BancosNavPacientes.Location = new System.Drawing.Point(11, 11);
            this.BancosNavPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BancosNavPacientes.Name = "BancosNavPacientes";
            this.BancosNavPacientes.Size = new System.Drawing.Size(1078, 90);
            this.BancosNavPacientes.TabIndex = 0;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1099, 711);
            this.Controls.Add(this.BancosBtnVolver);
            this.Controls.Add(this.BancosNavPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "8014 – Pacientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BancosBtnVolver;
        private CapaVista_Navegador.Navegador BancosNavPacientes;
    }
}
