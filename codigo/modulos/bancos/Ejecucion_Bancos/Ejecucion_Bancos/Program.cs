using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_Seguridad;
using CapaVista_Bancos.Formularios;
using CapaVista_Seguridad;

namespace Ejecucion_Bancos
{           
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmSplash.CrearMenuPrincipal = () => new FrmMenuPrincipal();

            Application.Run(new FrmLogin());
        }
    }
}
