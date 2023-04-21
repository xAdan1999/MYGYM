using Presentation.Forms.Controles;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Domain.Models;
using System;

namespace Presentation.Forms.Membresias
{
    public partial class ViewMembresias : Form
    {
        private MembresiaModel _membresiaModel;

        public ViewMembresias()
        {
            InitializeComponent();
        }

        private void ViewMembresias_Load(object sender, EventArgs e)
        {
            Helps.StaticMethods.GetPermisos(flowLayoutPanel: flowLayoutPanel1);

            _membresiaModel = new MembresiaModel();

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
                dataGridView_membresias.RowTemplate.Height = 32;
                dataGridView_membresias.DataSource = await _membresiaModel.GetAllMembresias();
                dataGridView_membresias.Columns[2].DefaultCellStyle.Format = "C2";
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
            Theme.ApplyColorScheme.ApplyColorSchemeOnDataGridView(dataGridView: dataGridView_membresias);

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
            lb_titulo.Text = string.Format("Membresías / {0}", dataGridView_membresias.Rows.Count.ToString());
        }

        //Recarga la informacion en el datagridview
        private async void RefreshData()
        {
            try
            {
                dataGridView_membresias.DataSource = await _membresiaModel.GetAllMembresias();
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
            dataGridView_membresias.DataSource = _membresiaModel.SearchMembresia(membresia: txt_buscar.Text.Trim());
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            CreateMembresia();
        }

        private void CreateMembresia()
        {
            using (FormMembresia formMembresia = new FormMembresia())
            {
                //Si el form responde un OK, quiere decir que todo salio bien
                //y se puede actualizar la informacion, de esta manera se evita
                //consultar a la base de datos en caso de que algo salga mal tras
                //cerrar el form
                var result = formMembresia.ShowDialog();

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
            UpdateMembresia();
        }

        private void UpdateMembresia()
        {
            //Solo si hay algo seleccionado en el datagridview se podra editar
            if (dataGridView_membresias.SelectedRows.Count == 0)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "No hay nada seleccionado");
                return;
            }

            //Recuperar el id de la membresia
            short membresiaId = Convert.ToInt16(dataGridView_membresias.CurrentRow.Cells[0].Value.ToString());

            //Abrir el formulario
            using (FormMembresia formMembresia = new FormMembresia(membresiaId: membresiaId))
            {
                //Recuperar los valores para poder editarlos
                formMembresia.txt_nombre_membresia.Text = dataGridView_membresias.CurrentRow.Cells[1].Value.ToString();
                formMembresia.txt_costo_membresia.Text = dataGridView_membresias.CurrentRow.Cells[2].Value.ToString();

                //Si el form responde un OK, quiere decir que todo salio bien
                //y se puede actualizar la informacion, de esta manera se evita
                //consultar a la base de datos en caso de que algo salga mal tras
                //cerrar el form
                var result = formMembresia.ShowDialog();

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
            if (dataGridView_membresias.SelectedRows.Count == 0)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "No hay nada seleccionado");
                return;
            }

            //Recuperar el id de la membresia para poder eliminarla
            short membresiaId = Convert.ToInt16(dataGridView_membresias.CurrentRow.Cells[0].Value.ToString());

            //Recuperar el nombre de la membresia para mostrarla al usuario
            string membresiaNombre = dataGridView_membresias.CurrentRow.Cells[1].Value.ToString();

            //Mostrar un mensaje para confirmar si se desea eliminar y almacenar el resultado del dialogo 
            var dialogResult = MessageBox.Show(($"La membresía '{ membresiaNombre }' se eliminará, ¿Estás seguro?"), "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si se acepta eliminar
            if (dialogResult == DialogResult.Yes)
            {
                //Indicar el comportamiento de estado de la entidad y mandar el id
                _membresiaModel.EntityState = Domain.ValueObjects.EntityState.Deleted;
                _membresiaModel.MembresiaId = membresiaId;

                //Capturar el resultado e informar al usuario
                string result = await _membresiaModel.SaveChanges();

                //Si se elimino correctamente
                if (result == "deleted")
                {
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Membresía eliminada correctamente");
                    RefreshData();
                }
                else
                {
                    Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: result);
                }
            }
        }

        //Este evento permite editar un elemento seleccionado al hacer doble click
        private void dataGridView_membresias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMembresia();
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
                        dataGridView_membresias.Columns[column].Visible = true;
                    }
                    else
                    {
                        //Caso contrario ocultar la columna de igual manera mediante el tag
                        dataGridView_membresias.Columns[column].Visible = false;
                    }
                }
            }
            panel_columnas.Visible = false;
        }
    }
}
