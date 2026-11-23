using System;
using System.Windows.Forms;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace PracticaExamen
{
    public partial class FrmBancosPractica : Form
    {
        public FrmBancosPractica()
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: " + ClsSesionSeguridad.NombreUsuario;
        }
        private void AbrirPacientes(object sender, EventArgs e)
        {
            using (var formulario = new FrmPacientes()) formulario.ShowDialog(this);
        }
        private void Volver(object sender, EventArgs e) { Close(); }
    }
}
