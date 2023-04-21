using System.Windows.Forms;
using Guna.UI2.WinForms;
using Domain.Models;
using System;

namespace Presentation.Forms.Roles
{
    public partial class FormRol : Form
    {
        private RolModel _rolModel;

        private PermisoModel _permisoModel;

        //Para editar
        private byte _rolId = 0;

        //Cuando se va a agregar
        public FormRol()
        {
            InitializeComponent();
        }

        //Cuando se va a editar
        public FormRol(byte rolId)
        {
            InitializeComponent();

            _rolId = rolId;
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            _rolModel = new RolModel();

            _permisoModel = new PermisoModel();

            ApplyColorScheme();

            //Si el id es igual a 0 quiere decir que se va a agregar 
            //de lo contrario quiere decir que se va a editar
            lb_titulo.Text = _rolId == 0 ? "Agregar rol" : "Editar rol";

            //Si el id es mayor a 0 quiere decir que se va a editar 
            //por lo que es necesario consultar los permisos del rol
            //para visualizarlos y editarlos
            if(_rolId > 0)
            {
                btn_guardar_permisos.Enabled = true;

                panel_permisos.Enabled = true;

                GetPermisos();
            }
        }

        private void ApplyColorScheme()
        {
            Theme.ApplyColorScheme.ApplyColorSchemeOnTextBox(guna2TextBox: txt_nombre_rol);

            //Recorrer los checkbox para aplicar el tema
            foreach (var control in panel_permisos.Controls)
            {
                if (control is Guna2CheckBox)
                {
                    Theme.ApplyColorScheme.ApplyColorSchemeOnCheckBox(guna2CheckBox: (Guna2CheckBox)control);
                }
            }
        }

        //Obtiene los permisos del rol
        private async void GetPermisos()
        {
            //Obtener los permisos
            var permisos = await _permisoModel.GetPermisosByRolId(rolId: _rolId);

            //Recorrer los controles
            foreach (var control in panel_permisos.Controls)
            {
                //Si el control recorrido es un checkbox
                if (control is Guna2CheckBox)
                {
                    //Convertirlo a tipo checkbox para acceder a la propiedad tag
                    var checkBox = (Guna2CheckBox)control;

                    //Recorrer la lista de permisos
                    foreach (var permiso in permisos)
                    {
                        //Si la operacion es igual al tag del checkbox
                        if (permiso.OperacionId == Convert.ToByte(checkBox.Tag))
                        {
                            //Si el permiso para esa operacion es 1 marcar el checkbox
                            if (permiso.Status == 1)
                            {
                                checkBox.Checked = true;
                            }
                        }
                    }
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_rol_Click(object sender, EventArgs e)
        {
            CreateRol();
        }

        private async void CreateRol()
        {
            //Si hay algun campo requerido vacio no continuar
            if (string.IsNullOrEmpty(txt_nombre_rol.Text))
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "Debes asignar un nombre al rol");
                return;
            }

            //Asignar los valores al objeto
            _rolModel.RolId = _rolId;
            _rolModel.Nombre = txt_nombre_rol.Text.Trim();

            //Dependiendo de la accion a realizar (agregar o editar) 
            //asignar un comportamiento al estado de entidad
            _rolModel.EntityState = _rolId == 0 ? Domain.ValueObjects.EntityState.Created : Domain.ValueObjects.EntityState.Updated;

            //En caso de que el proceso este tardando, bloquear los botones 
            //para evitar que el usuario haga movimientos innecesarios y 
            //ocurra un error
            btn_guardar_rol.Text = "Espera...";
            btn_cancelar.Enabled = false;
            btn_guardar_rol.Enabled = false;

            //Verificar el mensaje capturado
            string message = await _rolModel.SaveChanges();

            btn_guardar_rol.Text = "Guardar";
            btn_cancelar.Enabled = true;

            //En modo editar los botones de guardar permisos y el rol
            //estaran activos pues puede que solo se desee editar el rol
            //o los permisos de este
            btn_guardar_rol.Enabled = _rolId != 0 ? true : false;

            //Fijar un mensaje de informacion
            SetMessage(message: message);
        }

        private void SetMessage(string message)
        {
            //Si no corresponde a un "created" o un "updated" 
            //quiere decir que algo salio mal
            switch (message)
            {
                case "created":
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Rol creado correctamente");
                    panel_permisos.Enabled = true;
                    btn_cancelar.Enabled = false;
                    btn_guardar_rol.Enabled = false;
                    btn_guardar_permisos.Enabled = true;
                    break;

                case "updated":
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Datos actualizados correctamente");
                    panel_permisos.Enabled = true;
                    btn_cancelar.Enabled = false;
                    btn_guardar_rol.Enabled = false;
                    btn_guardar_permisos.Enabled = true;
                    break;

                default:
                    Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: message);
                    break;
            }
        }

        private void btn_guardar_permisos_Click(object sender, EventArgs e)
        {
            CreatePermisos();
        }

        private async void CreatePermisos()
        {
            //Dependiendo de la accion a realizar (agregar o editar) asignar un comportamiento al estado de entidad
            _permisoModel.EntityState = _rolId == 0 ? Domain.ValueObjects.EntityState.Created : Domain.ValueObjects.EntityState.Updated;

            //Obtener el id del rol que se acaba de agregar
            byte rolId = _rolModel.GetLastRolId();

            //Recorrer los controles
            foreach (var control in panel_permisos.Controls)
            {
                //Si el control recorrido es un checkbox
                if (control is Guna2CheckBox)
                {
                    //Convertirlo al tipo checkbox para poder acceder a sus propiedades
                    var checkBox = (Guna2CheckBox)control;

                    //Si esta activo
                    if (checkBox.Checked == true)
                    {
                        //Asingar 1 para indicar que tiene permiso
                        _permisoModel.Status = 1;
                    }
                    else
                    {
                        //Caso contrario asignar un 0
                        _permisoModel.Status = 0;
                    }
                    _permisoModel.RolId = _rolId == 0 ? rolId : _rolId;
                    _permisoModel.OperacionId = Convert.ToByte(checkBox.Tag);
                    await _permisoModel.SaveChanges();
                }
            }
            Helps.StaticMethods.ShowGenericMessageBox(message: "Permisos generados correctamente");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region eventos de teclado

        private void txt_nombre_rol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateRol();
            }
        }

        #endregion
    }
}
