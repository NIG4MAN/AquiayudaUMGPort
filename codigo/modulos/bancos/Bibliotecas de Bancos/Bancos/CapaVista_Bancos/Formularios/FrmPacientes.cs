/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 23/11/2026
 * ================================================================
 * Propósito :
 *  Mantenimiento de Pacientes (aplicación 8014 del módulo Bancos).
 *  Usa el componente Navegador para ingresar, modificar, eliminar,
 *  imprimir y consultar; la consulta del reporte la pide al Controlador.
 * ================================================================
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Bancos;

namespace CapaVista_Bancos.Formularios
{
    public partial class FrmPacientes : Form
    {
        private readonly ClsControladorPaciente _Controlador = new ClsControladorPaciente();
        private readonly DataTable _Pacientes = new DataTable("DsPacientes");

        public FrmPacientes()
        {
            InitializeComponent();

            BancosNavPacientes.NavegadorAccionSolicitada += BancosMetPrepararReporte;

            // 8000 = módulo Bancos, 8014 = aplicación Pacientes (debe coincidir con Seguridad)
            BancosNavPacientes.NavegadorMetConfigurar(
                "tbl_paciente",
                8000,
                8014,
                new Dictionary<string, object>
                {
                    { "DsPacientes", _Pacientes }
                });
        }

        private void BancosMetPrepararReporte(string Accion)
        {
            if (Accion != "IMPRIMIR")
                return;

            _Pacientes.Clear();
            _Pacientes.Merge(_Controlador.BancosMetConsultarPacientes());
        }

        private void BancosBtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
