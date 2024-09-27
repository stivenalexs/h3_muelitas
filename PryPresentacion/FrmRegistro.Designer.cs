namespace PryPresentacion
{
    partial class FrmRegistro
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
            this.btn_volver = new MaterialSkin.Controls.MaterialButton();
            this.cmb_correo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_s = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_sangre = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_tp = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_registrar = new MaterialSkin.Controls.MaterialButton();
            this.cmb_tipo = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_foto = new MaterialSkin.Controls.MaterialButton();
            this.txb_contacto = new MaterialSkin.Controls.MaterialTextBox2();
            this.txb_correo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txb_documento = new MaterialSkin.Controls.MaterialTextBox2();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.txb_nombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.date_fechanaci = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txb_contraseña = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmb_TipoDocumento = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_volver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_volver.Depth = 0;
            this.btn_volver.HighEmphasis = true;
            this.btn_volver.Icon = null;
            this.btn_volver.Location = new System.Drawing.Point(6, 66);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_volver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_volver.Size = new System.Drawing.Size(76, 36);
            this.btn_volver.TabIndex = 46;
            this.btn_volver.Text = "volver";
            this.btn_volver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_volver.UseAccentColor = false;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // cmb_correo
            // 
            this.cmb_correo.AutoResize = false;
            this.cmb_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_correo.Depth = 0;
            this.cmb_correo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_correo.DropDownHeight = 174;
            this.cmb_correo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_correo.DropDownWidth = 121;
            this.cmb_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_correo.FormattingEnabled = true;
            this.cmb_correo.Hint = "tipo";
            this.cmb_correo.IntegralHeight = false;
            this.cmb_correo.ItemHeight = 43;
            this.cmb_correo.Location = new System.Drawing.Point(202, 363);
            this.cmb_correo.MaxDropDownItems = 4;
            this.cmb_correo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_correo.Name = "cmb_correo";
            this.cmb_correo.Size = new System.Drawing.Size(98, 49);
            this.cmb_correo.StartIndex = 0;
            this.cmb_correo.TabIndex = 45;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(465, 408);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 44;
            this.materialLabel1.Text = "tipo de sangre";
            // 
            // cmb_s
            // 
            this.cmb_s.AutoResize = false;
            this.cmb_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_s.Depth = 0;
            this.cmb_s.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_s.DropDownHeight = 174;
            this.cmb_s.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_s.DropDownWidth = 121;
            this.cmb_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_s.FormattingEnabled = true;
            this.cmb_s.Hint = "RH";
            this.cmb_s.IntegralHeight = false;
            this.cmb_s.ItemHeight = 43;
            this.cmb_s.Location = new System.Drawing.Point(546, 431);
            this.cmb_s.MaxDropDownItems = 4;
            this.cmb_s.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_s.Name = "cmb_s";
            this.cmb_s.Size = new System.Drawing.Size(94, 49);
            this.cmb_s.StartIndex = 0;
            this.cmb_s.TabIndex = 43;
            // 
            // cmb_sangre
            // 
            this.cmb_sangre.AutoResize = false;
            this.cmb_sangre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_sangre.Depth = 0;
            this.cmb_sangre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_sangre.DropDownHeight = 174;
            this.cmb_sangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sangre.DropDownWidth = 121;
            this.cmb_sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_sangre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_sangre.FormattingEnabled = true;
            this.cmb_sangre.Hint = "tipo";
            this.cmb_sangre.IntegralHeight = false;
            this.cmb_sangre.ItemHeight = 43;
            this.cmb_sangre.Location = new System.Drawing.Point(399, 431);
            this.cmb_sangre.MaxDropDownItems = 4;
            this.cmb_sangre.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_sangre.Name = "cmb_sangre";
            this.cmb_sangre.Size = new System.Drawing.Size(140, 49);
            this.cmb_sangre.StartIndex = 0;
            this.cmb_sangre.TabIndex = 42;
            // 
            // cmb_tp
            // 
            this.cmb_tp.AutoResize = false;
            this.cmb_tp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_tp.Depth = 0;
            this.cmb_tp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_tp.DropDownHeight = 174;
            this.cmb_tp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tp.DropDownWidth = 121;
            this.cmb_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_tp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_tp.FormattingEnabled = true;
            this.cmb_tp.IntegralHeight = false;
            this.cmb_tp.ItemHeight = 43;
            this.cmb_tp.Location = new System.Drawing.Point(60, 284);
            this.cmb_tp.MaxDropDownItems = 4;
            this.cmb_tp.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_tp.Name = "cmb_tp";
            this.cmb_tp.Size = new System.Drawing.Size(240, 49);
            this.cmb_tp.StartIndex = 0;
            this.cmb_tp.TabIndex = 41;
            // 
            // btn_registrar
            // 
            this.btn_registrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_registrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_registrar.Depth = 0;
            this.btn_registrar.HighEmphasis = true;
            this.btn_registrar.Icon = null;
            this.btn_registrar.Location = new System.Drawing.Point(278, 519);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_registrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_registrar.Size = new System.Drawing.Size(116, 36);
            this.btn_registrar.TabIndex = 40;
            this.btn_registrar.Text = "registrarse";
            this.btn_registrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_registrar.UseAccentColor = false;
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.AutoResize = false;
            this.cmb_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_tipo.Depth = 0;
            this.cmb_tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_tipo.DropDownHeight = 174;
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.DropDownWidth = 121;
            this.cmb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Hint = "tipo de usuario";
            this.cmb_tipo.IntegralHeight = false;
            this.cmb_tipo.ItemHeight = 43;
            this.cmb_tipo.Location = new System.Drawing.Point(60, 120);
            this.cmb_tipo.MaxDropDownItems = 4;
            this.cmb_tipo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(240, 49);
            this.cmb_tipo.StartIndex = 0;
            this.cmb_tipo.TabIndex = 39;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // btn_foto
            // 
            this.btn_foto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_foto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_foto.Depth = 0;
            this.btn_foto.HighEmphasis = true;
            this.btn_foto.Icon = null;
            this.btn_foto.Location = new System.Drawing.Point(547, 136);
            this.btn_foto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_foto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_foto.Size = new System.Drawing.Size(103, 36);
            this.btn_foto.TabIndex = 38;
            this.btn_foto.Text = "subir foto";
            this.btn_foto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_foto.UseAccentColor = false;
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // txb_contacto
            // 
            this.txb_contacto.AnimateReadOnly = false;
            this.txb_contacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_contacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_contacto.Depth = 0;
            this.txb_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_contacto.HideSelection = true;
            this.txb_contacto.Hint = "numero de contacto";
            this.txb_contacto.LeadingIcon = null;
            this.txb_contacto.Location = new System.Drawing.Point(399, 349);
            this.txb_contacto.MaxLength = 32767;
            this.txb_contacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_contacto.Name = "txb_contacto";
            this.txb_contacto.PasswordChar = '\0';
            this.txb_contacto.PrefixSuffixText = null;
            this.txb_contacto.ReadOnly = false;
            this.txb_contacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_contacto.SelectedText = "";
            this.txb_contacto.SelectionLength = 0;
            this.txb_contacto.SelectionStart = 0;
            this.txb_contacto.ShortcutsEnabled = true;
            this.txb_contacto.Size = new System.Drawing.Size(240, 48);
            this.txb_contacto.TabIndex = 36;
            this.txb_contacto.TabStop = false;
            this.txb_contacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_contacto.TrailingIcon = null;
            this.txb_contacto.UseSystemPasswordChar = false;
            this.txb_contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_contacto_KeyPress);
            // 
            // txb_correo
            // 
            this.txb_correo.AnimateReadOnly = false;
            this.txb_correo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_correo.Depth = 0;
            this.txb_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_correo.HideSelection = true;
            this.txb_correo.Hint = "correo";
            this.txb_correo.LeadingIcon = null;
            this.txb_correo.Location = new System.Drawing.Point(60, 363);
            this.txb_correo.MaxLength = 32767;
            this.txb_correo.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_correo.Name = "txb_correo";
            this.txb_correo.PasswordChar = '\0';
            this.txb_correo.PrefixSuffixText = null;
            this.txb_correo.ReadOnly = false;
            this.txb_correo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_correo.SelectedText = "";
            this.txb_correo.SelectionLength = 0;
            this.txb_correo.SelectionStart = 0;
            this.txb_correo.ShortcutsEnabled = true;
            this.txb_correo.Size = new System.Drawing.Size(136, 48);
            this.txb_correo.TabIndex = 35;
            this.txb_correo.TabStop = false;
            this.txb_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_correo.TrailingIcon = null;
            this.txb_correo.UseSystemPasswordChar = false;
            // 
            // txb_documento
            // 
            this.txb_documento.AnimateReadOnly = false;
            this.txb_documento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_documento.Depth = 0;
            this.txb_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_documento.HideSelection = true;
            this.txb_documento.Hint = "documento";
            this.txb_documento.LeadingIcon = null;
            this.txb_documento.Location = new System.Drawing.Point(60, 198);
            this.txb_documento.MaxLength = 32767;
            this.txb_documento.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_documento.Name = "txb_documento";
            this.txb_documento.PasswordChar = '\0';
            this.txb_documento.PrefixSuffixText = null;
            this.txb_documento.ReadOnly = false;
            this.txb_documento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_documento.SelectedText = "";
            this.txb_documento.SelectionLength = 0;
            this.txb_documento.SelectionStart = 0;
            this.txb_documento.ShortcutsEnabled = true;
            this.txb_documento.Size = new System.Drawing.Size(146, 48);
            this.txb_documento.TabIndex = 34;
            this.txb_documento.TabStop = false;
            this.txb_documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_documento.TrailingIcon = null;
            this.txb_documento.UseSystemPasswordChar = false;
            this.txb_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_documento_KeyPress);
            // 
            // pb_foto
            // 
            this.pb_foto.Location = new System.Drawing.Point(400, 85);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(118, 120);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 33;
            this.pb_foto.TabStop = false;
            // 
            // txb_nombre
            // 
            this.txb_nombre.AnimateReadOnly = false;
            this.txb_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_nombre.Depth = 0;
            this.txb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_nombre.HideSelection = true;
            this.txb_nombre.Hint = "nombre";
            this.txb_nombre.LeadingIcon = null;
            this.txb_nombre.Location = new System.Drawing.Point(400, 228);
            this.txb_nombre.MaxLength = 32767;
            this.txb_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PasswordChar = '\0';
            this.txb_nombre.PrefixSuffixText = null;
            this.txb_nombre.ReadOnly = false;
            this.txb_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_nombre.SelectedText = "";
            this.txb_nombre.SelectionLength = 0;
            this.txb_nombre.SelectionStart = 0;
            this.txb_nombre.ShortcutsEnabled = true;
            this.txb_nombre.Size = new System.Drawing.Size(240, 48);
            this.txb_nombre.TabIndex = 32;
            this.txb_nombre.TabStop = false;
            this.txb_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_nombre.TrailingIcon = null;
            this.txb_nombre.UseSystemPasswordChar = false;
            this.txb_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_nombre_KeyPress);
            // 
            // date_fechanaci
            // 
            this.date_fechanaci.CustomFormat = "dd/MM/yyyy";
            this.date_fechanaci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_fechanaci.Location = new System.Drawing.Point(60, 467);
            this.date_fechanaci.Margin = new System.Windows.Forms.Padding(2);
            this.date_fechanaci.Name = "date_fechanaci";
            this.date_fechanaci.Size = new System.Drawing.Size(163, 20);
            this.date_fechanaci.TabIndex = 47;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(58, 435);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(148, 19);
            this.materialLabel2.TabIndex = 48;
            this.materialLabel2.Text = "Fecha de nacimiento";
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.AnimateReadOnly = false;
            this.txb_contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_contraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_contraseña.Depth = 0;
            this.txb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_contraseña.HideSelection = true;
            this.txb_contraseña.Hint = "Contraseña";
            this.txb_contraseña.LeadingIcon = null;
            this.txb_contraseña.Location = new System.Drawing.Point(399, 285);
            this.txb_contraseña.MaxLength = 32767;
            this.txb_contraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.PasswordChar = '\0';
            this.txb_contraseña.PrefixSuffixText = null;
            this.txb_contraseña.ReadOnly = false;
            this.txb_contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_contraseña.SelectedText = "";
            this.txb_contraseña.SelectionLength = 0;
            this.txb_contraseña.SelectionStart = 0;
            this.txb_contraseña.ShortcutsEnabled = true;
            this.txb_contraseña.Size = new System.Drawing.Size(240, 48);
            this.txb_contraseña.TabIndex = 49;
            this.txb_contraseña.TabStop = false;
            this.txb_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_contraseña.TrailingIcon = null;
            this.txb_contraseña.UseSystemPasswordChar = false;
            // 
            // cmb_TipoDocumento
            // 
            this.cmb_TipoDocumento.AutoResize = false;
            this.cmb_TipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_TipoDocumento.Depth = 0;
            this.cmb_TipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_TipoDocumento.DropDownHeight = 174;
            this.cmb_TipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoDocumento.DropDownWidth = 121;
            this.cmb_TipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_TipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TipoDocumento.FormattingEnabled = true;
            this.cmb_TipoDocumento.IntegralHeight = false;
            this.cmb_TipoDocumento.ItemHeight = 43;
            this.cmb_TipoDocumento.Location = new System.Drawing.Point(212, 197);
            this.cmb_TipoDocumento.MaxDropDownItems = 4;
            this.cmb_TipoDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_TipoDocumento.Name = "cmb_TipoDocumento";
            this.cmb_TipoDocumento.Size = new System.Drawing.Size(94, 49);
            this.cmb_TipoDocumento.StartIndex = 0;
            this.cmb_TipoDocumento.TabIndex = 50;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 632);
            this.Controls.Add(this.cmb_TipoDocumento);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.date_fechanaci);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.cmb_correo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmb_s);
            this.Controls.Add(this.cmb_sangre);
            this.Controls.Add(this.cmb_tp);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.txb_contacto);
            this.Controls.Add(this.txb_correo);
            this.Controls.Add(this.txb_documento);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.txb_nombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistro";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_volver;
        private MaterialSkin.Controls.MaterialComboBox cmb_correo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmb_s;
        private MaterialSkin.Controls.MaterialComboBox cmb_sangre;
        private MaterialSkin.Controls.MaterialComboBox cmb_tp;
        private MaterialSkin.Controls.MaterialButton btn_registrar;
        private MaterialSkin.Controls.MaterialComboBox cmb_tipo;
        private MaterialSkin.Controls.MaterialButton btn_foto;
        private MaterialSkin.Controls.MaterialTextBox2 txb_contacto;
        private MaterialSkin.Controls.MaterialTextBox2 txb_correo;
        private MaterialSkin.Controls.MaterialTextBox2 txb_documento;
        private System.Windows.Forms.PictureBox pb_foto;
        private MaterialSkin.Controls.MaterialTextBox2 txb_nombre;
        private System.Windows.Forms.DateTimePicker date_fechanaci;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txb_contraseña;
        private MaterialSkin.Controls.MaterialComboBox cmb_TipoDocumento;
    }
}