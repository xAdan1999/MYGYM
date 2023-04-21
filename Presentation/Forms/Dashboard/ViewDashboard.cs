using System.Windows.Forms;
using Guna.UI2.WinForms;
using Domain.Models;
using System;

namespace Presentation.Forms.Dashboard
{
    public partial class ViewDashboard : Form
    {
        private MiembroModel _miembroModel;

        private DashboardModel _dashboardModel;

        public ViewDashboard()
        {
            InitializeComponent();
        }

        private void ViewDashboard_Load(object sender, EventArgs e)
        {
            _miembroModel = new MiembroModel();

            _dashboardModel = new DashboardModel();

            GetTotales();

            LoadChartStatus();
            LoadChartSexo();

            GetMiembrosByStatus(dataGridView: dataGridView_pendientes, progressIndicator: pi_dtgv_pendientes, status: "Pendiente");
            GetMiembrosByStatus(dataGridView: dataGridView_inactivos, progressIndicator: pi_dtgv_inactivos, status: "Inactivo");
        }

        //Obtiene la hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_hora.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper();
            lb_fecha.Text = DateTime.Now.ToLongDateString();
        }

        //Obtiene la cantidad de registros de cada modulo
        private async void GetTotales()
        {
            try
            {
                //Obtener totales
                var lst = await _dashboardModel.GetTotales();

                //Mostrarlos en los labels
                lb_total_miembros.Text = lst[0].ToString();
                lb_total_membresias.Text = lst[1].ToString();
                lb_total_usuarios.Text = lst[2].ToString();
                lb_total_roles.Text = lst[3].ToString();
            }
            catch (Exception ex)
            {
                Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: ex.ToString());
            }
        }

        //Muestra un grafico con la distribucion de miembros por status
        private async void LoadChartStatus()
        {
            try
            {
                //Obtener lista de totales
                var lst = await _miembroModel.GetTotalMiembrosByStatus();

                //Cargar el grafico
                chart1.Series[0].Points.AddXY($"Activos ({lst[0]}%)", lst[0]);
                chart1.Series[0].Points.AddXY($"Inactivos({lst[1]}%)", lst[1]);
                chart1.Series[0].Points.AddXY($"Pendientes({lst[2]}%)", lst[2]);
            }
            catch(Exception ex)
            {
                Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: ex.ToString());
            }
        }

        //Muestra un grafico con la distribucion de miembros por sexo
        private async void LoadChartSexo()
        {
            try
            {
                //Obtener lista de totales
                var lst = await _miembroModel.GetTotalMiembrosBySexo();

                //Cargar el grafico
                chart2.Series[0].Points.AddXY($"Hombres({lst[0]}%)", lst[0]);
                chart2.Series[0].Points.AddXY($"Mujeres({lst[1]}%)", lst[1]);
                chart2.Series[0].Points.AddXY($"Otro({lst[2]}%)", lst[2]);
            }
            catch (Exception ex)
            {
                Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: ex.ToString());
            }
        }

        private void ApplyColorScheme(DataGridView dataGridView)
        {
            //Tema personalizado para los datagridview del dashboard

            //Filas alternadas
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.control_fill_color;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Properties.Settings.Default.control_fill_color;
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Properties.Settings.Default.control_fore_color;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = Properties.Settings.Default.control_fore_color;

            //Filas
            dataGridView.RowsDefaultCellStyle.BackColor = Properties.Settings.Default.control_fill_color;
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Properties.Settings.Default.control_fill_color;
            dataGridView.RowsDefaultCellStyle.ForeColor = Properties.Settings.Default.control_fore_color;
            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Properties.Settings.Default.control_fore_color;
        }

        //Carga los miembros por status en un datagridview
        private async void GetMiembrosByStatus(DataGridView dataGridView, Guna2ProgressIndicator progressIndicator, string status)
        {
            progressIndicator.Visible = true;
            progressIndicator.BringToFront();
            progressIndicator.Start();

            try
            {
                dataGridView.RowTemplate.Height = 32;
                dataGridView.DataSource = await _miembroModel.GetPendientesOnDashboard(miembroStatus: status);
                HideColumns(dataGridView: dataGridView);
                ApplyColorScheme(dataGridView: dataGridView);
            }
            catch (Exception ex)
            {
                Helps.StaticMethods.ShowGenericErrorMessageBox(errorMessage: ex.Message.ToString());
            }

            progressIndicator.Visible = false;
            progressIndicator.Stop();
        }

        //Para ocultar algunas columnas
        private void HideColumns(DataGridView dataGridView)
        {
            int[] columnsToHide = new int[] { 0, 3, 4, 5, 6, 7, 8, 9, 11, 12};

            foreach (var column in columnsToHide)
            {
                dataGridView.Columns[column].Visible = false;
            }
        }
    }
}
