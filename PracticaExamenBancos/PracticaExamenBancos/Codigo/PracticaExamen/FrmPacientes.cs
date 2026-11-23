using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CapaControlador_Practica;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace PracticaExamen
{
    public partial class FrmPacientes : Form
    {
        private readonly ControladorPractica controlador = new ControladorPractica();
        private readonly DataTable pacientes = new DataTable();
        public FrmPacientes()
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: " + ClsSesionSeguridad.NombreUsuario;
            navegadorPacientes.RutaAyudaLocal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Ayuda","Pacientes.html");
            navegadorPacientes.NavegadorAccionSolicitada += PrepararReporte;
            navegadorPacientes.NavegadorMetConfigurar("tbl_paciente",8000,8990,
                new Dictionary<string,object> { { "DsPacientes", pacientes } });
        }
        private void PrepararReporte(string accion)
        {
            if (accion != "IMPRIMIR") return;
            pacientes.Clear();
            pacientes.Merge(controlador.ConsultarPacientes());
        }
        private void Volver(object sender, EventArgs e) { Close(); }
    }
}
