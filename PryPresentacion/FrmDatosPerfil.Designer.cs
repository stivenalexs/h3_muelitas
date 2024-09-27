namespace PryPresentacion
{
    partial class FrmDatosPerfil
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialButton();
            this.txb_contra = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmb_correo = new MaterialSkin.Controls.MaterialComboBox();
            this.txb_contacto = new MaterialSkin.Controls.MaterialTextBox2();
            this.txb_correo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lb_contraseña = new MaterialSkin.Controls.MaterialLabel();
            this.lb_correo = new MaterialSkin.Controls.MaterialLabel();
            this.lb_contacto = new MaterialSkin.Controls.MaterialLabel();
            this.lb_edad = new MaterialSkin.Controls.MaterialLabel();
            this.lb_nombre = new MaterialSkin.Controls.MaterialLabel();
            this.lb_documento = new MaterialSkin.Controls.MaterialLabel();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.lb_Nacimiento = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(494, 11);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 58;
            this.materialLabel2.Text = "Nombre";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(270, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 57;
            this.materialLabel1.Text = "numero documento";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.HighEmphasis = true;
            this.btn_actualizar.Icon = null;
            this.btn_actualizar.Location = new System.Drawing.Point(629, 262);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_actualizar.Size = new System.Drawing.Size(109, 36);
            this.btn_actualizar.TabIndex = 56;
            this.btn_actualizar.Text = "actualizar";
            this.btn_actualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_actualizar.UseAccentColor = false;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txb_contra
            // 
            this.txb_contra.AnimateReadOnly = false;
            this.txb_contra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_contra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_contra.Depth = 0;
            this.txb_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_contra.HideSelection = true;
            this.txb_contra.LeadingIcon = null;
            this.txb_contra.Location = new System.Drawing.Point(265, 262);
            this.txb_contra.MaxLength = 32767;
            this.txb_contra.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_contra.Name = "txb_contra";
            this.txb_contra.PasswordChar = '\0';
            this.txb_contra.PrefixSuffixText = null;
            this.txb_contra.ReadOnly = false;
            this.txb_contra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_contra.SelectedText = "";
            this.txb_contra.SelectionLength = 0;
            this.txb_contra.SelectionStart = 0;
            this.txb_contra.ShortcutsEnabled = true;
            this.txb_contra.Size = new System.Drawing.Size(319, 48);
            this.txb_contra.TabIndex = 55;
            this.txb_contra.TabStop = false;
            this.txb_contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_contra.TrailingIcon = null;
            this.txb_contra.UseSystemPasswordChar = false;
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
            this.cmb_correo.Hint = "@";
            this.cmb_correo.IntegralHeight = false;
            this.cmb_correo.ItemHeight = 43;
            this.cmb_correo.Location = new System.Drawing.Point(609, 175);
            this.cmb_correo.MaxDropDownItems = 4;
            this.cmb_correo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_correo.Name = "cmb_correo";
            this.cmb_correo.Size = new System.Drawing.Size(152, 49);
            this.cmb_correo.StartIndex = 0;
            this.cmb_correo.TabIndex = 54;
            // 
            // txb_contacto
            // 
            this.txb_contacto.AnimateReadOnly = false;
            this.txb_contacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_contacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_contacto.Depth = 0;
            this.txb_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_contacto.HideSelection = true;
            this.txb_contacto.LeadingIcon = null;
            this.txb_contacto.Location = new System.Drawing.Point(266, 97);
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
            this.txb_contacto.Size = new System.Drawing.Size(326, 48);
            this.txb_contacto.TabIndex = 52;
            this.txb_contacto.TabStop = false;
            this.txb_contacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_contacto.TrailingIcon = null;
            this.txb_contacto.UseSystemPasswordChar = false;
            // 
            // txb_correo
            // 
            this.txb_correo.AnimateReadOnly = false;
            this.txb_correo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_correo.Depth = 0;
            this.txb_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_correo.HideSelection = true;
            this.txb_correo.LeadingIcon = null;
            this.txb_correo.Location = new System.Drawing.Point(265, 175);
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
            this.txb_correo.Size = new System.Drawing.Size(327, 48);
            this.txb_correo.TabIndex = 51;
            this.txb_correo.TabStop = false;
            this.txb_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_correo.TrailingIcon = null;
            this.txb_correo.UseSystemPasswordChar = false;
            // 
            // lb_contraseña
            // 
            this.lb_contraseña.AutoSize = true;
            this.lb_contraseña.Depth = 0;
            this.lb_contraseña.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_contraseña.Location = new System.Drawing.Point(269, 240);
            this.lb_contraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_contraseña.Name = "lb_contraseña";
            this.lb_contraseña.Size = new System.Drawing.Size(80, 19);
            this.lb_contraseña.TabIndex = 50;
            this.lb_contraseña.Text = "contraseña";
            // 
            // lb_correo
            // 
            this.lb_correo.AutoSize = true;
            this.lb_correo.Depth = 0;
            this.lb_correo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_correo.Location = new System.Drawing.Point(269, 153);
            this.lb_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_correo.Name = "lb_correo";
            this.lb_correo.Size = new System.Drawing.Size(126, 19);
            this.lb_correo.TabIndex = 49;
            this.lb_correo.Text = "correo electronico";
            // 
            // lb_contacto
            // 
            this.lb_contacto.AutoSize = true;
            this.lb_contacto.Depth = 0;
            this.lb_contacto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_contacto.Location = new System.Drawing.Point(267, 75);
            this.lb_contacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_contacto.Name = "lb_contacto";
            this.lb_contacto.Size = new System.Drawing.Size(142, 19);
            this.lb_contacto.TabIndex = 48;
            this.lb_contacto.Text = "numero de contacto";
            // 
            // lb_edad
            // 
            this.lb_edad.AutoSize = true;
            this.lb_edad.Depth = 0;
            this.lb_edad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_edad.Location = new System.Drawing.Point(626, 11);
            this.lb_edad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_edad.Name = "lb_edad";
            this.lb_edad.Size = new System.Drawing.Size(145, 19);
            this.lb_edad.TabIndex = 47;
            this.lb_edad.Text = "fecha de nacimiento";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Depth = 0;
            this.lb_nombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_nombre.Location = new System.Drawing.Point(494, 46);
            this.lb_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(58, 19);
            this.lb_nombre.TabIndex = 46;
            this.lb_nombre.Text = "marselo";
            // 
            // lb_documento
            // 
            this.lb_documento.AutoSize = true;
            this.lb_documento.Depth = 0;
            this.lb_documento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_documento.Location = new System.Drawing.Point(273, 46);
            this.lb_documento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_documento.Name = "lb_documento";
            this.lb_documento.Size = new System.Drawing.Size(22, 19);
            this.lb_documento.TabIndex = 45;
            this.lb_documento.Text = "XD";
            // 
            // pb_foto
            // 
            this.pb_foto.Location = new System.Drawing.Point(21, 31);
            this.pb_foto.Margin = new System.Windows.Forms.Padding(2);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(215, 244);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 44;
            this.pb_foto.TabStop = false;
            // 
            // lb_Nacimiento
            // 
            this.lb_Nacimiento.AutoSize = true;
            this.lb_Nacimiento.Depth = 0;
            this.lb_Nacimiento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_Nacimiento.Location = new System.Drawing.Point(626, 47);
            this.lb_Nacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_Nacimiento.Name = "lb_Nacimiento";
            this.lb_Nacimiento.Size = new System.Drawing.Size(35, 19);
            this.lb_Nacimiento.TabIndex = 59;
            this.lb_Nacimiento.Text = "nose";
            // 
            // FrmDatosPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 315);
            this.Controls.Add(this.lb_Nacimiento);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txb_contra);
            this.Controls.Add(this.cmb_correo);
            this.Controls.Add(this.txb_contacto);
            this.Controls.Add(this.txb_correo);
            this.Controls.Add(this.lb_contraseña);
            this.Controls.Add(this.lb_correo);
            this.Controls.Add(this.lb_contacto);
            this.Controls.Add(this.lb_edad);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_documento);
            this.Controls.Add(this.pb_foto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDatosPerfil";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmDatosPerfil";
            this.Load += new System.EventHandler(this.FrmDatosPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_actualizar;
        private MaterialSkin.Controls.MaterialTextBox2 txb_contra;
        private MaterialSkin.Controls.MaterialComboBox cmb_correo;
        private MaterialSkin.Controls.MaterialTextBox2 txb_contacto;
        private MaterialSkin.Controls.MaterialTextBox2 txb_correo;
        private MaterialSkin.Controls.MaterialLabel lb_contraseña;
        private MaterialSkin.Controls.MaterialLabel lb_correo;
        private MaterialSkin.Controls.MaterialLabel lb_contacto;
        private MaterialSkin.Controls.MaterialLabel lb_edad;
        private MaterialSkin.Controls.MaterialLabel lb_nombre;
        private MaterialSkin.Controls.MaterialLabel lb_documento;
        private System.Windows.Forms.PictureBox pb_foto;
        private MaterialSkin.Controls.MaterialLabel lb_Nacimiento;
    }
}