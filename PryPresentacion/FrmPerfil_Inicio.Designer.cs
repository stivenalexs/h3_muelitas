namespace PryPresentacion
{
    partial class FrmPerfil_Inicio
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
            this.lb_bien = new System.Windows.Forms.Label();
            this.btn_seguimiento = new MaterialSkin.Controls.MaterialButton();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_Procedimiento = new MaterialSkin.Controls.MaterialButton();
            this.btn_citasp = new MaterialSkin.Controls.MaterialButton();
            this.btn_agendar = new MaterialSkin.Controls.MaterialButton();
            this.btn_reprogramar = new MaterialSkin.Controls.MaterialButton();
            this.lb_c = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_bien
            // 
            this.lb_bien.AutoSize = true;
            this.lb_bien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bien.Location = new System.Drawing.Point(16, 69);
            this.lb_bien.Name = "lb_bien";
            this.lb_bien.Size = new System.Drawing.Size(105, 24);
            this.lb_bien.TabIndex = 27;
            this.lb_bien.Text = "Bienvenido";
            // 
            // btn_seguimiento
            // 
            this.btn_seguimiento.AutoSize = false;
            this.btn_seguimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_seguimiento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_seguimiento.Depth = 0;
            this.btn_seguimiento.HighEmphasis = true;
            this.btn_seguimiento.Icon = null;
            this.btn_seguimiento.Location = new System.Drawing.Point(404, 114);
            this.btn_seguimiento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_seguimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_seguimiento.Name = "btn_seguimiento";
            this.btn_seguimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_seguimiento.Size = new System.Drawing.Size(136, 24);
            this.btn_seguimiento.TabIndex = 26;
            this.btn_seguimiento.Text = "seguimientos";
            this.btn_seguimiento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_seguimiento.UseAccentColor = false;
            this.btn_seguimiento.UseVisualStyleBackColor = true;
            this.btn_seguimiento.Click += new System.EventHandler(this.btn_seguimiento_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.Location = new System.Drawing.Point(20, 104);
            this.pb_foto.Margin = new System.Windows.Forms.Padding(2);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(180, 156);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 24;
            this.pb_foto.TabStop = false;
            // 
            // btn_Procedimiento
            // 
            this.btn_Procedimiento.AutoSize = false;
            this.btn_Procedimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Procedimiento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Procedimiento.Depth = 0;
            this.btn_Procedimiento.HighEmphasis = true;
            this.btn_Procedimiento.Icon = null;
            this.btn_Procedimiento.Location = new System.Drawing.Point(561, 114);
            this.btn_Procedimiento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Procedimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Procedimiento.Name = "btn_Procedimiento";
            this.btn_Procedimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Procedimiento.Size = new System.Drawing.Size(136, 24);
            this.btn_Procedimiento.TabIndex = 28;
            this.btn_Procedimiento.Text = "Procedimientos";
            this.btn_Procedimiento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Procedimiento.UseAccentColor = false;
            this.btn_Procedimiento.UseVisualStyleBackColor = true;
            this.btn_Procedimiento.Click += new System.EventHandler(this.btn_Procedimiento_Click);
            // 
            // btn_citasp
            // 
            this.btn_citasp.AutoSize = false;
            this.btn_citasp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_citasp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_citasp.Depth = 0;
            this.btn_citasp.HighEmphasis = true;
            this.btn_citasp.Icon = null;
            this.btn_citasp.Location = new System.Drawing.Point(256, 114);
            this.btn_citasp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_citasp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_citasp.Name = "btn_citasp";
            this.btn_citasp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_citasp.Size = new System.Drawing.Size(136, 24);
            this.btn_citasp.TabIndex = 29;
            this.btn_citasp.Text = "citas pendientes";
            this.btn_citasp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_citasp.UseAccentColor = false;
            this.btn_citasp.UseVisualStyleBackColor = true;
            this.btn_citasp.Click += new System.EventHandler(this.btn_citasp_Click);
            // 
            // btn_agendar
            // 
            this.btn_agendar.AutoSize = false;
            this.btn_agendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agendar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_agendar.Depth = 0;
            this.btn_agendar.HighEmphasis = true;
            this.btn_agendar.Icon = null;
            this.btn_agendar.Location = new System.Drawing.Point(265, 208);
            this.btn_agendar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_agendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agendar.Size = new System.Drawing.Size(127, 52);
            this.btn_agendar.TabIndex = 30;
            this.btn_agendar.Text = "agendar";
            this.btn_agendar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_agendar.UseAccentColor = false;
            this.btn_agendar.UseVisualStyleBackColor = true;
            this.btn_agendar.Click += new System.EventHandler(this.btn_agendar_Click);
            // 
            // btn_reprogramar
            // 
            this.btn_reprogramar.AutoSize = false;
            this.btn_reprogramar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reprogramar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_reprogramar.Depth = 0;
            this.btn_reprogramar.HighEmphasis = true;
            this.btn_reprogramar.Icon = null;
            this.btn_reprogramar.Location = new System.Drawing.Point(525, 208);
            this.btn_reprogramar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_reprogramar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reprogramar.Name = "btn_reprogramar";
            this.btn_reprogramar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_reprogramar.Size = new System.Drawing.Size(136, 52);
            this.btn_reprogramar.TabIndex = 32;
            this.btn_reprogramar.Text = "Reprogramar / cancelar";
            this.btn_reprogramar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reprogramar.UseAccentColor = false;
            this.btn_reprogramar.UseVisualStyleBackColor = true;
            this.btn_reprogramar.Click += new System.EventHandler(this.btn_reprogramar_Click);
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_c.Location = new System.Drawing.Point(261, 155);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(55, 24);
            this.lb_c.TabIndex = 34;
            this.lb_c.Text = "Citas:";
            // 
            // FrmPerfil_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 391);
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.btn_reprogramar);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.btn_citasp);
            this.Controls.Add(this.btn_Procedimiento);
            this.Controls.Add(this.lb_bien);
            this.Controls.Add(this.btn_seguimiento);
            this.Controls.Add(this.pb_foto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPerfil_Inicio";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmPerfil_Inicio";
            this.Load += new System.EventHandler(this.FrmPerfil_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_bien;
        private MaterialSkin.Controls.MaterialButton btn_seguimiento;
        private System.Windows.Forms.PictureBox pb_foto;
        private MaterialSkin.Controls.MaterialButton btn_Procedimiento;
        private MaterialSkin.Controls.MaterialButton btn_citasp;
        private MaterialSkin.Controls.MaterialButton btn_agendar;
        private MaterialSkin.Controls.MaterialButton btn_reprogramar;
        private System.Windows.Forms.Label lb_c;
    }
}