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
            this.label_fecha = new MaterialSkin.Controls.MaterialLabel();
            this.label_profesional = new MaterialSkin.Controls.MaterialLabel();
            this.label_tipocita = new MaterialSkin.Controls.MaterialLabel();
            this.btn_agendar = new MaterialSkin.Controls.MaterialButton();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_profesional = new System.Windows.Forms.ComboBox();
            this.cmb_tipocita = new System.Windows.Forms.ComboBox();
            this.date_hora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Depth = 0;
            this.label_hora.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_hora.Location = new System.Drawing.Point(175, 218);
            this.label_hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hora.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(35, 19);
            this.label_hora.TabIndex = 18;
            this.label_hora.Text = "Hora";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Depth = 0;
            this.label_fecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_fecha.Location = new System.Drawing.Point(175, 152);
            this.label_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label_profesional.Location = new System.Drawing.Point(175, 84);
            this.label_profesional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label_tipocita.Location = new System.Drawing.Point(175, 11);
            this.label_tipocita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.btn_agendar.Location = new System.Drawing.Point(175, 299);
            this.btn_agendar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_agendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agendar.Size = new System.Drawing.Size(336, 29);
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
            this.date_fecha.Location = new System.Drawing.Point(175, 183);
            this.date_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.date_fecha.MinDate = new System.DateTime(2024, 10, 1, 0, 0, 0, 0);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(334, 20);
            this.date_fecha.TabIndex = 12;
            this.date_fecha.Value = new System.DateTime(2024, 10, 1, 16, 12, 20, 0);
            // 
            // cmb_profesional
            // 
            this.cmb_profesional.FormattingEnabled = true;
            this.cmb_profesional.Location = new System.Drawing.Point(175, 109);
            this.cmb_profesional.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_profesional.Name = "cmb_profesional";
            this.cmb_profesional.Size = new System.Drawing.Size(335, 21);
            this.cmb_profesional.TabIndex = 11;
            // 
            // cmb_tipocita
            // 
            this.cmb_tipocita.FormattingEnabled = true;
            this.cmb_tipocita.Location = new System.Drawing.Point(175, 47);
            this.cmb_tipocita.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_tipocita.Name = "cmb_tipocita";
            this.cmb_tipocita.Size = new System.Drawing.Size(335, 21);
            this.cmb_tipocita.TabIndex = 10;
            this.cmb_tipocita.SelectedIndexChanged += new System.EventHandler(this.cmb_tipocita_SelectedIndexChanged);
            // 
            // date_hora
            // 
            this.date_hora.CustomFormat = "HH:mm";
            this.date_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_hora.Location = new System.Drawing.Point(175, 254);
            this.date_hora.Margin = new System.Windows.Forms.Padding(2);
            this.date_hora.MinDate = new System.DateTime(2024, 10, 1, 0, 0, 0, 0);
            this.date_hora.Name = "date_hora";
            this.date_hora.ShowUpDown = true;
            this.date_hora.Size = new System.Drawing.Size(334, 20);
            this.date_hora.TabIndex = 19;
            this.date_hora.Value = new System.DateTime(2024, 10, 1, 16, 12, 20, 0);
            // 
            // FrmAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 391);
            this.Controls.Add(this.date_hora);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_profesional);
            this.Controls.Add(this.label_tipocita);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.date_fecha);
            this.Controls.Add(this.cmb_profesional);
            this.Controls.Add(this.cmb_tipocita);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgendar";
            this.Text = "Agendar";
            this.Load += new System.EventHandler(this.FrmAgendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_hora;
        private MaterialSkin.Controls.MaterialLabel label_fecha;
        private MaterialSkin.Controls.MaterialLabel label_profesional;
        private MaterialSkin.Controls.MaterialLabel label_tipocita;
        private MaterialSkin.Controls.MaterialButton btn_agendar;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.ComboBox cmb_profesional;
        private System.Windows.Forms.ComboBox cmb_tipocita;
        private System.Windows.Forms.DateTimePicker date_hora;
    }
}