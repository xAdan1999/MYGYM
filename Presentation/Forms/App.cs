using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using Common.Cache;
using System;

namespace Presentation.Forms
{
    public partial class App : Form
    {
        private UsuarioModel _usuarioModel;

        private Form _activeForm = null;

        public App()
        {
            InitializeComponent();
        }

        private async void App_Load(object sender, EventArgs e)
        {
            _usuarioModel = new UsuarioModel();

            GetUsuarioAndPermisos();

            using (Task task = new Task(LoadDashboardForm))
            {
                task.Start();
                await task;
            }
        }

        //Muestra los modulos a los que tiene acceso el usuario
        private async void GetUsuarioAndPermisos()
        {
            try 
            {
                //Obtener en cache los datos del usuario autenticado mediante el id guardado tras iniciar sesion
                await _usuarioModel.GetUsuarioById(Properties.Settings.Default.usuario_id);

                //Mostrar el nombre del usuario autenticado
                lb_usuario.Text = UserCache.nombreUsuario;

                //Acceso a datos
                PermisoModel permisoModel = new PermisoModel();

                //Obtener los permisos que tiene el rol al que esta asociado el usuario auntenticado
                //Guardar los permisos en memoria para poder aplicarlos en los distintos modulos y
                //asi no tener que obtenerlos de nuevo desde la base de datos    
                Helps.StaticVariables.permisos = await permisoModel.GetPermisosByRolId(rolId: UserCache.rolId);

                Helps.StaticMethods.GetPermisos(flowLayoutPanel: flowLayoutPanel1);
            }
            catch (Exception ex)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: ex.ToString());
            }
        }

        //Para abrir forms hijos dentro del form padre
        private void OpenChildForm(Form childForm)
        {
            //Si hay algun form abierto, cerrarlo
            if (_activeForm != null) _activeForm.Close();

            //Guardar el form abierto
            _activeForm = childForm;

            //Indicar que no es una ventana de nivel superior
            childForm.TopLevel = false;

            //Acoplar el form hijo a todo el panel contendor
            childForm.Dock = DockStyle.Fill;

            //Agregarlo al panel contenedor
            panel_container.Controls.Add(childForm);

            //Mostrarlo
            childForm.Show();
        }

        private async void btn_dashboard_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadDashboardForm))
            {
                task.Start();
                await task;
            }
        }

        private void LoadDashboardForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenChildForm(new Dashboard.ViewDashboard())));
            }
        }

        private async void btn_miembros_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadMiembrosForm))
            {
                task.Start();
                await task;
            }
        }

        private void LoadMiembrosForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenChildForm(new Miembros.ViewMiembros())));
            }
        }

        private async void btn_membresias_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadMembresiasForm))
            {
                task.Start();
                await task;
            }
        }

        private void LoadMembresiasForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenChildForm(new Membresias.ViewMembresias())));
            }
        }

        private async void btn_usuarios_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadUsuariosForm))
            {
                task.Start();
                await task;
            }
        }

        private void LoadUsuariosForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenChildForm(new Usuarios.ViewUsuarios())));
            }
        }

        private async void btn_roles_usuario_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadRolesForm))
            {
                task.Start();
                await task;
            }
        }

        private void LoadRolesForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenChildForm(new Roles.ViewRoles())));
            }
        }

        private void btn_ajustes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ajustes.ViewAjustes(this));
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
