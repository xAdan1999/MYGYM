namespace Presentation.Forms.Roles
{
    partial class FormRol
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_guardar_rol = new Guna.UI2.WinForms.Guna2Button();
            this.txt_nombre_rol = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardar_permisos = new Guna.UI2.WinForms.Guna2Button();
            this.panel_permisos = new Guna.UI2.WinForms.Guna2Panel();
            this.chb_eliminar_roles = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_editar_roles = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_agregar_roles = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_mostrar_roles = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chb_eliminar_usuarios = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_editar_usuarios = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_agregar_usuarios = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_mostrar_usuarios = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chb_eliminar_membresia = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_editar_membresia = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_agregar_membresias = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_mostrar_membresias = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chb_eliminar_miembros = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_editar_miembros = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_agregar_miembros = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chb_mostrar_miembros = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_show_estadisticas = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_permisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.Animated = true;
            this.btn_cancelar.BorderColor = global::Presentation.Properties.Settings.Default.background_color;
            this.btn_cancelar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_cancelar.BorderThickness = 1;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_cancelar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_cancelar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_cancelar.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_help_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelar.FillColor = global::Presentation.Properties.Settings.Default.background_color;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = global::Presentation.Properties.Settings.Default.label_help_color;
            this.btn_cancelar.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_cancelar.Location = new System.Drawing.Point(129, 511);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(145, 32);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_titulo.Location = new System.Drawing.Point(45, 44);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(34, 21);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Rol";
            // 
            // btn_guardar_rol
            // 
            this.btn_guardar_rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar_rol.Animated = true;
            this.btn_guardar_rol.BorderColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_guardar_rol.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_guardar_rol.BorderThickness = 1;
            this.btn_guardar_rol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar_rol.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar_rol.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar_rol.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar_rol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar_rol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar_rol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardar_rol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardar_rol.FillColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_guardar_rol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_rol.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_rol.Location = new System.Drawing.Point(307, 161);
            this.btn_guardar_rol.Name = "btn_guardar_rol";
            this.btn_guardar_rol.Size = new System.Drawing.Size(118, 32);
            this.btn_guardar_rol.TabIndex = 5;
            this.btn_guardar_rol.Text = "Guardar rol";
            this.btn_guardar_rol.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_guardar_rol.Click += new System.EventHandler(this.btn_guardar_rol_Click);
            // 
            // txt_nombre_rol
            // 
            this.txt_nombre_rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre_rol.Animated = true;
            this.txt_nombre_rol.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre_rol.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_nombre_rol.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_nombre_rol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre_rol.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_rol.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_rol.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_rol.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_rol.DefaultText = "";
            this.txt_nombre_rol.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nombre_rol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nombre_rol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre_rol.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre_rol.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_nombre_rol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nombre_rol.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_nombre_rol.Location = new System.Drawing.Point(45, 161);
            this.txt_nombre_rol.MaxLength = 50;
            this.txt_nombre_rol.Name = "txt_nombre_rol";
            this.txt_nombre_rol.PasswordChar = '\0';
            this.txt_nombre_rol.PlaceholderText = "Asigna un nombre al rol";
            this.txt_nombre_rol.SelectedText = "";
            this.txt_nombre_rol.Size = new System.Drawing.Size(256, 32);
            this.txt_nombre_rol.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label2.Location = new System.Drawing.Point(45, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_help_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::Presentation.Properties.Settings.Default.label_help_color;
            this.label1.Location = new System.Drawing.Point(45, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos del rol";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label3.Location = new System.Drawing.Point(45, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Permisos";
            // 
            // btn_guardar_permisos
            // 
            this.btn_guardar_permisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar_permisos.Animated = true;
            this.btn_guardar_permisos.BorderColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_guardar_permisos.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_guardar_permisos.BorderThickness = 1;
            this.btn_guardar_permisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar_permisos.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar_permisos.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar_permisos.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar_permisos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar_permisos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar_permisos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardar_permisos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardar_permisos.Enabled = false;
            this.btn_guardar_permisos.FillColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_guardar_permisos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_permisos.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_permisos.Location = new System.Drawing.Point(280, 511);
            this.btn_guardar_permisos.Name = "btn_guardar_permisos";
            this.btn_guardar_permisos.Size = new System.Drawing.Size(145, 32);
            this.btn_guardar_permisos.TabIndex = 9;
            this.btn_guardar_permisos.Text = "Guardar permisos";
            this.btn_guardar_permisos.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_guardar_permisos.Click += new System.EventHandler(this.btn_guardar_permisos_Click);
            // 
            // panel_permisos
            // 
            this.panel_permisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_permisos.AutoScroll = true;
            this.panel_permisos.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.panel_permisos.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.panel_permisos.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.panel_permisos.BorderThickness = 1;
            this.panel_permisos.Controls.Add(this.chb_eliminar_roles);
            this.panel_permisos.Controls.Add(this.chb_editar_roles);
            this.panel_permisos.Controls.Add(this.chb_agregar_roles);
            this.panel_permisos.Controls.Add(this.chb_mostrar_roles);
            this.panel_permisos.Controls.Add(this.label8);
            this.panel_permisos.Controls.Add(this.chb_eliminar_usuarios);
            this.panel_permisos.Controls.Add(this.chb_editar_usuarios);
            this.panel_permisos.Controls.Add(this.chb_agregar_usuarios);
            this.panel_permisos.Controls.Add(this.chb_mostrar_usuarios);
            this.panel_permisos.Controls.Add(this.label7);
            this.panel_permisos.Controls.Add(this.chb_eliminar_membresia);
            this.panel_permisos.Controls.Add(this.chb_editar_membresia);
            this.panel_permisos.Controls.Add(this.chb_agregar_membresias);
            this.panel_permisos.Controls.Add(this.chb_mostrar_membresias);
            this.panel_permisos.Controls.Add(this.label6);
            this.panel_permisos.Controls.Add(this.chb_eliminar_miembros);
            this.panel_permisos.Controls.Add(this.chb_editar_miembros);
            this.panel_permisos.Controls.Add(this.chb_agregar_miembros);
            this.panel_permisos.Controls.Add(this.chb_mostrar_miembros);
            this.panel_permisos.Controls.Add(this.label5);
            this.panel_permisos.Controls.Add(this.chb_show_estadisticas);
            this.panel_permisos.Controls.Add(this.label4);
            this.panel_permisos.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel_permisos.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel_permisos.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel_permisos.Enabled = false;
            this.panel_permisos.FillColor = global::Presentation.Properties.Settings.Default.background_color;
            this.panel_permisos.Location = new System.Drawing.Point(45, 258);
            this.panel_permisos.Name = "panel_permisos";
            this.panel_permisos.Size = new System.Drawing.Size(380, 213);
            this.panel_permisos.TabIndex = 7;
            // 
            // chb_eliminar_roles
            // 
            this.chb_eliminar_roles.AutoSize = true;
            this.chb_eliminar_roles.BackColor = System.Drawing.Color.Transparent;
            this.chb_eliminar_roles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_eliminar_roles.CheckedState.BorderRadius = 0;
            this.chb_eliminar_roles.CheckedState.BorderThickness = 0;
            this.chb_eliminar_roles.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_eliminar_roles.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_eliminar_roles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_eliminar_roles.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_eliminar_roles.Location = new System.Drawing.Point(23, 605);
            this.chb_eliminar_roles.Name = "chb_eliminar_roles";
            this.chb_eliminar_roles.Size = new System.Drawing.Size(95, 19);
            this.chb_eliminar_roles.TabIndex = 22;
            this.chb_eliminar_roles.Tag = "17";
            this.chb_eliminar_roles.Text = "   Eliminar rol";
            this.chb_eliminar_roles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_eliminar_roles.UncheckedState.BorderRadius = 0;
            this.chb_eliminar_roles.UncheckedState.BorderThickness = 0;
            this.chb_eliminar_roles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_eliminar_roles.UseVisualStyleBackColor = false;
            // 
            // chb_editar_roles
            // 
            this.chb_editar_roles.AutoSize = true;
            this.chb_editar_roles.BackColor = System.Drawing.Color.Transparent;
            this.chb_editar_roles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_editar_roles.CheckedState.BorderRadius = 0;
            this.chb_editar_roles.CheckedState.BorderThickness = 0;
            this.chb_editar_roles.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_editar_roles.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_editar_roles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chb_editar_roles.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_editar_roles.Location = new System.Drawing.Point(23, 580);
            this.chb_editar_roles.Name = "chb_editar_roles";
            this.chb_editar_roles.Size = new System.Drawing.Size(82, 19);
            this.chb_editar_roles.TabIndex = 21;
            this.chb_editar_roles.Tag = "16";
            this.chb_editar_roles.Text = "   Editar rol";
            this.chb_editar_roles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_editar_roles.UncheckedState.BorderRadius = 0;
            this.chb_editar_roles.UncheckedState.BorderThickness = 0;
            this.chb_editar_roles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_editar_roles.UseVisualStyleBackColor = false;
            // 
            // chb_agregar_roles
            // 
            this.chb_agregar_roles.AutoSize = true;
            this.chb_agregar_roles.BackColor = System.Drawing.Color.Transparent;
            this.chb_agregar_roles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_agregar_roles.CheckedState.BorderRadius = 0;
            this.chb_agregar_roles.CheckedState.BorderThickness = 0;
            this.chb_agregar_roles.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_agregar_roles.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_agregar_roles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_agregar_roles.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_agregar_roles.Location = new System.Drawing.Point(23, 555);
            this.chb_agregar_roles.Name = "chb_agregar_roles";
            this.chb_agregar_roles.Size = new System.Drawing.Size(94, 19);
            this.chb_agregar_roles.TabIndex = 20;
            this.chb_agregar_roles.Tag = "15";
            this.chb_agregar_roles.Text = "   Agregar rol";
            this.chb_agregar_roles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_agregar_roles.UncheckedState.BorderRadius = 0;
            this.chb_agregar_roles.UncheckedState.BorderThickness = 0;
            this.chb_agregar_roles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_agregar_roles.UseVisualStyleBackColor = false;
            // 
            // chb_mostrar_roles
            // 
            this.chb_mostrar_roles.AutoSize = true;
            this.chb_mostrar_roles.BackColor = System.Drawing.Color.Transparent;
            this.chb_mostrar_roles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_mostrar_roles.CheckedState.BorderRadius = 0;
            this.chb_mostrar_roles.CheckedState.BorderThickness = 0;
            this.chb_mostrar_roles.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_mostrar_roles.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_mostrar_roles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_mostrar_roles.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_mostrar_roles.Location = new System.Drawing.Point(23, 530);
            this.chb_mostrar_roles.Name = "chb_mostrar_roles";
            this.chb_mostrar_roles.Size = new System.Drawing.Size(104, 19);
            this.chb_mostrar_roles.TabIndex = 19;
            this.chb_mostrar_roles.Tag = "14";
            this.chb_mostrar_roles.Text = "   Mostrar roles";
            this.chb_mostrar_roles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_mostrar_roles.UncheckedState.BorderRadius = 0;
            this.chb_mostrar_roles.UncheckedState.BorderThickness = 0;
            this.chb_mostrar_roles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_mostrar_roles.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.label8.Location = new System.Drawing.Point(20, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Roles";
            // 
            // chb_eliminar_usuarios
            // 
            this.chb_eliminar_usuarios.AutoSize = true;
            this.chb_eliminar_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.chb_eliminar_usuarios.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_eliminar_usuarios.CheckedState.BorderRadius = 0;
            this.chb_eliminar_usuarios.CheckedState.BorderThickness = 0;
            this.chb_eliminar_usuarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_eliminar_usuarios.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_eliminar_usuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_eliminar_usuarios.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_eliminar_usuarios.Location = new System.Drawing.Point(23, 467);
            this.chb_eliminar_usuarios.Name = "chb_eliminar_usuarios";
            this.chb_eliminar_usuarios.Size = new System.Drawing.Size(125, 19);
            this.chb_eliminar_usuarios.TabIndex = 17;
            this.chb_eliminar_usuarios.Tag = "13";
            this.chb_eliminar_usuarios.Text = "   Eliminar usuarios";
            this.chb_eliminar_usuarios.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_eliminar_usuarios.UncheckedState.BorderRadius = 0;
            this.chb_eliminar_usuarios.UncheckedState.BorderThickness = 0;
            this.chb_eliminar_usuarios.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_eliminar_usuarios.UseVisualStyleBackColor = false;
            // 
            // chb_editar_usuarios
            // 
            this.chb_editar_usuarios.AutoSize = true;
            this.chb_editar_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.chb_editar_usuarios.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_editar_usuarios.CheckedState.BorderRadius = 0;
            this.chb_editar_usuarios.CheckedState.BorderThickness = 0;
            this.chb_editar_usuarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_editar_usuarios.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_editar_usuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_editar_usuarios.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_editar_usuarios.Location = new System.Drawing.Point(23, 442);
            this.chb_editar_usuarios.Name = "chb_editar_usuarios";
            this.chb_editar_usuarios.Size = new System.Drawing.Size(112, 19);
            this.chb_editar_usuarios.TabIndex = 16;
            this.chb_editar_usuarios.Tag = "12";
            this.chb_editar_usuarios.Text = "   Editar usuarios";
            this.chb_editar_usuarios.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_editar_usuarios.UncheckedState.BorderRadius = 0;
            this.chb_editar_usuarios.UncheckedState.BorderThickness = 0;
            this.chb_editar_usuarios.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_editar_usuarios.UseVisualStyleBackColor = false;
            // 
            // chb_agregar_usuarios
            // 
            this.chb_agregar_usuarios.AutoSize = true;
            this.chb_agregar_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.chb_agregar_usuarios.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_agregar_usuarios.CheckedState.BorderRadius = 0;
            this.chb_agregar_usuarios.CheckedState.BorderThickness = 0;
            this.chb_agregar_usuarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_agregar_usuarios.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_agregar_usuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_agregar_usuarios.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_agregar_usuarios.Location = new System.Drawing.Point(23, 417);
            this.chb_agregar_usuarios.Name = "chb_agregar_usuarios";
            this.chb_agregar_usuarios.Size = new System.Drawing.Size(124, 19);
            this.chb_agregar_usuarios.TabIndex = 15;
            this.chb_agregar_usuarios.Tag = "11";
            this.chb_agregar_usuarios.Text = "   Agregar usuarios";
            this.chb_agregar_usuarios.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_agregar_usuarios.UncheckedState.BorderRadius = 0;
            this.chb_agregar_usuarios.UncheckedState.BorderThickness = 0;
            this.chb_agregar_usuarios.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_agregar_usuarios.UseVisualStyleBackColor = false;
            // 
            // chb_mostrar_usuarios
            // 
            this.chb_mostrar_usuarios.AutoSize = true;
            this.chb_mostrar_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.chb_mostrar_usuarios.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_mostrar_usuarios.CheckedState.BorderRadius = 0;
            this.chb_mostrar_usuarios.CheckedState.BorderThickness = 0;
            this.chb_mostrar_usuarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_mostrar_usuarios.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_mostrar_usuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_mostrar_usuarios.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_mostrar_usuarios.Location = new System.Drawing.Point(23, 392);
            this.chb_mostrar_usuarios.Name = "chb_mostrar_usuarios";
            this.chb_mostrar_usuarios.Size = new System.Drawing.Size(123, 19);
            this.chb_mostrar_usuarios.TabIndex = 14;
            this.chb_mostrar_usuarios.Tag = "10";
            this.chb_mostrar_usuarios.Text = "   Mostrar usuarios";
            this.chb_mostrar_usuarios.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_mostrar_usuarios.UncheckedState.BorderRadius = 0;
            this.chb_mostrar_usuarios.UncheckedState.BorderThickness = 0;
            this.chb_mostrar_usuarios.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_mostrar_usuarios.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.label7.Location = new System.Drawing.Point(20, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Usuarios";
            // 
            // chb_eliminar_membresia
            // 
            this.chb_eliminar_membresia.AutoSize = true;
            this.chb_eliminar_membresia.BackColor = System.Drawing.Color.Transparent;
            this.chb_eliminar_membresia.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_eliminar_membresia.CheckedState.BorderRadius = 0;
            this.chb_eliminar_membresia.CheckedState.BorderThickness = 0;
            this.chb_eliminar_membresia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_eliminar_membresia.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_eliminar_membresia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_eliminar_membresia.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_eliminar_membresia.Location = new System.Drawing.Point(23, 330);
            this.chb_eliminar_membresia.Name = "chb_eliminar_membresia";
            this.chb_eliminar_membresia.Size = new System.Drawing.Size(145, 19);
            this.chb_eliminar_membresia.TabIndex = 12;
            this.chb_eliminar_membresia.Tag = "9";
            this.chb_eliminar_membresia.Text = "   Eliminar membresias";
            this.chb_eliminar_membresia.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_eliminar_membresia.UncheckedState.BorderRadius = 0;
            this.chb_eliminar_membresia.UncheckedState.BorderThickness = 0;
            this.chb_eliminar_membresia.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_eliminar_membresia.UseVisualStyleBackColor = false;
            // 
            // chb_editar_membresia
            // 
            this.chb_editar_membresia.AutoSize = true;
            this.chb_editar_membresia.BackColor = System.Drawing.Color.Transparent;
            this.chb_editar_membresia.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_editar_membresia.CheckedState.BorderRadius = 0;
            this.chb_editar_membresia.CheckedState.BorderThickness = 0;
            this.chb_editar_membresia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_editar_membresia.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_editar_membresia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_editar_membresia.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_editar_membresia.Location = new System.Drawing.Point(23, 305);
            this.chb_editar_membresia.Name = "chb_editar_membresia";
            this.chb_editar_membresia.Size = new System.Drawing.Size(132, 19);
            this.chb_editar_membresia.TabIndex = 11;
            this.chb_editar_membresia.Tag = "8";
            this.chb_editar_membresia.Text = "   Editar membresias";
            this.chb_editar_membresia.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_editar_membresia.UncheckedState.BorderRadius = 0;
            this.chb_editar_membresia.UncheckedState.BorderThickness = 0;
            this.chb_editar_membresia.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_editar_membresia.UseVisualStyleBackColor = false;
            // 
            // chb_agregar_membresias
            // 
            this.chb_agregar_membresias.AutoSize = true;
            this.chb_agregar_membresias.BackColor = System.Drawing.Color.Transparent;
            this.chb_agregar_membresias.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_agregar_membresias.CheckedState.BorderRadius = 0;
            this.chb_agregar_membresias.CheckedState.BorderThickness = 0;
            this.chb_agregar_membresias.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_agregar_membresias.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_agregar_membresias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_agregar_membresias.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_agregar_membresias.Location = new System.Drawing.Point(23, 280);
            this.chb_agregar_membresias.Name = "chb_agregar_membresias";
            this.chb_agregar_membresias.Size = new System.Drawing.Size(144, 19);
            this.chb_agregar_membresias.TabIndex = 10;
            this.chb_agregar_membresias.Tag = "7";
            this.chb_agregar_membresias.Text = "   Agregar membresias";
            this.chb_agregar_membresias.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_agregar_membresias.UncheckedState.BorderRadius = 0;
            this.chb_agregar_membresias.UncheckedState.BorderThickness = 0;
            this.chb_agregar_membresias.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_agregar_membresias.UseVisualStyleBackColor = false;
            // 
            // chb_mostrar_membresias
            // 
            this.chb_mostrar_membresias.AutoSize = true;
            this.chb_mostrar_membresias.BackColor = System.Drawing.Color.Transparent;
            this.chb_mostrar_membresias.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_mostrar_membresias.CheckedState.BorderRadius = 0;
            this.chb_mostrar_membresias.CheckedState.BorderThickness = 0;
            this.chb_mostrar_membresias.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_mostrar_membresias.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_mostrar_membresias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_mostrar_membresias.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_mostrar_membresias.Location = new System.Drawing.Point(23, 255);
            this.chb_mostrar_membresias.Name = "chb_mostrar_membresias";
            this.chb_mostrar_membresias.Size = new System.Drawing.Size(143, 19);
            this.chb_mostrar_membresias.TabIndex = 9;
            this.chb_mostrar_membresias.Tag = "6";
            this.chb_mostrar_membresias.Text = "   Mostrar membresias";
            this.chb_mostrar_membresias.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_mostrar_membresias.UncheckedState.BorderRadius = 0;
            this.chb_mostrar_membresias.UncheckedState.BorderThickness = 0;
            this.chb_mostrar_membresias.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_mostrar_membresias.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.label6.Location = new System.Drawing.Point(20, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Membresías";
            // 
            // chb_eliminar_miembros
            // 
            this.chb_eliminar_miembros.AutoSize = true;
            this.chb_eliminar_miembros.BackColor = System.Drawing.Color.Transparent;
            this.chb_eliminar_miembros.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_eliminar_miembros.CheckedState.BorderRadius = 0;
            this.chb_eliminar_miembros.CheckedState.BorderThickness = 0;
            this.chb_eliminar_miembros.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_eliminar_miembros.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_eliminar_miembros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_eliminar_miembros.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_eliminar_miembros.Location = new System.Drawing.Point(23, 193);
            this.chb_eliminar_miembros.Name = "chb_eliminar_miembros";
            this.chb_eliminar_miembros.Size = new System.Drawing.Size(135, 19);
            this.chb_eliminar_miembros.TabIndex = 7;
            this.chb_eliminar_miembros.Tag = "5";
            this.chb_eliminar_miembros.Text = "   Eliminar miembros";
            this.chb_eliminar_miembros.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_eliminar_miembros.UncheckedState.BorderRadius = 0;
            this.chb_eliminar_miembros.UncheckedState.BorderThickness = 0;
            this.chb_eliminar_miembros.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_eliminar_miembros.UseVisualStyleBackColor = false;
            // 
            // chb_editar_miembros
            // 
            this.chb_editar_miembros.AutoSize = true;
            this.chb_editar_miembros.BackColor = System.Drawing.Color.Transparent;
            this.chb_editar_miembros.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_editar_miembros.CheckedState.BorderRadius = 0;
            this.chb_editar_miembros.CheckedState.BorderThickness = 0;
            this.chb_editar_miembros.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_editar_miembros.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_editar_miembros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_editar_miembros.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_editar_miembros.Location = new System.Drawing.Point(23, 168);
            this.chb_editar_miembros.Name = "chb_editar_miembros";
            this.chb_editar_miembros.Size = new System.Drawing.Size(122, 19);
            this.chb_editar_miembros.TabIndex = 6;
            this.chb_editar_miembros.Tag = "4";
            this.chb_editar_miembros.Text = "   Editar miembros";
            this.chb_editar_miembros.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_editar_miembros.UncheckedState.BorderRadius = 0;
            this.chb_editar_miembros.UncheckedState.BorderThickness = 0;
            this.chb_editar_miembros.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_editar_miembros.UseVisualStyleBackColor = false;
            // 
            // chb_agregar_miembros
            // 
            this.chb_agregar_miembros.AutoSize = true;
            this.chb_agregar_miembros.BackColor = System.Drawing.Color.Transparent;
            this.chb_agregar_miembros.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_agregar_miembros.CheckedState.BorderRadius = 0;
            this.chb_agregar_miembros.CheckedState.BorderThickness = 0;
            this.chb_agregar_miembros.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_agregar_miembros.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_agregar_miembros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_agregar_miembros.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_agregar_miembros.Location = new System.Drawing.Point(23, 143);
            this.chb_agregar_miembros.Name = "chb_agregar_miembros";
            this.chb_agregar_miembros.Size = new System.Drawing.Size(134, 19);
            this.chb_agregar_miembros.TabIndex = 5;
            this.chb_agregar_miembros.Tag = "3";
            this.chb_agregar_miembros.Text = "   Agregar miembros";
            this.chb_agregar_miembros.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_agregar_miembros.UncheckedState.BorderRadius = 0;
            this.chb_agregar_miembros.UncheckedState.BorderThickness = 0;
            this.chb_agregar_miembros.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_agregar_miembros.UseVisualStyleBackColor = false;
            // 
            // chb_mostrar_miembros
            // 
            this.chb_mostrar_miembros.AutoSize = true;
            this.chb_mostrar_miembros.BackColor = System.Drawing.Color.Transparent;
            this.chb_mostrar_miembros.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_mostrar_miembros.CheckedState.BorderRadius = 0;
            this.chb_mostrar_miembros.CheckedState.BorderThickness = 0;
            this.chb_mostrar_miembros.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_mostrar_miembros.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_mostrar_miembros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_mostrar_miembros.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_mostrar_miembros.Location = new System.Drawing.Point(23, 118);
            this.chb_mostrar_miembros.Name = "chb_mostrar_miembros";
            this.chb_mostrar_miembros.Size = new System.Drawing.Size(133, 19);
            this.chb_mostrar_miembros.TabIndex = 4;
            this.chb_mostrar_miembros.Tag = "2";
            this.chb_mostrar_miembros.Text = "   Mostrar miembros";
            this.chb_mostrar_miembros.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_mostrar_miembros.UncheckedState.BorderRadius = 0;
            this.chb_mostrar_miembros.UncheckedState.BorderThickness = 0;
            this.chb_mostrar_miembros.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_mostrar_miembros.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.label5.Location = new System.Drawing.Point(20, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Miembros";
            // 
            // chb_show_estadisticas
            // 
            this.chb_show_estadisticas.AutoSize = true;
            this.chb_show_estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.chb_show_estadisticas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_show_estadisticas.CheckedState.BorderRadius = 0;
            this.chb_show_estadisticas.CheckedState.BorderThickness = 0;
            this.chb_show_estadisticas.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chb_show_estadisticas.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chb_show_estadisticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_show_estadisticas.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.chb_show_estadisticas.Location = new System.Drawing.Point(23, 52);
            this.chb_show_estadisticas.Name = "chb_show_estadisticas";
            this.chb_show_estadisticas.Size = new System.Drawing.Size(139, 19);
            this.chb_show_estadisticas.TabIndex = 2;
            this.chb_show_estadisticas.Tag = "1";
            this.chb_show_estadisticas.Text = "   Mostrar estadisticas";
            this.chb_show_estadisticas.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_show_estadisticas.UncheckedState.BorderRadius = 0;
            this.chb_show_estadisticas.UncheckedState.BorderThickness = 0;
            this.chb_show_estadisticas.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_show_estadisticas.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.label4.Location = new System.Drawing.Point(20, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estadísticas";
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.ClientSize = new System.Drawing.Size(471, 587);
            this.Controls.Add(this.panel_permisos);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar_permisos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.btn_guardar_rol);
            this.Controls.Add(this.txt_nombre_rol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRol";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRol";
            this.Load += new System.EventHandler(this.FormRol_Load);
            this.panel_permisos.ResumeLayout(false);
            this.panel_permisos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2Button btn_guardar_rol;
        public Guna.UI2.WinForms.Guna2TextBox txt_nombre_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_guardar_permisos;
        private Guna.UI2.WinForms.Guna2Panel panel_permisos;
        private Guna.UI2.WinForms.Guna2CheckBox chb_eliminar_roles;
        private Guna.UI2.WinForms.Guna2CheckBox chb_editar_roles;
        private Guna.UI2.WinForms.Guna2CheckBox chb_agregar_roles;
        private Guna.UI2.WinForms.Guna2CheckBox chb_mostrar_roles;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CheckBox chb_eliminar_usuarios;
        private Guna.UI2.WinForms.Guna2CheckBox chb_editar_usuarios;
        private Guna.UI2.WinForms.Guna2CheckBox chb_agregar_usuarios;
        private Guna.UI2.WinForms.Guna2CheckBox chb_mostrar_usuarios;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CheckBox chb_eliminar_membresia;
        private Guna.UI2.WinForms.Guna2CheckBox chb_editar_membresia;
        private Guna.UI2.WinForms.Guna2CheckBox chb_agregar_membresias;
        private Guna.UI2.WinForms.Guna2CheckBox chb_mostrar_membresias;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CheckBox chb_eliminar_miembros;
        private Guna.UI2.WinForms.Guna2CheckBox chb_editar_miembros;
        private Guna.UI2.WinForms.Guna2CheckBox chb_agregar_miembros;
        private Guna.UI2.WinForms.Guna2CheckBox chb_mostrar_miembros;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox chb_show_estadisticas;
        private System.Windows.Forms.Label label4;
    }
}