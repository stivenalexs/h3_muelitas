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
            this.txb_turno = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_reprogramar = new MaterialSkin.Controls.MaterialButton();
            this.label_hora = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_hora = new System.Windows.Forms.ComboBox();
            this.label_fecha = new MaterialSkin.Controls.MaterialLabel();
            this.label_profesional = new MaterialSkin.Controls.MaterialLabel();
            this.date_fecha_repro = new System.Windows.Forms.DateTimePicker();
            this.combo_profesional_repro = new System.Windows.Forms.ComboBox();
            this.dataGrid_repro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_repro)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_turno
            // 
            this.txb_turno.AnimateReadOnly = false;
            this.txb_turno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_turno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txb_turno.Depth = 0;
            this.txb_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_turno.HideSelection = true;
            this.txb_turno.Hint = "numero turno";
            this.txb_turno.LeadingIcon = null;
            this.txb_turno.Location = new System.Drawing.Point(819, 140);
            this.txb_turno.Margin = new System.Windows.Forms.Padding(4);
            this.txb_turno.MaxLength = 32767;
            this.txb_turno.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_turno.Name = "txb_turno";
            this.txb_turno.PasswordChar = '\0';
            this.txb_turno.PrefixSuffixText = null;
            this.txb_turno.ReadOnly = false;
            this.txb_turno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_turno.SelectedText = "";
            this.txb_turno.SelectionLength = 0;
            this.txb_turno.SelectionStart = 0;
            this.txb_turno.ShortcutsEnabled = true;
            this.txb_turno.Size = new System.Drawing.Size(201, 48);
            this.txb_turno.TabIndex = 44;
            this.txb_turno.TabStop = false;
            this.txb_turno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_turno.TrailingIcon = null;
            this.txb_turno.UseSystemPasswordChar = false;
            // 
            // btn_reprogramar
            // 
            this.btn_reprogramar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reprogramar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_reprogramar.Depth = 0;
            this.btn_reprogramar.HighEmphasis = true;
            this.btn_reprogramar.Icon = null;
            this.btn_reprogramar.Location = new System.Drawing.Point(838, 427);
            this.btn_reprogramar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_reprogramar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reprogramar.Name = "btn_reprogramar";
            this.btn_reprogramar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_reprogramar.Size = new System.Drawing.Size(128, 36);
            this.btn_reprogramar.TabIndex = 43;
            this.btn_reprogramar.Text = "Reprogramar";
            this.btn_reprogramar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reprogramar.UseAccentColor = false;
            this.btn_reprogramar.UseVisualStyleBackColor = true;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Depth = 0;
            this.label_hora.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_hora.Location = new System.Drawing.Point(987, 321);
            this.label_hora.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(35, 19);
            this.label_hora.TabIndex = 42;
            this.label_hora.Text = "Hora";
            // 
            // cmb_hora
            // 
            this.cmb_hora.FormattingEnabled = true;
            this.cmb_hora.Location = new System.Drawing.Point(991, 359);
            this.cmb_hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_hora.Name = "cmb_hora";
            this.cmb_hora.Size = new System.Drawing.Size(121, 24);
            this.cmb_hora.TabIndex = 41;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Depth = 0;
            this.label_fecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_fecha.Location = new System.Drawing.Point(735, 322);
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
            this.label_profesional.Location = new System.Drawing.Point(815, 232);
            this.label_profesional.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_profesional.Name = "label_profesional";
            this.label_profesional.Size = new System.Drawing.Size(81, 19);
            this.label_profesional.TabIndex = 39;
            this.label_profesional.Text = "profesional";
            // 
            // date_fecha_repro
            // 
            this.date_fecha_repro.Location = new System.Drawing.Point(739, 359);
            this.date_fecha_repro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_fecha_repro.Name = "date_fecha_repro";
            this.date_fecha_repro.Size = new System.Drawing.Size(200, 22);
            this.date_fecha_repro.TabIndex = 38;
            // 
            // combo_profesional_repro
            // 
            this.combo_profesional_repro.FormattingEnabled = true;
            this.combo_profesional_repro.Location = new System.Drawing.Point(819, 263);
            this.combo_profesional_repro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_profesional_repro.Name = "combo_profesional_repro";
            this.combo_profesional_repro.Size = new System.Drawing.Size(200, 24);
            this.combo_profesional_repro.TabIndex = 37;
            // 
            // dataGrid_repro
            // 
            this.dataGrid_repro.AllowUserToAddRows = false;
            this.dataGrid_repro.AllowUserToDeleteRows = false;
            this.dataGrid_repro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_repro.Location = new System.Drawing.Point(90, 139);
            this.dataGrid_repro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGrid_repro.Name = "dataGrid_repro";
            this.dataGrid_repro.ReadOnly = true;
            this.dataGrid_repro.RowHeadersWidth = 51;
            this.dataGrid_repro.RowTemplate.Height = 24;
            this.dataGrid_repro.Size = new System.Drawing.Size(611, 361);
            this.dataGrid_repro.TabIndex = 36;
            // 
            // FrmReprogramarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 545);
            this.Controls.Add(this.txb_turno);
            this.Controls.Add(this.btn_reprogramar);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.cmb_hora);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_profesional);
            this.Controls.Add(this.date_fecha_repro);
            this.Controls.Add(this.combo_profesional_repro);
            this.Controls.Add(this.dataGrid_repro);
            this.Name = "FrmReprogramarCita";
            this.Text = "FrmReprogramarCita";
            this.Load += new System.EventHandler(this.FrmReprogramarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_repro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txb_turno;
        private MaterialSkin.Controls.MaterialButton btn_reprogramar;
        private MaterialSkin.Controls.MaterialLabel label_hora;
        private System.Windows.Forms.ComboBox cmb_hora;
        private MaterialSkin.Controls.MaterialLabel label_fecha;
        private MaterialSkin.Controls.MaterialLabel label_profesional;
        private System.Windows.Forms.DateTimePicker date_fecha_repro;
        private System.Windows.Forms.ComboBox combo_profesional_repro;
        private System.Windows.Forms.DataGridView dataGrid_repro;
    }
}