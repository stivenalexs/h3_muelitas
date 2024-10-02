namespace PryPresentacion
{
    partial class FrmReprogramarCita
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
            this.txb_codigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_reprogramar = new MaterialSkin.Controls.MaterialButton();
            this.label_hora = new MaterialSkin.Controls.MaterialLabel();
            this.label_fecha = new MaterialSkin.Controls.MaterialLabel();
            this.label_profesional = new MaterialSkin.Controls.MaterialLabel();
            this.combo_profesional = new System.Windows.Forms.ComboBox();
            this.dtvListaCitas = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.date_hora = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_especialidad = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtvListaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_codigo
            // 
            this.txb_codigo.AnimateReadOnly = false;
            this.txb_codigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_codigo.Depth = 0;
            this.txb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_codigo.HideSelection = true;
            this.txb_codigo.Hint = "numero turno";
            this.txb_codigo.LeadingIcon = null;
            this.txb_codigo.Location = new System.Drawing.Point(554, 12);
            this.txb_codigo.MaxLength = 32767;
            this.txb_codigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.PasswordChar = '\0';
            this.txb_codigo.PrefixSuffixText = null;
            this.txb_codigo.ReadOnly = false;
            this.txb_codigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_codigo.SelectedText = "";
            this.txb_codigo.SelectionLength = 0;
            this.txb_codigo.SelectionStart = 0;
            this.txb_codigo.ShortcutsEnabled = true;
            this.txb_codigo.Size = new System.Drawing.Size(279, 48);
            this.txb_codigo.TabIndex = 44;
            this.txb_codigo.TabStop = false;
            this.txb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_codigo.TrailingIcon = null;
            this.txb_codigo.UseSystemPasswordChar = false;
            this.txb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_codigo_KeyPress);
            // 
            // btn_reprogramar
            // 
            this.btn_reprogramar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reprogramar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_reprogramar.Depth = 0;
            this.btn_reprogramar.HighEmphasis = true;
            this.btn_reprogramar.Icon = null;
            this.btn_reprogramar.Location = new System.Drawing.Point(650, 238);
            this.btn_reprogramar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_reprogramar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reprogramar.Name = "btn_reprogramar";
            this.btn_reprogramar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_reprogramar.Size = new System.Drawing.Size(128, 36);
            this.btn_reprogramar.TabIndex = 43;
            this.btn_reprogramar.Text = "Reprogramar";
            this.btn_reprogramar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reprogramar.UseAccentColor = false;
            this.btn_reprogramar.UseVisualStyleBackColor = true;
            this.btn_reprogramar.Click += new System.EventHandler(this.btn_reprogramar_Click);
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Depth = 0;
            this.label_hora.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_hora.Location = new System.Drawing.Point(730, 154);
            this.label_hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hora.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(35, 19);
            this.label_hora.TabIndex = 42;
            this.label_hora.Text = "Hora";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Depth = 0;
            this.label_fecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_fecha.Location = new System.Drawing.Point(556, 147);
            this.label_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(41, 19);
            this.label_fecha.TabIndex = 40;
            this.label_fecha.Text = "fecha";
            // 
            // label_profesional
            // 
            this.label_profesional.AutoSize = true;
            this.label_profesional.Depth = 0;
            this.label_profesional.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_profesional.Location = new System.Drawing.Point(556, 73);
            this.label_profesional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_profesional.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_profesional.Name = "label_profesional";
            this.label_profesional.Size = new System.Drawing.Size(81, 19);
            this.label_profesional.TabIndex = 39;
            this.label_profesional.Text = "profesional";
            // 
            // combo_profesional
            // 
            this.combo_profesional.FormattingEnabled = true;
            this.combo_profesional.Location = new System.Drawing.Point(559, 99);
            this.combo_profesional.Margin = new System.Windows.Forms.Padding(2);
            this.combo_profesional.Name = "combo_profesional";
            this.combo_profesional.Size = new System.Drawing.Size(151, 21);
            this.combo_profesional.TabIndex = 37;
            // 
            // dtvListaCitas
            // 
            this.dtvListaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvListaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dtvListaCitas.Location = new System.Drawing.Point(12, 12);
            this.dtvListaCitas.Name = "dtvListaCitas";
            this.dtvListaCitas.Size = new System.Drawing.Size(511, 398);
            this.dtvListaCitas.TabIndex = 45;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // date_fecha
            // 
            this.date_fecha.CustomFormat = "";
            this.date_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fecha.Location = new System.Drawing.Point(559, 180);
            this.date_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.date_fecha.MinDate = new System.DateTime(2024, 10, 1, 0, 0, 0, 0);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(151, 20);
            this.date_fecha.TabIndex = 46;
            this.date_fecha.Value = new System.DateTime(2024, 10, 1, 16, 12, 20, 0);
            // 
            // date_hora
            // 
            this.date_hora.CustomFormat = "HH:mm";
            this.date_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_hora.Location = new System.Drawing.Point(733, 180);
            this.date_hora.Margin = new System.Windows.Forms.Padding(2);
            this.date_hora.MinDate = new System.DateTime(2024, 10, 1, 0, 0, 0, 0);
            this.date_hora.Name = "date_hora";
            this.date_hora.ShowUpDown = true;
            this.date_hora.Size = new System.Drawing.Size(105, 20);
            this.date_hora.TabIndex = 47;
            this.date_hora.Value = new System.DateTime(2024, 10, 1, 16, 12, 20, 0);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(730, 73);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 48;
            this.materialLabel1.Text = "Especialidad";
            // 
            // lb_especialidad
            // 
            this.lb_especialidad.AutoSize = true;
            this.lb_especialidad.Depth = 0;
            this.lb_especialidad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_especialidad.Location = new System.Drawing.Point(730, 101);
            this.lb_especialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_especialidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_especialidad.Name = "lb_especialidad";
            this.lb_especialidad.Size = new System.Drawing.Size(37, 19);
            this.lb_especialidad.TabIndex = 49;
            this.lb_especialidad.Text = "lafsa";
            // 
            // FrmReprogramarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 443);
            this.Controls.Add(this.lb_especialidad);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.date_hora);
            this.Controls.Add(this.date_fecha);
            this.Controls.Add(this.dtvListaCitas);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.btn_reprogramar);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_profesional);
            this.Controls.Add(this.combo_profesional);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReprogramarCita";
            this.Text = "FrmReprogramarCita";
            this.Load += new System.EventHandler(this.FrmReprogramarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvListaCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txb_codigo;
        private MaterialSkin.Controls.MaterialButton btn_reprogramar;
        private MaterialSkin.Controls.MaterialLabel label_hora;
        private MaterialSkin.Controls.MaterialLabel label_fecha;
        private MaterialSkin.Controls.MaterialLabel label_profesional;
        private System.Windows.Forms.ComboBox combo_profesional;
        private System.Windows.Forms.DataGridView dtvListaCitas;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.DateTimePicker date_hora;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lb_especialidad;
    }
}