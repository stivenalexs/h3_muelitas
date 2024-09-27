namespace PryPresentacion
{
    partial class FrmInicio
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
            this.btn_iniciar = new MaterialSkin.Controls.MaterialButton();
            this.txb_contraseña = new MaterialSkin.Controls.MaterialTextBox2();
            this.txb_usuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_ingresar = new MaterialSkin.Controls.MaterialButton();
            this.btn_registrar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.AutoSize = false;
            this.btn_iniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_iniciar.BackColor = System.Drawing.Color.White;
            this.btn_iniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_iniciar.Depth = 0;
            this.btn_iniciar.DrawShadows = false;
            this.btn_iniciar.Enabled = false;
            this.btn_iniciar.HighEmphasis = true;
            this.btn_iniciar.Icon = null;
            this.btn_iniciar.Location = new System.Drawing.Point(128, 394);
            this.btn_iniciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_iniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_iniciar.Size = new System.Drawing.Size(345, 36);
            this.btn_iniciar.TabIndex = 11;
            this.btn_iniciar.Text = "iniciar sesion";
            this.btn_iniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_iniciar.UseAccentColor = false;
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Visible = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.AnimateReadOnly = false;
            this.txb_contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_contraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_contraseña.Depth = 0;
            this.txb_contraseña.Enabled = false;
            this.txb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_contraseña.HideSelection = true;
            this.txb_contraseña.Hint = "Contraseña";
            this.txb_contraseña.LeadingIcon = null;
            this.txb_contraseña.Location = new System.Drawing.Point(128, 337);
            this.txb_contraseña.MaxLength = 32767;
            this.txb_contraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.PasswordChar = '*';
            this.txb_contraseña.PrefixSuffixText = null;
            this.txb_contraseña.ReadOnly = false;
            this.txb_contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_contraseña.SelectedText = "";
            this.txb_contraseña.SelectionLength = 0;
            this.txb_contraseña.SelectionStart = 0;
            this.txb_contraseña.ShortcutsEnabled = true;
            this.txb_contraseña.Size = new System.Drawing.Size(345, 48);
            this.txb_contraseña.TabIndex = 10;
            this.txb_contraseña.TabStop = false;
            this.txb_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_contraseña.TrailingIcon = null;
            this.txb_contraseña.UseSystemPasswordChar = false;
            this.txb_contraseña.Visible = false;
            // 
            // txb_usuario
            // 
            this.txb_usuario.AnimateReadOnly = false;
            this.txb_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_usuario.Depth = 0;
            this.txb_usuario.Enabled = false;
            this.txb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_usuario.HideSelection = true;
            this.txb_usuario.Hint = "Correo";
            this.txb_usuario.LeadingIcon = null;
            this.txb_usuario.Location = new System.Drawing.Point(128, 281);
            this.txb_usuario.MaxLength = 32767;
            this.txb_usuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PasswordChar = '\0';
            this.txb_usuario.PrefixSuffixText = null;
            this.txb_usuario.ReadOnly = false;
            this.txb_usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_usuario.SelectedText = "";
            this.txb_usuario.SelectionLength = 0;
            this.txb_usuario.SelectionStart = 0;
            this.txb_usuario.ShortcutsEnabled = true;
            this.txb_usuario.Size = new System.Drawing.Size(345, 48);
            this.txb_usuario.TabIndex = 9;
            this.txb_usuario.TabStop = false;
            this.txb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_usuario.TrailingIcon = null;
            this.txb_usuario.UseSystemPasswordChar = false;
            this.txb_usuario.Visible = false;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.AutoSize = false;
            this.btn_ingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ingresar.Depth = 0;
            this.btn_ingresar.HighEmphasis = true;
            this.btn_ingresar.Icon = null;
            this.btn_ingresar.Location = new System.Drawing.Point(128, 341);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ingresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ingresar.Size = new System.Drawing.Size(345, 36);
            this.btn_ingresar.TabIndex = 8;
            this.btn_ingresar.Text = "ingresar";
            this.btn_ingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ingresar.UseAccentColor = false;
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.AutoSize = false;
            this.btn_registrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_registrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_registrar.Depth = 0;
            this.btn_registrar.HighEmphasis = true;
            this.btn_registrar.Icon = null;
            this.btn_registrar.Location = new System.Drawing.Point(128, 293);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_registrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_registrar.Size = new System.Drawing.Size(345, 36);
            this.btn_registrar.TabIndex = 7;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_registrar.UseAccentColor = false;
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PryPresentacion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(128, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_volver
            // 
            this.btn_volver.Enabled = false;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(539, 409);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(95, 38);
            this.btn_volver.TabIndex = 12;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Visible = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 490);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInicio";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_iniciar;
        private MaterialSkin.Controls.MaterialTextBox2 txb_contraseña;
        private MaterialSkin.Controls.MaterialTextBox2 txb_usuario;
        private MaterialSkin.Controls.MaterialButton btn_ingresar;
        private MaterialSkin.Controls.MaterialButton btn_registrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_volver;
    }
}