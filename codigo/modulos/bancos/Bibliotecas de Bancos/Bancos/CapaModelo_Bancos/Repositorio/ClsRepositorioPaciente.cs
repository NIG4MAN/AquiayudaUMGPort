/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 23/11/2026
 * ================================================================
 * Propósito :
 *  Repositorio del mantenimiento de Pacientes. Contiene la consulta
 *  ODBC que alimenta el reporte; el ingreso, la modificación y la
 *  eliminación los ejecuta el componente Navegador.
 * ================================================================
 */

using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Bancos.Repositorio
{
    public sealed class ClsRepositorioPaciente : ClsConexion
    {
        public DataTable BancosMetConsultarPacientes()
        {
            const string Sentencia = @"
                SELECT pk_idPaciente,
                       nombrePaciente,
                       apellidoPaciente,
                       fechaNacimientoPaciente,
                       sexoPaciente,
                       direccionPaciente,
                       telefonoPaciente,
                       estadoPaciente
                FROM tbl_paciente
                ORDER BY pk_idPaciente";

            using (OdbcConnection Conexion = BancosMetObtenerConexion())
            using (OdbcDataAdapter Adaptador = new OdbcDataAdapter(Sentencia, Conexion))
            {
                DataTable Pacientes = new DataTable("DsPacientes");
                Adaptador.Fill(Pacientes);
                return Pacientes;
            }
        }
    }
}
