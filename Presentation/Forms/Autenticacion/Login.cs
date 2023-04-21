using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Threading;
using Domain.Models;
using System;

namespace Presentation.Forms.Autenticacion
{
    public partial class Login : Form
    {
        private UsuarioModel _usuarioModel;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _usuarioModel = new UsuarioModel();

            ApplyColorTheme();

            //Para ocultar la contraseña ya que por algun bug
            //del control, este no funciona correctamente si se 
            //activa desde la caja de propiedades
            txt_contrasena_usuario.UseSystemPasswordChar = true;
        }

        private void ApplyColorTheme()
        {
            //Recorrer los controles para aplicar el tema
            foreach (var control in panel2.Controls)
            {
                if (control is Guna2TextBox)
                {
                    Theme.ApplyColorScheme.ApplyColorSchemeOnTextBox(guna2TextBox: (Guna2TextBox)control);
                }
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            VerifyCredentials();
        }

        private async void VerifyCredentials()
        {
            try
            {
                //Para indicar que se esta realizando un proceso
                SetProgressIndicator(startProcess: true);

                //Enviar nombre y contraseña para obtener el id en caso de que el usuario si exista
                byte usuarioId = await _usuarioModel.Login(nombreUsuario: txt_nombre_usuario.Text.Trim(), contrasenaUsuario: txt_contrasena_usuario.Text.Trim());

                //Si el usuario no existe
                if (usuarioId <= 0)
                {
                    SetProgressIndicator(startProcess: false);
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Usuario o contraseña incorrecta");
                    return;
                }

                //Si el usuario existe guardar la sesion
                Properties.Settings.Default.usuario_id = usuarioId;
                Properties.Settings.Default.Save();

                //Mostrar el formulario principal en un hilo distinto
                //para poder cerrar el login sin detener toda la aplicacion
                Thread thread = new Thread(new ThreadStart(OpenMainForm));
                thread.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                SetProgressIndicator(startProcess: false);
                Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: ex.Message.ToString());
            }
        }

        private void OpenMainForm()
        {
            Application.Run(new App());
        }

        private void SetProgressIndicator(bool startProcess)
        {
            if (startProcess)
            {
                btn_ingresar.Text = "Espera...";
                btn_ingresar.Enabled = false;
                progress_indicator.Visible = true;
                progress_indicator.Start();
            }
            else
            {
                btn_ingresar.Text = "Ingresar";
                btn_ingresar.Enabled = true;
                progress_indicator.Visible = false;
                progress_indicator.Stop();
            }
        }

        //Evento para mostrar u ocultar la contraseña
        private void txt_contrasena_usuario_IconRightClick(object sender, EventArgs e)
        {
            if (txt_contrasena_usuario.UseSystemPasswordChar == true)
            {
                txt_contrasena_usuario.IconRight = Properties.Resources.ic_ocultar_contrasena;
                txt_contrasena_usuario.UseSystemPasswordChar = false;
            }
            else
            {
                txt_contrasena_usuario.IconRight = Properties.Resources.ic_mostrar_contrasena;
                txt_contrasena_usuario.UseSystemPasswordChar = true;
            }
        }

        #region eventos de teclado

        private void txt_nombre_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerifyCredentials();
            }
        }

        private void txt_contrasena_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerifyCredentials();
            }
        }

        #endregion 
    }
}
