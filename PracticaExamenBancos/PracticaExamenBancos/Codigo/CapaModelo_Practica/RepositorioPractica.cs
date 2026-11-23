using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

namespace CapaModelo_Practica
{
    public sealed class RepositorioPractica
    {
        public const string ConexionPractica = "Dsn=EmbutidosS.A;Database=dbpractica_pacientes";

        public void Preparar(string directorio)
        {
            using (var conexion = new OdbcConnection("Dsn=EmbutidosS.A"))
            {
                conexion.Open();
                string estructura = File.ReadAllText(Path.Combine(directorio, "Sql", "01_Estructura.sql"));
                foreach (string sentencia in estructura.Split(';'))
                {
                    if (string.IsNullOrWhiteSpace(sentencia)) continue;
                    using (var comando = new OdbcCommand(sentencia, conexion)) comando.ExecuteNonQuery();
                }
                using (var transaccion = conexion.BeginTransaction())
                {
                    foreach (string sentencia in File.ReadAllText(Path.Combine(directorio, "Sql", "02_Catalogos.sql")).Split(';'))
                    {
                        if (string.IsNullOrWhiteSpace(sentencia)) continue;
                        using (var comando = new OdbcCommand(sentencia, conexion, transaccion)) comando.ExecuteNonQuery();
                    }
                    using (var comando = new OdbcCommand(@"INSERT INTO tblusuario
                        (idUsuario,idEmpleado,nombreUsuario,contrasenaUsuario,ultimoAccesoUsuario,is_active)
                        SELECT 1,1,'usuariofinal',?,NOW(),1
                        WHERE NOT EXISTS (SELECT 1 FROM tblusuario WHERE nombreUsuario='usuariofinal')", conexion, transaccion))
                    {
                        comando.Parameters.Add("clave", OdbcType.VarChar, 255).Value = BCrypt.Net.BCrypt.HashPassword("Practica2026!");
                        comando.ExecuteNonQuery();
                    }
                    using (var comando = new OdbcCommand(@"INSERT INTO tblusuariorol
                        (idUsuario,idRol,fechaAsignacionUsuarioRol)
                        SELECT idUsuario,1,CURRENT_DATE FROM tblusuario u
                        WHERE nombreUsuario='usuariofinal' AND NOT EXISTS
                        (SELECT 1 FROM tblusuariorol r WHERE r.idUsuario=u.idUsuario AND r.idRol=1)", conexion, transaccion)) comando.ExecuteNonQuery();
                    using (var comando = new OdbcCommand("UPDATE tblReporte SET rutaReporte=? WHERE numeroReporte=8990", conexion, transaccion))
                    {
                        comando.Parameters.Add("ruta", OdbcType.VarChar, 500).Value = Path.Combine(directorio, "Reportes", "Pacientes.rdlc");
                        comando.ExecuteNonQuery();
                    }
                    transaccion.Commit();
                }
            }
        }

        public DataTable ConsultarPacientes()
        {
            using (var conexion = new OdbcConnection(ConexionPractica))
            using (var adaptador = new OdbcDataAdapter("SELECT * FROM tbl_paciente ORDER BY pk_idPaciente", conexion))
            {
                var tabla = new DataTable("DsPacientes");
                adaptador.Fill(tabla);
                return tabla;
            }
        }
    }
}
