namespace Presentation.Forms.Dashboard
{
    partial class ViewDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.pi_dtgv_inactivos = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_inactivos = new System.Windows.Forms.DataGridView();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.pi_dtgv_pendientes = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_pendientes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_total_membresias = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_total_roles = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_total_miembros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_total_usuarios = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inactivos)).BeginInit();
            this.guna2Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pendientes)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_titulo.Location = new System.Drawing.Point(26, 30);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(93, 21);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Estadísticas";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 587);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel9.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel9.BorderThickness = 1;
            this.guna2Panel9.Controls.Add(this.pi_dtgv_inactivos);
            this.guna2Panel9.Controls.Add(this.label2);
            this.guna2Panel9.Controls.Add(this.dataGridView_inactivos);
            this.guna2Panel9.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel9.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel9.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel9.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel9.Location = new System.Drawing.Point(549, 296);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(541, 288);
            this.guna2Panel9.TabIndex = 8;
            // 
            // pi_dtgv_inactivos
            // 
            this.pi_dtgv_inactivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pi_dtgv_inactivos.BackColor = System.Drawing.Color.Transparent;
            this.pi_dtgv_inactivos.DataBindings.Add(new System.Windows.Forms.Binding("ProgressColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pi_dtgv_inactivos.Location = new System.Drawing.Point(254, 136);
            this.pi_dtgv_inactivos.Name = "pi_dtgv_inactivos";
            this.pi_dtgv_inactivos.ProgressColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.pi_dtgv_inactivos.Size = new System.Drawing.Size(33, 48);
            this.pi_dtgv_inactivos.TabIndex = 3;
            this.pi_dtgv_inactivos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inactivos";
            // 
            // dataGridView_inactivos
            // 
            this.dataGridView_inactivos.AllowUserToAddRows = false;
            this.dataGridView_inactivos.AllowUserToDeleteRows = false;
            this.dataGridView_inactivos.AllowUserToOrderColumns = true;
            this.dataGridView_inactivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_inactivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_inactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_inactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_inactivos.BackgroundColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.dataGridView_inactivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_inactivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_inactivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_inactivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_inactivos.ColumnHeadersHeight = 32;
            this.dataGridView_inactivos.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView_inactivos.EnableHeadersVisualStyles = false;
            this.dataGridView_inactivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridView_inactivos.Location = new System.Drawing.Point(20, 52);
            this.dataGridView_inactivos.MultiSelect = false;
            this.dataGridView_inactivos.Name = "dataGridView_inactivos";
            this.dataGridView_inactivos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_inactivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_inactivos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_inactivos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_inactivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_inactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_inactivos.Size = new System.Drawing.Size(503, 212);
            this.dataGridView_inactivos.TabIndex = 2;
            this.dataGridView_inactivos.TabStop = false;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel8.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel8.BorderThickness = 1;
            this.guna2Panel8.Controls.Add(this.pi_dtgv_pendientes);
            this.guna2Panel8.Controls.Add(this.label1);
            this.guna2Panel8.Controls.Add(this.dataGridView_pendientes);
            this.guna2Panel8.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel8.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel8.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel8.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel8.Location = new System.Drawing.Point(3, 296);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(540, 288);
            this.guna2Panel8.TabIndex = 7;
            // 
            // pi_dtgv_pendientes
            // 
            this.pi_dtgv_pendientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pi_dtgv_pendientes.BackColor = System.Drawing.Color.Transparent;
            this.pi_dtgv_pendientes.DataBindings.Add(new System.Windows.Forms.Binding("ProgressColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pi_dtgv_pendientes.Location = new System.Drawing.Point(254, 140);
            this.pi_dtgv_pendientes.Name = "pi_dtgv_pendientes";
            this.pi_dtgv_pendientes.ProgressColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.pi_dtgv_pendientes.Size = new System.Drawing.Size(33, 48);
            this.pi_dtgv_pendientes.TabIndex = 3;
            this.pi_dtgv_pendientes.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "A punto de vencer";
            // 
            // dataGridView_pendientes
            // 
            this.dataGridView_pendientes.AllowUserToAddRows = false;
            this.dataGridView_pendientes.AllowUserToDeleteRows = false;
            this.dataGridView_pendientes.AllowUserToOrderColumns = true;
            this.dataGridView_pendientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_pendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_pendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_pendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pendientes.BackgroundColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.dataGridView_pendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_pendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_pendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(46)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(46)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_pendientes.ColumnHeadersHeight = 32;
            this.dataGridView_pendientes.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView_pendientes.EnableHeadersVisualStyles = false;
            this.dataGridView_pendientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridView_pendientes.Location = new System.Drawing.Point(19, 52);
            this.dataGridView_pendientes.MultiSelect = false;
            this.dataGridView_pendientes.Name = "dataGridView_pendientes";
            this.dataGridView_pendientes.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_pendientes.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_pendientes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_pendientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pendientes.Size = new System.Drawing.Size(503, 212);
            this.dataGridView_pendientes.TabIndex = 2;
            this.dataGridView_pendientes.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(546, 293);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel1.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lb_fecha);
            this.guna2Panel1.Controls.Add(this.lb_hora);
            this.guna2Panel1.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel1.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel1.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(540, 140);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lb_fecha
            // 
            this.lb_fecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lb_fecha.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_fecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_fecha.Location = new System.Drawing.Point(42, 86);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(148, 15);
            this.lb_fecha.TabIndex = 2;
            this.lb_fecha.Text = "Martes, 10 de Abril de 2023";
            // 
            // lb_hora
            // 
            this.lb_hora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_hora.AutoSize = true;
            this.lb_hora.BackColor = System.Drawing.Color.Transparent;
            this.lb_hora.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_hora.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_hora.Location = new System.Drawing.Point(34, 31);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(115, 50);
            this.lb_hora.TabIndex = 1;
            this.lb_hora.Text = "00:00";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.guna2Panel2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.guna2Panel4, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.guna2Panel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.guna2Panel5, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 146);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(546, 147);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel2.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lb_total_membresias);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel2.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel2.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel2.Location = new System.Drawing.Point(139, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(130, 141);
            this.guna2Panel2.TabIndex = 4;
            // 
            // lb_total_membresias
            // 
            this.lb_total_membresias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_total_membresias.AutoEllipsis = true;
            this.lb_total_membresias.BackColor = System.Drawing.Color.Transparent;
            this.lb_total_membresias.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_total_membresias.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_membresias.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_total_membresias.Location = new System.Drawing.Point(18, 70);
            this.lb_total_membresias.Name = "lb_total_membresias";
            this.lb_total_membresias.Size = new System.Drawing.Size(93, 30);
            this.lb_total_membresias.TabIndex = 2;
            this.lb_total_membresias.Text = "0";
            this.lb_total_membresias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Membresías";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel4.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.lb_total_roles);
            this.guna2Panel4.Controls.Add(this.label6);
            this.guna2Panel4.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel4.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel4.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel4.Location = new System.Drawing.Point(411, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(132, 141);
            this.guna2Panel4.TabIndex = 6;
            // 
            // lb_total_roles
            // 
            this.lb_total_roles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_total_roles.AutoEllipsis = true;
            this.lb_total_roles.BackColor = System.Drawing.Color.Transparent;
            this.lb_total_roles.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_total_roles.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_roles.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_total_roles.Location = new System.Drawing.Point(18, 70);
            this.lb_total_roles.Name = "lb_total_roles";
            this.lb_total_roles.Size = new System.Drawing.Size(95, 30);
            this.lb_total_roles.TabIndex = 2;
            this.lb_total_roles.Text = "0";
            this.lb_total_roles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.label6.Location = new System.Drawing.Point(43, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Roles";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel3.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.lb_total_miembros);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel3.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel3.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel3.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(130, 141);
            this.guna2Panel3.TabIndex = 3;
            // 
            // lb_total_miembros
            // 
            this.lb_total_miembros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_total_miembros.AutoEllipsis = true;
            this.lb_total_miembros.BackColor = System.Drawing.Color.Transparent;
            this.lb_total_miembros.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_total_miembros.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_miembros.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_total_miembros.Location = new System.Drawing.Point(18, 70);
            this.lb_total_miembros.Name = "lb_total_miembros";
            this.lb_total_miembros.Size = new System.Drawing.Size(93, 30);
            this.lb_total_miembros.TabIndex = 2;
            this.lb_total_miembros.Text = "0";
            this.lb_total_miembros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.label3.Location = new System.Drawing.Point(29, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miembros";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel5.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.lb_total_usuarios);
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel5.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel5.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel5.Location = new System.Drawing.Point(275, 3);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(130, 141);
            this.guna2Panel5.TabIndex = 7;
            // 
            // lb_total_usuarios
            // 
            this.lb_total_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_total_usuarios.AutoEllipsis = true;
            this.lb_total_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.lb_total_usuarios.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_total_usuarios.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_usuarios.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_total_usuarios.Location = new System.Drawing.Point(18, 70);
            this.lb_total_usuarios.Name = "lb_total_usuarios";
            this.lb_total_usuarios.Size = new System.Drawing.Size(93, 30);
            this.lb_total_usuarios.TabIndex = 2;
            this.lb_total_usuarios.Text = "0";
            this.lb_total_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.label5.Location = new System.Drawing.Point(33, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuarios";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.guna2Panel7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.guna2Panel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(546, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(547, 293);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel7.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel7.BorderThickness = 1;
            this.guna2Panel7.Controls.Add(this.label8);
            this.guna2Panel7.Controls.Add(this.chart2);
            this.guna2Panel7.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel7.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel7.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel7.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel7.Location = new System.Drawing.Point(276, 3);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(268, 287);
            this.guna2Panel7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.label8.Location = new System.Drawing.Point(15, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Distrución de miembros por Sexo";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Location = new System.Drawing.Point(4, 51);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(107)))), ((int)(((byte)(141))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(77)))), ((int)(((byte)(208)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(260, 233);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Panel6.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2Panel6.BorderThickness = 1;
            this.guna2Panel6.Controls.Add(this.label7);
            this.guna2Panel6.Controls.Add(this.chart1);
            this.guna2Panel6.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel6.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel6.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel6.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2Panel6.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(267, 287);
            this.guna2Panel6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Distribución de miembros por Status";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(4, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(186)))), ((int)(((byte)(63))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(81)))), ((int)(((byte)(84))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(84)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(260, 233);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ViewDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.ClientSize = new System.Drawing.Size(1105, 670);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lb_titulo);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "ViewDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.ViewDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inactivos)).EndInit();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pendientes)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        public System.Windows.Forms.DataGridView dataGridView_pendientes;
        public System.Windows.Forms.DataGridView dataGridView_inactivos;
        private Guna.UI2.WinForms.Guna2ProgressIndicator pi_dtgv_inactivos;
        private Guna.UI2.WinForms.Guna2ProgressIndicator pi_dtgv_pendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lb_total_membresias;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lb_total_roles;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label lb_total_usuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_total_miembros;
    }
}