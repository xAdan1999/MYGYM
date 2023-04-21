namespace Presentation.Forms.Usuarios
{
    partial class FormUsuario
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
            this.label5 = new System.Windows.Forms.Label();
            this.cb_rol_usuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txt_confirmar_contrasena_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nombre_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_contrasena_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label5.Location = new System.Drawing.Point(37, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rol";
            // 
            // cb_rol_usuario
            // 
            this.cb_rol_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_rol_usuario.BackColor = System.Drawing.Color.Transparent;
            this.cb_rol_usuario.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.cb_rol_usuario.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.cb_rol_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_rol_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_rol_usuario.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_rol_usuario.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_rol_usuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_rol_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rol_usuario.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.cb_rol_usuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_rol_usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_rol_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_rol_usuario.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.cb_rol_usuario.ItemHeight = 26;
            this.cb_rol_usuario.Items.AddRange(new object[] {
            "Seleccionar"});
            this.cb_rol_usuario.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cb_rol_usuario.Location = new System.Drawing.Point(37, 395);
            this.cb_rol_usuario.Name = "cb_rol_usuario";
            this.cb_rol_usuario.Size = new System.Drawing.Size(247, 32);
            this.cb_rol_usuario.StartIndex = 0;
            this.cb_rol_usuario.TabIndex = 10;
            this.cb_rol_usuario.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label4.Location = new System.Drawing.Point(37, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "* Confirmar contraseña";
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
            this.btn_cancelar.Location = new System.Drawing.Point(37, 461);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(118, 32);
            this.btn_cancelar.TabIndex = 14;
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
            this.lb_titulo.Location = new System.Drawing.Point(37, 46);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(65, 21);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Usuario";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.Animated = true;
            this.btn_guardar.BorderColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_guardar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_guardar.BorderThickness = 1;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardar.FillColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(166, 461);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(118, 32);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label2.Location = new System.Drawing.Point(37, 169);
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
            this.label1.Location = new System.Drawing.Point(37, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estos serán los datos para poder iniciar sesión\r\nes importante no olvidarlos\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label3.Location = new System.Drawing.Point(37, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "* Contraseña";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txt_confirmar_contrasena_usuario
            // 
            this.txt_confirmar_contrasena_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_confirmar_contrasena_usuario.Animated = true;
            this.txt_confirmar_contrasena_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_confirmar_contrasena_usuario.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_confirmar_contrasena_usuario.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_confirmar_contrasena_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confirmar_contrasena_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_confirmar_contrasena_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_confirmar_contrasena_usuario.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_confirmar_contrasena_usuario.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_confirmar_contrasena_usuario.DefaultText = "";
            this.txt_confirmar_contrasena_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confirmar_contrasena_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confirmar_contrasena_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmar_contrasena_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmar_contrasena_usuario.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_confirmar_contrasena_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_confirmar_contrasena_usuario.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_confirmar_contrasena_usuario.IconLeft = global::Presentation.Properties.Resources.ic_contrasena;
            this.txt_confirmar_contrasena_usuario.IconLeftOffset = new System.Drawing.Point(5, -1);
            this.txt_confirmar_contrasena_usuario.IconLeftSize = new System.Drawing.Size(19, 19);
            this.txt_confirmar_contrasena_usuario.IconRight = global::Presentation.Properties.Resources.ic_mostrar_contrasena;
            this.txt_confirmar_contrasena_usuario.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_confirmar_contrasena_usuario.IconRightOffset = new System.Drawing.Point(5, -1);
            this.txt_confirmar_contrasena_usuario.IconRightSize = new System.Drawing.Size(19, 19);
            this.txt_confirmar_contrasena_usuario.Location = new System.Drawing.Point(37, 328);
            this.txt_confirmar_contrasena_usuario.MaxLength = 50;
            this.txt_confirmar_contrasena_usuario.Name = "txt_confirmar_contrasena_usuario";
            this.txt_confirmar_contrasena_usuario.PasswordChar = '\0';
            this.txt_confirmar_contrasena_usuario.PlaceholderText = "Confirma la contraseña";
            this.txt_confirmar_contrasena_usuario.SelectedText = "";
            this.txt_confirmar_contrasena_usuario.Size = new System.Drawing.Size(247, 32);
            this.txt_confirmar_contrasena_usuario.TabIndex = 8;
            this.txt_confirmar_contrasena_usuario.TextOffset = new System.Drawing.Point(5, 0);
            this.txt_confirmar_contrasena_usuario.IconRightClick += new System.EventHandler(this.txt_confirmar_contrasena_usuario_IconRightClick);
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre_usuario.Animated = true;
            this.txt_nombre_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre_usuario.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_nombre_usuario.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_nombre_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_usuario.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_usuario.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_usuario.DefaultText = "";
            this.txt_nombre_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nombre_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nombre_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre_usuario.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nombre_usuario.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_nombre_usuario.IconLeft = global::Presentation.Properties.Resources.ic_usuario;
            this.txt_nombre_usuario.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_nombre_usuario.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txt_nombre_usuario.Location = new System.Drawing.Point(37, 194);
            this.txt_nombre_usuario.MaxLength = 50;
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.PasswordChar = '\0';
            this.txt_nombre_usuario.PlaceholderText = "Ingresa el nombre";
            this.txt_nombre_usuario.SelectedText = "";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(247, 32);
            this.txt_nombre_usuario.TabIndex = 4;
            this.txt_nombre_usuario.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txt_contrasena_usuario
            // 
            this.txt_contrasena_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contrasena_usuario.Animated = true;
            this.txt_contrasena_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_contrasena_usuario.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_contrasena_usuario.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_contrasena_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contrasena_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_contrasena_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_contrasena_usuario.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_contrasena_usuario.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_contrasena_usuario.DefaultText = "";
            this.txt_contrasena_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_contrasena_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_contrasena_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_contrasena_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_contrasena_usuario.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_contrasena_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_contrasena_usuario.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_contrasena_usuario.IconLeft = global::Presentation.Properties.Resources.ic_contrasena;
            this.txt_contrasena_usuario.IconLeftOffset = new System.Drawing.Point(5, -1);
            this.txt_contrasena_usuario.IconLeftSize = new System.Drawing.Size(19, 19);
            this.txt_contrasena_usuario.IconRight = global::Presentation.Properties.Resources.ic_mostrar_contrasena;
            this.txt_contrasena_usuario.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_contrasena_usuario.IconRightOffset = new System.Drawing.Point(5, -1);
            this.txt_contrasena_usuario.IconRightSize = new System.Drawing.Size(19, 19);
            this.txt_contrasena_usuario.Location = new System.Drawing.Point(37, 261);
            this.txt_contrasena_usuario.MaxLength = 50;
            this.txt_contrasena_usuario.Name = "txt_contrasena_usuario";
            this.txt_contrasena_usuario.PasswordChar = '\0';
            this.txt_contrasena_usuario.PlaceholderText = "Ingresa una contraseña";
            this.txt_contrasena_usuario.SelectedText = "";
            this.txt_contrasena_usuario.Size = new System.Drawing.Size(247, 32);
            this.txt_contrasena_usuario.TabIndex = 6;
            this.txt_contrasena_usuario.TextOffset = new System.Drawing.Point(5, 0);
            this.txt_contrasena_usuario.IconRightClick += new System.EventHandler(this.txt_contrasena_usuario_IconRightClick);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.ClientSize = new System.Drawing.Size(321, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_rol_usuario);
            this.Controls.Add(this.txt_confirmar_contrasena_usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contrasena_usuario);
            this.Controls.Add(this.label3);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox txt_confirmar_contrasena_usuario;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        public Guna.UI2.WinForms.Guna2TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txt_contrasena_usuario;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2ComboBox cb_rol_usuario;
    }
}