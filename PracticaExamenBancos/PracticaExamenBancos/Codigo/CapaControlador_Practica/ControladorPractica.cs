using System.Data;
using CapaModelo_Practica;

namespace CapaControlador_Practica
{
    public sealed class ControladorPractica
    {
        private readonly RepositorioPractica repositorio = new RepositorioPractica();
        public void Preparar(string directorio) { repositorio.Preparar(directorio); }
        public DataTable ConsultarPacientes() { return repositorio.ConsultarPacientes(); }
    }
}
