namespace Presentation.Forms
{
    partial class App
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
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_topbar = new System.Windows.Forms.Panel();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btn_miembros = new Guna.UI2.WinForms.Guna2Button();
            this.btn_membresias = new Guna.UI2.WinForms.Guna2Button();
            this.btn_usuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btn_roles_usuario = new Guna.UI2.WinForms.Guna2Button();
            this.cpb_foto_usuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_ajustes = new Guna.UI2.WinForms.Guna2Button();
            this.panel_topbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpb_foto_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.panel_container.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 46);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1107, 513);
            this.panel_container.TabIndex = 2;
            // 
            // panel_topbar
            // 
            this.panel_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel_topbar.Controls.Add(this.lb_usuario);
            this.panel_topbar.Controls.Add(this.flowLayoutPanel1);
            this.panel_topbar.Controls.Add(this.label1);
            this.panel_topbar.Controls.Add(this.lb_titulo);
            this.panel_topbar.Controls.Add(this.cpb_foto_usuario);
            this.panel_topbar.Controls.Add(this.btn_ajustes);
            this.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topbar.Location = new System.Drawing.Point(0, 0);
            this.panel_topbar.Name = "panel_topbar";
            this.panel_topbar.Size = new System.Drawing.Size(1107, 46);
            this.panel_topbar.TabIndex = 1;
            // 
            // lb_usuario
            // 
            this.lb_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_usuario.AutoEllipsis = true;
            this.lb_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.ForeColor = System.Drawing.Color.White;
            this.lb_usuario.Location = new System.Drawing.Point(1014, 16);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(83, 15);
            this.lb_usuario.TabIndex = 6;
            this.lb_usuario.Text = "Usuario";
            this.lb_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_dashboard);
            this.flowLayoutPanel1.Controls.Add(this.btn_miembros);
            this.flowLayoutPanel1.Controls.Add(this.btn_membresias);
            this.flowLayoutPanel1.Controls.Add(this.btn_usuarios);
            this.flowLayoutPanel1.Controls.Add(this.btn_roles_usuario);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 38);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "YM";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.lb_titulo.Location = new System.Drawing.Point(18, 13);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(22, 21);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "G";
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Animated = true;
            this.btn_dashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_dashboard.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_dashboard.BorderThickness = 1;
            this.btn_dashboard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_dashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_dashboard.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.CheckedState.Image = global::Presentation.Properties.Resources.ic_estadisticas_hover;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.DimGray;
            this.btn_dashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.HoverState.Image = global::Presentation.Properties.Resources.ic_estadisticas_hover;
            this.btn_dashboard.Image = global::Presentation.Properties.Resources.ic_estadisticas;
            this.btn_dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dashboard.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_dashboard.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_dashboard.Location = new System.Drawing.Point(3, 3);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(128, 32);
            this.btn_dashboard.TabIndex = 3;
            this.btn_dashboard.Tag = "1";
            this.btn_dashboard.Text = "Estadísticas";
            this.btn_dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dashboard.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_dashboard.Visible = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_miembros
            // 
            this.btn_miembros.Animated = true;
            this.btn_miembros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_miembros.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_miembros.BorderThickness = 1;
            this.btn_miembros.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_miembros.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_miembros.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_miembros.CheckedState.Image = global::Presentation.Properties.Resources.ic_miembros_hover;
            this.btn_miembros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_miembros.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_miembros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_miembros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_miembros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_miembros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_miembros.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_miembros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_miembros.ForeColor = System.Drawing.Color.DimGray;
            this.btn_miembros.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_miembros.HoverState.Image = global::Presentation.Properties.Resources.ic_miembros_hover;
            this.btn_miembros.Image = global::Presentation.Properties.Resources.ic_miembros;
            this.btn_miembros.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_miembros.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_miembros.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_miembros.Location = new System.Drawing.Point(137, 3);
            this.btn_miembros.Name = "btn_miembros";
            this.btn_miembros.Size = new System.Drawing.Size(129, 32);
            this.btn_miembros.TabIndex = 4;
            this.btn_miembros.Tag = "2";
            this.btn_miembros.Text = "Miembros";
            this.btn_miembros.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_miembros.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_miembros.Visible = false;
            this.btn_miembros.Click += new System.EventHandler(this.btn_miembros_Click);
            // 
            // btn_membresias
            // 
            this.btn_membresias.Animated = true;
            this.btn_membresias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_membresias.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_membresias.BorderThickness = 1;
            this.btn_membresias.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_membresias.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_membresias.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_membresias.CheckedState.Image = global::Presentation.Properties.Resources.ic_membresias_hover;
            this.btn_membresias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_membresias.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_membresias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_membresias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_membresias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_membresias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_membresias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_membresias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_membresias.ForeColor = System.Drawing.Color.DimGray;
            this.btn_membresias.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_membresias.HoverState.Image = global::Presentation.Properties.Resources.ic_membresias_hover;
            this.btn_membresias.Image = global::Presentation.Properties.Resources.ic_membresias;
            this.btn_membresias.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_membresias.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_membresias.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_membresias.Location = new System.Drawing.Point(272, 3);
            this.btn_membresias.Name = "btn_membresias";
            this.btn_membresias.Size = new System.Drawing.Size(128, 32);
            this.btn_membresias.TabIndex = 5;
            this.btn_membresias.Tag = "6";
            this.btn_membresias.Text = "Membresías";
            this.btn_membresias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_membresias.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_membresias.Visible = false;
            this.btn_membresias.Click += new System.EventHandler(this.btn_membresias_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Animated = true;
            this.btn_usuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_usuarios.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_usuarios.BorderThickness = 1;
            this.btn_usuarios.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_usuarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_usuarios.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_usuarios.CheckedState.Image = global::Presentation.Properties.Resources.ic_usuarios_hover;
            this.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuarios.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_usuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_usuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_usuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_usuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_usuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_usuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_usuarios.ForeColor = System.Drawing.Color.DimGray;
            this.btn_usuarios.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_usuarios.HoverState.Image = global::Presentation.Properties.Resources.ic_usuarios_hover;
            this.btn_usuarios.Image = global::Presentation.Properties.Resources.ic_usuarios;
            this.btn_usuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_usuarios.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_usuarios.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_usuarios.Location = new System.Drawing.Point(406, 3);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(128, 32);
            this.btn_usuarios.TabIndex = 6;
            this.btn_usuarios.Tag = "10";
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_usuarios.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_usuarios.Visible = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_roles_usuario
            // 
            this.btn_roles_usuario.Animated = true;
            this.btn_roles_usuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_roles_usuario.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_roles_usuario.BorderThickness = 1;
            this.btn_roles_usuario.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_roles_usuario.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_roles_usuario.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_roles_usuario.CheckedState.Image = global::Presentation.Properties.Resources.ic_roles_hover;
            this.btn_roles_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_roles_usuario.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_roles_usuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_roles_usuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_roles_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_roles_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_roles_usuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_roles_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_roles_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.btn_roles_usuario.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_roles_usuario.HoverState.Image = global::Presentation.Properties.Resources.ic_roles_hover;
            this.btn_roles_usuario.Image = global::Presentation.Properties.Resources.ic_roles;
            this.btn_roles_usuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_roles_usuario.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_roles_usuario.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_roles_usuario.Location = new System.Drawing.Point(540, 3);
            this.btn_roles_usuario.Name = "btn_roles_usuario";
            this.btn_roles_usuario.Size = new System.Drawing.Size(128, 32);
            this.btn_roles_usuario.TabIndex = 7;
            this.btn_roles_usuario.Tag = "14";
            this.btn_roles_usuario.Text = "Roles";
            this.btn_roles_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_roles_usuario.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_roles_usuario.Visible = false;
            this.btn_roles_usuario.Click += new System.EventHandler(this.btn_roles_usuario_Click);
            // 
            // cpb_foto_usuario
            // 
            this.cpb_foto_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpb_foto_usuario.Image = global::Presentation.Properties.Resources.user;
            this.cpb_foto_usuario.ImageRotate = 0F;
            this.cpb_foto_usuario.Location = new System.Drawing.Point(978, 11);
            this.cpb_foto_usuario.Name = "cpb_foto_usuario";
            this.cpb_foto_usuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpb_foto_usuario.Size = new System.Drawing.Size(25, 25);
            this.cpb_foto_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpb_foto_usuario.TabIndex = 1;
            this.cpb_foto_usuario.TabStop = false;
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajustes.Animated = true;
            this.btn_ajustes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_ajustes.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_ajustes.BorderThickness = 1;
            this.btn_ajustes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_ajustes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_ajustes.CheckedState.Image = global::Presentation.Properties.Resources.ic_ajustes_hover;
            this.btn_ajustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajustes.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_ajustes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajustes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajustes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajustes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajustes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_ajustes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajustes.ForeColor = System.Drawing.Color.White;
            this.btn_ajustes.HoverState.Image = global::Presentation.Properties.Resources.ic_ajustes_hover;
            this.btn_ajustes.Image = global::Presentation.Properties.Resources.ic_ajustes;
            this.btn_ajustes.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_ajustes.Location = new System.Drawing.Point(925, 7);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(32, 32);
            this.btn_ajustes.TabIndex = 5;
            this.btn_ajustes.Click += new System.EventHandler(this.btn_ajustes_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.ClientSize = new System.Drawing.Size(1107, 559);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_topbar);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaximumSize = new System.Drawing.Size(1366, 738);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "App";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_FormClosing);
            this.Load += new System.EventHandler(this.App_Load);
            this.panel_topbar.ResumeLayout(false);
            this.panel_topbar.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpb_foto_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_container;
        private Guna.UI2.WinForms.Guna2Button btn_miembros;
        private Guna.UI2.WinForms.Guna2Button btn_roles_usuario;
        private Guna.UI2.WinForms.Guna2Button btn_usuarios;
        private Guna.UI2.WinForms.Guna2Button btn_dashboard;
        private Guna.UI2.WinForms.Guna2Button btn_ajustes;
        private Guna.UI2.WinForms.Guna2Button btn_membresias;
        private System.Windows.Forms.Panel panel_topbar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpb_foto_usuario;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_usuario;
    }
}