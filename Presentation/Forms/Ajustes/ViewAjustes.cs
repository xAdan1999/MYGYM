using Presentation.Forms.Autenticacion;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using Common.Cache;
using System;

namespace Presentation.Forms.Ajustes
{
    public partial class ViewAjustes : Form
    {
        //En caso de querer cerrar sesion
        private Form _app;

        public ViewAjustes(Form app)
        {
            InitializeComponent();

            _app = app;
        }

        private void ViewAjustes_Load(object sender, EventArgs e)
        {
            lb_usuario.Text = string.Format("Usuario: {0} - {1}", UserCache.nombreUsuario, UserCache.rolNombre);
        }

        #region color primario

        private void btn_color_1_Click(object sender, EventArgs e)
        {
            SetPrimaryColor(primaryColor: Color.FromArgb(94, 148, 255));
        }

        private void btn_color_2_Click(object sender, EventArgs e)
        {
            SetPrimaryColor(primaryColor: Color.MediumOrchid);
        }

        private void btn_color_3_Click(object sender, EventArgs e)
        {
            SetPrimaryColor(primaryColor: Color.FromArgb(236, 60, 64));
        }

        private void btn_color_4_Click(object sender, EventArgs e)
        {
            SetPrimaryColor(primaryColor: Color.DarkOrange);
        }

        private void btn_color_5_Click(object sender, EventArgs e)
        {
            SetPrimaryColor(primaryColor: Color.MediumSeaGreen);
        }

        private void btn_color_6_Click(object sender, EventArgs e)
        {
            SetPrimaryColor(primaryColor: Color.FromArgb(107, 196, 60));
        }

        private void btn_color_personalizado_Click(object sender, EventArgs e)
        {
            GetCustomColor();
        }

        //Establece el color primario de la aplicacion
        public static void SetPrimaryColor(Color primaryColor)
        {
            Properties.Settings.Default.primary_color = primaryColor;
            Properties.Settings.Default.Save();
        }

        //Permite seleccionar un color personalizado
        public static void GetCustomColor()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = true;

                colorDialog.ShowHelp = true;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    SetPrimaryColor(primaryColor: colorDialog.Color);
                }
            }
        }

        #endregion

        #region estilo de borde de controles

        private void btn_completamente_cuadrado_Click(object sender, EventArgs e)
        {
            SetBorderRadius(borderSize: 0);
        }

        private void btn_medianamente_redondo_Click(object sender, EventArgs e)
        {
            SetBorderRadius(borderSize: 2);
        }

        private void btn_completamente_redondo_Click(object sender, EventArgs e)
        {
            SetBorderRadius(borderSize: 14);
        }

        private void SetBorderRadius(int borderSize)
        {
            Properties.Settings.Default.control_border_size = borderSize;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region tema

        private async void ts_dark_mode_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(SwitchTheme))
            {
                task.Start();
                await task;
            }
        }

        private void SwitchTheme()
        {
            if (ts_dark_mode.Checked)
            {
                Theme.ApplyTheme.ApplyDarkMode();
            }
            else
            {
                Theme.ApplyTheme.ApplyLightMode();
            }
        }

        #endregion

        #region cuenta

        private void lb_cerrar_sesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Resetear el id del usuario para indicar que no
            //existen usuarios autenticados en el sistema
            Properties.Settings.Default.usuario_id = 0;
            Properties.Settings.Default.Save();

            //Mostrar el login
            Thread thread = new Thread(new ThreadStart(OpenLogin));
            thread.Start();
            _app.Close();
        }

        private void OpenLogin()
        {
            Application.Run(new Login());
        }

        #endregion
    }
}
