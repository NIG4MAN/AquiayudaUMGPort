/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 23/11/2026
 * ================================================================
 * Propósito :
 *  Menú principal que se muestra después del Splash. Permite entrar
 *  al módulo de Seguridad o al módulo de Bancos.
 * ================================================================
 */

using System;
using System.Windows.Forms;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace Ejecucion_Bancos
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BancosBtnSeguridad_Click(object sender, EventArgs e)
        {
            using (var Formulario = new CapaVista_Seguridad.FrmMDISeguridad())
            {
                Formulario.ShowDialog(this);
            }
        }

        private void BancosBtnBancos_Click(object sender, EventArgs e)
        {
            using (var Formulario = new CapaVista_Bancos.Formularios.FrmMDIBancos())
            {
                Formulario.BancosMetActualizarInfoUsuario(
                    ClsSesionSeguridad.NombreEmpleado,
                    ClsSesionSeguridad.SeguridadMetRolesComoTexto());

                Formulario.ShowDialog(this);
            }
        }

        private void BancosBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
