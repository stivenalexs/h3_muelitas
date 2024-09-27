namespace PryPresentacion
{
    partial class FrmPerfil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new MaterialSkin.Controls.MaterialButton();
            this.btn_citas = new MaterialSkin.Controls.MaterialButton();
            this.btn_perfil = new MaterialSkin.Controls.MaterialButton();
            this.btn_inicio = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(58, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 354);
            this.panel1.TabIndex = 18;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.AutoSize = false;
            this.btn_cerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cerrar.Depth = 0;
            this.btn_cerrar.HighEmphasis = true;
            this.btn_cerrar.Icon = null;
            this.btn_cerrar.Location = new System.Drawing.Point(652, 72);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cerrar.Size = new System.Drawing.Size(127, 24);
            this.btn_cerrar.TabIndex = 17;
            this.btn_cerrar.Text = "cerrar cesion";
            this.btn_cerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cerrar.UseAccentColor = false;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_citas
            // 
            this.btn_citas.AutoSize = false;
            this.btn_citas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_citas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_citas.Depth = 0;
            this.btn_citas.HighEmphasis = true;
            this.btn_citas.Icon = null;
            this.btn_citas.Location = new System.Drawing.Point(468, 72);
            this.btn_citas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_citas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_citas.Name = "btn_citas";
            this.btn_citas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_citas.Size = new System.Drawing.Size(127, 24);
            this.btn_citas.TabIndex = 15;
            this.btn_citas.Text = "citas";
            this.btn_citas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_citas.UseAccentColor = false;
            this.btn_citas.UseVisualStyleBackColor = true;
            this.btn_citas.Click += new System.EventHandler(this.btn_citas_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.AutoSize = false;
            this.btn_perfil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_perfil.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_perfil.Depth = 0;
            this.btn_perfil.HighEmphasis = true;
            this.btn_perfil.Icon = null;
            this.btn_perfil.Location = new System.Drawing.Point(284, 72);
            this.btn_perfil.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_perfil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_perfil.Size = new System.Drawing.Size(127, 24);
            this.btn_perfil.TabIndex = 14;
            this.btn_perfil.Text = "perfil";
            this.btn_perfil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_perfil.UseAccentColor = false;
            this.btn_perfil.UseVisualStyleBackColor = true;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.AutoSize = false;
            this.btn_inicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_inicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_inicio.Depth = 0;
            this.btn_inicio.HighEmphasis = true;
            this.btn_inicio.Icon = null;
            this.btn_inicio.Location = new System.Drawing.Point(123, 72);
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_inicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_inicio.Size = new System.Drawing.Size(104, 24);
            this.btn_inicio.TabIndex = 13;
            this.btn_inicio.Text = "inicio";
            this.btn_inicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_inicio.UseAccentColor = false;
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_citas);
            this.Controls.Add(this.btn_perfil);
            this.Controls.Add(this.btn_inicio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPerfil";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmPerfil";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_cerrar;
        private MaterialSkin.Controls.MaterialButton btn_citas;
        private MaterialSkin.Controls.MaterialButton btn_perfil;
        private MaterialSkin.Controls.MaterialButton btn_inicio;
    }
}