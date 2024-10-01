namespace PryPresentacion
{
    partial class Frm_inicio_admin
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
            this.btn_horario = new MaterialSkin.Controls.MaterialButton();
            this.btn_pacientes = new MaterialSkin.Controls.MaterialButton();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_profesionales = new MaterialSkin.Controls.MaterialButton();
            this.btn_nomina = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_bien
            // 
            this.lb_bien.AutoSize = true;
            this.lb_bien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bien.Location = new System.Drawing.Point(427, 97);
            this.lb_bien.Name = "lb_bien";
            this.lb_bien.Size = new System.Drawing.Size(105, 24);
            this.lb_bien.TabIndex = 31;
            this.lb_bien.Text = "Bienvenido";
            // 
            // btn_horario
            // 
            this.btn_horario.AutoSize = false;
            this.btn_horario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_horario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_horario.Depth = 0;
            this.btn_horario.HighEmphasis = true;
            this.btn_horario.Icon = null;
            this.btn_horario.Location = new System.Drawing.Point(376, 227);
            this.btn_horario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_horario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_horario.Name = "btn_horario";
            this.btn_horario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_horario.Size = new System.Drawing.Size(136, 54);
            this.btn_horario.TabIndex = 30;
            this.btn_horario.Text = "gestionar horarios";
            this.btn_horario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_horario.UseAccentColor = false;
            this.btn_horario.UseVisualStyleBackColor = true;
            this.btn_horario.Click += new System.EventHandler(this.btn_horario_Click);
            // 
            // btn_pacientes
            // 
            this.btn_pacientes.AutoSize = false;
            this.btn_pacientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_pacientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_pacientes.Depth = 0;
            this.btn_pacientes.HighEmphasis = true;
            this.btn_pacientes.Icon = null;
            this.btn_pacientes.Location = new System.Drawing.Point(55, 227);
            this.btn_pacientes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_pacientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_pacientes.Name = "btn_pacientes";
            this.btn_pacientes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_pacientes.Size = new System.Drawing.Size(127, 54);
            this.btn_pacientes.TabIndex = 29;
            this.btn_pacientes.Text = "gestionar pacientes";
            this.btn_pacientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_pacientes.UseAccentColor = false;
            this.btn_pacientes.UseVisualStyleBackColor = true;
            this.btn_pacientes.Click += new System.EventHandler(this.btn_pacientes_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.Location = new System.Drawing.Point(209, 45);
            this.pb_foto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(178, 128);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 28;
            this.pb_foto.TabStop = false;
            // 
            // btn_profesionales
            // 
            this.btn_profesionales.AutoSize = false;
            this.btn_profesionales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_profesionales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_profesionales.Depth = 0;
            this.btn_profesionales.HighEmphasis = true;
            this.btn_profesionales.Icon = null;
            this.btn_profesionales.Location = new System.Drawing.Point(209, 227);
            this.btn_profesionales.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_profesionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_profesionales.Name = "btn_profesionales";
            this.btn_profesionales.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_profesionales.Size = new System.Drawing.Size(146, 54);
            this.btn_profesionales.TabIndex = 32;
            this.btn_profesionales.Text = "gestionar profecionales";
            this.btn_profesionales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_profesionales.UseAccentColor = false;
            this.btn_profesionales.UseVisualStyleBackColor = true;
            this.btn_profesionales.Click += new System.EventHandler(this.btn_profesionales_Click);
            // 
            // btn_nomina
            // 
            this.btn_nomina.AutoSize = false;
            this.btn_nomina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nomina.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_nomina.Depth = 0;
            this.btn_nomina.HighEmphasis = true;
            this.btn_nomina.Icon = null;
            this.btn_nomina.Location = new System.Drawing.Point(530, 227);
            this.btn_nomina.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_nomina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_nomina.Name = "btn_nomina";
            this.btn_nomina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_nomina.Size = new System.Drawing.Size(136, 54);
            this.btn_nomina.TabIndex = 33;
            this.btn_nomina.Text = "gestionar nomina";
            this.btn_nomina.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_nomina.UseAccentColor = false;
            this.btn_nomina.UseVisualStyleBackColor = true;
            this.btn_nomina.Click += new System.EventHandler(this.btn_nomina_Click);
            // 
            // Frm_inicio_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 365);
            this.Controls.Add(this.btn_nomina);
            this.Controls.Add(this.btn_profesionales);
            this.Controls.Add(this.lb_bien);
            this.Controls.Add(this.btn_horario);
            this.Controls.Add(this.btn_pacientes);
            this.Controls.Add(this.pb_foto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_inicio_admin";
            this.Text = "Frm_inicio_admin";
            this.Load += new System.EventHandler(this.Frm_inicio_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_bien;
        private MaterialSkin.Controls.MaterialButton btn_horario;
        private MaterialSkin.Controls.MaterialButton btn_pacientes;
        private System.Windows.Forms.PictureBox pb_foto;
        private MaterialSkin.Controls.MaterialButton btn_profesionales;
        private MaterialSkin.Controls.MaterialButton btn_nomina;
    }
}