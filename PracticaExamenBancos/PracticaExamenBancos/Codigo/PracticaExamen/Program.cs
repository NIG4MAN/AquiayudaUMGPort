using System;
using System.IO;
using System.Windows.Forms;
using CapaControlador_Practica;
using CapaVista_Seguridad;

namespace PracticaExamen
{
    internal static class Program
    {
        [STAThread]
        private static int Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            try
            {
                new ControladorPractica().Preparar(AppDomain.CurrentDomain.BaseDirectory);
                if (args.Length > 0 && args[0] == "--preparar") return 0;
                FrmSplash.CrearMenuPractica = () => new FrmMenuPractica();
                Application.Run(new FrmLogin());
                return 0;
            }
            catch (Exception error)
            {
                if (args.Length > 0) { Console.Error.WriteLine(error); return 1; }
                MessageBox.Show("No se pudo iniciar la práctica. Comprueba que MySQL esté iniciado y que exista el DSN de 64 bits EmbutidosS.A.\n\n" + error.Message,
                    "Práctica de Bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }
    }
}
