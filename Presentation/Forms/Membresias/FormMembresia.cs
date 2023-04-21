using System.Windows.Forms;
using Guna.UI2.WinForms;
using Domain.Models;
using System;

namespace Presentation.Forms.Membresias
{
    public partial class FormMembresia : Form
    {
        private MembresiaModel _membresiaModel;

        //Para editar
        private short _membresiaId = 0;

        //Cuando se va a agregar
        public FormMembresia()
        {
            InitializeComponent();
        }

        //Cuando se va a editar 
        public FormMembresia(short membresiaId)
        {
            InitializeComponent();

            _membresiaId = membresiaId;
        }

        private void FormMembresia_Load(object sender, EventArgs e)
        {
            _membresiaModel = new MembresiaModel();

            ApplyColorScheme();

            //Si el id es igual a 0 quiere decir que se va a agregar 
            //de lo contrario quiere decir que se va a editar
            lb_titulo.Text = _membresiaId == 0 ? "Agregar membresía" : "Editar membresía";
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
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            CreateMembresia();
        }

        private async void CreateMembresia()
        {
            //Si hay algun campo requerido vacio no continuar
            if (string.IsNullOrEmpty(txt_nombre_membresia.Text) || string.IsNullOrEmpty(txt_costo_membresia.Text))
            {
                Helps.StaticMethods.ShowGenericMessageBox(message: "Asegurate de llenar todos los campos");
                return;
            }

            //Asignar los valores al objeto
            _membresiaModel.MembresiaId = _membresiaId;
            _membresiaModel.Nombre = txt_nombre_membresia.Text.Trim();
            _membresiaModel.Costo = Convert.ToDecimal(txt_costo_membresia.Text.Trim());

            //Dependiendo de la accion a realizar (agregar o editar) asignar un comportamiento al estado de entidad
            _membresiaModel.EntityState = _membresiaId == 0 ? Domain.ValueObjects.EntityState.Created : Domain.ValueObjects.EntityState.Updated;

            //En caso de que el proceso este tardando, bloquear los botones 
            //para evitar que el usuario haga movimientos innecesarios y 
            //ocurra un error
            btn_guardar.Text = "Espera...";
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;

            //Verificar el mensaje capturado
            string message = await _membresiaModel.SaveChanges();

            btn_guardar.Text = "Guardar";
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;

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
                    Helps.StaticMethods.ShowGenericMessageBox(message: "Membresía agregada correctamente");
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

        #region eventos de teclado

        private void txt_nombre_membresia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateMembresia();
            }
        }

        private void txt_costo_membresia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateMembresia();
            }
        }

        #endregion

        #region validaciones de teclado

        private void txt_costo_membresia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as Guna2TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
