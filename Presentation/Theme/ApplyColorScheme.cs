using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Theme
{
    public static class ApplyColorScheme
    {
        //Esta clase aplica el tema del usuario a algunos controles cuyas
        //propiedades no fueron posibles bindear

        public static void ApplyColorSchemeOnTextBox(Guna2TextBox guna2TextBox)
        {
            guna2TextBox.HoverState.BorderColor = Properties.Settings.Default.primary_color;
            guna2TextBox.FocusedState.BorderColor = Properties.Settings.Default.primary_color;
            guna2TextBox.FocusedState.FillColor = Properties.Settings.Default.control_focused_fill_color;
        }

        public static void ApplyColorThemeOnToggleSwitch(Guna2ToggleSwitch guna2ToggleSwitch)
        {
            guna2ToggleSwitch.CheckedState.BorderColor = Properties.Settings.Default.primary_color;
            guna2ToggleSwitch.CheckedState.FillColor = Properties.Settings.Default.primary_color;
        }

        public static void ApplyColorSchemeOnComboBox(Guna2ComboBox guna2ComboBox)
        {
            guna2ComboBox.FocusedState.BorderColor = Properties.Settings.Default.primary_color;
            guna2ComboBox.ItemsAppearance.SelectedBackColor = Properties.Settings.Default.primary_color;
        }

        public static void ApplyColorSchemeOnCheckBox(Guna2CheckBox guna2CheckBox)
        {
            guna2CheckBox.CheckedState.FillColor = Properties.Settings.Default.primary_color;
            guna2CheckBox.CheckedState.BorderColor = Properties.Settings.Default.primary_color;
        }

        public static void ApplyColorSchemeOnDataGridView(DataGridView dataGridView)
        {
            //Columas
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Properties.Settings.Default.control_fill_color;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Properties.Settings.Default.control_fill_color;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Properties.Settings.Default.control_fore_color;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Properties.Settings.Default.control_focused_fore_color;

            //Filas alternadas
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.control_fill_color;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Properties.Settings.Default.primary_color;
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Properties.Settings.Default.control_fore_color;

            //Filas
            dataGridView.RowsDefaultCellStyle.BackColor = Properties.Settings.Default.background_color;
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Properties.Settings.Default.primary_color;
            dataGridView.RowsDefaultCellStyle.ForeColor = Properties.Settings.Default.control_fore_color;
        }
    }
}
