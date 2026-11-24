/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 23/11/2026
 * ================================================================
 * Propósito :
 *  Controlador del mantenimiento de Pacientes. Recibe las solicitudes
 *  de la vista y las delega al repositorio del Modelo.
 * ================================================================
 */

using System.Data;
using CapaModelo_Bancos.Repositorio;

namespace CapaControlador_Bancos
{
    public sealed class ClsControladorPaciente
    {
        private readonly ClsRepositorioPaciente _Repositorio = new ClsRepositorioPaciente();

        public DataTable BancosMetConsultarPacientes()
        {
            return _Repositorio.BancosMetConsultarPacientes();
        }
    }
}
