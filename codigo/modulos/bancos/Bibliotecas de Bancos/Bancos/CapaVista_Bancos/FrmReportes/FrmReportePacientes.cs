/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 23/11/2026
 * ================================================================
 * Propósito :
 *  Muestra en un visor el reporte con el listado de pacientes
 *  registrados en el mantenimiento Pacientes.
 * ================================================================
 */
using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Bancos;
using Microsoft.Reporting.WinForms;

namespace CapaVista_Bancos.FrmReportes
{
    public partial class FrmReportePacientes : Form
    {
        private readonly ClsControladorPaciente _Controlador = new ClsControladorPaciente();

        public FrmReportePacientes()
        {
            InitializeComponent();
        }

        private void FrmReportePacientes_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable Pacientes = _Controlador.BancosMetConsultarPacientes();

                ReportDataSource DatosReporte = new ReportDataSource("DsPacientes", Pacientes);
                BancosRvReporte.LocalReport.ReportEmbeddedResource = "CapaVista_Bancos.Reporte.RpReportePacientes.rdlc";
                BancosRvReporte.LocalReport.DataSources.Clear();
                BancosRvReporte.LocalReport.DataSources.Add(DatosReporte);
                BancosRvReporte.RefreshReport();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "No fue posible generar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
