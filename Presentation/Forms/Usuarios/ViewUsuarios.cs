using Presentation.Forms.Controles;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;
using Domain.Models;
using System;

namespace Presentation.Forms.Usuarios
{
    public partial class ViewUsuarios : Form
    {
        private UsuarioModel _usuarioModel;

        public ViewUsuarios()
        {
            InitializeComponent();
        }

        private void ViewUsuarios_Load(object sender, EventArgs e)
        {
            Helps.StaticMethods.GetPermisos(flowLayoutPanel: flowLayoutPanel1);

            _usuarioModel = new UsuarioModel();

            ApplyColorScheme();

            SetData();
        }

        //Anteriormente solo habia un metodo que cargaba la informacion pero aplicaba
        //ajustes como ocultar columnas cada vez que era necesario actualizar cambios,
        //para eso se creo este metodo el cual aplica esos ajustes solo una vez ya que
        //solo sera llamado al inicio
        private async void SetData()
        {
            lb_titulo.Text = "Cargando información...";
            progress_indicator.Visible = true;
            progress_indicator.Start();

            try
            {
                dataGridView_usuarios.RowTemplate.Height = 32;
                dataGridView_usuarios.DataSource = await _usuarioModel.GetAllUsuarios();
                dataGridView_usuarios.Columns[3].Visible = false; // Columna id rol
            }
            catch (Exception ex)
            {
                Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: ex.Message.ToString());
            }

            CountRows();
            progress_indicator.Visible = false;
            progress_indicator.Stop();
        }

        private void ApplyColorScheme()
        {
            Theme.ApplyColorScheme.ApplyColorSchemeOnTextBox(guna2TextBox: txt_buscar);
            Theme.ApplyColorScheme.ApplyColorSchemeOnDataGridView(dataGridView: dataGridView_usuarios);

            //Recorrer los checkbox para aplicar el tema
            foreach (var control in panel_columnas.Controls)
            {
                if (control is Guna2CheckBox)
                {
                    Theme.ApplyColorScheme.ApplyColorSchemeOnCheckBox(guna2CheckBox: (Guna2CheckBox)control);
                }
            }
        }

        //Realiza un conteo rapido desde el datagridview
        private void CountRows()
        {
            lb_titulo.Text = string.Format("Usuarios / {0}", dataGridView_usuarios.Rows.Count.ToString());
        }

        //Recarga la informacion en el datagridview
        private async void RefreshData()
        {
            try
            {
                dataGridView_usuarios.DataSource = await _usuarioModel.GetAllUsuarios();
                CountRows();

                CustomBottomMessage bottomMessage = new CustomBottomMessage();
                bottomMessage.message = "Datos actualizados correctamente";
                bottomMessage.Dock = DockStyle.Fill;

                panel_bottom_message.Controls.Add(bottomMessage);
            }
            catch (Exception ex)
            {
                Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: ex.Message.ToString());
            }
        }

        //Se buscan coincidencias con cada pulsacion de teclas
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView_usuarios.DataSource = _usuarioModel.SearchUsuario(usuario: txt_buscar.Text.Trim());
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            CreateUsuario();
        }

        private void CreateUsuario()
        {
            using (FormUsuario formUsuario = new FormUsuario())
            {
                //Si el form responde un OK, quiere decir que todo salio bien
                //y se puede actualizar la informacion, de esta manera se evita
                //consultar a la base de datos en caso de que algo salga mal tras
                //cerrar el form
                var result = formUsuario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshData();
                }
            }
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            UpdateUsuario();
        }

        private void UpdateUsuario()
        {
            //Solo si hay algo seleccionado en el datagridview se podra editar
            if (dataGridView_usuarios.SelectedRows.Count == 0)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "No hay nada seleccionado");
                return;
            }

            //Recuperar el id del usuario
            byte usuarioId = Convert.ToByte(dataGridView_usuarios.CurrentRow.Cells[0].Value.ToString());

            //Abrir el formulario
            using (FormUsuario formUsuario = new FormUsuario(usuarioId: usuarioId))
            {
                //Recuperar los valores para poder editarlos
                formUsuario.txt_nombre_usuario.Text = dataGridView_usuarios.CurrentRow.Cells[1].Value.ToString();
                formUsuario.txt_contrasena_usuario.Text = dataGridView_usuarios.CurrentRow.Cells[2].Value.ToString();
                formUsuario.txt_confirmar_contrasena_usuario.Text = dataGridView_usuarios.CurrentRow.Cells[2].Value.ToString();
                formUsuario.cb_rol_usuario.Text = dataGridView_usuarios.CurrentRow.Cells[3].Value.ToString();

                //Si el form responde un OK, quiere decir que todo salio bien
                //y se puede actualizar la informacion, de esta manera se evita
                //consultar a la base de datos en caso de que algo salga mal tras
                //cerrar el form
                var result = formUsuario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshData();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DeleteUsuario();
        }

        private async void DeleteUsuario()
        {
            //Solo si hay algo seleccionado en el datagridview se podra eliminar
            if (dataGridView_usuarios.SelectedRows.Count == 0)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "No hay nada seleccionado");
                return;
            }

            //Recuperar el id del usuario para poder eliminarlo
            byte usuarioId = Convert.ToByte(dataGridView_usuarios.CurrentRow.Cells[0].Value.ToString());

            //Recuperar el nombre para mostrarlo al usuario
            string nombreUsuario = dataGridView_usuarios.CurrentRow.Cells[3].Value.ToString();

            //Mostrar un mensaje para confirmar si se desea eliminar y almacenar el resultado del dialogo 
            var dialogResult = MessageBox.Show(($"El usuario '{ nombreUsuario }' será eliminado, ¿Estás seguro?"), "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si se acepta eliminar
            if (dialogResult == DialogResult.Yes)
            {
                //Indicar el comportamiento de estado de la entidad y mandar el id
                _usuarioModel.EntityState = Domain.ValueObjects.EntityState.Deleted;
                _usuarioModel.UsuarioId = usuarioId;

                //Capturar el resultado e informar al usuario
                string result = await _usuarioModel.SaveChanges();

                //Si se elimino correctamente
                if (result == "deleted")
                {
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Usuario eliminado correctamente");
                    RefreshData();
                }
                else
                {
                    Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: result);
                }
            }
        }

        //Este evento permite editar un elemento seleccionado al hacer doble click
        private void dataGridView_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateUsuario();
        }

        private void btn_mostrar_columnas_Click(object sender, EventArgs e)
        {
            panel_columnas.Visible = panel_columnas.Visible == false ? true : false;
        }

        //Para mostrar u ocultar columnas
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Recorrer los controles que estan en el panel de mostrar u ocultar columnas
            foreach (var control in panel_columnas.Controls)
            {
                //Si el control recorrido es de tipo checkbox
                if (control is Guna2CheckBox)
                {
                    //Convertirlo al tipo checkbox para poder acceder a sus propiedades
                    var checkBox = (Guna2CheckBox)control;

                    //Obtener la columna
                    byte column = Convert.ToByte(checkBox.Tag);

                    //Si esta activo 
                    if (checkBox.Checked)
                    {
                        //Mostrar la columna deseada mediante el tag del checkbox previamente 
                        //agregado desde las propiedades de control
                        dataGridView_usuarios.Columns[column].Visible = true;
                    }
                    else
                    {
                        //Caso contrario ocultar la columna de igual manera mediante el tag
                        dataGridView_usuarios.Columns[column].Visible = false;
                    }
                }
            }
            panel_columnas.Visible = false;
        }

        private void dataGridView_usuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.Value = new string('●', e.Value.ToString().Length);
            }
        }
    }
}
