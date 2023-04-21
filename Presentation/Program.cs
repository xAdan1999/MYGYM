using System.Windows.Forms;
using System;

namespace Presentation
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

            //Si hay un usuario autenticado abrir directamente la aplicacion 
            //de lo contrario abrir el login para iniciar sesion
            if (Auth())
            {
                Application.Run(new Forms.App());
            }
            else
            {
                Application.Run(new Forms.Autenticacion.Login());
            }
        }

        private static bool Auth()
        {
            //Si el id del usuario guardado en el archivo de configuracion
            //es diferente de 0 quiere decir que hay un usuario auntenticado
            return Properties.Settings.Default.usuario_id != 0 ? true : false;
        }
    }
}
