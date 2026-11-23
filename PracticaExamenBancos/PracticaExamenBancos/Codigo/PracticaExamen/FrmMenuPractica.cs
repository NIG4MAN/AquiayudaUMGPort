using System;
using System.Windows.Forms;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad;

namespace PracticaExamen
{
    public partial class FrmMenuPractica : Form
    {
        public FrmMenuPractica()
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: " + ClsSesionSeguridad.NombreUsuario;
        }
        private void AbrirSeguridad(object sender, EventArgs e)
        {
            using (var formulario = new FrmMDISeguridad()) formulario.ShowDialog(this);
        }
        private void AbrirBancos(object sender, EventArgs e)
        {
            using (var formulario = new FrmBancosPractica()) formulario.ShowDialog(this);
        }
        private void Salir(object sender, EventArgs e) { Close(); }
    }
}
