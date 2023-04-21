using System.Windows.Forms;
using Guna.UI2.WinForms;
using Domain.Models;
using System;

namespace Presentation.Forms.Miembros
{
    public partial class FormMiembro : Form
    {
        private MiembroModel _miembroModel;

        private MembresiaModel _membresiaModel;

        //Para editar
        private int _miembroId = 0;

        //Cuando se va a agregar
        public FormMiembro()
        {
            InitializeComponent();
        }

        //Cuando se va a editar 
        public FormMiembro(int miembroId)
        {
            InitializeComponent();

            _miembroId = miembroId;
        }

        private void FormMiembro_Load(object sender, EventArgs e)
        {
            _miembroModel = new MiembroModel();

            _membresiaModel = new MembresiaModel();

            ApplyColorScheme();

            //Si el id es igual a 0 quiere decir que se va a agregar 
            //de lo contrario quiere decir que se va a editar
            if (_miembroId == 0)
            {
                lb_titulo.Text = "Agregar miembro";
            }
            else
            {
                lb_titulo.Text = "Editar miembro";
                cb_membresia.Enabled = false;
                txt_costo_membresia.Enabled = false;
                txt_fecha_inicio.Enabled = false;
                txt_fecha_fin.Enabled = false;
            }

            //Obtener fecha
            txt_fecha_inicio.Text = dateTimePicker1.Text;
            txt_fecha_fin.Text = dateTimePicker2.Text;

            //Obtener membresias
            GetMembresias();

            //Obtener el costo de la membresia seleccionada al inicio
            GetCostoMembresia();
        }

        private void ApplyColorScheme()
        {
            //Recorrer los controles para aplicar el tema
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
        private void GetMembresias()
        {
            var lstMembresias = _membresiaModel.GetAllMembresiasOnComboBox();
            cb_membresia.DataSource = lstMembresias;
            cb_membresia.DisplayMember = "Nombre";
            cb_membresia.ValueMember = "MembresiaId";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            CreateMiembro();
        }

        private async void CreateMiembro()
        {
            //Si hay algun campo requerido vacio no continuar
            if (string.IsNullOrEmpty(txt_nombre_miembro.Text) || string.IsNullOrEmpty(txt_apellido_miembro.Text))
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "Asegurate de llenar todos los campos");
                return;
            }

            //Si no hay membresias no se podra crear el miembro
            if (cb_membresia.Items.Count == 0)
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "No hay membresías para seleccionar");
                return;
            }

            //Asignar los valores al objeto
            _miembroModel.MiembroId = _miembroId;
            _miembroModel.Nombre = txt_nombre_miembro.Text.Trim();
            _miembroModel.Apellido = txt_apellido_miembro.Text.Trim();
            _miembroModel.Telefono = txt_telefono_miembro.Text.Trim();
            _miembroModel.Sexo = cb_sexo_miembro.SelectedItem.ToString();
            _miembroModel.MembresiaId = short.Parse(cb_membresia.SelectedValue.ToString());
            _miembroModel.Status = "Activo";
            _miembroModel.FechaInicio = dateTimePicker1.Value;
            _miembroModel.FechaFin = dateTimePicker2.Value;

            //Dependiendo de la accion a realizar (agregar o editar) asignar un comportamiento al estado de entidad
            _miembroModel.EntityState = _miembroId == 0 ? Domain.ValueObjects.EntityState.Created : Domain.ValueObjects.EntityState.Updated;

            //En caso de que el proceso este tardando, bloquear los botones 
            //para evitar que el usuario haga movimientos innecesarios y 
            //ocurra un error
            btn_guardar.Text = "Espera...";
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;

            //Verificar el mensaje capturado
            string message = await _miembroModel.SaveChanges();

            btn_guardar.Text = "Guardar";
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;

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
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Miembro agregado correctamente");
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

        //Evento que obtiene el costo de la membresia seleccionada
        private void cb_membresia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCostoMembresia();
        }

        //Obtiene el costo de la membresia seleccionada
        private async void GetCostoMembresia()
        {
            short membresiaId = Convert.ToInt16(cb_membresia.SelectedValue);
            decimal costoMembresia = await _membresiaModel.GetCostoMembresiaById(membresiaId);
            txt_costo_membresia.Text = costoMembresia.ToString("C2");
        }

        private void txt_fecha_inicio_IconRightClick(object sender, EventArgs e)
        {
            dateTimePicker1.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void txt_fecha_fin_IconRightClick(object sender, EventArgs e)
        {
            dateTimePicker2.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_fecha_inicio.Text = dateTimePicker1.Text;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txt_fecha_fin.Text = dateTimePicker2.Text;
        }

        #region eventos de teclado

        private void txt_nombre_miembro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateMiembro();
            }
        }

        private void txt_apellido_miembro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateMiembro();
            }
        }

        private void txt_telefono_miembro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateMiembro();
            }
        }

        #endregion

        #region validaciones de teclado

        private void txt_nombre_miembro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_miembro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
