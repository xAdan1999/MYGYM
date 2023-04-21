using System.Windows.Forms;
using Guna.UI2.WinForms;
using System;

namespace Presentation.Helps
{
    public class StaticMethods
    {
        //Esta clase contiene metodos genericos para utilizar en cualquier parte
        //del proyecto (capa de presentacion)

        public static DialogResult ShowGenericMessageBox(string message)
        {
            return MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowGenericErrorMessageBox(string errorMessage)
        {
            return MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void GetPermisos(FlowLayoutPanel flowLayoutPanel)
        {
            //Recorrer el menu de opciones
            foreach (var control in flowLayoutPanel.Controls)
            {
                //Si el control recorrido es un boton
                if (control is Guna2Button)
                {
                    //Convertirlo a tipo boton para acceder a la propiedad tag
                    var button = (Guna2Button)control;

                    //Recorrar la lista de permisos
                    foreach (var permiso in Helps.StaticVariables.permisos)
                    {
                        //Si el tag del boton recorrido corresponde a una de las operaciones del sistema
                        //(1 - estadisticas, 2 - miembros, 6 - membresias, 10 - usuarios, 14 - roles)
                        if (permiso.OperacionId == Convert.ToByte(button.Tag))
                        {
                            //Si el permiso para para esa operacion es 0
                            //bloquear el boton pues no tiene accesso
                            if (permiso.Status == 1)
                            {
                                button.Visible = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
