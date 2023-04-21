using System.Windows.Forms;
using Guna.UI2.WinForms;
using Domain.Models;
using System;

namespace Presentation.Forms.Usuarios
{
    public partial class FormUsuario : Form
    {
        private UsuarioModel _usuarioModel;

        private RolModel _rolModel;

        //Para editar
        private byte _usuarioId = 0;

        //Cuando se va a agregar
        public FormUsuario()
        {
            InitializeComponent();
        }

        //Cuando se va a editar
        public FormUsuario(byte usuarioId)
        {
            InitializeComponent();

            _usuarioId = usuarioId;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            _usuarioModel = new UsuarioModel();

            _rolModel = new RolModel();

            ApplyColorScheme();

            //Si el id es igual a 0 quiere decir que se va a agregar 
            //de lo contrario quiere decir que se va a editar
            lb_titulo.Text = _usuarioId == 0 ? "Agregar usuario" : "Editar usuario";

            //Para ocultar la contraseña ya que por algun bug
            //del control, este no funciona correctamente si se 
            //activo desde las propiedades 
            txt_contrasena_usuario.UseSystemPasswordChar = true;
            txt_confirmar_contrasena_usuario.UseSystemPasswordChar = true;

            //Obtener los roles
            GetRoles();
        }

        private void ApplyColorScheme()
        {
            //Recorrer los controles para aplicar el tema correspondiente
            foreach (var control in this.Controls)
            {
                if (control is Guna2TextBox)
                {
                    Theme.ApplyColorScheme.ApplyColorSchemeOnTextBox(guna2TextBox: (Guna2TextBox)control);
                }
                else if (control is Guna2ComboBox)
                {
                    Theme.ApplyColorScheme.ApplyColorSchemeOnComboBox(guna2ComboBox: (Guna2ComboBox)control);
                }
            }
        }

        //Carga la lista de membresias en el combobox
        private void GetRoles()
        {
            var lstRoles = _rolModel.GetAllRolesOnComboBox();
            cb_rol_usuario.DataSource = lstRoles;
            cb_rol_usuario.DisplayMember = "Nombre";
            cb_rol_usuario.ValueMember = "RolId";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            CreateUsuario();
        }

        private async void CreateUsuario()
        {
            //Si hay algun campo requerido vacio no continuar
            if (string.IsNullOrEmpty(txt_nombre_usuario.Text) || string.IsNullOrEmpty(txt_contrasena_usuario.Text))
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "Asegurate de llenar todos los campos");
                return;
            }

            //Si las contraseñas no coinciden
            if (txt_contrasena_usuario.Text.Trim() != txt_confirmar_contrasena_usuario.Text.Trim())
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "La contraseña no coincide, por favor verificala");
                return;
            }

            //Si no hay roles no se podra crear el usuario
            if (cb_rol_usuario.Items.Count == 0)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "Es necesario que antes agregues algunos roles");
                return;
            }

            //Asignar los valores al objeto
            _usuarioModel.UsuarioId = _usuarioId;
            _usuarioModel.RolId = Convert.ToByte(cb_rol_usuario.SelectedValue.ToString());
            _usuarioModel.NombreUsuario = txt_nombre_usuario.Text.Trim();
            _usuarioModel.Contrasena = txt_contrasena_usuario.Text.ToString();

            //Dependiendo de la accion a realizar (agregar o editar) asignar un comportamiento al estado de entidad
            _usuarioModel.EntityState = _usuarioId == 0 ? Domain.ValueObjects.EntityState.Created : Domain.ValueObjects.EntityState.Updated;

            //En caso de que el proceso este tardando, bloquear los botones 
            //para evitar que el usuario haga movimientos innecesarios y 
            //ocurra un error
            btn_guardar.Text = "Espera...";
            btn_cancelar.Enabled = false;
            btn_guardar.Enabled = false;

            //Verificar el mensaje capturado
            string message = await _usuarioModel.SaveChanges();

            btn_guardar.Text = "Guardar";
            btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;

            //Fijar un mensaje de informacion
            SetMessage(message);
        }

        private void SetMessage(string message)
        {
            //Si no corresponde a un "created" o un "updated" 
            //quiere decir que algo salio mal
            switch (message)
            {
                case "created":
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Usuario creado correctamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;

                case "updated":
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Datos actualizados correctamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;

                default:
                    Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: message);
                    break;
            }
        }

        //Para mostrar u ocultar la contraseña
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

        //Para mostrar u ocultar la contraseña
        private void txt_confirmar_contrasena_usuario_IconRightClick(object sender, EventArgs e)
        {
            if (txt_confirmar_contrasena_usuario.UseSystemPasswordChar == true)
            {
                txt_contrasena_usuario.IconRight = Properties.Resources.ic_ocultar_contrasena;
                txt_confirmar_contrasena_usuario.UseSystemPasswordChar = false;
            }
            else
            {
                txt_contrasena_usuario.IconRight = Properties.Resources.ic_mostrar_contrasena;
                txt_confirmar_contrasena_usuario.UseSystemPasswordChar = true;
            }
        }
    }
}
