using Presentation.Forms.Controles;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;
using Domain.Models;
using System;

namespace Presentation.Forms.Miembros
{
    public partial class ViewMiembros : Form
    {
        private MiembroModel _miembroModel;

        public ViewMiembros()
        {
            InitializeComponent();
        }

        private void ViewMiembros_Load(object sender, EventArgs e)
        {
            Helps.StaticMethods.GetPermisos(flowLayoutPanel: flowLayoutPanel1);

            _miembroModel = new MiembroModel();

            ApplyColorScheme();

            VerifyStatus();

            SetData();
        }

        private async void VerifyStatus()
        {
            await _miembroModel.UpdateStatus();
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
                dataGridView_miembros.RowTemplate.Height = 32;
                dataGridView_miembros.DataSource = await _miembroModel.GetAllMiembros();
                dataGridView_miembros.Columns[7].DefaultCellStyle.Format = "C2";
                HideDataGridViewColumns();
            }
            catch (Exception ex)
            {
                Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: ex.Message.ToString());
            }

            CountRows();
            progress_indicator.Visible = false;
            progress_indicator.Stop();
        }

        //Para ocultar algunas columnas
        private void HideDataGridViewColumns()
        {
            //telefono, membresia id, fecha creacion, ultima modificacion
            int[] columnsToHide = new int[] { 3, 5, 11, 12 };

            foreach (var column in columnsToHide)
            {
                dataGridView_miembros.Columns[column].Visible = false;
            }
        }

        private void ApplyColorScheme()
        {
            Theme.ApplyColorScheme.ApplyColorSchemeOnTextBox(guna2TextBox: txt_buscar);
            Theme.ApplyColorScheme.ApplyColorSchemeOnComboBox(guna2ComboBox: cb_filtro_sexo);
            Theme.ApplyColorScheme.ApplyColorSchemeOnComboBox(guna2ComboBox: cb_filtro_status);
            Theme.ApplyColorScheme.ApplyColorSchemeOnDataGridView(dataGridView: dataGridView_miembros);

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
            lb_titulo.Text = string.Format("Miembros / {0}", dataGridView_miembros.Rows.Count.ToString());
        }

        //Recarga la informacion en el datagridview
        private async void RefreshData()
        {
            try
            {
                //Si la informacion esta filtrada resetear los combobox
                if (cb_filtro_status.SelectedIndex != 0)
                {
                    cb_filtro_status.SelectedIndex = 0;
                }
                if (cb_filtro_sexo.SelectedIndex != 0)
                {
                    cb_filtro_sexo.SelectedIndex = 0;
                }

                dataGridView_miembros.DataSource = await _miembroModel.GetAllMiembros();
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
            //Si la informacion esta filtrada, resetear el combobox para indicar
            //que se esta buscando dentro de toda la informacion sin filtrar
            //ya que realizar busqueda de informacion filtrada implicaria
            //agregar dicha funcion y por el momento no se desea
            if (cb_filtro_status.SelectedIndex != 0)
            {
                cb_filtro_status.SelectedIndex = 0;
            }
            if (cb_filtro_sexo.SelectedIndex != 0)
            {
                cb_filtro_sexo.SelectedIndex = 0;
            }
            dataGridView_miembros.DataSource = _miembroModel.SearchMiembro(miembro: txt_buscar.Text.Trim());
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            CreateMiembro();
        }

        private void CreateMiembro()
        {
            using (FormMiembro formMiembro = new FormMiembro())
            {
                //Si el form responde un OK, quiere decir que todo salio bien
                //y se puede actualizar la informacion, de esta manera se evita
                //consultar a la base de datos en caso de que algo salga mal tras
                //cerrar el form
                var result = formMiembro.ShowDialog();

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
            UpdateMiembro();
        }

        private void UpdateMiembro()
        {
            //Solo si hay algo seleccionado en el datagridview se podra editar
            if (dataGridView_miembros.SelectedRows.Count == 0)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "No hay nada seleccionado");
                return;
            }

            //Recuperar el id del miembro
            int miembroId = Convert.ToInt32(dataGridView_miembros.CurrentRow.Cells[0].Value.ToString());

            //Abrir el formulario
            using (FormMiembro formMiembro = new FormMiembro(miembroId: miembroId))
            {
                //Recuperar los valores para poder editarlos
                formMiembro.txt_nombre_miembro.Text = dataGridView_miembros.CurrentRow.Cells[1].Value.ToString();
                formMiembro.txt_apellido_miembro.Text = dataGridView_miembros.CurrentRow.Cells[2].Value.ToString();
                formMiembro.txt_telefono_miembro.Text = dataGridView_miembros.CurrentRow.Cells[3].Value.ToString();
                formMiembro.cb_sexo_miembro.Text = dataGridView_miembros.CurrentRow.Cells[4].Value.ToString();

                //Si el form responde un OK, quiere decir que todo salio bien
                //y se puede actualizar la informacion, de esta manera se evita
                //consultar a la base de datos en caso de que algo salga mal tras
                //cerrar el form
                var result = formMiembro.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshData();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DeleteMembresia();
        }

        private async void DeleteMembresia()
        {
            //Solo si hay algo seleccionado en el datagridview se podra eliminar
            if (dataGridView_miembros.SelectedRows.Count == 0)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "No hay nada seleccionado");
                return;
            }

            //Recuperar el id del miembro para poder eliminarlo
            int miembroId = Convert.ToInt32(dataGridView_miembros.CurrentRow.Cells[0].Value.ToString());

            //Recuperar el nombre del miembro para mostrarlo al usuario
            string miembro = string.Format($"{ dataGridView_miembros.CurrentRow.Cells[1].Value.ToString() } { dataGridView_miembros.CurrentRow.Cells[2].Value.ToString() }");

            //Mostrar un mensaje para confirmar si se desea eliminar y almacenar el resultado del dialogo 
            var dialogResult = MessageBox.Show(($"El miembro '{ miembro }' se eliminará, ¿Estás seguro?"), "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si se acepta eliminar
            if (dialogResult == DialogResult.Yes)
            {
                //Indicar el comportamiento de estado de la entidad y mandar el id
                _miembroModel.EntityState = Domain.ValueObjects.EntityState.Deleted;
                _miembroModel.MiembroId = miembroId;

                //Capturar el resultado e informar al usuario
                string result = await _miembroModel.SaveChanges();

                //Si se elimino correctamente
                if (result == "deleted")
                {
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Miembro eliminado correctamente");
                    RefreshData();
                }
                else
                {
                    Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: result);
                }
            }
        }

        //Este evento permite editar un elemento seleccionado al hacer doble click
        private void dataGridView_miembros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMiembro();
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
                        dataGridView_miembros.Columns[column].Visible = true;
                    }
                    else
                    {
                        //Caso contrario ocultar la columna de igual manera mediante el tag
                        dataGridView_miembros.Columns[column].Visible = false;
                    }
                }
            }
            panel_columnas.Visible = false;
        }

        private void dataGridView_miembros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Aplica un color a las celdas en la columna status dependiendo
            //de si este es activo, inactivo o pendiente
            if (e.ColumnIndex == 8 && e.Value != null)
            {
                //Si la membresia del miembro aun esta activa
                if (e.Value.ToString() == "Activo")
                {
                    e.CellStyle.BackColor = Color.FromArgb(75, 186, 63);
                    e.CellStyle.ForeColor = Color.White;
                }
                //Si la membresia del miembro ya vencio
                else if (e.Value.ToString() == "Inactivo")
                {
                    e.CellStyle.BackColor = Color.FromArgb(227, 81, 84);
                    e.CellStyle.ForeColor = Color.White;
                }
                //Si la membresia del miembro esta a punto de vencer
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(248, 186, 84);
                    e.CellStyle.ForeColor = Color.FromArgb(72, 46, 9);
                }
            }

            if (e.ColumnIndex == 4 && e.Value != null)
            {
                //Para visualizar mejor el genero
                if (e.Value.ToString() == "Masculino")
                {
                    e.CellStyle.BackColor = Color.FromArgb(94, 148, 255);
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (e.Value.ToString() == "Femenino")
                {
                    e.CellStyle.BackColor = Color.FromArgb(243, 107, 141);
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(175, 77, 208);
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void cb_filtro_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Filtra los miembros por el status seleccionado
            dataGridView_miembros.DataSource = _miembroModel.GetMiembrosByValue(cb_filtro_status.SelectedItem.ToString(), cb_filtro_sexo.SelectedItem.ToString());
        }

        private void cb_filtro_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Filtra los miembros por sexo
            dataGridView_miembros.DataSource = _miembroModel.GetMiembrosByValue(cb_filtro_status.SelectedItem.ToString(), cb_filtro_sexo.SelectedItem.ToString());
        }
    }
}
