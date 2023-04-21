namespace Presentation.Forms.Autenticacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progress_indicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_ingresar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_nombre_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contrasena_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 510);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::Presentation.Properties.Settings.Default.background_color;
            this.panel2.Controls.Add(this.progress_indicator);
            this.panel2.Controls.Add(this.lb_titulo);
            this.panel2.Controls.Add(this.btn_ingresar);
            this.panel2.Controls.Add(this.txt_nombre_usuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_contrasena_usuario);
            this.panel2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Presentation.Properties.Settings.Default, "background_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(394, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 510);
            this.panel2.TabIndex = 2;
            // 
            // progress_indicator
            // 
            this.progress_indicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progress_indicator.DataBindings.Add(new System.Windows.Forms.Binding("ProgressColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.progress_indicator.Location = new System.Drawing.Point(181, 385);
            this.progress_indicator.Name = "progress_indicator";
            this.progress_indicator.ProgressColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.progress_indicator.Size = new System.Drawing.Size(33, 48);
            this.progress_indicator.TabIndex = 8;
            this.progress_indicator.Visible = false;
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_title_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = global::Presentation.Properties.Settings.Default.label_title_color;
            this.lb_titulo.Location = new System.Drawing.Point(74, 77);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(104, 21);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Iniciar sesión";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ingresar.Animated = true;
            this.btn_ingresar.BorderColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_ingresar.BorderRadius = global::Presentation.Properties.Settings.Default.control_border_size;
            this.btn_ingresar.BorderThickness = 1;
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_ingresar.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::Presentation.Properties.Settings.Default, "control_border_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_ingresar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Presentation.Properties.Settings.Default, "primary_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_ingresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ingresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ingresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ingresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ingresar.FillColor = global::Presentation.Properties.Settings.Default.primary_color;
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Location = new System.Drawing.Point(74, 336);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(247, 32);
            this.btn_ingresar.TabIndex = 7;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
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
            this.txt_nombre_usuario.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_nombre_usuario.IconLeft")));
            this.txt_nombre_usuario.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_nombre_usuario.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txt_nombre_usuario.Location = new System.Drawing.Point(74, 204);
            this.txt_nombre_usuario.MaxLength = 50;
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.PasswordChar = '\0';
            this.txt_nombre_usuario.PlaceholderText = "Ingresa tu nombre de usuario";
            this.txt_nombre_usuario.SelectedText = "";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(247, 32);
            this.txt_nombre_usuario.TabIndex = 4;
            this.txt_nombre_usuario.TextOffset = new System.Drawing.Point(5, 0);
            this.txt_nombre_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_usuario_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label3.Location = new System.Drawing.Point(74, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_help_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::Presentation.Properties.Settings.Default.label_help_color;
            this.label2.Location = new System.Drawing.Point(74, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa tus datos para poder ingresar";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Presentation.Properties.Settings.Default, "label_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = global::Presentation.Properties.Settings.Default.label_color;
            this.label4.Location = new System.Drawing.Point(74, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
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
            this.txt_contrasena_usuario.Location = new System.Drawing.Point(74, 271);
            this.txt_contrasena_usuario.MaxLength = 50;
            this.txt_contrasena_usuario.Name = "txt_contrasena_usuario";
            this.txt_contrasena_usuario.PasswordChar = '\0';
            this.txt_contrasena_usuario.PlaceholderText = "Ingresa tu nombre de usuario";
            this.txt_contrasena_usuario.SelectedText = "";
            this.txt_contrasena_usuario.Size = new System.Drawing.Size(247, 32);
            this.txt_contrasena_usuario.TabIndex = 6;
            this.txt_contrasena_usuario.TextOffset = new System.Drawing.Point(5, 0);
            this.txt_contrasena_usuario.IconRightClick += new System.EventHandler(this.txt_contrasena_usuario_IconRightClick);
            this.txt_contrasena_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contrasena_usuario_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 510);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "MY GYM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(107, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ProgressIndicator progress_indicator;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2Button btn_ingresar;
        private Guna.UI2.WinForms.Guna2TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_contrasena_usuario;
    }
}