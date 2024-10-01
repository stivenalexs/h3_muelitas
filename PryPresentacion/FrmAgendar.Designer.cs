namespace PryPresentacion
{
    partial class FrmAgendar
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
            this.label_hora = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_hora = new System.Windows.Forms.ComboBox();
            this.label_fecha = new MaterialSkin.Controls.MaterialLabel();
            this.label_profesional = new MaterialSkin.Controls.MaterialLabel();
            this.label_tipocita = new MaterialSkin.Controls.MaterialLabel();
            this.btn_agendar = new MaterialSkin.Controls.MaterialButton();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_profesional = new System.Windows.Forms.ComboBox();
            this.cmb_tipocita = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Depth = 0;
            this.label_hora.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_hora.Location = new System.Drawing.Point(236, 336);
            this.label_hora.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(35, 19);
            this.label_hora.TabIndex = 18;
            this.label_hora.Text = "Hora";
            // 
            // cmb_hora
            // 
            this.cmb_hora.FormattingEnabled = true;
            this.cmb_hora.Location = new System.Drawing.Point(240, 375);
            this.cmb_hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_hora.Name = "cmb_hora";
            this.cmb_hora.Size = new System.Drawing.Size(447, 24);
            this.cmb_hora.TabIndex = 17;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Depth = 0;
            this.label_fecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_fecha.Location = new System.Drawing.Point(236, 255);
            this.label_fecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(41, 19);
            this.label_fecha.TabIndex = 16;
            this.label_fecha.Text = "fecha";
            // 
            // label_profesional
            // 
            this.label_profesional.AutoSize = true;
            this.label_profesional.Depth = 0;
            this.label_profesional.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_profesional.Location = new System.Drawing.Point(237, 171);
            this.label_profesional.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_profesional.Name = "label_profesional";
            this.label_profesional.Size = new System.Drawing.Size(81, 19);
            this.label_profesional.TabIndex = 15;
            this.label_profesional.Text = "profesional";
            // 
            // label_tipocita
            // 
            this.label_tipocita.AutoSize = true;
            this.label_tipocita.Depth = 0;
            this.label_tipocita.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_tipocita.Location = new System.Drawing.Point(364, 81);
            this.label_tipocita.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_tipocita.Name = "label_tipocita";
            this.label_tipocita.Size = new System.Drawing.Size(79, 19);
            this.label_tipocita.TabIndex = 14;
            this.label_tipocita.Text = "tipo de cita";
            // 
            // btn_agendar
            // 
            this.btn_agendar.AutoSize = false;
            this.btn_agendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agendar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_agendar.Depth = 0;
            this.btn_agendar.HighEmphasis = true;
            this.btn_agendar.Icon = null;
            this.btn_agendar.Location = new System.Drawing.Point(240, 420);
            this.btn_agendar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_agendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agendar.Size = new System.Drawing.Size(448, 36);
            this.btn_agendar.TabIndex = 13;
            this.btn_agendar.Text = "agendar";
            this.btn_agendar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_agendar.UseAccentColor = false;
            this.btn_agendar.UseVisualStyleBackColor = true;
            this.btn_agendar.Click += new System.EventHandler(this.btn_agendar_Click);
            // 
            // date_fecha
            // 
            this.date_fecha.CustomFormat = "";
            this.date_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fecha.Location = new System.Drawing.Point(242, 293);
            this.date_fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(444, 22);
            this.date_fecha.TabIndex = 12;
            // 
            // cmb_profesional
            // 
            this.cmb_profesional.FormattingEnabled = true;
            this.cmb_profesional.Location = new System.Drawing.Point(241, 202);
            this.cmb_profesional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_profesional.Name = "cmb_profesional";
            this.cmb_profesional.Size = new System.Drawing.Size(445, 24);
            this.cmb_profesional.TabIndex = 11;
            // 
            // cmb_tipocita
            // 
            this.cmb_tipocita.FormattingEnabled = true;
            this.cmb_tipocita.Location = new System.Drawing.Point(241, 125);
            this.cmb_tipocita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_tipocita.Name = "cmb_tipocita";
            this.cmb_tipocita.Size = new System.Drawing.Size(445, 24);
            this.cmb_tipocita.TabIndex = 10;
            // 
            // FrmAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 499);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.cmb_hora);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_profesional);
            this.Controls.Add(this.label_tipocita);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.date_fecha);
            this.Controls.Add(this.cmb_profesional);
            this.Controls.Add(this.cmb_tipocita);
            this.Name = "FrmAgendar";
            this.Text = "Agendar";
            this.Load += new System.EventHandler(this.FrmAgendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_hora;
        private System.Windows.Forms.ComboBox cmb_hora;
        private MaterialSkin.Controls.MaterialLabel label_fecha;
        private MaterialSkin.Controls.MaterialLabel label_profesional;
        private MaterialSkin.Controls.MaterialLabel label_tipocita;
        private MaterialSkin.Controls.MaterialButton btn_agendar;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.ComboBox cmb_profesional;
        private System.Windows.Forms.ComboBox cmb_tipocita;
    }
}