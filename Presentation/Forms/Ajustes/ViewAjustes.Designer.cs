namespace Presentation.Forms.Ajustes
{
    partial class ViewAjustes
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
            this.lb_titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_color_6 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_color_5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_color_4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_color_3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_color_2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_color_1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ts_dark_mode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_completamente_cuadrado = new Guna.UI2.WinForms.Guna2Button();
            this.btn_medianamente_redondo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_completamente_redondo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btn_color_personalizado = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.lb_cerrar_sesion = new System.Windows.Forms.LinkLabel();
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
            this.lb_titulo.Size = new System.Drawing.Size(63, 21);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Ajustes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label2.Location = new System.Drawing.Point(26, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color primario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apariencia";
            // 
            // btn_color_6
            // 
            this.btn_color_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color_6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(196)))), ((int)(((byte)(60)))));
            this.btn_color_6.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_color_6.BorderThickness = 1;
            this.btn_color_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color_6.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color_6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color_6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(196)))), ((int)(((byte)(60)))));
            this.btn_color_6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_color_6.ForeColor = System.Drawing.Color.White;
            this.btn_color_6.Location = new System.Drawing.Point(944, 155);
            this.btn_color_6.Name = "btn_color_6";
            this.btn_color_6.Size = new System.Drawing.Size(32, 32);
            this.btn_color_6.TabIndex = 9;
            this.btn_color_6.Click += new System.EventHandler(this.btn_color_6_Click);
            // 
            // btn_color_5
            // 
            this.btn_color_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color_5.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_color_5.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_color_5.BorderThickness = 1;
            this.btn_color_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color_5.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color_5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color_5.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_color_5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_color_5.ForeColor = System.Drawing.Color.White;
            this.btn_color_5.Location = new System.Drawing.Point(906, 155);
            this.btn_color_5.Name = "btn_color_5";
            this.btn_color_5.Size = new System.Drawing.Size(32, 32);
            this.btn_color_5.TabIndex = 8;
            this.btn_color_5.Click += new System.EventHandler(this.btn_color_5_Click);
            // 
            // btn_color_4
            // 
            this.btn_color_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color_4.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_color_4.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_color_4.BorderThickness = 1;
            this.btn_color_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color_4.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color_4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color_4.FillColor = System.Drawing.Color.DarkOrange;
            this.btn_color_4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_color_4.ForeColor = System.Drawing.Color.White;
            this.btn_color_4.Location = new System.Drawing.Point(868, 155);
            this.btn_color_4.Name = "btn_color_4";
            this.btn_color_4.Size = new System.Drawing.Size(32, 32);
            this.btn_color_4.TabIndex = 7;
            this.btn_color_4.Click += new System.EventHandler(this.btn_color_4_Click);
            // 
            // btn_color_3
            // 
            this.btn_color_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color_3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.btn_color_3.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_color_3.BorderThickness = 1;
            this.btn_color_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color_3.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color_3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color_3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.btn_color_3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_color_3.ForeColor = System.Drawing.Color.White;
            this.btn_color_3.Location = new System.Drawing.Point(830, 155);
            this.btn_color_3.Name = "btn_color_3";
            this.btn_color_3.Size = new System.Drawing.Size(32, 32);
            this.btn_color_3.TabIndex = 6;
            this.btn_color_3.Click += new System.EventHandler(this.btn_color_3_Click);
            // 
            // btn_color_2
            // 
            this.btn_color_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color_2.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btn_color_2.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_color_2.BorderThickness = 1;
            this.btn_color_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color_2.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color_2.FillColor = System.Drawing.Color.MediumOrchid;
            this.btn_color_2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_color_2.ForeColor = System.Drawing.Color.White;
            this.btn_color_2.Location = new System.Drawing.Point(792, 155);
            this.btn_color_2.Name = "btn_color_2";
            this.btn_color_2.Size = new System.Drawing.Size(32, 32);
            this.btn_color_2.TabIndex = 5;
            this.btn_color_2.Click += new System.EventHandler(this.btn_color_2_Click);
            // 
            // btn_color_1
            // 
            this.btn_color_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_color_1.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_color_1.BorderThickness = 1;
            this.btn_color_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color_1.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_color_1.ForeColor = System.Drawing.Color.White;
            this.btn_color_1.Location = new System.Drawing.Point(754, 155);
            this.btn_color_1.Name = "btn_color_1";
            this.btn_color_1.Size = new System.Drawing.Size(32, 32);
            this.btn_color_1.TabIndex = 4;
            this.btn_color_1.Click += new System.EventHandler(this.btn_color_1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label3.Location = new System.Drawing.Point(27, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estilo de borde de controles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label4.Location = new System.Drawing.Point(28, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Modo obscuro";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ts_dark_mode
            // 
            this.ts_dark_mode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ts_dark_mode.Checked = global::Presentation.Properties.Settings.Default.ts_dark_mode;
            this.ts_dark_mode.CheckedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.ts_dark_mode.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.ts_dark_mode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_dark_mode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ts_dark_mode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Presentation.Properties.Settings.Default, "ts_dark_mode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ts_dark_mode.Location = new System.Drawing.Point(979, 375);
            this.ts_dark_mode.Name = "ts_dark_mode";
            this.ts_dark_mode.Size = new System.Drawing.Size(35, 20);
            this.ts_dark_mode.TabIndex = 18;
            this.ts_dark_mode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_dark_mode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_dark_mode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_dark_mode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ts_dark_mode.Click += new System.EventHandler(this.ts_dark_mode_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Separator1.FillColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Separator1.Location = new System.Drawing.Point(31, 209);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(983, 10);
            this.guna2Separator1.TabIndex = 11;
            this.guna2Separator1.TabStop = false;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Separator2.FillColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Separator2.Location = new System.Drawing.Point(31, 334);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(983, 10);
            this.guna2Separator2.TabIndex = 16;
            this.guna2Separator2.TabStop = false;
            // 
            // btn_completamente_cuadrado
            // 
            this.btn_completamente_cuadrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_completamente_cuadrado.Animated = true;
            this.btn_completamente_cuadrado.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.btn_completamente_cuadrado.BorderThickness = 1;
            this.btn_completamente_cuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_completamente_cuadrado.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_completamente_cuadrado.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_completamente_cuadrado.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_completamente_cuadrado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_completamente_cuadrado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_completamente_cuadrado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_completamente_cuadrado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_completamente_cuadrado.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.btn_completamente_cuadrado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_completamente_cuadrado.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.btn_completamente_cuadrado.Location = new System.Drawing.Point(391, 263);
            this.btn_completamente_cuadrado.Margin = new System.Windows.Forms.Padding(0, 5, 30, 10);
            this.btn_completamente_cuadrado.Name = "btn_completamente_cuadrado";
            this.btn_completamente_cuadrado.Size = new System.Drawing.Size(199, 32);
            this.btn_completamente_cuadrado.TabIndex = 13;
            this.btn_completamente_cuadrado.Text = "Completamente cuadrado";
            this.btn_completamente_cuadrado.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_completamente_cuadrado.Click += new System.EventHandler(this.btn_completamente_cuadrado_Click);
            // 
            // btn_medianamente_redondo
            // 
            this.btn_medianamente_redondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_medianamente_redondo.Animated = true;
            this.btn_medianamente_redondo.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.btn_medianamente_redondo.BorderRadius = 3;
            this.btn_medianamente_redondo.BorderThickness = 1;
            this.btn_medianamente_redondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_medianamente_redondo.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_medianamente_redondo.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_medianamente_redondo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_medianamente_redondo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_medianamente_redondo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_medianamente_redondo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_medianamente_redondo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_medianamente_redondo.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.btn_medianamente_redondo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medianamente_redondo.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.btn_medianamente_redondo.Location = new System.Drawing.Point(603, 263);
            this.btn_medianamente_redondo.Margin = new System.Windows.Forms.Padding(0, 5, 30, 10);
            this.btn_medianamente_redondo.Name = "btn_medianamente_redondo";
            this.btn_medianamente_redondo.Size = new System.Drawing.Size(199, 32);
            this.btn_medianamente_redondo.TabIndex = 14;
            this.btn_medianamente_redondo.Text = "Medianamente redondo";
            this.btn_medianamente_redondo.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_medianamente_redondo.Click += new System.EventHandler(this.btn_medianamente_redondo_Click);
            // 
            // btn_completamente_redondo
            // 
            this.btn_completamente_redondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_completamente_redondo.Animated = true;
            this.btn_completamente_redondo.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.btn_completamente_redondo.BorderRadius = 14;
            this.btn_completamente_redondo.BorderThickness = 1;
            this.btn_completamente_redondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_completamente_redondo.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_completamente_redondo.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_fill_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_completamente_redondo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "control_fore_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_completamente_redondo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_completamente_redondo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_completamente_redondo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_completamente_redondo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_completamente_redondo.FillColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.btn_completamente_redondo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_completamente_redondo.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.btn_completamente_redondo.Location = new System.Drawing.Point(815, 263);
            this.btn_completamente_redondo.Margin = new System.Windows.Forms.Padding(0, 5, 30, 10);
            this.btn_completamente_redondo.Name = "btn_completamente_redondo";
            this.btn_completamente_redondo.Size = new System.Drawing.Size(199, 32);
            this.btn_completamente_redondo.TabIndex = 15;
            this.btn_completamente_redondo.Text = "Completamente redondo";
            this.btn_completamente_redondo.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_completamente_redondo.Click += new System.EventHandler(this.btn_completamente_redondo_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.BackColor = global::Presentation.Properties.Settings.Default.control_fill_color;
            this.guna2HtmlToolTip1.BorderColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2HtmlToolTip1.ForeColor = global::Presentation.Properties.Settings.Default.control_fore_color;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // btn_color_personalizado
            // 
            this.btn_color_personalizado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color_personalizado.Animated = true;
            this.btn_color_personalizado.BorderColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_color_personalizado.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_color_personalizado.BorderThickness = 1;
            this.btn_color_personalizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color_personalizado.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_personalizado.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_personalizado.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_color_personalizado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_personalizado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color_personalizado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color_personalizado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color_personalizado.FillColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_color_personalizado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_color_personalizado.ForeColor = System.Drawing.Color.White;
            this.btn_color_personalizado.Image = global::Presentation.Properties.Resources.ic_color_personalizado;
            this.btn_color_personalizado.ImageOffset = new System.Drawing.Point(1, 0);
            this.btn_color_personalizado.ImageSize = new System.Drawing.Size(23, 23);
            this.btn_color_personalizado.Location = new System.Drawing.Point(982, 155);
            this.btn_color_personalizado.Name = "btn_color_personalizado";
            this.btn_color_personalizado.Size = new System.Drawing.Size(32, 32);
            this.btn_color_personalizado.TabIndex = 10;
            this.btn_color_personalizado.TextOffset = new System.Drawing.Point(0, -1);
            this.guna2HtmlToolTip1.SetToolTip(this.btn_color_personalizado, "Seleccionar otro color");
            this.btn_color_personalizado.Click += new System.EventHandler(this.btn_color_personalizado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.label5.Location = new System.Drawing.Point(28, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cuenta";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.lb_usuario.Location = new System.Drawing.Point(28, 527);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(53, 15);
            this.lb_usuario.TabIndex = 20;
            this.lb_usuario.Text = "Usuario: ";
            this.lb_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "control_border_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guna2Separator3.FillColor = global::Presentation.Properties.Settings.Default.control_border_color;
            this.guna2Separator3.Location = new System.Drawing.Point(31, 579);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(983, 10);
            this.guna2Separator3.TabIndex = 22;
            this.guna2Separator3.TabStop = false;
            // 
            // lb_cerrar_sesion
            // 
            this.lb_cerrar_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_cerrar_sesion.AutoSize = true;
            this.lb_cerrar_sesion.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_cerrar_sesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cerrar_sesion.LinkColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.lb_cerrar_sesion.Location = new System.Drawing.Point(941, 527);
            this.lb_cerrar_sesion.Name = "lb_cerrar_sesion";
            this.lb_cerrar_sesion.Size = new System.Drawing.Size(75, 15);
            this.lb_cerrar_sesion.TabIndex = 21;
            this.lb_cerrar_sesion.TabStop = true;
            this.lb_cerrar_sesion.Text = "Cerrar sesión";
            this.lb_cerrar_sesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_cerrar_sesion_LinkClicked);
            // 
            // ViewAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.ClientSize = new System.Drawing.Size(1065, 559);
            this.Controls.Add(this.lb_cerrar_sesion);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_completamente_redondo);
            this.Controls.Add(this.btn_medianamente_redondo);
            this.Controls.Add(this.btn_completamente_cuadrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ts_dark_mode);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_color_personalizado);
            this.Controls.Add(this.btn_color_6);
            this.Controls.Add(this.btn_color_5);
            this.Controls.Add(this.btn_color_4);
            this.Controls.Add(this.btn_color_3);
            this.Controls.Add(this.btn_color_2);
            this.Controls.Add(this.btn_color_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_titulo);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAjustes";
            this.Text = "ViewAjustes";
            this.Load += new System.EventHandler(this.ViewAjustes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_color_personalizado;
        private Guna.UI2.WinForms.Guna2Button btn_color_6;
        private Guna.UI2.WinForms.Guna2Button btn_color_5;
        private Guna.UI2.WinForms.Guna2Button btn_color_4;
        private Guna.UI2.WinForms.Guna2Button btn_color_3;
        private Guna.UI2.WinForms.Guna2Button btn_color_2;
        private Guna.UI2.WinForms.Guna2Button btn_color_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ts_dark_mode;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button btn_completamente_cuadrado;
        private Guna.UI2.WinForms.Guna2Button btn_medianamente_redondo;
        private Guna.UI2.WinForms.Guna2Button btn_completamente_redondo;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_usuario;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.LinkLabel lb_cerrar_sesion;
    }
}