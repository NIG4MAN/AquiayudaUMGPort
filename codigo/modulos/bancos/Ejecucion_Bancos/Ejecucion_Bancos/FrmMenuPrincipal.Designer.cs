namespace Ejecucion_Bancos
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.BancosLblTitulo = new System.Windows.Forms.Label();
            this.BancosBtnSeguridad = new System.Windows.Forms.Button();
            this.BancosBtnBancos = new System.Windows.Forms.Button();
            this.BancosBtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BancosLblTitulo
            // 
            this.BancosLblTitulo.AutoSize = true;
            this.BancosLblTitulo.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BancosLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosLblTitulo.Location = new System.Drawing.Point(60, 24);
            this.BancosLblTitulo.Name = "BancosLblTitulo";
            this.BancosLblTitulo.Size = new System.Drawing.Size(220, 30);
            this.BancosLblTitulo.TabIndex = 3;
            this.BancosLblTitulo.Text = "Menú principal";
            // 
            // BancosBtnSeguridad
            // 
            this.BancosBtnSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosBtnSeguridad.FlatAppearance.BorderSize = 0;
            this.BancosBtnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BancosBtnSeguridad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BancosBtnSeguridad.ForeColor = System.Drawing.Color.White;
            this.BancosBtnSeguridad.Location = new System.Drawing.Point(60, 80);
            this.BancosBtnSeguridad.Name = "BancosBtnSeguridad";
            this.BancosBtnSeguridad.Size = new System.Drawing.Size(220, 45);
            this.BancosBtnSeguridad.TabIndex = 0;
            this.BancosBtnSeguridad.Text = "Seguridad";
            this.BancosBtnSeguridad.UseVisualStyleBackColor = false;
            this.BancosBtnSeguridad.Click += new System.EventHandler(this.BancosBtnSeguridad_Click);
            // 
            // BancosBtnBancos
            // 
            this.BancosBtnBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosBtnBancos.FlatAppearance.BorderSize = 0;
            this.BancosBtnBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BancosBtnBancos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BancosBtnBancos.ForeColor = System.Drawing.Color.White;
            this.BancosBtnBancos.Location = new System.Drawing.Point(60, 140);
            this.BancosBtnBancos.Name = "BancosBtnBancos";
            this.BancosBtnBancos.Size = new System.Drawing.Size(220, 45);
            this.BancosBtnBancos.TabIndex = 1;
            this.BancosBtnBancos.Text = "Bancos";
            this.BancosBtnBancos.UseVisualStyleBackColor = false;
            this.BancosBtnBancos.Click += new System.EventHandler(this.BancosBtnBancos_Click);
            // 
            // BancosBtnSalir
            // 
            this.BancosBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosBtnSalir.FlatAppearance.BorderSize = 0;
            this.BancosBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BancosBtnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BancosBtnSalir.ForeColor = System.Drawing.Color.White;
            this.BancosBtnSalir.Location = new System.Drawing.Point(60, 200);
            this.BancosBtnSalir.Name = "BancosBtnSalir";
            this.BancosBtnSalir.Size = new System.Drawing.Size(220, 45);
            this.BancosBtnSalir.TabIndex = 2;
            this.BancosBtnSalir.Text = "Salir";
            this.BancosBtnSalir.UseVisualStyleBackColor = false;
            this.BancosBtnSalir.Click += new System.EventHandler(this.BancosBtnSalir_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(340, 280);
            this.Controls.Add(this.BancosLblTitulo);
            this.Controls.Add(this.BancosBtnSalir);
            this.Controls.Add(this.BancosBtnBancos);
            this.Controls.Add(this.BancosBtnSeguridad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BancosLblTitulo;
        private System.Windows.Forms.Button BancosBtnSeguridad;
        private System.Windows.Forms.Button BancosBtnBancos;
        private System.Windows.Forms.Button BancosBtnSalir;
    }
}
