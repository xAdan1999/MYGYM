﻿namespace Presentation.Forms.Roles
{
    partial class ViewRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRoles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.progress_indicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.btn_editar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_columnas = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_roles = new System.Windows.Forms.DataGridView();
            this.btn_recargar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.panel_columnas = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.chb_nombre = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_id = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_ultima_modificacion = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_fecha_creacion = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.panel_bottom_message = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roles)).BeginInit();
            this.panel_columnas.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progress_indicator
            // 
            this.progress_indicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progress_indicator.DataBindings.Add(new System.Windows.Forms.Binding("ProgressColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.progress_indicator.Location = new System.Drawing.Point(516, 304);
            this.progress_indicator.Name = "progress_indicator";
            this.progress_indicator.ProgressColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.progress_indicator.Size = new System.Drawing.Size(33, 48);
            this.progress_indicator.TabIndex = 5;
            this.progress_indicator.Visible = false;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.Animated = true;
            this.btn_editar.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.btn_editar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_editar.BorderThickness = 1;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_editar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_editar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_editar.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_editar.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.btn_editar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageSize = new System.Drawing.Size(19, 19);
            this.btn_editar.Location = new System.Drawing.Point(207, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(32, 32);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Tag = "16";
            this.guna2HtmlToolTip1.SetToolTip(this.btn_editar, "Editar");
            this.btn_editar.Visible = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Animated = true;
            this.btn_eliminar.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.btn_eliminar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_eliminar.BorderThickness = 1;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_eliminar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_eliminar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_eliminar.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminar.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.btn_eliminar.Image = global::Presentation.Properties.Resources.ic_eliminar;
            this.btn_eliminar.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_eliminar.Location = new System.Drawing.Point(245, 3);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(32, 32);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Tag = "17";
            this.guna2HtmlToolTip1.SetToolTip(this.btn_eliminar, "Eliminar");
            this.btn_eliminar.Visible = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_columnas
            // 
            this.btn_columnas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_columnas.Animated = true;
            this.btn_columnas.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.btn_columnas.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_columnas.BorderThickness = 1;
            this.btn_columnas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_columnas.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_columnas.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_columnas.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_columnas.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_columnas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_columnas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_columnas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_columnas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_columnas.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.btn_columnas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_columnas.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.btn_columnas.Image = global::Presentation.Properties.Resources.ic_mostrar;
            this.btn_columnas.ImageOffset = new System.Drawing.Point(0, 1);
            this.btn_columnas.ImageSize = new System.Drawing.Size(17, 19);
            this.btn_columnas.Location = new System.Drawing.Point(283, 3);
            this.btn_columnas.Name = "btn_columnas";
            this.btn_columnas.Size = new System.Drawing.Size(32, 32);
            this.btn_columnas.TabIndex = 7;
            this.guna2HtmlToolTip1.SetToolTip(this.btn_columnas, "Mostrar columnas");
            this.btn_columnas.Click += new System.EventHandler(this.btn_mostrar_columnas_Click);
            // 
            // dataGridView_roles
            // 
            this.dataGridView_roles.AllowUserToAddRows = false;
            this.dataGridView_roles.AllowUserToDeleteRows = false;
            this.dataGridView_roles.AllowUserToOrderColumns = true;
            this.dataGridView_roles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_roles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_roles.BackgroundColor = global::Presentation.Properties.Settings.Default.background_color;
            this.dataGridView_roles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_roles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_roles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_roles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_roles.ColumnHeadersHeight = 32;
            this.dataGridView_roles.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView_roles.EnableHeadersVisualStyles = false;
            this.dataGridView_roles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridView_roles.Location = new System.Drawing.Point(26, 137);
            this.dataGridView_roles.MultiSelect = false;
            this.dataGridView_roles.Name = "dataGridView_roles";
            this.dataGridView_roles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_roles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_roles.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_roles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_roles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_roles.Size = new System.Drawing.Size(1012, 373);
            this.dataGridView_roles.TabIndex = 4;
            this.dataGridView_roles.TabStop = false;
            this.dataGridView_roles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_roles_CellDoubleClick);
            // 
            // btn_recargar
            // 
            this.btn_recargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recargar.Animated = true;
            this.btn_recargar.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.btn_recargar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_recargar.BorderThickness = 1;
            this.btn_recargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_recargar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_recargar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_recargar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_recargar.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_recargar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_recargar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_recargar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_recargar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_recargar.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.btn_recargar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recargar.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.btn_recargar.Image = global::Presentation.Properties.Resources.ic_recargar;
            this.btn_recargar.ImageSize = new System.Drawing.Size(17, 18);
            this.btn_recargar.Location = new System.Drawing.Point(169, 3);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(32, 32);
            this.btn_recargar.TabIndex = 4;
            this.guna2HtmlToolTip1.SetToolTip(this.btn_recargar, "Recargar información");
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Animated = true;
            this.btn_agregar.BorderColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_agregar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_agregar.BorderThickness = 1;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_agregar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_agregar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar.FillColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(3, 3);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(160, 32);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Tag = "15";
            this.btn_agregar.Text = "+ Agregar rol";
            this.btn_agregar.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_agregar.Visible = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Animated = true;
            this.txt_buscar.BackColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_buscar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_buscar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_buscar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_buscar.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_buscar.DefaultText = "";
            this.txt_buscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_buscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_buscar.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_buscar.IconLeft = global::Presentation.Properties.Resources.ic_buscar;
            this.txt_buscar.IconLeftOffset = new System.Drawing.Point(5, -1);
            this.txt_buscar.IconLeftSize = new System.Drawing.Size(16, 16);
            this.txt_buscar.Location = new System.Drawing.Point(26, 83);
            this.txt_buscar.MaxLength = 50;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.PasswordChar = '\0';
            this.txt_buscar.PlaceholderText = "Buscar por id o rol";
            this.txt_buscar.SelectedText = "";
            this.txt_buscar.Size = new System.Drawing.Size(694, 32);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.TextOffset = new System.Drawing.Point(5, 0);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_titulo.Location = new System.Drawing.Point(26, 30);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(74, 21);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Roles / 0";
            // 
            // panel_columnas
            // 
            this.panel_columnas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_columnas.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.panel_columnas.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.panel_columnas.BorderThickness = 1;
            this.panel_columnas.Controls.Add(this.btn_guardar);
            this.panel_columnas.Controls.Add(this.chb_nombre);
            this.panel_columnas.Controls.Add(this.chb_id);
            this.panel_columnas.Controls.Add(this.chb_ultima_modificacion);
            this.panel_columnas.Controls.Add(this.chb_fecha_creacion);
            this.panel_columnas.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel_columnas.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel_columnas.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel_columnas.FillColor = global::Presentation.Properties.Settings.Default.background_color;
            this.panel_columnas.Location = new System.Drawing.Point(860, 122);
            this.panel_columnas.Name = "panel_columnas";
            this.panel_columnas.Size = new System.Drawing.Size(178, 183);
            this.panel_columnas.TabIndex = 6;
            this.panel_columnas.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.Animated = true;
            this.btn_guardar.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.btn_guardar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_guardar.BorderThickness = 1;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardar.FillColor = global::Presentation.Properties.Settings.Default.background_color;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.btn_guardar.Image = global::Presentation.Properties.Resources.ic_guardar;
            this.btn_guardar.ImageSize = new System.Drawing.Size(19, 19);
            this.btn_guardar.Location = new System.Drawing.Point(18, 130);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(139, 32);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Aplicar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // chb_nombre
            // 
            this.chb_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_nombre.AutoSize = true;
            this.chb_nombre.BackColor = System.Drawing.Color.Transparent;
            this.chb_nombre.Checked = true;
            this.chb_nombre.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_nombre.CheckedState.BorderRadius = 0;
            this.chb_nombre.CheckedState.BorderThickness = 0;
            this.chb_nombre.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_nombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_nombre.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chb_nombre.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_nombre.Location = new System.Drawing.Point(18, 44);
            this.chb_nombre.Name = "chb_nombre";
            this.chb_nombre.Size = new System.Drawing.Size(79, 19);
            this.chb_nombre.TabIndex = 2;
            this.chb_nombre.Tag = "1";
            this.chb_nombre.Text = "   Nombre";
            this.chb_nombre.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_nombre.UncheckedState.BorderRadius = 0;
            this.chb_nombre.UncheckedState.BorderThickness = 0;
            this.chb_nombre.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_nombre.UseVisualStyleBackColor = false;
            // 
            // chb_id
            // 
            this.chb_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_id.AutoSize = true;
            this.chb_id.BackColor = System.Drawing.Color.Transparent;
            this.chb_id.Checked = true;
            this.chb_id.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_id.CheckedState.BorderRadius = 0;
            this.chb_id.CheckedState.BorderThickness = 0;
            this.chb_id.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_id.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_id.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_id.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_id.Location = new System.Drawing.Point(18, 19);
            this.chb_id.Name = "chb_id";
            this.chb_id.Size = new System.Drawing.Size(46, 19);
            this.chb_id.TabIndex = 1;
            this.chb_id.Tag = "0";
            this.chb_id.Text = "   ID";
            this.chb_id.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_id.UncheckedState.BorderRadius = 0;
            this.chb_id.UncheckedState.BorderThickness = 0;
            this.chb_id.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_id.UseVisualStyleBackColor = false;
            // 
            // chb_ultima_modificacion
            // 
            this.chb_ultima_modificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_ultima_modificacion.AutoSize = true;
            this.chb_ultima_modificacion.BackColor = System.Drawing.Color.Transparent;
            this.chb_ultima_modificacion.Checked = true;
            this.chb_ultima_modificacion.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_ultima_modificacion.CheckedState.BorderRadius = 0;
            this.chb_ultima_modificacion.CheckedState.BorderThickness = 0;
            this.chb_ultima_modificacion.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_ultima_modificacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_ultima_modificacion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_ultima_modificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ultima_modificacion.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_ultima_modificacion.Location = new System.Drawing.Point(18, 94);
            this.chb_ultima_modificacion.Name = "chb_ultima_modificacion";
            this.chb_ultima_modificacion.Size = new System.Drawing.Size(143, 19);
            this.chb_ultima_modificacion.TabIndex = 4;
            this.chb_ultima_modificacion.Tag = "3";
            this.chb_ultima_modificacion.Text = "   Ultima modificación";
            this.chb_ultima_modificacion.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_ultima_modificacion.UncheckedState.BorderRadius = 0;
            this.chb_ultima_modificacion.UncheckedState.BorderThickness = 0;
            this.chb_ultima_modificacion.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_ultima_modificacion.UseVisualStyleBackColor = false;
            // 
            // chb_fecha_creacion
            // 
            this.chb_fecha_creacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_fecha_creacion.AutoSize = true;
            this.chb_fecha_creacion.BackColor = System.Drawing.Color.Transparent;
            this.chb_fecha_creacion.Checked = true;
            this.chb_fecha_creacion.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_fecha_creacion.CheckedState.BorderRadius = 0;
            this.chb_fecha_creacion.CheckedState.BorderThickness = 0;
            this.chb_fecha_creacion.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_fecha_creacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_fecha_creacion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_fecha_creacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_fecha_creacion.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_fecha_creacion.Location = new System.Drawing.Point(18, 69);
            this.chb_fecha_creacion.Name = "chb_fecha_creacion";
            this.chb_fecha_creacion.Size = new System.Drawing.Size(130, 19);
            this.chb_fecha_creacion.TabIndex = 3;
            this.chb_fecha_creacion.Tag = "2";
            this.chb_fecha_creacion.Text = "   Fecha de creación";
            this.chb_fecha_creacion.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_fecha_creacion.UncheckedState.BorderRadius = 0;
            this.chb_fecha_creacion.UncheckedState.BorderThickness = 0;
            this.chb_fecha_creacion.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_fecha_creacion.UseVisualStyleBackColor = false;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.BackColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2HtmlToolTip1.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2HtmlToolTip1.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // panel_bottom_message
            // 
            this.panel_bottom_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom_message.Location = new System.Drawing.Point(0, 530);
            this.panel_bottom_message.Name = "panel_bottom_message";
            this.panel_bottom_message.Size = new System.Drawing.Size(1065, 29);
            this.panel_bottom_message.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btn_agregar);
            this.flowLayoutPanel1.Controls.Add(this.btn_recargar);
            this.flowLayoutPanel1.Controls.Add(this.btn_editar);
            this.flowLayoutPanel1.Controls.Add(this.btn_eliminar);
            this.flowLayoutPanel1.Controls.Add(this.btn_columnas);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(723, 80);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(319, 38);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ViewRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.ClientSize = new System.Drawing.Size(1065, 559);
            this.Controls.Add(this.progress_indicator);
            this.Controls.Add(this.panel_columnas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_bottom_message);
            this.Controls.Add(this.dataGridView_roles);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lb_titulo);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewRoles";
            this.Text = "ViewRoles";
            this.Load += new System.EventHandler(this.ViewRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roles)).EndInit();
            this.panel_columnas.ResumeLayout(false);
            this.panel_columnas.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ProgressIndicator progress_indicator;
        private Guna.UI2.WinForms.Guna2Button btn_editar;
        private Guna.UI2.WinForms.Guna2Button btn_eliminar;
        private Guna.UI2.WinForms.Guna2Button btn_columnas;
        public System.Windows.Forms.DataGridView dataGridView_roles;
        private Guna.UI2.WinForms.Guna2Button btn_recargar;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
        public Guna.UI2.WinForms.Guna2TextBox txt_buscar;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2Panel panel_columnas;
        private Guna.UI2.WinForms.Guna2CheckBox chb_nombre;
        private Guna.UI2.WinForms.Guna2CheckBox chb_id;
        private Guna.UI2.WinForms.Guna2CheckBox chb_ultima_modificacion;
        private Guna.UI2.WinForms.Guna2CheckBox chb_fecha_creacion;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private System.Windows.Forms.Panel panel_bottom_message;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}