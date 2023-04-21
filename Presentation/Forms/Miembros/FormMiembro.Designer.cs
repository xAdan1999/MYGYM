namespace Presentation.Forms.Miembros
{
    partial class FormMiembro
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
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_nombre_miembro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apellido_miembro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_sexo_miembro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_costo_membresia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_membresia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txt_fecha_inicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_telefono_miembro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_fecha_fin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
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
            this.btn_cancelar.Location = new System.Drawing.Point(320, 489);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(118, 32);
            this.btn_cancelar.TabIndex = 23;
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
            this.lb_titulo.Location = new System.Drawing.Point(46, 51);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(78, 21);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Miembro";
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
            this.btn_guardar.Location = new System.Drawing.Point(449, 489);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(118, 32);
            this.btn_guardar.TabIndex = 24;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_nombre_miembro
            // 
            this.txt_nombre_miembro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre_miembro.Animated = true;
            this.txt_nombre_miembro.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre_miembro.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_nombre_miembro.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_nombre_miembro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre_miembro.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_miembro.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_miembro.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_miembro.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nombre_miembro.DefaultText = "";
            this.txt_nombre_miembro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nombre_miembro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nombre_miembro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre_miembro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre_miembro.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_nombre_miembro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nombre_miembro.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_nombre_miembro.Location = new System.Drawing.Point(46, 195);
            this.txt_nombre_miembro.MaxLength = 50;
            this.txt_nombre_miembro.Name = "txt_nombre_miembro";
            this.txt_nombre_miembro.PasswordChar = '\0';
            this.txt_nombre_miembro.PlaceholderText = "Ingresa el nombre";
            this.txt_nombre_miembro.SelectedText = "";
            this.txt_nombre_miembro.Size = new System.Drawing.Size(247, 32);
            this.txt_nombre_miembro.TabIndex = 4;
            this.txt_nombre_miembro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_miembro_KeyDown);
            this.txt_nombre_miembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_miembro_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label2.Location = new System.Drawing.Point(46, 170);
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
            this.label1.Location = new System.Drawing.Point(46, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos personales";
            // 
            // txt_apellido_miembro
            // 
            this.txt_apellido_miembro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_apellido_miembro.Animated = true;
            this.txt_apellido_miembro.BackColor = System.Drawing.Color.Transparent;
            this.txt_apellido_miembro.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_apellido_miembro.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_apellido_miembro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apellido_miembro.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_apellido_miembro.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_apellido_miembro.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_apellido_miembro.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_apellido_miembro.DefaultText = "";
            this.txt_apellido_miembro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_apellido_miembro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_apellido_miembro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_apellido_miembro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_apellido_miembro.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_apellido_miembro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_apellido_miembro.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_apellido_miembro.Location = new System.Drawing.Point(46, 262);
            this.txt_apellido_miembro.MaxLength = 50;
            this.txt_apellido_miembro.Name = "txt_apellido_miembro";
            this.txt_apellido_miembro.PasswordChar = '\0';
            this.txt_apellido_miembro.PlaceholderText = "Ingresa el apellido";
            this.txt_apellido_miembro.SelectedText = "";
            this.txt_apellido_miembro.Size = new System.Drawing.Size(247, 32);
            this.txt_apellido_miembro.TabIndex = 6;
            this.txt_apellido_miembro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_apellido_miembro_KeyDown);
            this.txt_apellido_miembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_miembro_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label3.Location = new System.Drawing.Point(46, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "* Apellido";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label4.Location = new System.Drawing.Point(46, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. Teléfono";
            // 
            // cb_sexo_miembro
            // 
            this.cb_sexo_miembro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_sexo_miembro.BackColor = System.Drawing.Color.Transparent;
            this.cb_sexo_miembro.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.cb_sexo_miembro.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.cb_sexo_miembro.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sexo_miembro.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sexo_miembro.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sexo_miembro.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sexo_miembro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_sexo_miembro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sexo_miembro.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.cb_sexo_miembro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_sexo_miembro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_sexo_miembro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexo_miembro.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.cb_sexo_miembro.ItemHeight = 26;
            this.cb_sexo_miembro.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cb_sexo_miembro.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cb_sexo_miembro.Location = new System.Drawing.Point(46, 396);
            this.cb_sexo_miembro.Name = "cb_sexo_miembro";
            this.cb_sexo_miembro.Size = new System.Drawing.Size(247, 32);
            this.cb_sexo_miembro.StartIndex = 0;
            this.cb_sexo_miembro.TabIndex = 10;
            this.cb_sexo_miembro.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label5.Location = new System.Drawing.Point(46, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label10.Location = new System.Drawing.Point(320, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Termina";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label9.Location = new System.Drawing.Point(320, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Inicia";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label7.Location = new System.Drawing.Point(320, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "* Membresía";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_help_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = global::Presentation.Properties.Settings.Default.label_help_color;
            this.label6.Location = new System.Drawing.Point(320, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datos de la membresía";
            // 
            // txt_costo_membresia
            // 
            this.txt_costo_membresia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_costo_membresia.Animated = true;
            this.txt_costo_membresia.BackColor = System.Drawing.Color.Transparent;
            this.txt_costo_membresia.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_costo_membresia.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_costo_membresia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_costo_membresia.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_costo_membresia.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_costo_membresia.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_costo_membresia.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_costo_membresia.DefaultText = "";
            this.txt_costo_membresia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_costo_membresia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_costo_membresia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_costo_membresia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_costo_membresia.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_costo_membresia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_costo_membresia.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_costo_membresia.Location = new System.Drawing.Point(320, 262);
            this.txt_costo_membresia.MaxLength = 7;
            this.txt_costo_membresia.Name = "txt_costo_membresia";
            this.txt_costo_membresia.PasswordChar = '\0';
            this.txt_costo_membresia.PlaceholderText = "$0.00";
            this.txt_costo_membresia.ReadOnly = true;
            this.txt_costo_membresia.SelectedText = "";
            this.txt_costo_membresia.Size = new System.Drawing.Size(247, 32);
            this.txt_costo_membresia.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label8.Location = new System.Drawing.Point(320, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Costo a pagar";
            // 
            // cb_membresia
            // 
            this.cb_membresia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_membresia.BackColor = System.Drawing.Color.Transparent;
            this.cb_membresia.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.cb_membresia.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.cb_membresia.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_membresia.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_membresia.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_membresia.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_membresia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_membresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_membresia.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.cb_membresia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_membresia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_membresia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_membresia.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.cb_membresia.ItemHeight = 26;
            this.cb_membresia.Items.AddRange(new object[] {
            "Seleccionar"});
            this.cb_membresia.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cb_membresia.Location = new System.Drawing.Point(320, 195);
            this.cb_membresia.Name = "cb_membresia";
            this.cb_membresia.Size = new System.Drawing.Size(247, 32);
            this.cb_membresia.StartIndex = 0;
            this.cb_membresia.TabIndex = 13;
            this.cb_membresia.TextOffset = new System.Drawing.Point(5, 0);
            this.cb_membresia.SelectionChangeCommitted += new System.EventHandler(this.cb_membresia_SelectionChangeCommitted);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 329);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(320, 396);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.TabStop = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fecha_inicio.Animated = true;
            this.txt_fecha_inicio.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha_inicio.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_fecha_inicio.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_fecha_inicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fecha_inicio.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fecha_inicio.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fecha_inicio.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fecha_inicio.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fecha_inicio.DefaultText = "";
            this.txt_fecha_inicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fecha_inicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fecha_inicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fecha_inicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fecha_inicio.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_fecha_inicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_fecha_inicio.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_fecha_inicio.IconRight = global::Presentation.Properties.Resources.ic_fecha;
            this.txt_fecha_inicio.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_fecha_inicio.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txt_fecha_inicio.IconRightSize = new System.Drawing.Size(17, 17);
            this.txt_fecha_inicio.Location = new System.Drawing.Point(320, 329);
            this.txt_fecha_inicio.MaxLength = 50;
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.PasswordChar = '\0';
            this.txt_fecha_inicio.PlaceholderText = "domingo, 9 de abril de 2023";
            this.txt_fecha_inicio.ReadOnly = true;
            this.txt_fecha_inicio.SelectedText = "";
            this.txt_fecha_inicio.Size = new System.Drawing.Size(247, 32);
            this.txt_fecha_inicio.TabIndex = 17;
            this.txt_fecha_inicio.IconRightClick += new System.EventHandler(this.txt_fecha_inicio_IconRightClick);
            // 
            // txt_telefono_miembro
            // 
            this.txt_telefono_miembro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefono_miembro.Animated = true;
            this.txt_telefono_miembro.BackColor = System.Drawing.Color.Transparent;
            this.txt_telefono_miembro.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_telefono_miembro.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_telefono_miembro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telefono_miembro.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_telefono_miembro.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_telefono_miembro.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_telefono_miembro.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_telefono_miembro.DefaultText = "";
            this.txt_telefono_miembro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_telefono_miembro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_telefono_miembro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telefono_miembro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telefono_miembro.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_telefono_miembro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_telefono_miembro.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_telefono_miembro.IconLeft = global::Presentation.Properties.Resources.ic_telefono;
            this.txt_telefono_miembro.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_telefono_miembro.IconLeftSize = new System.Drawing.Size(14, 16);
            this.txt_telefono_miembro.Location = new System.Drawing.Point(46, 329);
            this.txt_telefono_miembro.MaxLength = 20;
            this.txt_telefono_miembro.Name = "txt_telefono_miembro";
            this.txt_telefono_miembro.PasswordChar = '\0';
            this.txt_telefono_miembro.PlaceholderText = "(000) 000-0000";
            this.txt_telefono_miembro.SelectedText = "";
            this.txt_telefono_miembro.Size = new System.Drawing.Size(247, 32);
            this.txt_telefono_miembro.TabIndex = 8;
            this.txt_telefono_miembro.TextOffset = new System.Drawing.Point(5, 0);
            this.txt_telefono_miembro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_telefono_miembro_KeyDown);
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fecha_fin.Animated = true;
            this.txt_fecha_fin.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha_fin.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.txt_fecha_fin.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.txt_fecha_fin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fecha_fin.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fecha_fin.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fecha_fin.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fecha_fin.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fecha_fin.DefaultText = "";
            this.txt_fecha_fin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fecha_fin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fecha_fin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fecha_fin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fecha_fin.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.txt_fecha_fin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_fecha_fin.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.txt_fecha_fin.IconRight = global::Presentation.Properties.Resources.ic_fecha;
            this.txt_fecha_fin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_fecha_fin.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txt_fecha_fin.IconRightSize = new System.Drawing.Size(17, 17);
            this.txt_fecha_fin.Location = new System.Drawing.Point(320, 396);
            this.txt_fecha_fin.MaxLength = 50;
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.PasswordChar = '\0';
            this.txt_fecha_fin.PlaceholderText = "domingo, 9 de abril de 2023";
            this.txt_fecha_fin.ReadOnly = true;
            this.txt_fecha_fin.SelectedText = "";
            this.txt_fecha_fin.Size = new System.Drawing.Size(247, 32);
            this.txt_fecha_fin.TabIndex = 21;
            this.txt_fecha_fin.IconRightClick += new System.EventHandler(this.txt_fecha_fin_IconRightClick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FormMiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.ClientSize = new System.Drawing.Size(617, 570);
            this.Controls.Add(this.txt_fecha_fin);
            this.Controls.Add(this.txt_fecha_inicio);
            this.Controls.Add(this.cb_membresia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_costo_membresia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_sexo_miembro);
            this.Controls.Add(this.txt_telefono_miembro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nombre_miembro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_apellido_miembro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMiembro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMiembro";
            this.Load += new System.EventHandler(this.FormMiembro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        public Guna.UI2.WinForms.Guna2TextBox txt_nombre_miembro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txt_apellido_miembro;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txt_telefono_miembro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2TextBox txt_fecha_inicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox txt_costo_membresia;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2TextBox txt_fecha_fin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public Guna.UI2.WinForms.Guna2ComboBox cb_sexo_miembro;
        public Guna.UI2.WinForms.Guna2ComboBox cb_membresia;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}